using Core.Requests.Categories;
using System.ComponentModel.DataAnnotations;

namespace UnitTests.Core.Requests.Categories;

public class UpdateTests
{
    private List<ValidationResult> ValidateModel(object model)
    {
        var validationResults = new List<ValidationResult>();
        var validationContext = new ValidationContext(model, null, null);
        Validator.TryValidateObject(model, validationContext, validationResults, true);
        return validationResults;
    }

    [Fact]
    public void UpdateRequest_ShouldHaveDefaultValues()
    {
        // Arrange
        var request = new Update();

        // Act & Assert
        Assert.Equal(0, request.Id);
        Assert.Equal(string.Empty, request.UserId);
        Assert.Equal(string.Empty, request.Title);
        Assert.Equal(string.Empty, request.Description);
    }

    [Fact]
    public void UpdateRequest_ShouldBeValidWithValidData()
    {
        // Arrange
        var request = new Update
        {
            Id = 1,
            UserId = "User123",
            Title = "Valid Title",
            Description = "Valid Description"
        };

        // Act
        var validationResults = ValidateModel(request);

        // Assert
        Assert.Empty(validationResults); // No validation errors
    }

    [Fact]
    public void UpdateRequest_ShouldFailValidation_WhenTitleIsMissing()
    {
        // Arrange
        var request = new Update
        {
            Id = 1,
            UserId = "User123",
            Description = "Valid Description"
        };

        // Act
        var validationResults = ValidateModel(request);

        // Assert
        var validationResult = Assert.Single(validationResults);
        Assert.Equal("Título inválido", validationResult.ErrorMessage);
    }

    [Fact]
    public void UpdateRequest_ShouldFailValidation_WhenTitleIsTooLong()
    {
        // Arrange
        var request = new Update
        {
            Id = 1,
            UserId = "User123",
            Title = new string('A', 81), // 81 characters
            Description = "Valid Description"
        };

        // Act
        var validationResults = ValidateModel(request);

        // Assert
        var validationResult = Assert.Single(validationResults);
        Assert.Equal("O título deve conter até 80 caracteres", validationResult.ErrorMessage);
    }

    [Fact]
    public void UpdateRequest_ShouldFailValidation_WhenDescriptionIsMissing()
    {
        // Arrange
        var request = new Update
        {
            Id = 1,
            UserId = "User123",
            Title = "Valid Title"
        };

        // Act
        var validationResults = ValidateModel(request);

        // Assert
        var validationResult = Assert.Single(validationResults);
        Assert.Equal("Descrição inválido", validationResult.ErrorMessage);
    }
}