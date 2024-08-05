using Core.Configurations.Constants;
using Core.Responses;

namespace UnitTests.Core.Responses
{
    public class PagedResponseTests
    {
        [Fact]
        public void PagedResponse_ShouldCalculateTotalPagesCorrectly()
        {
            // Arrange
            int totalCount = 100;
            int pageSize = 10;
            int currentPage = 1;

            // Act
            var pagedResponse = new PagedResponse<object>(new object(), totalCount, currentPage, pageSize);

            // Assert
            Assert.Equal(10, pagedResponse.TotalPages);
        }

        [Fact]
        public void PagedResponse_ShouldHaveDefaultValues()
        {
            // Arrange & Act
            var pagedResponse = new PagedResponse<object>(new object());

            // Assert
            Assert.Equal(0, pagedResponse.TotalCount);
            Assert.Equal(1, pagedResponse.CurrentPage);
            Assert.Equal(10, pagedResponse.PageSize);
            Assert.Equal(0, pagedResponse.TotalPages);
        }

        [Fact]
        public void PagedResponse_Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var data = new object();
            int totalCount = 50;
            int currentPage = 2;
            int pageSize = 20;

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
            var pagedResponse = new PagedResponse<object>(new object());

            // Assert
            Assert.True(pagedResponse.IsSuccess);
        }

        [Fact]
        public void PagedResponse_Constructor_ShouldNotInitializeSuccessCorrectly()
        {
            // Arrange & Act
            var pagedResponse = new PagedResponse<object>(new object(), ResponseConst.BadRequest);

            // Assert
            Assert.False(pagedResponse.IsSuccess);
        }
    }
}
