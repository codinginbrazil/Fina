using Core.Configurations;
using Core.Responses;

namespace UnitTests.Responses;

public class PagedResponseTests
{
    [Fact]
    public void PagedResponse_ShouldCalculateTotalPagesCorrectly()
    {
        // Arrange
        var totalCount = 100;
        var pageSize = 10;
        var currentPage = 1;

        // Act
        var pagedResponse = new PagedResponse<object>(null, totalCount, currentPage, pageSize);

        // Assert
        Assert.Equal(10, pagedResponse.TotalPages); // Expected total pages should be 10
    }

    [Fact]
    public void PagedResponse_ShouldHaveDefaultValues()
    {
        // Arrange & Act
        var pagedResponse = new PagedResponse<object>(null);

        // Assert
        Assert.Equal(0, pagedResponse.TotalCount);
        Assert.Equal(0, pagedResponse.CurrentPage);
        Assert.Equal(10, pagedResponse.PageSize); // Assume que DefaultPageSize é 10
        Assert.Equal(0, pagedResponse.TotalPages);
    }

    [Fact]
    public void PagedResponse_Constructor_ShouldSetPropertiesCorrectly()
    {
        // Arrange
        var data = new object();
        var totalCount = 50;
        var currentPage = 2;
        var pageSize = 20;

        // Act
        var pagedResponse = new PagedResponse<object>(data, totalCount, currentPage, pageSize);

        // Assert
        Assert.Equal(data, pagedResponse.Data);
        Assert.Equal(totalCount, pagedResponse.TotalCount);
        Assert.Equal(currentPage, pagedResponse.CurrentPage);
        Assert.Equal(pageSize, pagedResponse.PageSize);
        Assert.Equal(3, pagedResponse.TotalPages); // Expected total pages should be 3 (50 total / 20 page size = 2.5, ceiling to 3)
    }

    [Fact]
    public void PagedResponse_Constructor_ShouldInitializeSuccessCorrectly()
    {
        // Arrange & Act
        var pagedResponse = new PagedResponse<object>(null, 200);

        // Assert
        Assert.True(pagedResponse.IsSuccess);
    }

    [Fact]
    public void PagedResponse_Constructor_ShouldNotInitializeSuccessCorrectly()
    {
        // Arrange & Act
        var pagedResponse = new PagedResponse<object>(null, 403);

        // Assert
        Assert.False(pagedResponse.IsSuccess);
    }
}
        