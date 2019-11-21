using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Hours(this decimal value) => TimeSpan.FromHours((double)value);

        public static TimeSpan Hours(this double value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this float value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this int value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this long value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this short value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this uint value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this ulong value) => TimeSpan.FromHours(value);

        public static TimeSpan Hours(this ushort value) => TimeSpan.FromHours(value);
    }
}
