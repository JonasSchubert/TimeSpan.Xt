using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class of FluentTimeSpan, including methods for Week
    /// </summary>
    public static partial class FluentTimeSpan
    {
        /// <summary>
        /// Represents ticks per week
        /// </summary>
        public const long TicksPerWeek = 7 * TimeSpan.TicksPerDay;

        /// <summary>
        /// Converts a decimal value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The decimal weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(decimal value) => new TimeSpan((long)(TicksPerWeek * value));

        /// <summary>
        /// Converts a double value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The double weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(double value) => new TimeSpan((long)(TicksPerWeek * value));

        /// <summary>
        /// Converts a float value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The float weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(float value) => new TimeSpan((long)(TicksPerWeek * value));

        /// <summary>
        /// Converts a int value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The int weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(int value) => new TimeSpan(TicksPerWeek * value);

        /// <summary>
        /// Converts a long value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The long weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(long value) => new TimeSpan(TicksPerWeek * value);

        /// <summary>
        /// Converts a short value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The short weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(short value) => new TimeSpan(TicksPerWeek * value);

        /// <summary>
        /// Converts a uint value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The uint weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(uint value) => new TimeSpan(TicksPerWeek * value);

        /// <summary>
        /// Converts a ulong value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The ulong weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(ulong value) => new TimeSpan((long)(TicksPerWeek * value));

        /// <summary>
        /// Converts a ushort value representing weeks into a Timespan
        /// </summary>
        /// <param name="value">The ushort weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromWeeks(ushort value) => new TimeSpan(TicksPerWeek * value);
    }
}
