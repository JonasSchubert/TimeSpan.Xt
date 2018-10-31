using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Hours(this decimal value)
        {
            return TimeSpan.FromHours((double)value);
        }

        public static TimeSpan Hours(this double value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this float value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this int value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this long value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this short value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this uint value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this ulong value)
        {
            return TimeSpan.FromHours(value);
        }

        public static TimeSpan Hours(this ushort value)
        {
            return TimeSpan.FromHours(value);
        }
    }
}
