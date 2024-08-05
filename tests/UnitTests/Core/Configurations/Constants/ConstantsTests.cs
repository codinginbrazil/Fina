using Core.Configurations.Constants;

namespace UnitTests.Core.Configurations.Constants;

public class ConstConfigurationTests
{
    [Fact]
    public void FrontendConst_ShouldHaveCorrectPortAndUrl()
    {
        // Arrange
        var expectedHost = Constant.Host;
        var expectedPort = "5200";
        var expectedUrl = $"{expectedHost}:{expectedPort}";

        // Act
        var actualHost = FrontendConst.Host;
        var actualPort = FrontendConst.Port;
        var actualUrl = FrontendConst.Url;

        // Assert
        Assert.Equal(expectedHost, actualHost);
        Assert.Equal(expectedPort, actualPort);
        Assert.Equal(expectedUrl, actualUrl);
    }

    [Fact]
    public void BackendConst_ShouldHaveCorrectPortAndUrl()
    {
        // Arrange
        var expectedHost = Constant.Host;
        var expectedPort = "7273";
        var expectedUrl = $"{expectedHost}:{expectedPort}";

        // Act
        var actualHost = BackendConst.Host;
        var actualPort = BackendConst.Port;
        var actualUrl = BackendConst.Url;

        // Assert
        Assert.Equal(expectedHost, actualHost);
        Assert.Equal(expectedPort, actualPort);
        Assert.Equal(expectedUrl, actualUrl);
    }

    [Fact]
    public void FrontendAndBackendPorts_ShouldBeDifferent()
    {
        // Act
        var frontendPort = FrontendConst.Port;
        var backendPort = BackendConst.Port;

        // Assert
        Assert.NotEqual(frontendPort, backendPort);
    }

}
