using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Centuries(this decimal value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this double value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this float value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this int value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this long value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this short value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this uint value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this ulong value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        public static TimeSpan Centuries(this ushort value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);
    }
}
