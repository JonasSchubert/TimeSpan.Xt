//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Seconds.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Second TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The sbyte seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this sbyte value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The byte seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this byte value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The decimal seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this decimal value)
    {
      return TimeSpan.FromSeconds((double)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The double seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this double value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The float seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this float value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The int seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this int value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The long seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this long value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The short seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this short value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The uint seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this uint value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The ulong seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this ulong value)
    {
      return TimeSpan.FromSeconds(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in seconds for a value.
    /// </summary>
    /// <param name="value">The ushort seconds value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Seconds(this ushort value)
    {
      return TimeSpan.FromSeconds(value);
    }
  }
}
