using Core.Configurations.Exceptions;

namespace UnitTests.Core.Configurations.Exceptions;

public class CommonExceptionTests
{
    [Fact]
    public void CommonException_ShouldHaveParameterlessConstructor()
    {
        // Act
        var exception = new CommonException();

        // Assert
        Assert.NotNull(exception);
        Assert.Equal("Exception of type 'Core.Configurations.Exceptions.CommonException' was thrown.", exception.Message);
    }

    [Fact]
    public void CommonException_ShouldSetMessage()
    {
        // Arrange
        var message = "This is a custom error message.";

        // Act
        var exception = new CommonException(message);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal(message, exception.Message);
    }

    [Fact]
    public void CommonException_ShouldSetMessageAndInnerException()
    {
        // Arrange
        var message = "This is a custom error message.";
        var innerException = new Exception("This is an inner exception.");

        // Act
        var exception = new CommonException(message, innerException);

        // Assert
        Assert.NotNull(exception);
        Assert.Equal(message, exception.Message);
        Assert.Equal(innerException, exception.InnerException);
    }
}
