using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Milliseconds(this decimal value) => TimeSpan.FromMilliseconds((double)value);

        public static TimeSpan Milliseconds(this double value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this float value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this int value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this long value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this short value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this uint value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this ulong value) => TimeSpan.FromMilliseconds(value);

        public static TimeSpan Milliseconds(this ushort value) => TimeSpan.FromMilliseconds(value);
    }
}
