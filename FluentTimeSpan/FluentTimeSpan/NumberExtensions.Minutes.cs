using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Minutes(this decimal value) => TimeSpan.FromMinutes((double)value);

        public static TimeSpan Minutes(this double value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this float value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this int value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this long value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this short value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this uint value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this ulong value) => TimeSpan.FromMinutes(value);

        public static TimeSpan Minutes(this ushort value) => TimeSpan.FromMinutes(value);
    }
}
