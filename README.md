# FluentTimeSpan

[![Nuget](https://img.shields.io/badge/nuget-blue.svg)](https://www.nuget.org/packages/FluentTimeSpan/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](http://makeapullrequest.com)

[![CI Status](https://cpgithub.visualstudio.com/GitHubPipelines/_apis/build/status/conplementAG.FluentTimeSpan)](https://cpgithub.visualstudio.com/GitHubPipelines/_build/latest?definitionId=5)
[![Build](https://img.shields.io/badge/build-success-green.svg)](releases/0.4.0.190515/)
[![Version](https://img.shields.io/badge/version-v0.4.0.190515-blue.svg)](https://github.com/conplementAG/FluentTimeSpan/releases/tag/0.4.0)

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

var twoYears = 2.Years();
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

Copyright (c) 2018-2019 conplementAG

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
