using NUnit.Framework;

namespace TimeXt.Test
{
    [TestFixture]
    public class UnitTests
    {
        [Test]
        public void AllComparisonsWorkShouldWorkAsExpected()
        {
            Assert.AreEqual(2.Weeks(), 14.Days());
            Assert.IsTrue(3.Weeks() > 20.9.Days());
            Assert.IsTrue(4.Weeks() < 28.1f.Days());
            Assert.AreNotEqual(2.Weeks(), 13.00.Days());

            Assert.AreEqual(2.Days(), 48.Hours());
            Assert.IsTrue(1.Days() > 23.9.Hours());
            Assert.IsTrue(0.Days() < 0.1f.Hours());
            Assert.AreNotEqual(2.Days(), 49.00.Hours());

            Assert.AreEqual(2.Hours(), 120.Minutes());
            Assert.IsTrue(3.Hours() > 179.9.Minutes());
            Assert.IsTrue(5.Hours() < 300.1f.Minutes());
            Assert.AreNotEqual(2.Hours(), 121.00.Minutes());

            Assert.AreEqual(15.Minutes(), 900.Seconds());
            Assert.IsTrue(30.Minutes() > 1799.9.Seconds());
            Assert.IsTrue(45.Minutes() < 2700.1f.Seconds());
            Assert.AreNotEqual(15.Minutes(), 899.00.Seconds());

            Assert.AreEqual(10.Seconds(), 10000.MilliSeconds());
            Assert.IsTrue(20.Seconds() > 19999.9.MilliSeconds());
            Assert.IsTrue(30.Seconds() < 30000.1f.MilliSeconds());
            Assert.AreNotEqual(10.Seconds(), 10010.00.MilliSeconds());

            Assert.AreEqual(10.MilliSeconds(), 10000.MicroSeconds());
            Assert.IsTrue(20.MilliSeconds() > 19999.9.MicroSeconds());
            Assert.IsTrue(30.MilliSeconds() < 30000.1f.MicroSeconds());
            Assert.AreNotEqual(10.MilliSeconds(), 10010.00.MicroSeconds());

            Assert.AreEqual(10.MicroSeconds(), 10000.NanoSeconds());
            Assert.IsTrue(20.MicroSeconds() > 19999.9.NanoSeconds());
            Assert.IsTrue(30.MicroSeconds() < 30000.1f.NanoSeconds());
            Assert.AreNotEqual(10.MicroSeconds(), 10010.00.NanoSeconds());

            Assert.AreEqual(10.NanoSeconds(), 10000.PicoSeconds());
            Assert.IsTrue(20.NanoSeconds() > 19999.9.PicoSeconds());
            Assert.IsTrue(30.NanoSeconds() < 30000.1f.PicoSeconds());
            Assert.AreNotEqual(10.NanoSeconds(), 10010.00.PicoSeconds());
        }

        [Test]
        public void AllConversionsWorkShouldWorkAsExpected()
        {
            Assert.IsTrue(4.Weeks().InDays == 28.0);
            Assert.IsTrue(7.Days().InWeeks == 1.0);
            Assert.IsTrue(2.5.Days().InHours == 60.0);
            Assert.IsTrue(5.25.Hours().InMinutes == 315.0);
            Assert.IsTrue(72.Hours().InDays == 3.0);
            Assert.IsTrue(360.Minutes().InHours == 6.0);
            Assert.IsTrue(15.5.Minutes().InSeconds == 930.0);
            Assert.IsTrue(7200.Seconds().InHours == 2.0);
            Assert.IsTrue(10800.Seconds().InDays == 0.125);
            Assert.IsTrue(5.75.Seconds().InMilliSeconds == 5750.0);
            Assert.IsTrue(5.75.MilliSeconds().InMicroSeconds == 5750.0);
            Assert.IsTrue(5.75.MicroSeconds().InNanoSeconds == 5750.0);
            Assert.IsTrue(5.75.NanoSeconds().InPicoSeconds == 5750.0);
        }

        [Test]
        public void PlusOperatorShouldWorkAsExpected()
        {
            Assert.IsTrue(2.Weeks() + 7.Days() == 3.Weeks());
            Assert.IsTrue(2.5.Days() + 12.Hours() == 3.Days());
            Assert.IsTrue(2.25.Hours() + 45.Minutes() == 3.Hours());
            Assert.IsTrue(2.25.Minutes() + 45.Seconds() == 3.Minutes());
            Assert.IsTrue(2.25.Seconds() + 750.MilliSeconds() == 3.Seconds());
        }

        [Test]
        public void MinusOperatorShouldWorkAsExpected()
        {
            Assert.IsTrue(2.Weeks() - 7.Days() == 1.Weeks());
            Assert.IsTrue(2.5.Days() - 12.Hours() == 2.Days());
            Assert.IsTrue(2.25.Hours() - 15.Minutes() == 2.Hours());
            Assert.IsTrue(2.25.Minutes() - 15.Seconds() == 2.Minutes());
            Assert.IsTrue(2.25.Seconds() - 250.MilliSeconds() == 2.Seconds());
        }

        [Test]
        public void MultiplicationOperatorShouldWorkAsExpected()
        {
            Assert.IsTrue(2.Weeks() * 2 == 4.Weeks());
            Assert.IsTrue(2.5.Days() * 3 == 7.5.Days());
            Assert.IsTrue(2.25.Hours() * 4 == 10.Hours());
            Assert.IsTrue(2.25.Minutes() * 4 == 10.Minutes());
            Assert.IsTrue(2.25.Seconds() * 4 == 10.Seconds());
        }

        [Test]
        public void DivisionOperatorShouldWorkAsExpected()
        {
            Assert.IsTrue(2.Weeks() / 2 == 1.Weeks());
            Assert.IsTrue(7.5.Days() / 3 == 2.5.Days());
            Assert.IsTrue(4.0.Hours() / 4 == 1.Hours());
            Assert.IsTrue(4.0.Minutes() / 4 == 1.Minutes());
            Assert.IsTrue(4.0.Seconds() / 4 == 1.Seconds());
        }

        [Test]
        public void IncrementOperatorShouldWorkAsExpected()
        {
            var weeks = 2.Weeks();
            Assert.IsTrue(++weeks == 3.Weeks());

            var days = 3.Days();
            Assert.IsTrue(++days == 4.Days());

            var hours = 12.Hours();
            Assert.IsTrue(++hours == 13.Hours());
        }

        [Test]
        public void DecrementOperatorShouldWorkAsExpected()
        {
            var weeks = 2.Weeks();
            Assert.IsTrue(--weeks == 1.Weeks());

            var days = 3.Days();
            Assert.IsTrue(--days == 2.Days());

            var hours = 12.Hours();
            Assert.IsTrue(--hours == 11.Hours());
        }

        [Test]
        public void CompareToShouldWorkAsExpected()
        {
            Assert.IsTrue((55.NanoSeconds().CompareTo(60.NanoSeconds())) == 5000);
        }

        [Test]
        public void ContainsShouldWorkAsExpected()
        {
            Assert.IsTrue(60.NanoSeconds().Contains(55.NanoSeconds()));
            Assert.IsFalse(55.NanoSeconds().Contains(60.NanoSeconds()));
        }
    }
}
