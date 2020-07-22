using StefaniniCore.Application.Validators;
using FluentValidation.TestHelper;
using Xunit;
using StefaniniCore.Application.InputModels.UserSystemInputModel;

namespace StefaniniCore.xUnit.Tests.FluentValidatorsTests
{
    public class UserSystemFluentValidatorsTests
    {
        private readonly UserSystemInputModelValidator _userSystemInputModelValidator;

        public UserSystemFluentValidatorsTests()
        {
            _userSystemInputModelValidator = new UserSystemInputModelValidator();
        }

        #region .: FIELDSC BY FIELD :.

        [Theory(DisplayName = "FluentValidator UserSystem - UserName Required")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void FluentValidator_UserSystem_UserName_Required(string invalidName)
        {
            _userSystemInputModelValidator.ShouldHaveValidationErrorFor(x => x.UserName, invalidName);
        }

        [Theory(DisplayName = "FluentValidator UserSystem - UserSystem Size Exceeded")]
        [InlineData(31)]
        [InlineData(50)]
        [InlineData(150)]
        [InlineData(2)]
        [InlineData(0)]
        public void FluentValidator_UserSystem_UserName_Size_Exceeded(int sizeExceeded)
        {
            string userSystemSizeExceeded = new string('A', sizeExceeded);
            _userSystemInputModelValidator.ShouldHaveValidationErrorFor(x => x.UserName, userSystemSizeExceeded);
        }

        [Theory(DisplayName = "FluentValidator UserSystem - Password Required")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void FluentValidator_UserSystem_Password_Required(string invalidName)
        {
            _userSystemInputModelValidator.ShouldHaveValidationErrorFor(x => x.Password, invalidName);
        }

        [Theory(DisplayName = "FluentValidator UserSystem - Password Size Exceeded")]
        [InlineData(31)]
        [InlineData(50)]
        [InlineData(150)]
        [InlineData(2)]
        [InlineData(0)]
        public void FluentValidator_UserSystem_Password_Size_Exceeded(int sizeExceeded)
        {
            string passwordSizeExceeded = new string('A', sizeExceeded);
            _userSystemInputModelValidator.ShouldHaveValidationErrorFor(x => x.Password, passwordSizeExceeded);
        }

        [Theory(DisplayName = "FluentValidator UserSystem - ProfileId Required")]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-4)]
        public void FluentValidator_UserSystem_ProfileId_Required(int profileId)
        {
            _userSystemInputModelValidator.ShouldHaveValidationErrorFor(x => x.ProfileTypeId, profileId);;
        }
        #endregion

        #region .: WITH ALL FIELDS :.
        [Theory(DisplayName = "FluentValidator UserSystem - Validate All Fields - Success")]
        [InlineData(1)]
        [InlineData(7)]
        [InlineData(10)]
        public void FluentValidator_UserSystem_Validate_All_Fields_Success(int id)
        {
            // Arrange
            var validationResult = _userSystemInputModelValidator.Validate(
               new UserSystemInputModel()
               {
                   Id = id,
                   UserName = "john_snow",
                   Password = "myPa$sword",
                   ProfileTypeId = 1
               });

            // Assert
            Assert.True(validationResult.IsValid);
        }

        [Theory(DisplayName = "FluentValidator UserSystem - Validate All Fields - Failed")]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(10)]
        public void FluentValidator_UserSystem_Validate_All_Fields_Failed(int id)
        {
            // Arrange
            var validationResult = _userSystemInputModelValidator.Validate(
               new UserSystemInputModel()
               {
                   Id = id,
                   UserName = null,
                   Password = null,
                   ProfileTypeId = 1
               });

            // Assert
            Assert.False(validationResult.IsValid);
        }
        #endregion
    }
}
