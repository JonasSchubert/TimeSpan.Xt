using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Weeks(this decimal value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this double value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this float value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this int value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this long value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this short value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this uint value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this ulong value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }

        public static TimeSpan Weeks(this ushort value)
        {
            return FluentTimeSpan.FromWeeks(value);
        }
    }
}
