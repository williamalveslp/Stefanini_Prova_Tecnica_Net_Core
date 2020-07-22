using StefaniniCore.Application.Validators.ProfileTypes;
using Xunit;
using FluentValidation.TestHelper;
using StefaniniCore.Application.InputModels.ProfileTypes;

namespace StefaniniCore.xUnit.Tests.FluentValidatorsTests
{
    public class ProfileTypeFluentValidatorsTests
    {
        private readonly ProfileTypeInputModelValidator _profileTypeInputModelValidator;

        public ProfileTypeFluentValidatorsTests()
        {
            _profileTypeInputModelValidator = new ProfileTypeInputModelValidator();
        }

        #region .: FIELDS BY FIELDS :.
        [Theory(DisplayName = "FluentValidator ProfileType - Name Required")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void FluentValidator_ProfileType_Name_Required(string invalidName)
        {
            _profileTypeInputModelValidator.ShouldHaveValidationErrorFor(x => x.Name, invalidName);
        }

        [Theory(DisplayName = "FluentValidator ProfileType - TaskList Required")]
        [InlineData(null)]
        [InlineData(new int[] { })]
        public void FluentValidator_ProfileType_TaskList_Required(int[] invalidData)
        {
            _profileTypeInputModelValidator.ShouldHaveValidationErrorFor(x => x.TaskIds, invalidData);
        }

        [Theory(DisplayName = "FluentValidator ProfileType - Name Size Exceeded")]
        [InlineData(31)]
        [InlineData(50)]
        [InlineData(150)]
        [InlineData(2)]
        [InlineData(0)]
        public void FluentValidator_ProfileType_Name_Size_Exceeded(int sizeExceeded)
        {
            string nameSizeExceeded = new string('A', sizeExceeded);
            _profileTypeInputModelValidator.ShouldHaveValidationErrorFor(x => x.Name, nameSizeExceeded);
        }
        #endregion

        #region .: WITH ALL FIELDS :.
        [Fact(DisplayName = "FluentValidator ProfileType - Validate All Fields - Sucess")]
        public void FluentValidator_ProfileType_Validate_All_Fields_Sucess()
        {
            // Arrange
            var validationResult = _profileTypeInputModelValidator.Validate(
                new ProfileTypeInputModel()
                {
                    Name = "Jhon",
                    TaskIds = new int[] { 3, 5, 10 }
                });

            // Assert
            Assert.True(validationResult.IsValid);
        }

        [Fact(DisplayName = "FluentValidator ProfileType - Validate All Fields - Failed")]
        public void FluentValidator_ProfileType_Validate_All_Fields_Failed()
        {
            // Arrange
            var validationResult = _profileTypeInputModelValidator.Validate(
                new ProfileTypeInputModel()
                {
                    Name = null,
                    TaskIds = null
                });

            // Assert
            Assert.False(validationResult.IsValid);
        }
        #endregion
    }
}
