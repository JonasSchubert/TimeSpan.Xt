using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class HoursTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      2.Hours().Should().Be(120.Minutes());
      2.Hours().Should().NotBe(119.Minutes());
      2.Hours().Should().BeGreaterThan(119.99.Minutes());
      2.Hours().Should().BeLessThan(120.01.Minutes());
    }
  }
}
