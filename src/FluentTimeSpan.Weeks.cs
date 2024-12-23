﻿//-----------------------------------------------------------------------
// <copyright file="FluentTimeSpan.Weeks.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class of FluentTimeSpan, including methods for Week.
  /// </summary>
  public static partial class FluentTimeSpan
  {
    /// <summary>
    /// Represents ticks per week.
    /// </summary>
    public const long TicksPerWeek = 7 * TimeSpan.TicksPerDay;

    /// <summary>
    /// Converts a sbyte value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The sbyte weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(sbyte value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a byte value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The byte weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(byte value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a decimal value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The decimal weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(decimal value)
    {
      return new TimeSpan((long)(TicksPerWeek * value));
    }

    /// <summary>
    /// Converts a double value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The double weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(double value)
    {
      return new TimeSpan((long)(TicksPerWeek * value));
    }

    /// <summary>
    /// Converts a float value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The float weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(float value)
    {
      return new TimeSpan((long)(TicksPerWeek * value));
    }

    /// <summary>
    /// Converts a int value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The int weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(int value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a long value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The long weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(long value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a short value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The short weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(short value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a uint value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The uint weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(uint value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }

    /// <summary>
    /// Converts a ulong value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The ulong weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(ulong value)
    {
      return new TimeSpan((long)(TicksPerWeek * value));
    }

    /// <summary>
    /// Converts a ushort value representing weeks into a Timespan.
    /// </summary>
    /// <param name="value">The ushort weeks value.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan FromWeeks(ushort value)
    {
      return new TimeSpan(TicksPerWeek * value);
    }
  }
}
