using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Seconds(this decimal value) => TimeSpan.FromSeconds((double)value);

        public static TimeSpan Seconds(this double value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this float value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this int value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this long value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this short value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this uint value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this ulong value) => TimeSpan.FromSeconds(value);

        public static TimeSpan Seconds(this ushort value) => TimeSpan.FromSeconds(value);
    }
}
