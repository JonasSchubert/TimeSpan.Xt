using System;

namespace FluentTimeSpan
{
    public static partial class NumberExtensions
    {
        public static TimeSpan Centuries(this decimal value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this double value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this float value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this int value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this long value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this short value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this uint value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this ulong value) => FluentTimeSpan.FromCenturies(value);

        public static TimeSpan Centuries(this ushort value) => FluentTimeSpan.FromCenturies(value);
    }
}
