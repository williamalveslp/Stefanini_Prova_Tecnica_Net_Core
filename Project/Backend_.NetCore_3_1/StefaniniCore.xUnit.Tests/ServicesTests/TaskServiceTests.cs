using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Domain.Services.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace StefaniniCore.xUnit.Tests.ServicesTests
{
    public class TaskServiceTests
    {
        private readonly Mock<ITaskRepository> _mockRepository;
        private readonly ITaskService _service;

        public TaskServiceTests()
        {
            _mockRepository = new Mock<ITaskRepository>();
            _service = new TaskService(_mockRepository.Object);
        }

        [Theory(DisplayName = "Insert Task Service - Success")]
        [InlineData(true)]
        [InlineData(false)]
        public void Insert_Task_Service_Success(bool isActive)
        {
            // Arrange
            int id = 0;
            string name = "some name 123";
            string description = "some description";

            Mock<Task> mockTask = new Mock<Task>();
            mockTask.SetupGet(f => f.Id).Returns(id);
            mockTask.SetupGet(f => f.Name).Returns(name);
            mockTask.SetupGet(f => f.Description).Returns(description);
            mockTask.SetupGet(f => f.IsActive).Returns(isActive);
            mockTask.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
            mockTask.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);

            _mockRepository.Setup(f => f.Insert(It.IsAny<Task>())).Returns(mockTask.Object);

            // Action
            var result = _service.Insert(new Task(name, description));

            // Assert
            _mockRepository.Verify(f => f.Insert(It.Is<Task>(f => f.Name == name && f.Description == description)), Times.Once);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "GetAll Task Service")]
        public void GetAll_Task_Service()
        {
            // Arrange
            IList<Task> tasks = GetMockSetupList();
            _mockRepository.Setup(x => x.GetAll()).Returns(tasks);

            // Action
            var getAllTasks = _service.GetAll();

            // Assert
            _mockRepository.Verify(f => f.GetAll(), Times.Once);
            Assert.Equal(3, getAllTasks.Count);
        }

        [Fact(DisplayName = "GetById Task Service")]
        public void GetById_Task_Service()
        {
            // Arrange
            int id = 123;

            Mock<Task> mockTask = new Mock<Task>();
            mockTask.SetupGet(f => f.Id).Returns(id);
            mockTask.SetupGet(f => f.Name).Returns("some name 4");
            mockTask.SetupGet(f => f.Description).Returns("some description 4");
            mockTask.SetupGet(f => f.IsActive).Returns(true);
            mockTask.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
            mockTask.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);

            _mockRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(mockTask.Object);

            // Action
            var profileType = _service.GetById(id);

            // Assert
            _mockRepository.Verify(f => f.GetById(It.IsAny<int>()), Times.Once);
            Assert.NotNull(profileType);
        }

        // TODO: Test for Update.

        [Fact(DisplayName = "Delete ById Task Service")]
        public void DeleteById_Task_Service()
        {
            // Arrange
            int id = 5;
            _mockRepository.Setup(f => f.DeleteById(id));

            // Action
            _service.DeleteById(id);

            // Assert
            _mockRepository.Verify(f => f.DeleteById(id), Times.Once);
        }

        #region .: PRIVATE METHODS :.
        private IList<Task> GetMockSetupList()
        {
            Mock<List<Mock<Task>>> mockSetupList = new Mock<List<Mock<Task>>>();

            for (int i = 1; i <= 3; i++)
            {
                Mock<Task> mockProfileType = new Mock<Task>();
                mockProfileType.SetupGet(f => f.Id).Returns(i);
                mockProfileType.SetupGet(f => f.Name).Returns($"some name {i}");
                mockProfileType.SetupGet(f => f.Description).Returns($"some description {i}");
                mockProfileType.SetupGet(f => f.IsActive).Returns(true);
                mockProfileType.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
                mockProfileType.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);
                mockSetupList.Object.Add(mockProfileType);
            }
            IList<Task> tasks = new List<Task>();

            foreach (var item in mockSetupList.Object)
                tasks.Add(item.Object);

            return tasks;
        }
        #endregion

        // TODO: Test for Update
    }
}
