using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Years(this decimal value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this double value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this float value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this int value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this long value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this short value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this uint value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this ulong value) => FluentTimeSpan.FromYears(value);

        public static TimeSpan Years(this ushort value) => FluentTimeSpan.FromYears(value);
    }
}
