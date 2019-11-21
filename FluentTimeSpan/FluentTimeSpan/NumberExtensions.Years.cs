using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Years(this decimal value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this double value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this float value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this int value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this long value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this short value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this uint value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this ulong value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);

        public static TimeSpan Years(this ushort value, bool accumulated = false) => FluentTimeSpan.FromYears(value, accumulated);
    }
}
