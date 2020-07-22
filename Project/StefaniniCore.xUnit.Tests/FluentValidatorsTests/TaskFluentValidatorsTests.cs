using FluentValidation.TestHelper;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Services.Validators;
using Xunit;

namespace StefaniniCore.xUnit.Tests.FluentValidatorsTests
{
    public class TaskFluentValidatorsTests
    {
        private readonly TaskInputModelValidator _taskInputModelValidator;

        public TaskFluentValidatorsTests()
        {
            _taskInputModelValidator = new TaskInputModelValidator();
        }

        #region .: FIELDS BY FIELDS :.

        [Theory(DisplayName = "FluentValidator Task - Name Required")]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void FluentValidator_Task_Name_Required(string invalidName)
        {
            _taskInputModelValidator.ShouldHaveValidationErrorFor(x => x.Name, invalidName);
        }

        [Theory(DisplayName = "FluentValidator Task - Name Size Exceeded")]
        [InlineData(31)]
        [InlineData(50)]
        [InlineData(150)]
        [InlineData(2)]
        [InlineData(0)]
        public void FluentValidator_Task_Name_Size_Exceeded(int sizeExceeded)
        {
            string nameSizeExceeded = new string('A', sizeExceeded);
            _taskInputModelValidator.ShouldHaveValidationErrorFor(x => x.Name, nameSizeExceeded);
        }

        [Theory(DisplayName = "FluentValidator Task - Description Size Exceeded")]
        [InlineData(151)]
        [InlineData(180)]
        [InlineData(310)]
        public void FluentValidator_Task_Description_Size_Exceeded(int sizeExceeded)
        {
            string descriptionSizeExceeded = new string('A', sizeExceeded);
            _taskInputModelValidator.ShouldHaveValidationErrorFor(x => x.Description, descriptionSizeExceeded);
        }
        #endregion

        #region .: WITH ALL FIEDS :.

        [Theory(DisplayName = "FluentValidator Task - Validate All Fields - Success")]
        [InlineData(1)]
        [InlineData(3)]
        [InlineData(10)]
        public void FluentValidator_Task_Validate_All_Fields_Success(int id)
        {
            // Arrange
            var validationResult = _taskInputModelValidator.Validate(
                new TaskInputModel()
                {
                    Id = id,
                    Name = "Do something",
                    Description = "Do something very well"
                });

            // Assert
            Assert.True(validationResult.IsValid);
        }

        [Theory(DisplayName = "FluentValidator Task - Validate All Fields - Failed")]
        [InlineData(-10)]
        [InlineData(0)]
        [InlineData(5)]
        public void FluentValidator_Task_Validate_All_Fields__Failed(int id)
        {
            // Arrange
            var validationResult = _taskInputModelValidator.Validate(
                new TaskInputModel()
                {
                    Id = id,
                    Name = null,
                    Description = null
                });

            // Assert
            Assert.False(validationResult.IsValid);
        }
        #endregion
    }
}
