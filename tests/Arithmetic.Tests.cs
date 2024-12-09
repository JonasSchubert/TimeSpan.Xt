using FluentAssertions;
using Xunit;

namespace TimeSpanXt.Test
{
  public class ArithmeticTests
  {
    [Fact]
    public void PlusOperatorShouldWorkAsExpected()
    {
      (3.Centuries() + 20.Decades()).Should().Be(5.Centuries());
      (3.Decades() + 20.Years()).Should().Be(5.Decades());
      (1.Years() + 50.Weeks() + 15.Days()).Should().Be(2.Years());
      (2.Weeks() + 7.Days()).Should().Be(3.Weeks());
      (2.5.Days() + 12.Hours()).Should().Be(3.Days());
      (2.25.Hours() + 45.Minutes()).Should().Be(3.Hours());
      (2.25.Minutes() + 45.Seconds()).Should().Be(3.Minutes());
      (2.25.Seconds() + 750.Milliseconds()).Should().Be(3.Seconds());
    }

    [Fact]
    public void MinusOperatorShouldWorkAsExpected()
    {
      (3.Centuries() - 20.Decades()).Should().Be(1.Centuries());
      (3.Decades() - 20.Years()).Should().Be(1.Decades());
      (2.Years() - 50.Weeks() - 15.Days()).Should().Be(1.Years());
      (2.Weeks() - 7.Days()).Should().Be(1.Weeks());
      (2.5.Days() - 12.Hours()).Should().Be(2.Days());
      (2.25.Hours() - 15.Minutes()).Should().Be(2.Hours());
      (2.25.Minutes() - 15.Seconds()).Should().Be(2.Minutes());
      (2.25.Seconds() - 250.Milliseconds()).Should().Be(2.Seconds());
    }

    [Fact]
    public void MultiplicationOperatorShouldWorkAsExpected()
    {
      (2.Centuries() * 2.0).Should().Be(4.Centuries());
      (2.Decades() * 2.0).Should().Be(4.Decades());
      (2.Years() * 2.0).Should().Be(4.Years());
      (2.Weeks() * 2.0).Should().Be(4.Weeks());
      (2.5.Days() * 3.0).Should().Be(7.5.Days());
      (2.25.Hours() * 4.0).Should().Be(9.Hours());
      (2.25.Minutes() * 4.0).Should().Be(9.Minutes());
      (2.25.Seconds() * 4.0).Should().Be(9.Seconds());
    }

    [Fact]
    public void DivisionOperatorShouldWorkAsExpected()
    {
      (2.Centuries() / 2.0).Should().Be(1.Centuries());
      (2.Decades() / 2.0).Should().Be(1.Decades());
      (2.Years() / 2.0).Should().Be(1.Years());
      (2.Weeks() / 2.0).Should().Be(1.Weeks());
      (7.5.Days() / 3.0).Should().Be(2.5.Days());
      (4.0.Hours() / 4.0).Should().Be(1.Hours());
      (4.0.Minutes() / 4.0).Should().Be(1.Minutes());
      (4.0.Seconds() / 4.0).Should().Be(1.Seconds());
    }
  }
}
