using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class to add helper methods to number values, e.g. to return a Century TimeSpan value from a number
    /// </summary>
    public static partial class NumberExtensions
    {
        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The decimal decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this decimal value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The double decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this double value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The float decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this float value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The int decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this int value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The long decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this long value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The short decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this short value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The uint decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this uint value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The ulong decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this ulong value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

        /// <summary>
        /// Returns the TimeSpan value in decades for a value
        /// </summary>
        /// <param name="value">The ushort decades value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan Centuries(this ushort value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);
    }
}
