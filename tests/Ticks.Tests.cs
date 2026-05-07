using AwesomeAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class TicksTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      20_000.Ticks().Should().Be(2.Milliseconds());
    }
  }
}
