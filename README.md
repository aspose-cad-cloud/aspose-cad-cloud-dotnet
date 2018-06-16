# Aspose.CAD for Cloud .NET SDK
[Aspose.CAD for Cloud](https://products.aspose.cloud/CAD/cloud) is a true REST API that enables you to perform a wide range of drawing processing operations including creation, manipulation and conversion in the cloud, with zero initial costs. Our Cloud SDKs are wrappers around REST API in various programming languages, allowing you to process drawings in language of your choice quickly and easily, gaining all benefits of strong types and IDE highlights. 

This repository contains Aspose.CAD for Cloud .NET SDK source code. This SDK allows you to work with Aspose.CAD for Cloud REST APIs in your .NET applications quickly and easily, with zero initial cost.

To use this SDK, you will need App SID and App Key which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

# Example
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

# Licensing
All Aspose.CAD for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

# Resources
+ [**Web API reference**](https://apireference.aspose.cloud/CAD/)
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/CAD/cloud)
+ [**Documentation**](https://docs.aspose.cloud/display/CADcloud/Home)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/CAD)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.CAD/)
+ [**Blog**](https://blog.aspose.cloud/category/aspose-products/aspose.CAD-cloud/)