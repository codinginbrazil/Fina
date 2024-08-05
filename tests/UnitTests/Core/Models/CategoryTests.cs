using Core.Models;

namespace UnitTests.Core.Models;

public class CategoryTests
{
    [Fact]
    public void Category_ShouldHaveDefaultValues()
    {
        // Arrange
        var category = new Category();

        // Act
        var id = category.Id;
        var description = category.Description;
        var userId = category.UserId;

        // Assert
        Assert.Equal(0, id); // Assuming default value of long is 0
        Assert.Null(description);
        Assert.Equal(string.Empty, userId);
    }

    [Fact]
    public void Category_ShouldAllowSettingId()
    {
        // Arrange
        var category = new Category();
        var id = 123L;

        // Act
        category.Id = id;

        // Assert
        Assert.Equal(id, category.Id);
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
