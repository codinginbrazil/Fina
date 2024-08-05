using Core.Requests.Categories;

namespace UnitTests.Core.Requests.Categories;

public class DeleteTests
{
    [Fact]
    public void DeleteRequest_ShouldHaveDefaultValues()
    {
        // Arrange
        var request = new Delete();

        // Act & Assert
        Assert.Equal(string.Empty, request.UserId);
        Assert.Equal(0, request.Id);
    }

    [Fact]
    public void DeleteRequest_ShouldAllowSettingUserId()
    {
        // Arrange
        var request = new Delete();
        var userId = "User123";

        // Act
        request.UserId = userId;

        // Assert
        Assert.Equal(userId, request.UserId);
    }

    [Fact]
    public void DeleteRequest_ShouldAllowSettingId()
    {
        // Arrange
        var request = new Delete();
        var id = 123L;

        // Act
        request.Id = id;

        // Assert
        Assert.Equal(id, request.Id);
    }
}