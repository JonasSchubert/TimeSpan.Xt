//-----------------------------------------------------------------------
// <copyright file="FluentTimeSpan.InX.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class of FluentTimeSpan, including methods for conversion to time units.
  /// </summary>
  public static partial class FluentTimeSpan
  {
    /// <summary>
    /// Converts a Timespan into a century value.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>A double value displaying the centuries a Timespan would represent.</returns>
    public static double InCenturies(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerCenturyAccumulated : TicksPerCentury);

    /// <summary>
    /// Converts a Timespan into a decade value.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>A double value displaying the decades a Timespan would represent.</returns>
    public static double InDecades(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerDecadeAccumulated : TicksPerDecade);

    /// <summary>
    /// Converts a Timespan into a year value.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>A double value displaying the years a Timespan would represent.</returns>
    public static double InYears(this TimeSpan timeSpan, bool accumulated = false) => (double)timeSpan.Ticks / (accumulated ? TicksPerYearAccumulated : TicksPerYear);

    /// <summary>
    /// Converts a Timespan into a week value.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the weeks a Timespan would represent.</returns>
    public static double InWeeks(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TicksPerWeek;

    /// <summary>
    /// Converts a Timespan into a day value.
    /// Basically the same as TimeSpan.TotalDays.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the days a Timespan would represent.</returns>
    public static double InDays(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerDay;

    /// <summary>
    /// Converts a Timespan into a hour value.
    /// Basically the same as TimeSpan.TotalHours.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the hours a Timespan would represent.</returns>
    public static double InHours(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerHour;

    /// <summary>
    /// Converts a Timespan into a minute value.
    /// Basically the same as TimeSpan.TotalMinutes.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the minutes a Timespan would represent.</returns>
    public static double InMinutes(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerMinute;

    /// <summary>
    /// Converts a Timespan into a second value.
    /// Basically the same as TimeSpan.TotalSeconds.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the seconds a Timespan would represent.</returns>
    public static double InSeconds(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerSecond;

    /// <summary>
    /// Converts a Timespan into a second value.
    /// Basically the same as TimeSpan.TotalMilliseconds.
    /// </summary>
    /// <param name="timeSpan">The timespan value.</param>
    /// <returns>A double value displaying the milliseconds a Timespan would represent.</returns>
    public static double InMilliseconds(this TimeSpan timeSpan) => (double)timeSpan.Ticks / TimeSpan.TicksPerMillisecond;
  }
}
