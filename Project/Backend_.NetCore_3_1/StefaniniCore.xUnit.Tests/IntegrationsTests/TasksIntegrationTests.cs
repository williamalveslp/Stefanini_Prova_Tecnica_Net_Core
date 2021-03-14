using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using StefaniniCore.API.Controllers;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
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
            var response = await _controller.Insert(inputModel);

            // Assert
            Assert.NotNull(response);

            var responseObject = response as OkObjectResult;
            Assert.NotNull(responseObject);

            var responseValue = responseObject.Value as ResponseData<TaskDetailViewModel>;
            string expectedName = name;

            Assert.NotNull(responseValue.Data?.Task);
            Assert.Equal(expectedName, responseValue.Data.Task.Name);
        }
    }
}
