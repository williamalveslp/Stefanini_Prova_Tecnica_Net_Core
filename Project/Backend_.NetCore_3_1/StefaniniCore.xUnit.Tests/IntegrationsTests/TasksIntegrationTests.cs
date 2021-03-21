using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using StefaniniCore.API.Controllers;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace StefaniniCore.xUnit.Tests.IntegrationsTests
{
    public class TasksIntegrationTests
    {
        private readonly Mock<ITaskAppService> _mockAppService;
        private readonly TasksController _controller;

        public TasksIntegrationTests()
        {
            var mockLogger = new Mock<ILogger<TasksController>>();
            _mockAppService = new Mock<ITaskAppService>();

            _controller = new TasksController(mockLogger.Object, _mockAppService.Object);
        }

        [Theory]
        [InlineData(1, "Test 1", "Description 1")]
        [InlineData(50, "Test 50", "Description 50")]
        public async Task Insert(int id, string name, string description)
        {
            // Arrange
            Mock<Domain.Entities.Task> mockTask = new Mock<Domain.Entities.Task>();
            mockTask.SetupGet(f => f.Id).Returns(id);
            mockTask.SetupGet(f => f.Name).Returns(name);

            TaskDetailViewModel viewModel = new TaskDetailViewModel()
            {
                Task = mockTask.Object
            };

            _mockAppService.Setup(f => f.Save(It.IsAny<TaskInputModel>())).Returns(viewModel);

            TaskInputModel inputModel = new TaskInputModel()
            {
                Id = 0,
                Name = name,
                Description = description
            };

            // Action
            var response = _controller.Insert(inputModel);

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.NotNull(responseObject);

            var responseValue = responseObject.Value as ResponseData<TaskDetailViewModel>;
            string expectedName = name;

            Assert.NotNull(responseValue.Data?.Task);
            Assert.Equal(expectedName, responseValue.Data.Task.Name);
        }

        [Theory]
        [InlineData(1, "Test 1", "Description 1")]
        [InlineData(50, "Test 50", "Description 50")]
        public async Task Update(int id, string name, string description)
        {
            // Arrange
            Mock<Domain.Entities.Task> mockTask = new Mock<Domain.Entities.Task>();
            mockTask.SetupGet(f => f.Id).Returns(id);
            mockTask.SetupGet(f => f.Name).Returns(name);
            mockTask.SetupGet(f => f.Description).Returns(description);

            TaskDetailViewModel viewModel = new TaskDetailViewModel()
            {
                Task = mockTask.Object
            };

            _mockAppService.Setup(f => f.Save(It.IsAny<TaskInputModel>())).Returns(viewModel);

            TaskInputModel inputModel = new TaskInputModel()
            {
                Id = id,
                Name = name,
                Description = description
            };

            // Action
            var response = _controller.Update(inputModel);

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.NotNull(responseObject);

            var responseValue = responseObject.Value as ResponseData<TaskDetailViewModel>;
            string expectedName = name;

            Assert.NotNull(responseValue.Data?.Task);
            Assert.Equal(expectedName, responseValue.Data.Task.Name);
        }

        [Theory]
        [InlineData(5)]
        public async System.Threading.Tasks.Task GetById(int expectedId)
        {
            // Arrange
            Mock<Domain.Entities.Task> mockTask = new Mock<Domain.Entities.Task>();
            mockTask.SetupGet(f => f.Id).Returns(expectedId);
            mockTask.SetupGet(f => f.Name).Returns($"Test {expectedId}");

            Mock<TaskDetailViewModel> mockViewModel = new Mock<TaskDetailViewModel>();
            mockViewModel.Setup(f => f.Task).Returns(mockTask.Object);

            // Arrange
            _mockAppService.Setup(f => f.GetById(expectedId)).Returns(mockViewModel.Object);

            // Action
            var response = _controller.GetById(expectedId);

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.Equal((int)HttpStatusCode.OK, responseObject.StatusCode);

            var responseValue = responseObject.Value as ResponseData<TaskDetailViewModel>;
            Assert.NotNull(responseValue.Data);
            Assert.Equal(expectedId, responseValue.Data.Task.Id);
        }


        [Fact]
        public async Task DeleteById()
        {
            // Arrange
            _mockAppService.Setup(f => f.DeleteById(It.IsAny<int>()));

            // Action
            var response = _controller.Delete(It.IsAny<int>());

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.NotNull(responseObject);

            var responseValue = responseObject.Value as ResponseData<HttpStatusCode>;
            Assert.Equal(HttpStatusCode.OK, responseValue.Data);
        }
    }
}
