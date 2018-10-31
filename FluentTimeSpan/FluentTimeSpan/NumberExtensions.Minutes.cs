using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Minutes(this decimal value)
        {
            return TimeSpan.FromMinutes((double)value);
        }

        public static TimeSpan Minutes(this double value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this float value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this int value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this long value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this short value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this uint value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this ulong value)
        {
            return TimeSpan.FromMinutes(value);
        }

        public static TimeSpan Minutes(this ushort value)
        {
            return TimeSpan.FromMinutes(value);
        }
    }
}
