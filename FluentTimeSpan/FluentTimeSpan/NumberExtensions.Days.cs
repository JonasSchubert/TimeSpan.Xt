using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Days(this decimal value) => TimeSpan.FromDays((double)value);

        public static TimeSpan Days(this double value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this float value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this int value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this long value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this short value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this uint value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this ulong value) => TimeSpan.FromDays(value);

        public static TimeSpan Days(this ushort value) => TimeSpan.FromDays(value);
    }
}
