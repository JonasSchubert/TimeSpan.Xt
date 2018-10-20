using System;

namespace TimeXt
{
    public class Interval
    {
        public Interval(double value, Unit unit)
        {
            Value = value;
            Unit = unit;
        }

        public double Value { get; }

        public Unit Unit { get; }

        public double InWeeks { get { return Value * Unit.ConversionRate / UnitCollection.Week.ConversionRate; } }

        public double InDays { get { return Value * Unit.ConversionRate / UnitCollection.Day.ConversionRate; } }

        public double InHours { get { return Value * Unit.ConversionRate / UnitCollection.Hour.ConversionRate; } }

        public double InMinutes { get { return Value * Unit.ConversionRate / UnitCollection.Minute.ConversionRate; } }

        public double InSeconds { get { return Value * Unit.ConversionRate / UnitCollection.Second.ConversionRate; } }

        public double InMilliSeconds { get { return Value * Unit.ConversionRate / UnitCollection.MilliSecond.ConversionRate; } }

        public double InMicroSeconds { get { return Value * Unit.ConversionRate / UnitCollection.MicroSecond.ConversionRate; } }

        public double InNanoSeconds { get { return Value * Unit.ConversionRate / UnitCollection.NanoSecond.ConversionRate; } }

        public double InPicoSeconds { get { return Value * Unit.ConversionRate / UnitCollection.PicoSecond.ConversionRate; } }

        public static bool operator >(Interval interval1, Interval interval2)
        {
            return interval1.InPicoSeconds > interval2.InPicoSeconds;
        }

        public static bool operator <(Interval interval1, Interval interval2)
        {
            return interval1.InPicoSeconds < interval2.InPicoSeconds;
        }

        public static Interval operator +(Interval interval1, Interval interval2)
        {
            var value = ((interval1.InPicoSeconds + interval2.InPicoSeconds) / interval1.Unit.ConversionRate) * UnitCollection.PicoSecond.ConversionRate;
            return new Interval(value, interval1.Unit);
        }

        public static Interval operator -(Interval interval1, Interval interval2)
        {
            var value = ((interval1.InPicoSeconds - interval2.InPicoSeconds) / interval1.Unit.ConversionRate) * UnitCollection.PicoSecond.ConversionRate;
            return new Interval(value, interval1.Unit);
        }

        public static Interval operator *(Interval interval, double multiplier)
        {
            var value = interval.Value * multiplier;
            return new Interval(value, interval.Unit);
        }

        public static Interval operator *(Interval interval, int multiplier)
        {
            return interval * multiplier;
        }

        public static Interval operator *(Interval interval, uint multiplier)
        {
            return interval * multiplier;
        }

        public static Interval operator *(Interval interval, decimal multiplier)
        {
            return interval * (double)multiplier;
        }

        public static Interval operator *(Interval interval, float multiplier)
        {
            return interval * multiplier;
        }

        public static Interval operator /(Interval interval, double multiplier)
        {
            if (multiplier == 0)
            {
                throw new ArithmeticException("Diversion value may not be 0!");
            }
            var value = interval.Value / multiplier;
            return new Interval(value, interval.Unit);
        }

        public static Interval operator /(Interval interval, int multiplier)
        {
            return interval / multiplier;
        }

        public static Interval operator /(Interval interval, uint multiplier)
        {
            return interval / multiplier;
        }

        public static Interval operator /(Interval interval, decimal multiplier)
        {
            return interval / (double)multiplier;
        }

        public static Interval operator /(Interval interval, float multiplier)
        {
            return interval / multiplier;
        }

        public static Interval operator ++(Interval interval)
        {
            var value = interval.Value + 1;
            return new Interval(value, interval.Unit);
        }

        public static Interval operator --(Interval interval)
        {
            var value = interval.Value - 1;
            return new Interval(value, interval.Unit);
        }

        public int CompareTo(Interval compareInterval)
        {
            return (int)compareInterval.InPicoSeconds - (int)InPicoSeconds;
        }

        public bool Contains(Interval interval)
        {
            return InPicoSeconds >= interval.InPicoSeconds;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Interval))
            {
                return false;
            }
            return CompareTo((Interval)obj) == 0;
        }

        public override int GetHashCode()
        {
            return (int)InPicoSeconds;
        }

        public override string ToString()
        {
            return InPicoSeconds.ToString();
        }
    }
}
