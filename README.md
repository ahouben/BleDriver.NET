
[![Build Status](https://travis-ci.org/ahouben/BleDriver.NET.svg?branch=master)](https://travis-ci.org/ahouben/BleDriver.NET)

[![Build status](https://ci.appveyor.com/api/projects/status/299v7rc0micdmxnc?svg=true)](https://ci.appveyor.com/project/ahouben/bledriver-net)

[![master version](http://img.shields.io/myget/bledriver-feed/v/BgApiDriver.svg?style=flat)](https://www.myget.org/feed/Packages/bledriver-feed)

## BleDriver.NET

C# bindings for Bluegiga BLED112 or BLE112 Bluetooth Low Energy USB Dongle.

This project generates C# api bindings for the Bluegiga BLED112 by parsing the bleapi XML specification file. The user is required to have the Bluegiga Bluetooth Smart SDK (available from http://techforum.bluegiga.com/BLED112). This project is not associated with Bluegiga.

### Visual Studio Code configuration

* Install the following extensions:
  * C# Dev Kit, to run the unit tests
  * Python, to generate new API classes when a new API .xml is available from Bluegiga

### Generating the API

Steps:
* Open Visual Studio Code in the root of the repository
* Open the Run & Debug window
* Run "Python Debugger: Generate BG API", this will update the generated C# class `./src/BgApi.g.cs`

### Running Unit Tests

Steps:
* Plug in your BLED112 dongle into a free USB socket
* Update the COM port in `CommandTests.cs` according to your Device Manager, there should be a "Bluegiga Bluetooth Low Energy (COMx)" entry, e.g. COM9

from the command line:
* `cd ./tests`
* `dotnet test`

from Visual Studio Code:
* Open the Test Explorer window using Ctrl+Shift+P and select "Testing: Focus on Test Explorer View"
* Then "Run All"

Result:
```
Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 25 s - BgApiDriver.Tests.dll (net8.0)
```

### Other bindings

For python bindings see https://github.com/petermoz/blepy.