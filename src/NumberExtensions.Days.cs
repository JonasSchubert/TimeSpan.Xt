//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Days.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Day TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The sbyte days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this sbyte value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The byte days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this byte value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The decimal days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this decimal value) => TimeSpan.FromDays((double)value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The double days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this double value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The float days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this float value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The int days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this int value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The long days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this long value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The short days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this short value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The uint days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this uint value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The ulong days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this ulong value) => TimeSpan.FromDays(value);

    /// <summary>
    /// Returns the TimeSpan value in days for a value.
    /// </summary>
    /// <param name="value">The ushort days value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Days(this ushort value) => TimeSpan.FromDays(value);
  }
}
