using System;

namespace TimeXt
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Milliseconds(this decimal value)
        {
            return TimeSpan.FromMilliseconds((double)value);
        }

        public static TimeSpan Milliseconds(this double value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this float value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this int value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this long value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this short value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this uint value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this ulong value)
        {
            return TimeSpan.FromMilliseconds(value);
        }

        public static TimeSpan Milliseconds(this ushort value)
        {
            return TimeSpan.FromMilliseconds(value);
        }
    }
}
