using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerYearAccumulated = (long)(365.25 * TimeSpan.TicksPerDay);

        public const long TicksPerYear = 365 * TimeSpan.TicksPerDay;

        public static TimeSpan FromYears(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

        public static TimeSpan FromYears(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

        public static TimeSpan FromYears(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

        public static TimeSpan FromYears(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

        public static TimeSpan FromYears(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

        public static TimeSpan FromYears(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

        public static TimeSpan FromYears(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

        public static TimeSpan FromYears(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * (long)value);

        public static TimeSpan FromYears(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);
    }
}
