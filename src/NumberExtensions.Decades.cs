﻿//-----------------------------------------------------------------------
// <copyright file="NumberExtensions.Decades.cs" company="Jonas Schubert">
//     Copyright (c) Jonas Schubert. All rights reserved.
// </copyright>
// <author>Jonas Schubert</author>
//-----------------------------------------------------------------------

using System;

namespace TimeSpanXt
{
  /// <summary>
  /// The partial class to add helper methods to number values, e.g. to return a Decade TimeSpan value from a number.
  /// </summary>
  public static partial class NumberExtensions
  {
    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The sbyte decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this sbyte value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The byte decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this byte value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The decimal decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this decimal value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The double decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this double value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The float decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this float value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The int decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this int value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The long decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this long value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The short decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this short value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The uint decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this uint value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The ulong decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this ulong value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }

    /// <summary>
    /// Returns the TimeSpan value in decades for a value.
    /// </summary>
    /// <param name="value">The ushort decades value.</param>
    /// <param name="accumulated">If set to true, returns the accumulated value. Accumulated values include leap years.</param>
    /// <returns>The Timespan.</returns>
    public static TimeSpan Decades(this ushort value, bool accumulated = false)
    {
      return FluentTimeSpan.FromDecades(value, accumulated);
    }
  }
}
