using FluentAssertions;
using System;
using Xunit;

namespace FluentTimeSpan.Test
{
    public class UnitTests
    {
        [Fact]
        public void AllComparisonsWorkShouldWorkAsExpected()
        {
            3.Centuries(true).Should().Be(109575.Days());
            3.Centuries(true).Should().NotBe(109574.Days());
            3.Centuries(true).Should().BeGreaterThan(109574.99.Days());
            3.Centuries(true).Should().BeLessThan(109575.01.Days());

            3.Centuries().Should().Be(109500.00.Days());
            3.Centuries().Should().NotBe(109499.Days());
            3.Centuries().Should().BeGreaterThan(109499.99.Days());
            3.Centuries().Should().BeLessThan(109500.01.Days());

            3.Decades(true).Should().Be(10957.5.Days());
            3.Decades(true).Should().NotBe(10957.4.Days());
            3.Decades(true).Should().BeGreaterThan(10957.49.Days());
            3.Decades(true).Should().BeLessThan(10957.51.Days());

            3.Decades().Should().Be(10950.00.Days());
            3.Decades().Should().NotBe(10949.00.Days());
            3.Decades().Should().BeGreaterThan(10949.99.Days());
            3.Decades().Should().BeLessThan(10950.01.Days());

            3.Years(true).Should().Be(1095.75.Days());
            3.Years(true).Should().NotBe(1094.75.Days());
            3.Years(true).Should().BeGreaterThan(1095.74.Days());
            3.Years(true).Should().BeLessThan(1095.76.Days());

            3.Years().Should().Be(1095.00.Days());
            3.Years().Should().NotBe(1094.00.Days());
            3.Years().Should().BeGreaterThan(1094.99.Days());
            3.Years().Should().BeLessThan(1095.01.Days());

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
            3.1.Centuries().InDecades().Should().Be(31);
            2.5.Decades().InYears().Should().Be(25);
            375.Years().InCenturies().Should().Be(3.75);
            2.5.Years().InDays().Should().Be(912.5);
            4.5.Weeks().InDays().Should().Be(31.5);
            10.5.Days().InWeeks().Should().Be(1.5);
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

            (testDateTime + 1.Years()).Should().Be(new DateTime(2019, 10, 24, 18, 23, 30, 500));
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
