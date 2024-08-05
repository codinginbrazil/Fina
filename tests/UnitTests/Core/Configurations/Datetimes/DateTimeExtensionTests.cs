using Core.Configurations.DateTimes;

namespace UnitTests.Core.Configurations.Datetimes;

public class DateTimeExtensionTests
{
    [Fact]
    public void GetFirstDay_ShouldReturnFirstDayOfMonth()
    {
        // Arrange
        var date = new DateTime(2023, 5, 15);

        // Act
        var firstDay = date.GetFirstDay();

        // Assert
        Assert.Equal(new DateTime(2023, 5, 1), firstDay);
    }

    [Fact]
    public void GetFirstDay_ShouldReturnFirstDayOfSpecificMonthAndYear()
    {
        // Arrange
        var date = new DateTime(2023, 5, 15);

        // Act
        var firstDay = date.GetFirstDay(year: 2024, month: 10);

        // Assert
        Assert.Equal(new DateTime(2024, 10, 1), firstDay);
    }

    [Fact]
    public void GetLastDay_ShouldReturnLastDayOfMonth()
    {
        // Arrange
        var date = new DateTime(2023, 5, 15);

        // Act
        var lastDay = date.GetLastDay();

        // Assert
        Assert.Equal(new DateTime(2023, 5, 31), lastDay);
    }

    [Fact]
    public void GetLastDay_ShouldReturnLastDayOfSpecificMonthAndYear()
    {
        // Arrange
        var date = new DateTime(2023, 5, 15);

        // Act
        var lastDay = date.GetLastDay(year: 2024, month: 2);

        // Assert
        Assert.Equal(new DateTime(2024, 2, 29), lastDay); // Leap year, February has 29 days
    }
}

