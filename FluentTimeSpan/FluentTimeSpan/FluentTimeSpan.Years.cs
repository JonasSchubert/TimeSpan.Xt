using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerYear = (long)(365.25 * TimeSpan.TicksPerDay);

        public static TimeSpan FromYears(decimal value) => new TimeSpan((long)(TicksPerYear * value));

        public static TimeSpan FromYears(double value) => new TimeSpan((long)(TicksPerYear * value));

        public static TimeSpan FromYears(float value) => new TimeSpan((long)(TicksPerYear * value));

        public static TimeSpan FromYears(int value) => new TimeSpan(TicksPerYear * value);

        public static TimeSpan FromYears(long value) => new TimeSpan(TicksPerYear * value);

        public static TimeSpan FromYears(short value) => new TimeSpan(TicksPerYear * value);

        public static TimeSpan FromYears(uint value) => new TimeSpan(TicksPerYear * value);

        public static TimeSpan FromYears(ulong value) => new TimeSpan((long)(TicksPerYear * value));

        public static TimeSpan FromYears(ushort value) => new TimeSpan(TicksPerYear * value);
    }
}
