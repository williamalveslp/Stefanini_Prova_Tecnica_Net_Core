using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace StefaniniCore.xUnit.Tests.ServicesTests
{
    public class ProfileTypeServiceTests
    {
        private readonly Mock<IProfileTypeRepository> _mockRepository;
        private readonly IProfileTypeService _service;

        public ProfileTypeServiceTests()
        {
            _mockRepository = new Mock<IProfileTypeRepository>();
            _service = new ProfileTypeService(_mockRepository.Object);
        }

        [Theory(DisplayName = "Insert ProfileType Service - Success")]
        [InlineData(true)]
        [InlineData(false)]
        public void Insert_ProfileType_Service_Success(bool isActive)
        {
            // Arrange
            int id = 0;
            string name = "some name 123";

            Mock<ProfileType> mockExpectedProfileType = new Mock<ProfileType>();
            mockExpectedProfileType.SetupGet(f => f.Id).Returns(id);
            mockExpectedProfileType.SetupGet(f => f.Name).Returns(name);
            mockExpectedProfileType.SetupGet(f => f.IsActive).Returns(isActive);
            mockExpectedProfileType.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
            mockExpectedProfileType.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);

            _mockRepository.Setup(f => f.Insert(It.IsAny<ProfileType>())).Returns(mockExpectedProfileType.Object);
           
            // Action
            var result = _service.Insert(new ProfileType(name));

            // Assert
            _mockRepository.Verify(f => f.Insert(It.Is<ProfileType>(f => f.Name == name)), Times.Once);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "GetAll ProfileType Service")]
        public void GetAll_ProfileType_Service()
        {
            // Arrange
            IList<ProfileType> profileTypes = GetMockSetupList();
            _mockRepository.Setup(x => x.GetAll()).Returns(profileTypes);

            // Action
            var getAllProfileTypes = _service.GetAll();

            // Assert
            _mockRepository.Verify(f => f.GetAll(), Times.Once);
            Assert.Equal(3, getAllProfileTypes.Count);
        }

        [Fact(DisplayName = "GetById ProfileType Service")]
        public void GetById_ProfileType_Service()
        {
            // Arrange
            int id = 123;

            Mock<ProfileType> mockProfileType = new Mock<ProfileType>();
            mockProfileType.SetupGet(f => f.Id).Returns(id);
            mockProfileType.SetupGet(f => f.Name).Returns("some name 4");
            mockProfileType.SetupGet(f => f.IsActive).Returns(true);
            mockProfileType.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
            mockProfileType.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);

            _mockRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(mockProfileType.Object);

            // Action
            var profileType = _service.GetById(id);

            // Assert
            _mockRepository.Verify(f => f.GetById(It.IsAny<int>()), Times.Once);
            Assert.NotNull(profileType);
        }

        #region .: PRIVATE METHODS :.
        private IList<ProfileType> GetMockSetupList()
        {   
            Mock<List<Mock<ProfileType>>> mockSetupList = new Mock<List<Mock<ProfileType>>>();

            for (int i = 1; i <= 3; i++)
            {
                Mock<ProfileType> mockProfileType = new Mock<ProfileType>();
                mockProfileType.SetupGet(f => f.Id).Returns(i);
                mockProfileType.SetupGet(f => f.Name).Returns($"some name {i}");
                mockProfileType.SetupGet(f => f.IsActive).Returns(true);
                mockProfileType.SetupGet(f => f.Date_Created).Returns(DateTime.Now);
                mockProfileType.SetupGet(f => f.Date_Updated).Returns(DateTime.Now);
                mockSetupList.Object.Add(mockProfileType);
            }
            IList<ProfileType> profileTypes = new List<ProfileType>();

            foreach (var item in mockSetupList.Object)
                profileTypes.Add(item.Object);

            return profileTypes;
        }
        #endregion
    }
}
