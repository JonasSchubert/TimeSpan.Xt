using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class to add helper methods to number values, e.g. to return a Second TimeSpan value from a number
    /// </summary>
    public static partial class NumberExtensions
    {
        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The decimal seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this decimal value) => TimeSpan.FromSeconds((double)value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The double seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this double value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The float seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this float value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The int seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this int value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The long seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this long value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The short seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this short value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The uint seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this uint value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The ulong seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this ulong value) => TimeSpan.FromSeconds(value);

        /// <summary>
        /// Returns the TimeSpan value in seconds for a value
        /// </summary>
        /// <param name="value">The ushort seconds value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Seconds(this ushort value) => TimeSpan.FromSeconds(value);
    }
}
