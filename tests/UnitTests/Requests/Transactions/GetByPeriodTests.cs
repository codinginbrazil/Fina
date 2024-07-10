using Core.Configurations;
using Core.Requests.Transactions;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.Requests.Transactions;

public class GetByPeriodTests
{
    [Fact]
    public void StartDate_ShouldNotHaveRequiredValidation()
    {
        // Arrange
        var getByPeriod = new GetByPeriod();

        // Act
        var validationResults = ValidateModel(getByPeriod);

        // Assert
        Assert.DoesNotContain(validationResults, v => v.MemberNames.Contains("StartDate"));
    }

    [Fact]
    public void EndDate_ShouldNotHaveRequiredValidation()
    {
        // Arrange
        var getByPeriod = new GetByPeriod();

        // Act
        var validationResults = ValidateModel(getByPeriod);

        // Assert
        Assert.DoesNotContain(validationResults, v => v.MemberNames.Contains("EndDate"));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("2023-01-01")]
    public void StartDate_ShouldValidateCorrectly(string inputDate)
    {
        // Arrange
        var getByPeriod = new GetByPeriod();
        if (inputDate != null)
        {
            getByPeriod.StartDate = DateTime.Parse(inputDate);
        }

        // Act
        var validationResults = ValidateModel(getByPeriod);

        // Assert
        Assert.True(IsValid(validationResults));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("2023-01-31")]
    public void EndDate_ShouldValidateCorrectly(string inputDate)
    {
        // Arrange
        var getByPeriod = new GetByPeriod();
        if (inputDate != null)
        {
            getByPeriod.EndDate = DateTime.Parse(inputDate);
        }

        // Act
        var validationResults = ValidateModel(getByPeriod);

        // Assert
        Assert.True(IsValid(validationResults));
    }

    private static System.Collections.Generic.List<ValidationResult> ValidateModel(object model)
    {
        var validationResults = new System.Collections.Generic.List<ValidationResult>();
        var context = new ValidationContext(model, serviceProvider: null, items: null);
        Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);
        return validationResults;
    }

    private static bool IsValid(System.Collections.Generic.List<ValidationResult> validationResults)
    {
        return validationResults.Count == 0;
    }
}