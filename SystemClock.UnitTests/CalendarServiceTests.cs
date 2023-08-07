using System;
using FluentAssertions;
using Moq;
using SystemClock.Console;

namespace SystemClock.UnitTests;

public class CalendarServiceTests
{
    [Theory]
    [InlineData("2022-08-01")]
    [InlineData("2022-08-02")]
    [InlineData("2022-08-03")]
    [InlineData("2022-08-04")]
    [InlineData("2022-08-05")]
    public void IsWorkingDay_WhenItIsWorkingDay_ReturnsTrue(string workingDay)
    {
        // Arrange
        var systemClockStub = new Mock<ISystemClock>();
        systemClockStub
            .Setup(x => x.Now)
            .Returns(DateTime.Parse(workingDay));

        var sut = new CalendarService(systemClockStub.Object);

        // Act
        var actual = sut.IsWorkingDay();

        // Assert
        actual.Should().Be(true);
    }

    [Theory]
    [InlineData("2022-08-06")]
    [InlineData("2022-08-07")]
    public void IsWorkingDay_WhenItIsWeekendDay_ReturnsFalse(string weekendDay)
    {
        // Arrange
        var systemClockStub = new Mock<ISystemClock>();

        systemClockStub
            .Setup(x => x.Now)
            .Returns(DateTime.Parse(weekendDay));

        var sut = new CalendarService(systemClockStub.Object);

        // Act
        var actual = sut.IsWorkingDay();

        // Assert
        actual.Should().Be(false);
    }
}