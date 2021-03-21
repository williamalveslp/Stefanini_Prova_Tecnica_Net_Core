using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;
using Moq;
using Newtonsoft.Json;
using StefaniniCore.API;
using StefaniniCore.API.Controllers;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Xunit;

namespace StefaniniCore.xUnit.Tests.IntegrationsTests
{
    public class ProfileTypesIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;
        private readonly Mock<IProfileTypeAppService> _mockAppService;
        private readonly ProfileTypesController _controller;

        public ProfileTypesIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            // Mock the Dependencies of Controller.
            var mockLogger = new Mock<ILogger<ProfileTypesController>>();
            _mockAppService = new Mock<IProfileTypeAppService>();

            // Build the Controller with Mock data.
            _controller = new ProfileTypesController(mockLogger.Object, _mockAppService.Object);

            _client = factory.CreateClient();
        }

#if DEBUG
        // It's testing the endpoint only (data not mocked).
        // It's like #DEBUG, because on AzureDevops we have no permission with localhost PORT 8080.
        [Theory]
        [InlineData("/ProfileTypes")]
        public async System.Threading.Tasks.Task GetAll_NotMocked(string url)
        {
            // Action
            var response = await _client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // 200 - 299.
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            string responseString = await response.Content.ReadAsStringAsync();
            Assert.NotNull(responseString);

            var responseValue = JsonConvert.DeserializeObject<ResponseData<ProfileTypeListViewModel>>(responseString);
            Assert.NotNull(responseValue.Data?.ProfileTypes);
            Assert.NotEmpty(responseValue.Data.ProfileTypes);
    }
#endif

        [Fact]
        public async System.Threading.Tasks.Task GetAll()
        {
            // Arrange
            var mockDataList = GetMockDataList();
            _mockAppService.Setup(f => f.GetAll()).Returns(mockDataList);

            // Action
            var response = _controller.Get();

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.Equal((int)HttpStatusCode.OK, responseObject.StatusCode);

            var responseValue = responseObject.Value as ResponseData<ProfileTypeListViewModel>;
            Assert.NotNull(responseValue.Data.ProfileTypes);
            Assert.NotEmpty(responseValue.Data.ProfileTypes);
        }

        // Example 2: It's using the mock data.
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public async System.Threading.Tasks.Task GetById(int expectedId)
        {
            // Arrange
            Mock<ProfileTypeDetailViewModel> mockViewModel = new Mock<ProfileTypeDetailViewModel>();
            mockViewModel.SetupGet(f => f.Id).Returns(expectedId);
            mockViewModel.SetupGet(f => f.Name).Returns($"Test {expectedId}");

            // Arrange
            _mockAppService.Setup(f => f.GetById(expectedId)).Returns(mockViewModel.Object);

            // Action
            var response = _controller.GetById(expectedId);

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.Equal((int)HttpStatusCode.OK, responseObject.StatusCode);

            var responseValue = responseObject.Value as ResponseData<ProfileTypeDetailViewModel>;
            Assert.NotNull(responseValue.Data);
            Assert.Equal(expectedId, responseValue.Data.Id);
        }

        [Fact]
        public async System.Threading.Tasks.Task Delete()
        {
            // Arrange
            _mockAppService.Setup(f => f.DeleteById(It.IsAny<int>()));

            // Action
            var response = _controller.Delete(It.IsAny<int>());

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.Equal((int)HttpStatusCode.OK, responseObject.StatusCode);

            var responseValue = responseObject.Value as ResponseData<HttpStatusCode>;
            Assert.Equal(HttpStatusCode.OK, responseValue.Data);
        }

        #region .: PRIVATE METHODS :.
        public ProfileTypeListViewModel GetMockDataList()
        {
            IList<ProfileType> profileTypes = new List<ProfileType>();

            for (int i = 1; i <= 5; i++)
            {
                Mock<ProfileType> mockProfileType = new Mock<ProfileType>();
                mockProfileType.SetupGet(f => f.Id).Returns(i);
                mockProfileType.SetupGet(f => f.Name).Returns($"Mocked Test {i}");
                profileTypes.Add(mockProfileType.Object);
            }

            ProfileTypeListViewModel viewModel = new ProfileTypeListViewModel();
            viewModel.Load(profileTypes);

            return viewModel;
        }
        #endregion
    }
}
