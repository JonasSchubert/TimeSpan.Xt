//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Minutes.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Minute TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The sbyte minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this sbyte value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The byte minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this byte value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The decimal minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this decimal value)
    {
      return TimeSpan.FromMinutes((double)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The double minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this double value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The float minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this float value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The int minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this int value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The long minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this long value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The short minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this short value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The uint minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this uint value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The ulong minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this ulong value)
    {
      return TimeSpan.FromMinutes(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in minutes for a value.
    /// </summary>
    /// <param name="value">The ushort minutes value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Minutes(this ushort value)
    {
      return TimeSpan.FromMinutes(value);
    }
  }
}
