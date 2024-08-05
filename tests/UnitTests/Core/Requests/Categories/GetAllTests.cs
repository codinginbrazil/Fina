using Core.Configurations.Constants;
using Core.Requests.Categories;

namespace UnitTests.Core.Requests.Categories;

public class GetAllRequestTests
{
    [Fact]
    public void GetAllRequest_ShouldHaveDefaultValues()
    {
        // Arrange
        var request = new GetAll();

        // Act & Assert
        Assert.Equal(string.Empty, request.UserId);
        Assert.Equal(Constant.DefaultPageSize, request.PageSize);
        Assert.Equal(Constant.DefaultPageNumber, request.PageNumber);
    }

    [Fact]
    public void GetAllRequest_ShouldAllowSettingUserId()
    {
        // Arrange
        var request = new GetAll();
        var userId = "User123";

        // Act
        request.UserId = userId;

        // Assert
        Assert.Equal(userId, request.UserId);
    }

    [Fact]
    public void GetAllRequest_ShouldAllowSettingPageSize()
    {
        // Arrange
        var request = new GetAll();
        var pageSize = 50;

        // Act
        request.PageSize = pageSize;

        // Assert
        Assert.Equal(pageSize, request.PageSize);
    }

    [Fact]
    public void GetAllRequest_ShouldAllowSettingPageNumber()
    {
        // Arrange
        var request = new GetAll();
        var pageNumber = 2;

        // Act
        request.PageNumber = pageNumber;

        // Assert
        Assert.Equal(pageNumber, request.PageNumber);
    }
}
