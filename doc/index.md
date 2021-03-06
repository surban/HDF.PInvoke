# HDF.PInvoke.NETStandard

[![Build Status](https://travis-ci.org/surban/HDF.PInvoke.svg?branch=master)](https://travis-ci.org/surban/HDF.PInvoke)
[![Build status](https://ci.appveyor.com/api/projects/status/k9f3fqys0hwdvxnu?svg=true)](https://ci.appveyor.com/project/surban/hdf-pinvoke)

## .NET Standard 2.0 port

This is an unofficial port of [HDF.PInvoke from the HDF group](https://github.com/HDFGroup/HDF.PInvoke) to .NET Standard 2.0 by [Sebastian Urban](mailto:surban@surban.net).
It has been tested on Linux, MacOS and Microsoft Windows.

The source code is available at <https://github.com/surban/HDF.PInvoke>.
Please use this GitHub repository to report issues and send pull requests.

## What it is (not)

HDF.PInvoke is a collection of [PInvoke](https://en.wikipedia.org/wiki/Platform_Invocation_Services)
signatures for the [HDF5 C-API](https://www.hdfgroup.org/HDF5/doc/RM/RM_H5Front.html).
It's practically *code-free*, which means we can blame all the bugs on Microsoft or [The HDF Group](https://www.hdfgroup.org/).

It is **not** a high-level .NET interface for HDF5. "It's the [GCD](https://en.wikipedia.org/wiki/Greatest_common_divisor)
of .NET bindings for HDF5, not the [LCM](https://en.wikipedia.org/wiki/Least_common_multiple)." 

## Supported platforms

This package supports and has been tested on 64-bit versions of Linux, MacOS and Microsoft Windows.

## Multithreaded operation

All HDF5 operations in this library are thread-safe as described in the [official document](https://support.hdfgroup.org/HDF5/faq/threadsafe.html), i.e. HDF5 operations from multiple threads are automatically serialized.

## API documentation

A [full API reference](api/HDF.PInvoke.html) of the .NET interface is provided.
See the official [HDF5 support page](https://portal.hdfgroup.org/display/HDF5/HDF5) for a usage guide.

## Installation

To install the latest HDF.PInvoke 1.10 for .NET core, run the following command inside your project directory.

```
dotnet add package HDF.PInvoke.NETStandard
```

You can also grab the NuGet package from <https://www.nuget.org/packages/HDF.PInvoke.NETStandard>.

## Native dependencies

The HDF5 native libraries for all supported platforms are included in the NuGet package.
For Windows, you additionally require the Visual C++ runtime, which is available from Microsoft as [Visual C++ Redistributable Packages for Visual Studio 2017](https://support.microsoft.com/en-us/help/2977003/the-latest-supported-visual-c-downloads).

## License

HDF.PInvoke is part of [HDF5](https://www.hdfgroup.org/HDF5/). 
It is subject to the *same* terms and conditions as HDF5. 
Please review <https://support.hdfgroup.org/ftp/HDF5/releases/COPYING> for the details. If you have any questions, please [contact the HDF group](http://www.hdfgroup.org/about/contact.html).

## Supporting HDF.PInvoke

The best way to support HDF.PInvoke is to contribute to it either by reporting bugs, writing documentation (e.g., the [cookbook](https://github.com/HDFGroup/HDF.PInvoke/wiki/Cookbook)), or sending pull requests.

***
