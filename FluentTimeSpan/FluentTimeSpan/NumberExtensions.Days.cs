using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Days(this decimal value)
        {
            return TimeSpan.FromDays((double)value);
        }

        public static TimeSpan Days(this double value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this float value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this int value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this long value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this short value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this uint value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this ulong value)
        {
            return TimeSpan.FromDays(value);
        }

        public static TimeSpan Days(this ushort value)
        {
            return TimeSpan.FromDays(value);
        }
    }
}
