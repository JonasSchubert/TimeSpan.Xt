# FluentTimeSpan - master branch

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Nuget](https://img.shields.io/badge/nuget-blue.svg)](https://www.nuget.org/packages/FluentTimeSpan/)

[![Build](https://img.shields.io/badge/build-success-green.svg)](https://github.com/TimeXt/FluentTimeSpan/blob/master/releases/0.3.0.181031/)
[![Version](https://img.shields.io/badge/version-v0.3.0.181031-blue.svg)](https://github.com/TimeXt/FluentTimeSpan/tree/master/releases/0.3.0.181031/)

First of all many thanks to [Kizitonwose](https://github.com/kizitonwose/Time) for the original idea and already awesome library!

This .NET Standard 2.0 library shall help to reduce code like

```C#
var dayInMillis = 24 * 60 * 60 * 1000;					// Represent a day in milliSeconds
var inFiveDays = DateTime.Now + TimeSpan.FromDays(5);
var oneWeekAgo = DateTime.Now - TimeSpan.FromDays(7);
```

## How to use

```C#
using FluentTimeSpan;

var oneWeek = 1.Weeks();
var threeDays = 3.Days();
var elevenHours = 11.Hours();
var sixMinutes = 6.Minutes();
var fiftySeconds = 50.Seconds();
var hundredMilliSeconds = 100.MilliSeconds();

var oneDayInMillis = 1.Days().InMilliseconds();    		// Converts one day into milliseconds and returns the double value
var twoWeeksInHours = 2.Weeks().InHours(); 		    	// Converts two weeks into hours and returns the double value

var addition = 1.Days() + 12.Hours() + 30.Minutes();
var difference = 34.Minutes() - 240.Seconds();
var multiplication = 2.Weeks() * 2;
var division = 2.Minutes() / 2;

var inFiveDays = DateTime.Now + 5.Days();
var yesterday = DateTime.Now - 24.Hours();
var oneWeekAgo = DateTime.Now - 1.Weeks();

```

## Requirements

- .NET Standard 2.0

## License

FluentTimeSpan-C# is distributed under the MIT license. [See LICENSE](https://github.com/TimeXt/FluentTimeSpan/blob/master/LICENSE.md) for details.
