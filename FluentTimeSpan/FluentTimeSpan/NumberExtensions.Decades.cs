using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Decades(this decimal value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this double value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this float value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this int value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this long value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this short value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this uint value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this ulong value) => FluentTimeSpan.FromDecades(value);

        public static TimeSpan Decades(this ushort value) => FluentTimeSpan.FromDecades(value);
    }
}
