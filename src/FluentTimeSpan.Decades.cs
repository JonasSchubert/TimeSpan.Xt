//-----------------------------------------------------------------------
// <copyright file="FluentTimeSpan.Decades.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class of FluentTimeSpan, including methods for Decade (365.25 days per year).
  /// To add leap years into the calculation.
  /// </summary>
  public static partial class FluentTimeSpan
  {
    /// <summary>
    /// Represents accumulated ticks per decade.
    /// </summary>
    public const long TicksPerDecadeAccumulated = 10 * TicksPerYearAccumulated;

    /// <summary>
    /// Represents ticks per decade.
    /// </summary>
    public const long TicksPerDecade = 10 * TicksPerYear;

    /// <summary>
    /// Converts a sbyte value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The sbyte decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(sbyte value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a byte value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The byte decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(byte value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a decimal value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The decimal decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

    /// <summary>
    /// Converts a double value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The double decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

    /// <summary>
    /// Converts a float value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The float decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value));

    /// <summary>
    /// Converts a int value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The int decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a long value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The long decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a short value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The short decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a uint value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The uint decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);

    /// <summary>
    /// Converts a ulong value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The ulong decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * (long)value);

    /// <summary>
    /// Converts a ushort value representing decades into a Timespan.
    /// </summary>
    /// <param name="value">The ushort decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromDecades(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerDecadeAccumulated : TicksPerDecade) * value);
  }
}
