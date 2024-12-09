using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class CenturiesTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      3.Centuries(accumulated: true).Should().Be(109575.Days());
      3.Centuries(accumulated: true).Should().NotBe(109574.Days());
      3.Centuries(accumulated: true).Should().BeGreaterThan(109574.99.Days());
      3.Centuries(accumulated: true).Should().BeLessThan(109575.01.Days());

      3.Centuries().Should().Be(109500.00.Days());
      3.Centuries().Should().NotBe(109499.Days());
      3.Centuries().Should().BeGreaterThan(109499.99.Days());
      3.Centuries().Should().BeLessThan(109500.01.Days());
    }
  }
}
