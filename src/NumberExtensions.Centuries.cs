//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Centuries.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Century TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The sbyte centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this sbyte value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The byte centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this byte value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The decimal centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this decimal value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The double centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this double value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The float centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this float value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The int centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this int value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The long centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this long value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The short centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this short value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The uint centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this uint value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The ulong centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this ulong value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);

    /// <summary>
    /// Returns the TimeSpan value in centuries for a value.
    /// </summary>
    /// <param name="value">The ushort centuries value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Centuries(this ushort value, bool accumulated = false) => FluentTimeSpan.FromCenturies(value, accumulated);
  }
}
