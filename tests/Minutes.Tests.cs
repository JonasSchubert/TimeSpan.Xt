using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test;

public class MinutesTests
{
  [Fact]
  public void ComparisonsWorkShouldWorkAsExpected()
  {
    2.Minutes().Should().Be(120.Seconds());
    2.Minutes().Should().NotBe(119.Seconds());
    2.Minutes().Should().BeGreaterThan(119.99.Seconds());
    2.Minutes().Should().BeLessThan(120.01.Seconds());
  }
}
