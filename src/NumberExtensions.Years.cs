//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Years.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Year TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The sbyte years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this sbyte value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The byte years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this byte value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The decimal years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this decimal value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The double years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this double value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The float years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this float value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The int years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this int value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The long years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this long value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The short years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this short value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The uint years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this uint value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The ulong years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this ulong value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in years for a value.
    /// </summary>
    /// <param name="value">The ushort years value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Years(this ushort value, bool accumulated = false)
    {
      return FluentTimeSpan.FromYears(value, accumulated);
    }
  }
}
