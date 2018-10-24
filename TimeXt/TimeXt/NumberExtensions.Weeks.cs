using System;

namespace TimeXt
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Weeks(this decimal value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this double value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this float value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this int value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this long value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this short value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this uint value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this ulong value)
        {
            return TimeSpanXt.FromWeeks(value);
        }

        public static TimeSpan Weeks(this ushort value)
        {
            return TimeSpanXt.FromWeeks(value);
        }
    }
}
