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
    public class UserSystemServiceTests
    {
        private readonly Mock<IUserSystemRepository> _mockRepository;
        private readonly IUserSystemService _service;

        public UserSystemServiceTests()
        {
            _mockRepository = new Mock<IUserSystemRepository>();
            _service = new UserSystemService(_mockRepository.Object);
        }

        [Theory(DisplayName = "Insert UserSystem Service - Success")]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(7)]
        public void Insert_UserSystem_Service_Success(int profileTypeId)
        {
            // Arrange
            int id = 0;
            string userName = "some user name";
            string password = "some pas$word";

            Mock<UserSystem> mockExpectedProfileType = new Mock<UserSystem>();
            mockExpectedProfileType.SetupGet(f => f.Id).Returns(id);
            mockExpectedProfileType.SetupGet(f => f.UserName).Returns(userName);
            mockExpectedProfileType.SetupGet(f => f.Password).Returns(password);

            _mockRepository.Setup(f => f.Insert(It.IsAny<UserSystem>())).Returns(mockExpectedProfileType.Object);

            // Action
            var result = _service.Insert(new UserSystem(userName, password, profileTypeId));

            // Assert
            _mockRepository.Verify(f => f.Insert(It.Is<UserSystem>(f => f.UserName == userName && f.Password == password)), Times.Once);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "GetAll UserSystem Service")]
        public void GetAll_UserSystem_Service()
        {
            // Arrange
            IList<UserSystem> userSystem = GetMockSetupList();
            _mockRepository.Setup(x => x.GetAll()).Returns(userSystem);

            // Action
            var getAllUserSystems = _service.GetAll();

            // Assert
            _mockRepository.Verify(f => f.GetAll(), Times.Once);
            Assert.Equal(3, getAllUserSystems.Count);
        }

        [Fact(DisplayName = "GetById UserSystem Service")]
        public void GetById_UserSystem_Service()
        {
            // Arrange
            int id = 123;

            UserSystem user = new UserSystem("some user name", "some pas$word", 1);
            _mockRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(user);

            // Action
            var profileType = _service.GetById(id);

            // Assert
            _mockRepository.Verify(f => f.GetById(It.IsAny<int>()), Times.Once);
            Assert.NotNull(profileType);
        }

        // TODO: Test for Update.

        [Fact(DisplayName = "Delete ById UserSystem Service")]
        public void DeleteById_UserSystem_Service()
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
        private IList<UserSystem> GetMockSetupList()
        {
            Mock<List<Mock<UserSystem>>> mockSetupList = new Mock<List<Mock<UserSystem>>>();

            for (int i = 1; i <= 3; i++)
            {
                Mock<UserSystem> mockUserSystems = new Mock<UserSystem>();
                mockUserSystems.SetupGet(f => f.Id).Returns(i);
                mockUserSystems.SetupGet(f => f.UserName).Returns($"some userName {i}");
                mockUserSystems.SetupGet(f => f.Password).Returns($"some password {i}");
                mockUserSystems.SetupGet(f => f.IsActive).Returns(true);
                mockUserSystems.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
                mockUserSystems.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);
                mockSetupList.Object.Add(mockUserSystems);
            }
            IList<UserSystem> userSystems = new List<UserSystem>();

            foreach (var item in mockSetupList.Object)
                userSystems.Add(item.Object);

            return userSystems;
        }
        #endregion
    }
}
