using System;

namespace FluentTimeSpan
{
    public static partial class FluentTimeSpan
    {
        public static double InYears(this TimeSpan timeSpan)
        {
            return timeSpan.Ticks / TicksPerYear;
        }

        public static double InWeeks(this TimeSpan timeSpan)
        {
            return timeSpan.Ticks / TicksPerWeek;
        }

        // Basically the same as TimeSpan.TotalDays
        public static double InDays(this TimeSpan timeSpan)
        {
            return (double)timeSpan.Ticks / TimeSpan.TicksPerDay;
        }

        // Basically the same as TimeSpan.TotalHours
        public static double InHours(this TimeSpan timeSpan)
        {
            return (double)timeSpan.Ticks / TimeSpan.TicksPerHour;
        }

        // Basically the same as TimeSpan.TotalMinutes
        public static double InMinutes(this TimeSpan timeSpan)
        {
            return (double)timeSpan.Ticks / TimeSpan.TicksPerMinute;
        }

        // Basically the same as TimeSpan.TotalSeconds
        public static double InSeconds(this TimeSpan timeSpan)
        {
            return (double)timeSpan.Ticks / TimeSpan.TicksPerSecond;
        }

        // Basically the same as TimeSpan.TotalMilliseconds
        public static double InMilliseconds(this TimeSpan timeSpan)
        {
            return (double)timeSpan.Ticks / TimeSpan.TicksPerMillisecond;
        }
    }
}
