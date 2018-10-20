# TimeXt-C# - master branch

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
<a target="_blank" href="https://www.paypal.me/GuepardoApps" title="Donate using PayPal"><img src="https://img.shields.io/badge/paypal-donate-blue.svg" /></a>

[![Build](https://img.shields.io/badge/build-success-green.svg)](https://github.com/TimeXt/TimeXt-CSharp/blob/master/releases/0.1.0.181020/)
[![Version](https://img.shields.io/badge/version-v0.1.0.181020-blue.svg)](https://github.com/TimeXt/TimeXt-CSharp/tree/master/releases/0.1.0.181020/)

First of all many thanks to [Kizitonwose](https://github.com/kizitonwose/Time) for the original idea and already awesome library!

This library shall help to reduce code like

```C#
var dayInMillis = 24 * 60 * 60 * 1000;							// Represent a day in milliSeconds
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
var fiveMicroSeconds = 5.MicroSeconds();
var oneNanoSecond = 1.NanoSeconds();
var onePicoSecond = 1.PicoSeconds();

var oneDayInMillis = 1.Days().InMilliSeconds;    				// Converts one day into milliseconds
var twoWeeksInHours = 2.Weeks().InHours;  		    			// Converts two weeks into hours

var addition = 1.Days() + 12.Hours() + 30.Minutes();
var difference = 34.Minutes() - 240.Seconds();
var multiplication = 2.Weeks() * 2;
var division = 2500.PicoSeconds() / 500;

var isLessTrue = 1.Days() < 1.Weeks()           				// True
var isLessFalse = 24.Hours() < 360.Minutes()    				// False

var isBiggerTrue = 5.Minutes() > 30.Seconds()   				// True
var isBiggerFalse = 500.NanoSeconds() > 1.Minutes() 			// False

```

## Custom TimeXt-Unit

If you would like to have your own time unit, implement it as followed:

```C#
// amount of seconds in one year
public static Unit Year = new Unit(365 * 24 * 60 * 60);

// Add also the extensions:

public static dobule InYears(this Interval interval)
{
    return interval.Value * interval.Unit.ConversionRate / Year.ConversionRate;
}

public static Interval Years(this double value)
{
    return new Interval(value, Year);
}


// Use it like:
var threeYears = 3.Years();
var daysInYear = 365.Days().InYears;

```

## License

TimeXt-C# is distributed under the MIT license. [See LICENSE](https://github.com/TimeXt/TimeXt-CSharp/blob/master/LICENSE.md) for details.
