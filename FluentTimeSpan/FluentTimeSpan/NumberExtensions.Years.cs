using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Years(this decimal value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this double value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this float value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this int value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this long value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this short value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this uint value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this ulong value)
        {
            return FluentTimeSpan.FromYears(value);
        }

        public static TimeSpan Years(this ushort value)
        {
            return FluentTimeSpan.FromYears(value);
        }
    }
}
