using System;

namespace FluentTimeSpan
{
    /// <summary>
    /// The partial class of FluentTimeSpan, including methods for Century (365.25 days per year)
    /// To add leap years into the calculation
    /// </summary>
    public static partial class FluentTimeSpan
    {
        /// <summary>
        /// Represents accumulated ticks per century
        /// </summary>
        public const long TicksPerCenturyAccumulated = 10 * TicksPerDecadeAccumulated;

        /// <summary>
        /// Represents ticks per century
        /// </summary>
        public const long TicksPerCentury = 10 * TicksPerDecade;

        /// <summary>
        /// Converts a decimal value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The decimal centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        /// <summary>
        /// Converts a double value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The double centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        /// <summary>
        /// Converts a float value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The float centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value));

        /// <summary>
        /// Converts a int value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The int centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        /// <summary>
        /// Converts a long value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The long centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        /// <summary>
        /// Converts a short value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The short centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        /// <summary>
        /// Converts a uint value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The uint centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);

        /// <summary>
        /// Converts a ulong value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The ulong centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * (long)value);

        /// <summary>
        /// Converts a ushort value representing centuries into a Timespan
        /// </summary>
        /// <param name="value">The ushort centuries value</param>
        /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years</param>
        /// <returns>The Timespan</returns>
        public static TimeSpan FromCenturies(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerCenturyAccumulated : TicksPerCentury) * value);
    }
}
