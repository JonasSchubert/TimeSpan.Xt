using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class to add helper methods to number values, e.g. to return a Minute TimeSpan value from a number
    /// </summary>
    public static partial class NumberExtensions
    {
        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The decimal minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this decimal value) => TimeSpan.FromMinutes((double)value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The double minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this double value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The float minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this float value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The int minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this int value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The long minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this long value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The short minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this short value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The uint minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this uint value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The ulong minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this ulong value) => TimeSpan.FromMinutes(value);

        /// <summary>
        /// Returns the TimeSpan value in minutes for a value
        /// </summary>
        /// <param name="value">The ushort minutes value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Minutes(this ushort value) => TimeSpan.FromMinutes(value);
    }
}
