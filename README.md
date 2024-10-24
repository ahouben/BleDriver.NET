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
* Then "Run Tests", "Debug Tests" or "Run Tests with Coverage"
* "Show Output" shows the console logs during test case execution

Result:
```
Passed!  - Failed:     0, Passed:     4, Skipped:     0, Total:     4, Duration: 25 s - BgApiDriver.Tests.dll (net8.0)
```

### Other bindings and GitHub projects

* https://github.com/petermoz/blepy: python
* https://github.com/jrowberg/bglib: C#, python, C++
* https://github.com/xloem/bglibpp: C++
* https://github.com/mjbrown/bgapi: python

More at https://github.com/search?q=bluegiga+OR+BLED112&type=repositories