using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services;
using Xunit;

namespace StefaniniCore.xUnit.Tests.ServicesTests
{
    public class ProfileTypeServiceTests
    {
        private readonly Mock<IProfileTypeRepository> _repository;
        private readonly IProfileTypeService _service;

        public ProfileTypeServiceTests()
        {
            _repository = new Mock<IProfileTypeRepository>();
            _service = new ProfileTypeService(_repository.Object);
        }

        [Fact(DisplayName = "Insert ProfileType Service - Success")]
        public void Insert_ProfileType_Service_Success()
        {
            // Arrange
            string name = "some name";
            ProfileType profileType = new ProfileType(name);

            // Action
            _service.Insert(profileType);

            // Assert
            _repository.Verify(f => f.Insert(It.Is<ProfileType>(f => f.Name == name)), Times.Once);
        }
    }
}
