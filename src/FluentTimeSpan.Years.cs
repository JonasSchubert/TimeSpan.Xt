//-----------------------------------------------------------------------
// <copyright file="FluentTimeSpan.Years.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class of FluentTimeSpan, including methods for Year.
  /// </summary>
  public static partial class FluentTimeSpan
  {
    /// <summary>
    /// Represents accumulated ticks per year (365.25 days per year).
    /// To add leap years into the calculation.
    /// </summary>
    public const long TicksPerYearAccumulated = (long)(365.25 * TimeSpan.TicksPerDay);

    /// <summary>
    /// Represents ticks per year.
    /// </summary>
    public const long TicksPerYear = 365 * TimeSpan.TicksPerDay;

    /// <summary>
    /// Converts a sbyte value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The sbyte years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(sbyte value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a byte value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The byte years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(byte value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a decimal value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The decimal years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(decimal value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

    /// <summary>
    /// Converts a double value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The double years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(double value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

    /// <summary>
    /// Converts a float value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The float years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(float value, bool accumulated = false) => new TimeSpan((long)((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value));

    /// <summary>
    /// Converts a int value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The int years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(int value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a long value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The long years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(long value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a short value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The short years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(short value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a uint value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The uint years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(uint value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);

    /// <summary>
    /// Converts a ulong value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The ulong years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(ulong value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * (long)value);

    /// <summary>
    /// Converts a ushort value representing years into a Timespan.
    /// </summary>
    /// <param name="value">The ushort years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromYears(ushort value, bool accumulated = false) => new TimeSpan((accumulated ? TicksPerYearAccumulated : TicksPerYear) * value);
  }
}
