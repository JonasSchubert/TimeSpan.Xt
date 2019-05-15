using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerYear = 365 * TimeSpan.TicksPerDay;

        public static TimeSpan FromYears(decimal value)
        {
            var ticks = TicksPerYear * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(double value)
        {
            var ticks = TicksPerYear * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(float value)
        {
            var ticks = TicksPerYear * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(int value)
        {
            var ticks = TicksPerYear * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(long value)
        {
            var ticks = TicksPerYear * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(short value)
        {
            var ticks = TicksPerYear * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(uint value)
        {
            var ticks = TicksPerYear * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(ulong value)
        {
            var ticks = TicksPerYear * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromYears(ushort value)
        {
            var ticks = TicksPerYear * value;
            return new TimeSpan(ticks);
        }
    }
}
