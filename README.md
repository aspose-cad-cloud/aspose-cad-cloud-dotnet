# Aspose.CAD Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.CAD-Cloud.svg)](https://www.nuget.org/packages/Aspose.CAD-Cloud/)
[Aspose.CAD Cloud](https://products.aspose.cloud/cad) is a true [REST API](https://apireference.aspose.cloud/cad/) that enables you to perform a wide range of CAD and BIM drawings processing operations including manipulation, export and conversion in a cloud, with zero initial costs.

This repository contains [Aspose.CAD Cloud .NET SDK](https://products.aspose.cloud/cad/net) source code which is written in C#. This SDK allows you to work with Aspose.CAD Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost and gain all benefits of strong types and IDE highlights.


# Key Features

* Supports the latest versions of AutoCAD DWG, DXF, DWF, DWFX, DWT, STL, IGS, DGN, OBJ and CF2 files
* Convert CAD drawings to high quality PDF
* Convert CAD drawing to high quality raster images
* Convert CAD drawing to high quality vector files like SVG and WMF
* Modify and convert CAD drawing to DXF
* Modify and convert CAD drawing to DWF
* Select and modify specific entities
* Retrieve & update drawing properties and metadata
* Select and convert specific layouts
* Select and convert specific layers
* Track the file conversion process

#### Drawing Formats Support
Export the following drawing to various formats (generally supported ones are BMP, PSD, JPEG, TIFF, GIF, PNG, JPEG2000, SVG, WMF and PDF):
* DWG
* DXF
* DWF
* DWFX
* DWT
* STL
* IGS
* DGN
* OBJ
* CF2

Process options, change and return drawings in the same format:
* DXF
* DWF

Output formats to export:
* BMP
* PSD
* JPEG
* TIFF
* GIF
* PNG
* JPEG2000 (JP2, J2K)
* SVG
* WMF
* PDF

#### Supported CAD Operations
* Export 
* Resize
* Crop
* Rotate and Flip

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

## Contact Us

Your feedback is very important to us. Please feel free to contact us using our [Support Forums](https://forum.aspose.cloud/c/cad).

# Resources

+ [**Web API reference**](https://apireference.aspose.cloud/cad/)
+ [**Website**](https://www.aspose.cloud/)
+ [**Product Home**](https://products.aspose.cloud/cad)
+ [**Documentation**](https://docs.aspose.cloud/cad/)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/cad)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
+ [**Blog**](https://blog.aspose.cloud/category/cad/)

# Licensing

All Aspose.CAD for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).
