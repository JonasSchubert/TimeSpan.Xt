using System;
using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test;

public class ConversionTests
{
  [Fact]
  public void AllConversionsWorkShouldWorkAsExpected()
  {
    3.1.Centuries().InDecades().Should().Be(31);
    2.5.Decades().InYears().Should().Be(25);
    375.Years().InCenturies().Should().Be(3.75);
    2.5.Years().InDays().Should().Be(912.5);
    4.5.Weeks().InDays().Should().Be(31.5);
    10.5.Days().InWeeks().Should().Be(1.5);
    2.5.Days().InHours().Should().Be(60);
    5.25.Hours().InMinutes().Should().Be(315);
    72.Hours().InDays().Should().Be(3);
    360.Minutes().InHours().Should().Be(6);
    15.5.Minutes().InSeconds().Should().Be(930);
    7200.Seconds().InHours().Should().Be(2);
    10800.Seconds().InDays().Should().Be(0.125);
    5.75.Seconds().InMilliseconds().Should().Be(5750);
  }

  [Fact]
  public void CompareToShouldWorkAsExpected()
  {
    60.Weeks().CompareTo(55.Weeks()).Should().Be(1);
    55.Weeks().CompareTo(60.Weeks()).Should().Be(-1);
  }

  [Fact]
  public void DateTimeOperatorShouldWorkAsExpected()
  {
    var testDateTime = new DateTime(2018, 10, 24, 18, 23, 30, 500);

    (testDateTime + 1.Years()).Should().Be(new DateTime(2019, 10, 24, 18, 23, 30, 500));
    (testDateTime + 1.Weeks()).Should().Be(new DateTime(2018, 10, 31, 18, 23, 30, 500));
    (testDateTime - 24.Days()).Should().Be(new DateTime(2018, 9, 30, 18, 23, 30, 500));
    (testDateTime + 80.5.Hours()).Should().Be(new DateTime(2018, 10, 28, 2, 53, 30, 500));
    (testDateTime - 15.25.Minutes()).Should().Be(new DateTime(2018, 10, 24, 18, 8, 15, 500));
    (testDateTime + 45.75.Seconds()).Should().Be(new DateTime(2018, 10, 24, 18, 24, 16, 250));
    (testDateTime - 15500.Milliseconds()).Should().Be(new DateTime(2018, 10, 24, 18, 23, 15, 0));
  }

  [Fact]
  public void ShouldBeInterchangableWithTimeSpan()
  {
    1.Weeks().Should().Be(TimeSpan.FromDays(7));
    (1.Weeks() + TimeSpan.FromDays(1)).Should().Be(TimeSpan.FromDays(8));
  }
}
