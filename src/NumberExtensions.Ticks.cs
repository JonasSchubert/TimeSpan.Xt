//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Ticks.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a tick TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The sbyte ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this sbyte value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The byte ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this byte value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The decimal ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this decimal value)
    {
      return TimeSpan.FromTicks((long)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The double ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this double value)
    {
      return TimeSpan.FromTicks((long)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The float ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this float value)
    {
      return TimeSpan.FromTicks((long)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The int ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this int value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The long ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this long value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The short ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this short value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The uint ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this uint value)
    {
      return TimeSpan.FromTicks(value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The ulong ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this ulong value)
    {
      return TimeSpan.FromTicks((long)value);
    }

    /// <summary>
    /// Returns the TimeSpan value in ticks for a value.
    /// </summary>
    /// <param name="value">The ushort ticks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Ticks(this ushort value)
    {
      return TimeSpan.FromTicks(value);
    }
  }
}
