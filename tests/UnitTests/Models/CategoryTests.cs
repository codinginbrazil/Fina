using Core.Models;

namespace UnitTests.Models;

public class CategoryTests
{
    [Fact]
    public void Category_ShouldHaveEmptyUserId_ByDefault()
    {
        // Arrange
        var category = new Category();

        // Act
        var userId = category.UserId;

        // Assert
        Assert.Equal(string.Empty, userId);
    }

    [Fact]
    public void Category_ShouldAllowSettingDescription()
    {
        // Arrange
        var category = new Category();
        var description = "Test Description";

        // Act
        category.Description = description;

        // Assert
        Assert.Equal(description, category.Description);
    }

    [Fact]
    public void Category_ShouldAllowSettingUserId()
    {
        // Arrange
        var category = new Category();
        var userId = "User123";

        // Act
        category.UserId = userId;

        // Assert
        Assert.Equal(userId, category.UserId);
    }
}
