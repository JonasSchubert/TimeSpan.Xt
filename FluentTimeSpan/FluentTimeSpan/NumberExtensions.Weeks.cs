using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Weeks(this decimal value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this double value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this float value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this int value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this long value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this short value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this uint value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this ulong value) => FluentTimeSpan.FromWeeks(value);

        public static TimeSpan Weeks(this ushort value) => FluentTimeSpan.FromWeeks(value);
    }
}
