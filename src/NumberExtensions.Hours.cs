//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Hours.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Hour TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The sbyte hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this sbyte value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The byte hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this byte value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The decimal hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this decimal value)
    {
      return TimeSpan.FromHours((double)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The double hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this double value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The float hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this float value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The int hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this int value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The long hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this long value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The short hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this short value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The uint hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this uint value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The ulong hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this ulong value)
    {
      return TimeSpan.FromHours(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in hours for a value.
    /// </summary>
    /// <param name="value">The ushort hours value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Hours(this ushort value)
    {
      return TimeSpan.FromHours(value);
    }
  }
}
