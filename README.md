# TimeXt-C# - develop branch

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Nuget](https://img.shields.io/badge/nuget-blue.svg)](https://www.nuget.org/packages/TimeXt/)

[![Build](https://img.shields.io/badge/build-success-green.svg)](https://github.com/TimeXt/TimeXt-CSharp/blob/develop/releases/0.2.0.1.181024/)
[![Version](https://img.shields.io/badge/version-v0.2.0.1.181024-blue.svg)](https://github.com/TimeXt/TimeXt-CSharp/tree/develop/releases/0.2.0.1.181024/)

[![PayPal](https://img.shields.io/badge/paypal-donate-blue.svg)](https://www.paypal.me/GuepardoApps/)

First of all many thanks to [Kizitonwose](https://github.com/kizitonwose/Time) for the original idea and already awesome library!

This .NET Core 2.1 library shall help to reduce code like

```C#
var dayInMillis = 24 * 60 * 60 * 1000;					// Represent a day in milliSeconds
var inFiveDays = DateTime.Now + TimeSpan.FromDays(5);
```

## How to use

```C#
using TimeXt;

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

```

## Requirements

- .NET Core 2.1

## License

TimeXt-C# is distributed under the MIT license. [See LICENSE](https://github.com/TimeXt/TimeXt-CSharp/blob/develop/LICENSE.md) for details.
