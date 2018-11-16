using FluentAssertions;
using System;
using System.Threading.Tasks;
using Xunit;

namespace FluentTimeSpan.Test
{
    public class UnitTests
    {
        [Fact]
        public void AllComparisonsWorkShouldWorkAsExpected()
        {
            2.Weeks().Should().Be(14.Days());
            2.Weeks().Should().NotBe(13.Days());
            2.Weeks().Should().BeGreaterThan(13.99.Days());
            2.Weeks().Should().BeLessThan(14.01.Days());

            2.Days().Should().Be(48.Hours());
            2.Days().Should().NotBe(47.Hours());
            2.Days().Should().BeGreaterThan(47.99.Hours());
            2.Days().Should().BeLessThan(48.01.Hours());

            2.Hours().Should().Be(120.Minutes());
            2.Hours().Should().NotBe(119.Minutes());
            2.Hours().Should().BeGreaterThan(119.99.Minutes());
            2.Hours().Should().BeLessThan(120.01.Minutes());

            2.Minutes().Should().Be(120.Seconds());
            2.Minutes().Should().NotBe(119.Seconds());
            2.Minutes().Should().BeGreaterThan(119.99.Seconds());
            2.Minutes().Should().BeLessThan(120.01.Seconds());

            2.Seconds().Should().Be(2000.Milliseconds());
            2.Seconds().Should().NotBe(1999.Milliseconds());
            2.Seconds().Should().BeGreaterThan(1999.Milliseconds());
            2.Seconds().Should().BeLessThan(2001.Milliseconds());
        }

        [Fact]
        public void AllConversionsWorkShouldWorkAsExpected()
        {
            4.Weeks().InDays().Should().Be(28);
            7.Days().InWeeks().Should().Be(1);
            2.5.Days().InHours().Should().Be(60);
            5.25.Hours().InMinutes().Should().Be(315);
            72.Hours().InDays().Should().Be(3);
            360.Minutes().InHours().Should().Be(6);
            15.5.Minutes().InSeconds().Should().Be(930);
            7200.Seconds().InHours().Should().Be(2);
            10800.Seconds().InDays().Should().Be(0.125);
            5.75.Seconds().InMilliseconds().Should().Be(5750);
        }

        [Fact]
        public void PlusOperatorShouldWorkAsExpected()
        {
            (2.Weeks() + 7.Days()).Should().Be(3.Weeks());
            (2.5.Days() + 12.Hours()).Should().Be(3.Days());
            (2.25.Hours() + 45.Minutes()).Should().Be(3.Hours());
            (2.25.Minutes() + 45.Seconds()).Should().Be(3.Minutes());
            (2.25.Seconds() + 750.Milliseconds()).Should().Be(3.Seconds());
        }

        [Fact]
        public void MinusOperatorShouldWorkAsExpected()
        {
            (2.Weeks() - 7.Days()).Should().Be(1.Weeks());
            (2.5.Days() - 12.Hours()).Should().Be(2.Days());
            (2.25.Hours() - 15.Minutes()).Should().Be(2.Hours());
            (2.25.Minutes() - 15.Seconds()).Should().Be(2.Minutes());
            (2.25.Seconds() - 250.Milliseconds()).Should().Be(2.Seconds());
        }

        [Fact]
        public void MultiplicationOperatorShouldWorkAsExpected()
        {
            (2.Weeks() * 2.0).Should().Be(4.Weeks());
            (2.5.Days() * 3.0).Should().Be(7.5.Days());
            (2.25.Hours() * 4.0).Should().Be(9.Hours());
            (2.25.Minutes() * 4.0).Should().Be(9.Minutes());
            (2.25.Seconds() * 4.0).Should().Be(9.Seconds());
        }

        [Fact]
        public void DivisionOperatorShouldWorkAsExpected()
        {
            (2.Weeks() / 2.0).Should().Be(1.Weeks());
            (7.5.Days() / 3.0).Should().Be(2.5.Days());
            (4.0.Hours() / 4.0).Should().Be(1.Hours());
            (4.0.Minutes() / 4.0).Should().Be(1.Minutes());
            (4.0.Seconds() / 4.0).Should().Be(1.Seconds());
        }

        [Fact]
        public void CompareToShouldWorkAsExpected()
        {
            60.Weeks().CompareTo(55.Weeks()).Should().Be(1);
            55.Weeks().CompareTo(60.Weeks()).Should().Be(-1);
        }

        [Fact]
        public void DateTimeOperatorShouldWorkAsExpected()
        {
            var testDateTime = new DateTime(2018, 10, 24, 18, 23, 30, 500);

            (testDateTime + 1.Weeks()).Should().Be(new DateTime(2018, 10, 31, 18, 23, 30, 500));
            (testDateTime - 24.Days()).Should().Be(new DateTime(2018, 9, 30, 18, 23, 30, 500));
            (testDateTime + 80.5.Hours()).Should().Be(new DateTime(2018, 10, 28, 2, 53, 30, 500));
            (testDateTime - 15.25.Minutes()).Should().Be(new DateTime(2018, 10, 24, 18, 8, 15, 500));
            (testDateTime + 45.75.Seconds()).Should().Be(new DateTime(2018, 10, 24, 18, 24, 16, 250));
            (testDateTime - 15500.Milliseconds()).Should().Be(new DateTime(2018, 10, 24, 18, 23, 15, 0));
        }

        [Fact]
        public void ShouldBeInterchangableWithTimeSpan()
        {
            1.Weeks().Should().Be(TimeSpan.FromDays(7));
            (1.Weeks() + TimeSpan.FromDays(1)).Should().Be(TimeSpan.FromDays(8));
        }
    }
}
