using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerWeek = 7 * TimeSpan.TicksPerDay;

        public static TimeSpan FromWeeks(decimal value)
        {
            var ticks = TicksPerWeek * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(double value)
        {
            var ticks = TicksPerWeek * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(float value)
        {
            var ticks = TicksPerWeek * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(int value)
        {
            var ticks = TicksPerWeek * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(long value)
        {
            var ticks = TicksPerWeek * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(short value)
        {
            var ticks = TicksPerWeek * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(uint value)
        {
            var ticks = TicksPerWeek * value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(ulong value)
        {
            var ticks = TicksPerWeek * (long)value;
            return new TimeSpan(ticks);
        }

        public static TimeSpan FromWeeks(ushort value)
        {
            var ticks = TicksPerWeek * value;
            return new TimeSpan(ticks);
        }
    }
}
