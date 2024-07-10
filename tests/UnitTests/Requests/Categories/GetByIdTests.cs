using Core.Requests.Categories;

namespace UnitTests.Requests.Categories;

public class GetByIdTests
{
    [Fact]
    public void GetByIdRequest_ShouldAllowSettingAndGetId()
    {
        // Arrange
        var request = new GetById();
        var id = 123L;

        // Act
        request.Id = id;

        // Assert
        Assert.Equal(id, request.Id);
    }
}