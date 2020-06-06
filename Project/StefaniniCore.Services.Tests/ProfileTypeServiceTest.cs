using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services;
using System;
using Xunit;

namespace StefaniniCore.Services.Tests
{
    public class ProfileTypeServiceTest
    {
        private readonly Mock<IProfileTypeRepository> _repository;
        private readonly IProfileTypeService _service;

        public ProfileTypeServiceTest()
        {
            _repository = new Mock<IProfileTypeRepository>();
            _service = new ProfileTypeService(_repository.Object);
        }

        [Fact(DisplayName = "Insert ProfileType - Success")]
        public void Insert_ProfileType_Success()
        {
            // Arrange
            string name = "some name";
            ProfileType profileType = new ProfileType(name);

            // Action
            _service.Insert(profileType);

            // Assert
            _repository.Verify(f => f.Insert(It.Is<ProfileType>(f => f.Name == name)), Times.Once);
        }

        [Fact(DisplayName = "Insert ProfileType - Invalid data")]
        public void Insert_ProfileType_InvalidDate()
        {
            // Arrange
            ProfileType profileType = null;

            // Action
            Assert.Throws<Exception>(() => _service.Insert(profileType));

            // Assert
            _repository.Verify(f => f.Insert(It.Is< ProfileType>(f=> f == profileType)), Times.Never);
        }
    }
}
