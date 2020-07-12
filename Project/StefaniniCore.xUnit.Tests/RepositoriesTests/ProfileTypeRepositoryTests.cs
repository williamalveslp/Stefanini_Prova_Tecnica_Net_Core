using Moq;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using Xunit;

namespace StefaniniCore.xUnit.Tests.RepositoriesTests
{
    public class ProfileTypeRepositoryTests
    {
        private readonly IProfileTypeRepository _mockRepository;
        private readonly Mock<IProfileTypeRepository> mock;

        public ProfileTypeRepositoryTests()
        {
            mock = new Mock<IProfileTypeRepository>();

            IList<ProfileType> profileTypes = new List<ProfileType>()
            {
                new ProfileType("some name 1"),
                new ProfileType("some name 2"),
                new ProfileType("some name 3")
            };
            // Mock GetAll.
            mock.Setup(x => x.GetAll()).Returns(profileTypes);

            // Mock Insert.
            mock.Setup(x => x.Insert(It.IsAny<ProfileType>()))
                .Returns(new ProfileType("saved"));

            _mockRepository = mock.Object;
        }

        [Fact(DisplayName = "Insert ProfileType Repository - Success")]
        public void Insert_ProfileType_Repository_Success()
        {
            var profileType = new ProfileType("to save");

            var result = _mockRepository.Insert(profileType);
            Assert.NotNull(result);
        }

        [Fact(DisplayName = "GetAll ProfileType Repository - Success")]
        public void GetAll_ProfileType_GetAll()
        {
            var allProfileTypes = _mockRepository.GetAll();

            Assert.NotNull(allProfileTypes);
            Assert.NotEqual(0, allProfileTypes.Count);
        }

        // TODO: Update e Delete.
        // Sample: https://www.codeproject.com/Articles/47603/Mock-a-database-repository-using-moq
    }
}
