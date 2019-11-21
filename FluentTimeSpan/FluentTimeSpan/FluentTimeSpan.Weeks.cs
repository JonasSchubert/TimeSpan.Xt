using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerWeek = 7 * TimeSpan.TicksPerDay;

        public static TimeSpan FromWeeks(decimal value) => new TimeSpan((long)(TicksPerWeek * value));

        public static TimeSpan FromWeeks(double value) => new TimeSpan((long)(TicksPerWeek * value));

        public static TimeSpan FromWeeks(float value) => new TimeSpan((long)(TicksPerWeek * value));

        public static TimeSpan FromWeeks(int value) => new TimeSpan(TicksPerWeek * value);

        public static TimeSpan FromWeeks(long value) => new TimeSpan(TicksPerWeek * value);

        public static TimeSpan FromWeeks(short value) => new TimeSpan(TicksPerWeek * value);

        public static TimeSpan FromWeeks(uint value) => new TimeSpan(TicksPerWeek * value);

        public static TimeSpan FromWeeks(ulong value) => new TimeSpan((long)(TicksPerWeek * value));

        public static TimeSpan FromWeeks(ushort value) => new TimeSpan(TicksPerWeek * value);
    }
}
