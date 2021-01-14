![](https://img.shields.io/badge/api-v3.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/Aspose.cad-Cloud) ![Nuget](https://img.shields.io/nuget/dt/Aspose.cad-Cloud) [![GitHub license](https://img.shields.io/github/license/aspose-cad-cloud/aspose-cad-cloud-dotnet)](https://github.com/aspose-cad-cloud/aspose-cad-cloud-dotnet/blob/master/LICENSE) ![GitHub last commit](https://img.shields.io/github/last-commit/Aspose-cad-Cloud/aspose-cad-cloud-dotnet)
# AutoCAD File Processing .NET Cloud REST API
[Aspose.CAD Cloud](https://products.aspose.cloud/cad) is a true [REST API](https://apireference.aspose.cloud/cad/) that enables you to perform a wide range of CAD and BIM drawings processing operations including manipulation, export and conversion in a cloud, with zero initial costs.

This repository contains [Aspose.CAD Cloud .NET SDK](https://products.aspose.cloud/cad/net) source code which is written in C#. This SDK allows you to work with Aspose.CAD Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost and gain all benefits of strong types and IDE highlights.

## CAD Processing Features
- Export CAD drawings to other file formats.
- Get image properties of a CAD drawing.
- Change the scale of an AutoCAD sketch.
- Flip and rotate a CAD image.
- Upload or download CAD drawings to the cloud storage.
- Copy, move, delete CAD files from the cloud storage.

## Read & Write CAD Formats
DXF (R12/2007/2010)

## Save CAD As
*Fixed Layout*: PDF (as a vector and as a raster)
*Images*: BMP, PNG, JPG, JPEG, JPEG2000, TIF, TIFF, PSD, GIF, WMF

## Read CAD Formats
DWG (13, 14, 2000, 2004), DWG (2010, 2013, 2014), DWG (2015, 2017, 2018), DWT (13, 14, 2000, 2004), DWT (2010, 2013, 2014), DWT (2015, 2017, 2018), DWF, DGN v7, IGES (IGS), PLT, Industry Foundation Classes (IFC), STereoLithography (STL)

See [API Reference](https://apireference.aspose.cloud/cad/) for full API specification.

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.CAD-Cloud/) (recommended). For more details, please visit our [documentation website](https://docs.aspose.cloud/cad/available-sdks/).

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

The examples below show how your application have to initiate and convert "dxf" file to "pdf" using Aspose.CAD-Cloud library:

```csharp
// optional parameters are base URL, API version and debug mode
// default base URL is https://api.aspose.cloud
// default API version is v3.0
// default debug mode is false
// authentication type is OAuth2.0 (bearer JWT token)
var cadApi = new CadApi("yourAppKey", "yourAppSID");

// this GET request converts drawing files
// optional parameters are output file path, input file folder and Aspose storage name (if you have more than one storage and want to use non-default one)
// if output file path is not set, resulting image is returned in a stream; otherwise, it's saved at the specified path in the storage and null is returned
var getSaveRequest = new GetDrawingSaveAsRequest("inputImage.dwg", "png", "InputFolder", "ResultFolder/resultImage.png", "Your storage");

// returns null, saves result to storage
cadApi.GetDrawingSaveAs(getSaveRequest);

var getStreamRequest = new GetImageSaveAsRequest("inputDrawing.dxf", "pdf", "InputFolder", null);

// returns resulting stream
using (Stream resultGetImageStream = cadApi.GetDrawingSaveAs(getStreamRequest))
{
	// process resulting stream
}

// another option is to use POST request and send drawing as a stream, if it's not present in your storage
using (FileStream inputImageStream = new FileStream(@"D:\test\localInputDrawing.dxf", FileMode.Open, FileAccess.Read))
{
	var postSaveRequest = new PostDrawingSaveAsRequest(inputImageStream, "png", "ResultFolder/resultImage.png");

	// returns null, saves result to storage
	cadApi.PostDrawingSaveAs(postSaveRequest);
}

using (FileStream inputImageStream = new FileStream(@"D:\test\localInputDrawing.dwg", FileMode.Open, FileAccess.Read))
{
	var postStreamRequest = new PostDrawingSaveAsRequest(inputImageStream, "png");

	// returns resulting stream
	using (Stream resultPostImageStream = cadApi.PostDrawingSaveAs(postStreamRequest))
	{
		// process resulting stream
	}
}

// another requests typically follow the same principles
```
[Tests](Aspose.CAD.Cloud.Sdk.Test) contain various examples of using the SDK.

## Dependencies

- .NET Standard 2.0
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/)

## SDK Advanages

+ SDK is fully in sync with the API, all missing methods are added
+ Classes, methods and properties have comments and are IDE-friendly
+ Integrated security
+ Usage of Request/Response classes to represent long lists of parameters. This allows for cleaner code and easier backwards-compatibility going forward

# Licensing

All Aspose.CAD for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

## Aspose.CAD Cloud SDKs in Popular Languages

| .NET | Java | PHP | Python | Ruby | Node.js |
|---|---|---|---|---|---|
| [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-dotnet) | [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-java) | [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-php) | [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-python) | [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-ruby)  | [GitHub](https://github.com/aspose-cad-cloud/aspose-cad-cloud-node) |
| [NuGet](https://www.nuget.org/packages/Aspose.cad-Cloud/) | [Maven](https://repository.aspose.cloud/webapp/#/artifacts/browse/tree/General/repo/com/aspose/aspose-cad-cloud) | [Composer](https://packagist.org/packages/aspose/aspose-cad-cloud) | [PIP](https://pypi.org/project/aspose.cad-cloud/) | [GEM](https://rubygems.org/gems/aspose_cad_cloud)  | [NPM](https://www.npmjs.com/package/@asposecloud/aspose-cad-cloud) |

[Product Page](https://products.aspose.cloud/cad/net) | [Documentation](https://docs.aspose.cloud/display/cadcloud/Home) | [API Reference](https://apireference.aspose.cloud/cad/) | [Code Samples](https://github.com/aspose-cad-cloud/aspose-cad-cloud-dotnet) | [Blog](https://blog.aspose.cloud/category/cad/) | [Free Support](https://forum.aspose.cloud/c/cad) | [Free Trial](https://dashboard.aspose.cloud/#/apps)|
