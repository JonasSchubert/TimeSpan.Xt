using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class SecondsTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      2.Seconds().Should().Be(2000.Milliseconds());
      2.Seconds().Should().NotBe(1999.Milliseconds());
      2.Seconds().Should().BeGreaterThan(1999.Milliseconds());
      2.Seconds().Should().BeLessThan(2001.Milliseconds());
    }
  }
}
