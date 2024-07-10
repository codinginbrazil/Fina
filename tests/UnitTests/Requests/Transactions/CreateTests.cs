using Core.Requests.Transactions;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.Requests.Transactions;

public class CreateTests
{
    [Fact(Skip = "not implemented")]
    public void Amount_ShouldHaveRequiredValidation()
    {
        // Arrange
        var createRequest = new Create();

        // Act
        var validationResults = ValidateModel(createRequest);

        // Assert
        Assert.Contains(validationResults, v => v.MemberNames.Contains("Amount") && v.ErrorMessage == "Valor inválido");
    }

    [Fact (Skip = "not implemented")]
    public void CategoryId_ShouldHaveRequiredValidation()
    {
        // Arrange
        var createRequest = new Create();

        // Act
        var validationResults = ValidateModel(createRequest);

        // Assert
        Assert.Contains(validationResults, v => v.MemberNames.Contains("CategoryId") && v.ErrorMessage == "Categoria inválida");
    }

    [Fact]
    public void PaidOrReceivedAt_ShouldHaveRequiredValidation()
    {
        // Arrange
        var createRequest = new Create();

        // Act
        var validationResults = ValidateModel(createRequest);

        // Assert
        Assert.Contains(validationResults, v => v.MemberNames.Contains("PaidOrReceivedAt") && v.ErrorMessage == "Data inválida");
    }

    private static System.Collections.Generic.List<ValidationResult> ValidateModel(object model)
    {
        var validationResults = new System.Collections.Generic.List<ValidationResult>();
        var context = new ValidationContext(model, serviceProvider: null, items: null);
        Validator.TryValidateObject(model, context, validationResults, validateAllProperties: true);
        return validationResults;
    }
}