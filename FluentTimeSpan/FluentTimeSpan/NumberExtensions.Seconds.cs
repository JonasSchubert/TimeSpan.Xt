using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Seconds(this decimal value)
        {
            return TimeSpan.FromSeconds((double)value);
        }

        public static TimeSpan Seconds(this double value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this float value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this int value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this long value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this short value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this uint value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this ulong value)
        {
            return TimeSpan.FromSeconds(value);
        }

        public static TimeSpan Seconds(this ushort value)
        {
            return TimeSpan.FromSeconds(value);
        }
    }
}
