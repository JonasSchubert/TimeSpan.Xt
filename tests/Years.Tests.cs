using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class YearsTests
  {
    [Fact]
    public void ComparisonsWorkShouldWorkAsExpected()
    {
      3.Years(accumulated: true).Should().Be(1095.75.Days());
      3.Years(accumulated: true).Should().NotBe(1094.75.Days());
      3.Years(accumulated: true).Should().BeGreaterThan(1095.74.Days());
      3.Years(accumulated: true).Should().BeLessThan(1095.76.Days());

      3.Years().Should().Be(1095.00.Days());
      3.Years().Should().NotBe(1094.00.Days());
      3.Years().Should().BeGreaterThan(1094.99.Days());
      3.Years().Should().BeLessThan(1095.01.Days());
    }
  }
}
