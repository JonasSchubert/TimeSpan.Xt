using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class WeeksTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      2.Weeks().Should().Be(14.Days());
      2.Weeks().Should().NotBe(13.Days());
      2.Weeks().Should().BeGreaterThan(13.99.Days());
      2.Weeks().Should().BeLessThan(14.01.Days());
    }
  }
}
