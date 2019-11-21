using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public const long TicksPerCenturyAccumulated = 10 * TicksPerDecadeAccumulated;

        public const long TicksPerCentury = 10 * TicksPerDecade;

        public static TimeSpan FromCenturies(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        public static TimeSpan FromCenturies(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        public static TimeSpan FromCenturies(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        public static TimeSpan FromCenturies(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        public static TimeSpan FromCenturies(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        public static TimeSpan FromCenturies(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        public static TimeSpan FromCenturies(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        public static TimeSpan FromCenturies(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * (long)value);

        public static TimeSpan FromCenturies(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);
    }
}
