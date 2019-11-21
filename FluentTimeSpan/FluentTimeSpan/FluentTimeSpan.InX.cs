using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public static double InCenturies(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerCenturyAccumulated : TicksPerCentury);

        public static double InDecades(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerDecadeAccumulated : TicksPerDecade);

        public static double InYears(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerYearAccumulated : TicksPerYear);

        public static double InWeeks(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TicksPerWeek;

        // Basically the same as TimeSpan.TotalDays
        public static double InDays(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerDay;

        // Basically the same as TimeSpan.TotalHours
        public static double InHours(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerHour;

        // Basically the same as TimeSpan.TotalMinutes
        public static double InMinutes(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerMinute;

        // Basically the same as TimeSpan.TotalSeconds
        public static double InSeconds(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerSecond;

        // Basically the same as TimeSpan.TotalMilliseconds
        public static double InMilliseconds(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerMillisecond;
    }
}
