<h1 align="center">
	<img width="90" src="logo.png" alt="timext">
</h1>

<p align="center"><h1 style="text-align: center;">FluentTimeSpan</h1></p>

<p align="center">
  <a href="https://www.nuget.org/packages/FluentTimeSpan/"><img src="https://img.shields.io/badge/nuget-0.6.0-blue.svg"/></a>
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-blue.svg"/></a>
  <a href="http://makeapullrequest.com"><img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg"/></a>
  <a href="https://github.com/TimeXt/FluentTimeSpan/"><img src="https://img.shields.io/github/stars/TimeXt/FluentTimeSpan.svg"/></a>
</p>

<p align="center"><h6 style="text-align: center;">Support me</h6></p>

<p align="center">
  <a href="https://www.paypal.me/GuepardoApps"><img src="https://img.shields.io/badge/paypal-support-blue.svg"/></a>
</p>

First of all many thanks to [Kizitonwose](https://github.com/kizitonwose/Time) for the original idea and already awesome library!

This .NET Standard 2.0 library shall help to reduce code like

```C#
var dayInMillis = 24 * 60 * 60 * 1000;				// Represent a day in milliseconds
var inFiveDays = DateTime.Now + TimeSpan.FromDays(5);
var oneWeekAgo = DateTime.Now - TimeSpan.FromDays(7);
```

## How to use

```C#
using FluentTimeSpan;

var fiveCenturies = 5.Centuries();				// uses precise calculation: 		1 Century == 36500 days
var fiveCenturiesAccumulated = 5.Centuries(true);		// uses accumulated calculation: 	1 Century == 36525 days
var tenDecades = 10.0.Decades();				// uses precise calculation: 		1 Decade == 3650 days
var tenDecadesAccumulated = 10.0.Decades(true);			// uses accumulated calculation: 	1 Decade == 3652.5 days
var twoYears = 2.Years();					// uses precise calculation: 		1 Year == 365 days
var twoYearsAccumulated = 2.Years(true);		        // uses accumulated calculation: 	1 Year == 365.25 days
var oneWeek = 1.Weeks();
var threeDays = 3.Days();
var elevenHours = 11.Hours();
var sixMinutes = 6.Minutes();
var fiftySeconds = 50.Seconds();
var hundredMilliSeconds = 100.Milliseconds();

var oneDayInMillis = 1.Days().InMilliseconds();    		// Converts one day into milliseconds and returns the double value => 86400000
var twoWeeksInHours = 2.Weeks().InHours(); 		    	// Converts two weeks into hours and returns the double value => 336
var thirtyFiveDaysInWeeks = 35.Days().InWeeks(); 		// Converts 35 days into weeks and returns the double value => 5

var addition = 1.Days() + 12.Hours() + 30.Minutes();
var difference = 34.Minutes() - 240.Seconds();
var multiplication = 2.Weeks() * 2;
var division = 2.Minutes() / 2;

var inFiveDays = DateTime.Now + 5.Days();
var yesterday = DateTime.Now - 24.Hours();
var oneWeekAgo = DateTime.Now - 1.Weeks();
```

Since FluentTimeSpan is directly interchangable with TimeSpan, it can be used in all places where you would normally use TimeSpan, e.g.

```C#
Task.Delay(5.Seconds())
```

## Contributors

| [<img alt="JonasSchubert" src="https://avatars0.githubusercontent.com/u/21952813?v=4&s=117" width="117"/>](https://github.com/JonasSchubert) | [<img alt="DenisBiondic" src="https://avatars1.githubusercontent.com/u/3341262?v=4&s=117" width="117"/>](https://github.com/DenisBiondic) 
| :---------------------------------------------------------------------------------------------------------------------------------------: | :---------------------------------------------------------------------------------------------------------------------------------------: |
| [Jonas Schubert](https://github.com/JonasSchubert) | [Denis Biondic](https://github.com/DenisBiondic) |

## License

FluentTimeSpan is distributed under the MIT license. [See LICENSE](LICENSE.md) for details.

```
MIT License

Copyright (c) 2018-2021 JonasSchubert

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
