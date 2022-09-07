# IlyfairyLib.WinApi

![Stars](https://img.shields.io/github/stars/ilyfairy/ilyfairylib.winapi)
[![NuGet](https://img.shields.io/nuget/v/IlyfairyLib.WinApi)](https://www.nuget.org/packages/IlyfairyLib.WinApi)

A library collection of all API method signatures on the Windows operating system. But this library has not been tested, please test it before putting it into use.

Win32 APIs for all Windows versions are welcome. Special Windows Store targeted assemblies omit p/invoke signatures to banned APIs so your Store apps can depend on these libraries without getting rejected by the Store certification process.  

## Usage
Go to [Nuget](https://www.nuget.org/packages/IlyfairyLib.WinApi) or enter the following command:  
```powershell
Install-Package IlyfairyLib.WinApi
```

## Distribution

Now all user32.dll exposed api is done  


Library      | All apis     | Done
-------------|------------------|-------------
[user32.dll](./dll/user32.md)|1006|758
kernelbase.dll|1904|80
