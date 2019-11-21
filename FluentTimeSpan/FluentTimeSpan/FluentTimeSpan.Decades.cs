using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerDecadeAccumulated = 10 * TicksPerYearAccumulated;

        public const long TicksPerDecade = 10 * TicksPerYear;

        public static TimeSpan FromDecades(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

        public static TimeSpan FromDecades(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

        public static TimeSpan FromDecades(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

        public static TimeSpan FromDecades(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

        public static TimeSpan FromDecades(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

        public static TimeSpan FromDecades(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

        public static TimeSpan FromDecades(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

        public static TimeSpan FromDecades(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * (long)value);

        public static TimeSpan FromDecades(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);
    }
}
