using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class to add helper methods to number values, e.g. to return a Week TimeSpan value from a number
    /// </summary>
    public static partial class NumberExtensions
    {
        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The decimal weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this decimal value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The double weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this double value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The float weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this float value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The int weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this int value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The long weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this long value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The short weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this short value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The uint weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this uint value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The ulong weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this ulong value) => FluentTimeSpan.FromWeeks(value);

        /// <summary>
        /// Returns the TimeSpan value in weeks for a value
        /// </summary>
        /// <param name="value">The ushort weeks value</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Weeks(this ushort value) => FluentTimeSpan.FromWeeks(value);
    }
}
