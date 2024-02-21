//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Milliseconds.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Millisecond TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The sbyte milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this sbyte value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The byte milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this byte value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The decimal milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this decimal value) => TimeSpan.FromMilliseconds((double)value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The double milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this double value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The float milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this float value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The int milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this int value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The long milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this long value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The short milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this short value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The uint milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this uint value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The ulong milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this ulong value) => TimeSpan.FromMilliseconds(value);

    /// <summary>
    /// Returns the TimeSpan value in milliseconds for a value.
    /// </summary>
    /// <param name="value">The ushort milliseconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Milliseconds(this ushort value) => TimeSpan.FromMilliseconds(value);
  }
}
