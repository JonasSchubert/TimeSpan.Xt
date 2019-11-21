using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerDecade = (long)(3652.5 * TimeSpan.TicksPerDay);

        public static TimeSpan FromDecades(decimal value) => new TimeSpan((long)(TicksPerDecade * value));

        public static TimeSpan FromDecades(double value) => new TimeSpan((long)(TicksPerDecade * value));

        public static TimeSpan FromDecades(float value) => new TimeSpan((long)(TicksPerDecade * value));

        public static TimeSpan FromDecades(int value) => new TimeSpan(TicksPerDecade * value);

        public static TimeSpan FromDecades(long value) => new TimeSpan(TicksPerDecade * value);

        public static TimeSpan FromDecades(short value) => new TimeSpan(TicksPerDecade * value);

        public static TimeSpan FromDecades(uint value) => new TimeSpan(TicksPerDecade * value);

        public static TimeSpan FromDecades(ulong value) => new TimeSpan((long)(TicksPerDecade * value));

        public static TimeSpan FromDecades(ushort value) => new TimeSpan(TicksPerDecade * value);
    }
}
