using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Decades(this decimal value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this double value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this float value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this int value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this long value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this short value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this uint value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this ulong value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);

        public static TimeSpan Decades(this ushort value, bool accumulated = false) => FluentTimeSpan.FromDecades(value, accumulated);
    }
}
