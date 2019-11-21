using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerCentury = 36525 * TimeSpan.TicksPerDay;

        public static TimeSpan FromCenturies(decimal value) => new TimeSpan((long)(TicksPerCentury * value));

        public static TimeSpan FromCenturies(double value) => new TimeSpan((long)(TicksPerCentury * value));

        public static TimeSpan FromCenturies(float value) => new TimeSpan((long)(TicksPerCentury * value));

        public static TimeSpan FromCenturies(int value) => new TimeSpan(TicksPerCentury * value);

        public static TimeSpan FromCenturies(long value) => new TimeSpan(TicksPerCentury * value);

        public static TimeSpan FromCenturies(short value) => new TimeSpan(TicksPerCentury * value);

        public static TimeSpan FromCenturies(uint value) => new TimeSpan(TicksPerCentury * value);

        public static TimeSpan FromCenturies(ulong value) => new TimeSpan((long)(TicksPerCentury * value));

        public static TimeSpan FromCenturies(ushort value) => new TimeSpan(TicksPerCentury * value);
    }
}
