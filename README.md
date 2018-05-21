# Aspose.CAD Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.CAD-Cloud.svg)](https://www.nuget.org/packages/Aspose.CAD-Cloud/)
This repository contains Aspose.CAD Cloud SDK for .NET source code. This SDK allows you to work with Aspose.CAD Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

# Key Features
- Conversions: High quality conversions to:
  * Pdf
  * Bmp
  * Gif
  * Jpeg
  * Jpeg2000
  * Png
  * Wmf
  * Tiff
  * Psd
- Document Object Model: Programmatic access through a rich API to all drawing elements allows to do various operations on drawing content:
  * modify
  * extract
  * copy
  * split
  * join 
  * replace

See [API Reference](https://apireference.aspose.cloud/CAD/) for full API specification.

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.CAD-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/display/CADcloud/Available+SDKs#AvailableSDKs-.NET).

### Prerequisites

To use Aspose CAD for Cloud .NET SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

### Installation

#### Install Aspose.CAD-Cloud via NuGet

From the command line:

	nuget install Aspose.CAD-Cloud

From Package Manager:

	PM> Install-Package Aspose.CAD-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.CAD-Cloud".
5. Click on the Aspose.CAD-Cloud package, select the appropriate version in the right-tab and click *Install*.

### Sample usage

The examples below show how your application have to initiate and convert "dwg" file to "pdf" using Aspose.CAD-Cloud library:
```csharp
var saveAsApi = new SaveAsApi(AppKey, AppSid);
var request = new SaveAsGetImageSaveAsRequest("fileStoredInCloud.dwg", "pdf");
saveAsApi.SaveAsGetImageSaveAs(request);
```

[Tests](Aspose.CAD.Cloud.Sdk.Tests) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Comparison with Old generation SDK
New SDK has the following advantages over the [previous version](https://github.com/aspose-CAD/Aspose.CAD-for-Cloud):
+ SDK is fully in sync with the API, all missing methods are added
+ Classes, methods and properties have comments and are IDE-friendly
+ Better security
+ Usage of Request/Response classes to represent long lists of parameters. This allows for cleaner code and easier backwards-compatibility going forward

New SDK is not backwards compatible with previous generation because of the last item. It should be straightforward to convert your code to using Request/Response objects, if you need any help on migration please ask at [Free Support Forums](https://forum.aspose.cloud/c/CAD).

## Contact Us
Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/CAD).
