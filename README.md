# Aspose.CAD Cloud SDK for .NET [![NuGet](https://img.shields.io/nuget/v/Aspose.CAD-Cloud.svg)](https://www.nuget.org/packages/Aspose.CAD-Cloud/)
This repository contains Aspose.CAD Cloud SDK for .NET source code. This SDK allows you to perform a wide range of CAD drawing processing operations including creation, manipulation and conversion in the cloud, with zero initial costs and gain all benefits of strong types and IDE highlights.

# Key Features
* Supports the latest versions of AutoCAD DWG, DXF, DWF, DWT, STL, IGS, DGN and CF2 files
* Convert CAD drawings to high quality PDF
* Convert CAD drawing to high quality raster images
* Convert CAD drawing to high quality vector files like SVG and WMF
* Modify and convert CAD drawing to DXF
* Select and modify specific entities
* Select and convert specific layouts
* Select and convert specific layers
* Track the file conversion process

See [API Reference](https://apireference.aspose.cloud/cad/) for full API specification.

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

The examples below show how your application have to initiate and convert "doc" file to "pdf" using Aspose.CAD-Cloud library:
```csharp
// optional parameters are base URL, API version, authentication type and debug mode
// default base URL is https://api.aspose.cloud
// default API version is v1.1
// default authentication type is OAuth2.0
// default debug mode is false
var CADApi = new CADApi("yourAppKey", "yourAppSID");

// this GET request converts drawing files
// optional parameters are output file path, input file folder and Aspose storage name (if you have more than one storage and want to use non-default one) 
// if output file path is not set, resulting image is returned in a stream; otherwise, it's saved at the specified path in the storage and null is returned
var getSaveRequest = new GetImageSaveAsRequest("inputImage.dwwg", "png", "ResultFolder/resultImage.png", "InputFolder");

// returns null, saves result to storage
CADApi.GetImageSaveAs(getSaveRequest);

var getStreamRequest = new GetImageSaveAsRequest("inputDrawing.dxf", "png", null, "InputFolder");

// returns resulting stream
using (Stream resultGetImageStream = CADApi.GetImageSaveAs(getStreamRequest))
{
	// process resulting stream
}

// another option is to use POST request and send image in a stream, if it's not present in your storage

using (FileStream inputImageStream = new FileStream(@"D:\test\localInputDrawing.dxf", FileMode.Open, FileAccess.Read))
{
	var postSaveRequest = new PostImageSaveAsRequest(inputImageStream, "png", "ResultFolder/resultImage.png");
	
	// returns null, saves result to storage
	CADApi.PostImageSaveAs(postSaveRequest);
}

using (FileStream inputImageStream = new FileStream(@"D:\test\localInputDrawing.dwg", FileMode.Open, FileAccess.Read))
{
	var postStreamRequest = new PostImageSaveAsRequest(inputImageStream, "png");
	
	// returns resulting stream
	using (Stream resultPostImageStream = CADApi.PostImageSaveAs(postStreamRequest))
	{
		// process resulting stream
	}
}

// another requests typically follow the same principles
```

[Tests](Aspose.CAD.Cloud.Sdk.Test) contain various examples of using the SDK.

## Dependencies
- .NET Framework 2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

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
+ [**Documentation**](https://docs.aspose.cloud/display/cadcloud/Home)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/cad)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
+ [**Blog**](https://blog.aspose.cloud/category/cad/)

# Licensing
All Aspose.CAD for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).