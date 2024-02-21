using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test;

public class DaysTests
{
  [Fact]
  public void ComparisonsWorkShouldWorkAsExpected()
  {
    2.Days().Should().Be(48.Hours());
    2.Days().Should().NotBe(47.Hours());
    2.Days().Should().BeGreaterThan(47.99.Hours());
    2.Days().Should().BeLessThan(48.01.Hours());
  }
}
