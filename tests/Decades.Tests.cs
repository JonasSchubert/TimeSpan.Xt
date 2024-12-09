using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class DecadesTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      3.Decades(accumulated: true).Should().Be(10957.5.Days());
      3.Decades(accumulated: true).Should().NotBe(10957.4.Days());
      3.Decades(accumulated: true).Should().BeGreaterThan(10957.49.Days());
      3.Decades(accumulated: true).Should().BeLessThan(10957.51.Days());

      3.Decades().Should().Be(10950.00.Days());
      3.Decades().Should().NotBe(10949.00.Days());
      3.Decades().Should().BeGreaterThan(10949.99.Days());
      3.Decades().Should().BeLessThan(10950.01.Days());
    }
  }
}
