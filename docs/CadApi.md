# Aspose.CAD.Cloud.Sdk.Api.CadApi

<a name="copyfile"></a>
## **CopyFile**
> void CopyFile(CopyFileRequest request)

Copy file

### **CopyFileRequest** Parameters
```csharp
CopyFileRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="copyfolder"></a>
## **CopyFolder**
> void CopyFolder(CopyFolderRequest request)

Copy folder

### **CopyFolderRequest** Parameters
```csharp
CopyFolderRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="createfolder"></a>
## **CreateFolder**
> void CreateFolder(CreateFolderRequest request)

Create the folder

### **CreateFolderRequest** Parameters
```csharp
CreateFolderRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletefile"></a>
## **DeleteFile**
> void DeleteFile(DeleteFileRequest request)

Delete file

### **DeleteFileRequest** Parameters
```csharp
DeleteFileRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="deletefolder"></a>
## **DeleteFolder**
> void DeleteFolder(DeleteFolderRequest request)

Delete folder

### **DeleteFolderRequest** Parameters
```csharp
DeleteFolderRequest(
    string path, 
    string storageName = null, 
    bool? recursive = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="downloadfile"></a>
## **DownloadFile**
> System.IO.Stream DownloadFile(DownloadFileRequest request)

Download file

### **DownloadFileRequest** Parameters
```csharp
DownloadFileRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdiscusage"></a>
## **GetDiscUsage**
> [DiscUsage](DiscUsage.md) GetDiscUsage(GetDiscUsageRequest request)

Get disc usage

### **GetDiscUsageRequest** Parameters
```csharp
GetDiscUsageRequest(
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdrawingproperties"></a>
## **GetDrawingProperties**
> [CadResponse](CadResponse.md) GetDrawingProperties(GetDrawingPropertiesRequest request)

Retrieves info about an existing drawing.             

### **GetDrawingPropertiesRequest** Parameters
```csharp
GetDrawingPropertiesRequest(
    string name, 
    string folder = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **folder** | **string**| Folder with a drawing to get properties for. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

[**CadResponse**](CadResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdrawingresize"></a>
## **GetDrawingResize**
> System.IO.Stream GetDrawingResize(GetDrawingResizeRequest request)

Resize an existing drawing.

### **GetDrawingResizeRequest** Parameters
```csharp
GetDrawingResizeRequest(
    string name, 
    string outputFormat, 
    int? newWidth, 
    int? newHeight, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of a drawing. | 
 **outputFormat** | **string**| Resulting file format. | 
 **newWidth** | **int?**| New width. | 
 **newHeight** | **int?**| New height. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdrawingrotateflip"></a>
## **GetDrawingRotateFlip**
> System.IO.Stream GetDrawingRotateFlip(GetDrawingRotateFlipRequest request)

Rotate/flip an existing drawing.

### **GetDrawingRotateFlipRequest** Parameters
```csharp
GetDrawingRotateFlipRequest(
    string name, 
    string outputFormat, 
    string rotateFlipType, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of a drawing. | 
 **outputFormat** | **string**| Resulting file format. | 
 **rotateFlipType** | **string**| Rotate/flip operation to apply. Possible values: RotateNoneFlipNone, Rotate90FlipNone, Rotate180FlipNone, Rotate270FlipNone, RotateNoneFlipX, Rotate90FlipX, Rotate180FlipX, Rotate270FlipX, RotateNoneFlipY, Rotate90FlipY, Rotate180FlipY, Rotate270FlipY, RotateNoneFlipXY, Rotate90FlipXY, Rotate180FlipXY, Rotate270FlipXY | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getdrawingsaveas"></a>
## **GetDrawingSaveAs**
> System.IO.Stream GetDrawingSaveAs(GetDrawingSaveAsRequest request)

Export an existing drawing to another format.

### **GetDrawingSaveAsRequest** Parameters
```csharp
GetDrawingSaveAsRequest(
    string name, 
    string outputFormat, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **outputFormat** | **string**| Resulting file format. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getfileversions"></a>
## **GetFileVersions**
> [FileVersions](FileVersions.md) GetFileVersions(GetFileVersionsRequest request)

Get file versions

### **GetFileVersionsRequest** Parameters
```csharp
GetFileVersionsRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="getfileslist"></a>
## **GetFilesList**
> [FilesList](FilesList.md) GetFilesList(GetFilesListRequest request)

Get all files and folders within a folder

### **GetFilesListRequest** Parameters
```csharp
GetFilesListRequest(
    string path, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesList**](FilesList.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="movefile"></a>
## **MoveFile**
> void MoveFile(MoveFileRequest request)

Move file

### **MoveFileRequest** Parameters
```csharp
MoveFileRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="movefolder"></a>
## **MoveFolder**
> void MoveFolder(MoveFolderRequest request)

Move folder

### **MoveFolderRequest** Parameters
```csharp
MoveFolderRequest(
    string srcPath, 
    string destPath, 
    string srcStorageName = null, 
    string destStorageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="objectexists"></a>
## **ObjectExists**
> [ObjectExist](ObjectExist.md) ObjectExists(ObjectExistsRequest request)

Check if file or folder exists

### **ObjectExistsRequest** Parameters
```csharp
ObjectExistsRequest(
    string path, 
    string storageName = null, 
    string versionId = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingbmp"></a>
## **PostDrawingBmp**
> System.IO.Stream PostDrawingBmp(PostDrawingBmpRequest request)

Export an existing drawing to BMP format with export settings specified.

### **PostDrawingBmpRequest** Parameters
```csharp
PostDrawingBmpRequest(
    string name, 
    BmpOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**BmpOptionsDTO**](BmpOptionsDTO.md)| Export BMP options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingdxf"></a>
## **PostDrawingDXF**
> System.IO.Stream PostDrawingDXF(PostDrawingDXFRequest request)

Export an existing drawing to DXF format with export settings specified.

### **PostDrawingDXFRequest** Parameters
```csharp
PostDrawingDXFRequest(
    string name, 
    DxfOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**DxfOptionsDTO**](DxfOptionsDTO.md)| Export DXF options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingdwf"></a>
## **PostDrawingDwf**
> System.IO.Stream PostDrawingDwf(PostDrawingDwfRequest request)

Export an existing drawing to Dwf format with export settings specified.

### **PostDrawingDwfRequest** Parameters
```csharp
PostDrawingDwfRequest(
    string name, 
    DwfOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**DwfOptionsDTO**](DwfOptionsDTO.md)| Export Dwf options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingfbx"></a>
## **PostDrawingFbx**
> System.IO.Stream PostDrawingFbx(PostDrawingFbxRequest request)

Export an existing drawing to Fbx format with export settings specified.

### **PostDrawingFbxRequest** Parameters
```csharp
PostDrawingFbxRequest(
    string name, 
    FbxOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**FbxOptionsDTO**](FbxOptionsDTO.md)| Export Fbx options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawinggif"></a>
## **PostDrawingGif**
> System.IO.Stream PostDrawingGif(PostDrawingGifRequest request)

Export an existing drawing into GIF format with export settings specified.

### **PostDrawingGifRequest** Parameters
```csharp
PostDrawingGifRequest(
    string name, 
    GifOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**GifOptionsDTO**](GifOptionsDTO.md)| Export GIF options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingjpeg"></a>
## **PostDrawingJpeg**
> System.IO.Stream PostDrawingJpeg(PostDrawingJpegRequest request)

Export an existing drawing into JPEG format with export settings specified.

### **PostDrawingJpegRequest** Parameters
```csharp
PostDrawingJpegRequest(
    string name, 
    JpegOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**JpegOptionsDTO**](JpegOptionsDTO.md)| Export JPEG options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingjpeg2000"></a>
## **PostDrawingJpeg2000**
> System.IO.Stream PostDrawingJpeg2000(PostDrawingJpeg2000Request request)

Export an existing drawing into JPEG2000 format with export settings specified.

### **PostDrawingJpeg2000Request** Parameters
```csharp
PostDrawingJpeg2000Request(
    string name, 
    Jpeg2000OptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**Jpeg2000OptionsDTO**](Jpeg2000OptionsDTO.md)| Export JPEG2000 options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingobj"></a>
## **PostDrawingObj**
> System.IO.Stream PostDrawingObj(PostDrawingObjRequest request)

Export an existing drawing to Obj format with export settings specified.

### **PostDrawingObjRequest** Parameters
```csharp
PostDrawingObjRequest(
    string name, 
    ObjOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**ObjOptionsDTO**](ObjOptionsDTO.md)| Export Obj options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingpdf"></a>
## **PostDrawingPdf**
> System.IO.Stream PostDrawingPdf(PostDrawingPdfRequest request)

Export an existing drawing to PDF format with export settings specified.

### **PostDrawingPdfRequest** Parameters
```csharp
PostDrawingPdfRequest(
    string name, 
    PdfOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**PdfOptionsDTO**](PdfOptionsDTO.md)| Export PDF options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingpng"></a>
## **PostDrawingPng**
> System.IO.Stream PostDrawingPng(PostDrawingPngRequest request)

Export an existing drawing into PNG format with export settings specified.

### **PostDrawingPngRequest** Parameters
```csharp
PostDrawingPngRequest(
    string name, 
    PngOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**PngOptionsDTO**](PngOptionsDTO.md)| Export PNG options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingproperties"></a>
## **PostDrawingProperties**
> [CadResponse](CadResponse.md) PostDrawingProperties(PostDrawingPropertiesRequest request)

Retrieves info about drawing which is passed as a zero-indexed multipart/form-data content or as raw body stream.

### **PostDrawingPropertiesRequest** Parameters
```csharp
PostDrawingPropertiesRequest(
    System.IO.Stream drawingData)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 

### Return type

[**CadResponse**](CadResponse.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingpsd"></a>
## **PostDrawingPsd**
> System.IO.Stream PostDrawingPsd(PostDrawingPsdRequest request)

Export an existing drawing into PSD format with export settings specified.

### **PostDrawingPsdRequest** Parameters
```csharp
PostDrawingPsdRequest(
    string name, 
    PsdOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**PsdOptionsDTO**](PsdOptionsDTO.md)| Export PSD options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingresize"></a>
## **PostDrawingResize**
> System.IO.Stream PostDrawingResize(PostDrawingResizeRequest request)

Resize a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream.

### **PostDrawingResizeRequest** Parameters
```csharp
PostDrawingResizeRequest(
    System.IO.Stream drawingData, 
    string outputFormat, 
    int? newWidth, 
    int? newHeight, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outputFormat** | **string**| Resulting file format. | 
 **newWidth** | **int?**| New width. | 
 **newHeight** | **int?**| New height. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingrotateflip"></a>
## **PostDrawingRotateFlip**
> System.IO.Stream PostDrawingRotateFlip(PostDrawingRotateFlipRequest request)

Rotate/flip a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream.

### **PostDrawingRotateFlipRequest** Parameters
```csharp
PostDrawingRotateFlipRequest(
    System.IO.Stream drawingData, 
    string outputFormat, 
    string rotateFlipType, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outputFormat** | **string**| Resulting file format. | 
 **rotateFlipType** | **string**| Rotate/flip operation to apply. Possible values: RotateNoneFlipNone, Rotate90FlipNone, Rotate180FlipNone, Rotate270FlipNone, RotateNoneFlipX, Rotate90FlipX, Rotate180FlipX, Rotate270FlipX, RotateNoneFlipY, Rotate90FlipY, Rotate180FlipY, Rotate270FlipY, RotateNoneFlipXY, Rotate90FlipXY, Rotate180FlipXY, Rotate270FlipXY | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingsaveas"></a>
## **PostDrawingSaveAs**
> System.IO.Stream PostDrawingSaveAs(PostDrawingSaveAsRequest request)

Export existing drawing to another format. Drawing data is passed as zero-indexed multipart/form-data content or as raw body stream.             

### **PostDrawingSaveAsRequest** Parameters
```csharp
PostDrawingSaveAsRequest(
    System.IO.Stream drawingData, 
    string outputFormat, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outputFormat** | **string**| Resulting file format. | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingsvg"></a>
## **PostDrawingSvg**
> System.IO.Stream PostDrawingSvg(PostDrawingSvgRequest request)

Export an existing drawing to SVG format with export settings specified.

### **PostDrawingSvgRequest** Parameters
```csharp
PostDrawingSvgRequest(
    string name, 
    SvgOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**SvgOptionsDTO**](SvgOptionsDTO.md)| Export SVG options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingtiff"></a>
## **PostDrawingTiff**
> System.IO.Stream PostDrawingTiff(PostDrawingTiffRequest request)

Export an existing drawing into TIFF format with export settings specified.

### **PostDrawingTiffRequest** Parameters
```csharp
PostDrawingTiffRequest(
    string name, 
    TiffOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**TiffOptionsDTO**](TiffOptionsDTO.md)| Export TIFF options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="postdrawingwmf"></a>
## **PostDrawingWmf**
> System.IO.Stream PostDrawingWmf(PostDrawingWmfRequest request)

Export an existing drawing to WMF format with export settings specified.

### **PostDrawingWmfRequest** Parameters
```csharp
PostDrawingWmfRequest(
    string name, 
    WmfOptionsDTO options, 
    string folder = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Filename of an input drawing on a storage. | 
 **options** | [**WmfOptionsDTO**](WmfOptionsDTO.md)| Export WMF options passed as a JSON on a request body. | 
 **folder** | **string**| Folder with a drawing to process. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingbmp"></a>
## **PutDrawingBmp**
> System.IO.Stream PutDrawingBmp(PutDrawingBmpRequest request)

Export drawing to BMP format. Drawing data is passed as zero-indexed multipart/form-data as well as export BMP options serialized as JSON. Order of drawing data and BMP options could vary.

### **PutDrawingBmpRequest** Parameters
```csharp
PutDrawingBmpRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/BmpOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingdxf"></a>
## **PutDrawingDXF**
> System.IO.Stream PutDrawingDXF(PutDrawingDXFRequest request)

Export drawing to DXF format. Drawing data is passed as zero-indexed multipart/form-data as well as export DXF options serialized as JSON. Order of drawing data and DXF options could vary.

### **PutDrawingDXFRequest** Parameters
```csharp
PutDrawingDXFRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/DxfOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingdwf"></a>
## **PutDrawingDwf**
> System.IO.Stream PutDrawingDwf(PutDrawingDwfRequest request)

Export drawing to Dwf format. Drawing data is passed as zero-indexed multipart/form-data as well as export Dwf options serialized as JSON. Order of drawing data and Dwf options could vary.

### **PutDrawingDwfRequest** Parameters
```csharp
PutDrawingDwfRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/DwfOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingfbx"></a>
## **PutDrawingFbx**
> System.IO.Stream PutDrawingFbx(PutDrawingFbxRequest request)

Export drawing to Fbx format. Drawing data is passed as zero-indexed multipart/form-data as well as export Fbx options serialized as JSON. Order of drawing data and Fbx options could vary.

### **PutDrawingFbxRequest** Parameters
```csharp
PutDrawingFbxRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/FbxOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawinggif"></a>
## **PutDrawingGif**
> System.IO.Stream PutDrawingGif(PutDrawingGifRequest request)

Export drawing to GIF format. Drawing data is passed as zero-indexed multipart/form-data as well as export GIF options serialized as JSON. Order of drawing data and GIF options could vary.

### **PutDrawingGifRequest** Parameters
```csharp
PutDrawingGifRequest(
    System.IO.Stream drawingData, 
    string exportOptions = null, 
    string outPath = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/GifOptionsDTO model definition. | [optional] 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingjpeg"></a>
## **PutDrawingJpeg**
> System.IO.Stream PutDrawingJpeg(PutDrawingJpegRequest request)

Export drawing to JPEG format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG options serialized as JSON. Order of drawing data and JPEG options could vary.

### **PutDrawingJpegRequest** Parameters
```csharp
PutDrawingJpegRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/JpegOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingjpeg2000"></a>
## **PutDrawingJpeg2000**
> System.IO.Stream PutDrawingJpeg2000(PutDrawingJpeg2000Request request)

Export drawing to JPEG2000 format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG2000 options serialized as JSON. Order of drawing data and JPEG2000 options could vary.

### **PutDrawingJpeg2000Request** Parameters
```csharp
PutDrawingJpeg2000Request(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/Jpeg2000OptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingobj"></a>
## **PutDrawingObj**
> System.IO.Stream PutDrawingObj(PutDrawingObjRequest request)

Export drawing to Obj format. Drawing data is passed as zero-indexed multipart/form-data as well as export Obj options serialized as JSON. Order of drawing data and Obj options could vary.

### **PutDrawingObjRequest** Parameters
```csharp
PutDrawingObjRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/ObjOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingpdf"></a>
## **PutDrawingPdf**
> System.IO.Stream PutDrawingPdf(PutDrawingPdfRequest request)

Export drawing to PDF format. Drawing data is passed as zero-indexed multipart/form-data as well as export PDF options serialized as JSON. Order of drawing data and PDF options could vary.

### **PutDrawingPdfRequest** Parameters
```csharp
PutDrawingPdfRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/PdfOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingpng"></a>
## **PutDrawingPng**
> System.IO.Stream PutDrawingPng(PutDrawingPngRequest request)

Export drawing to PNG format. Drawing data is passed as zero-indexed multipart/form-data as well as export PNG options serialized as JSON. Order of drawing data and PNG options could vary.

### **PutDrawingPngRequest** Parameters
```csharp
PutDrawingPngRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/PngOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingpsd"></a>
## **PutDrawingPsd**
> System.IO.Stream PutDrawingPsd(PutDrawingPsdRequest request)

Export drawing to PSD format. Drawing data is passed as zero-indexed multipart/form-data as well as export PSD options serialized as JSON. Order of drawing data and PSD options could vary.

### **PutDrawingPsdRequest** Parameters
```csharp
PutDrawingPsdRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/PsdOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingsvg"></a>
## **PutDrawingSvg**
> System.IO.Stream PutDrawingSvg(PutDrawingSvgRequest request)

Export drawing to SVG format. Drawing data is passed as zero-indexed multipart/form-data as well as export SVG options serialized as JSON. Order of drawing data and SVG options could vary.

### **PutDrawingSvgRequest** Parameters
```csharp
PutDrawingSvgRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/SvgOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingtiff"></a>
## **PutDrawingTiff**
> System.IO.Stream PutDrawingTiff(PutDrawingTiffRequest request)

Export drawing to TIFF format. Drawing data is passed as zero-indexed multipart/form-data as well as export TIFF options serialized as JSON. Order of drawing data and TIFF options could vary.

### **PutDrawingTiffRequest** Parameters
```csharp
PutDrawingTiffRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/TiffOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="putdrawingwmf"></a>
## **PutDrawingWmf**
> System.IO.Stream PutDrawingWmf(PutDrawingWmfRequest request)

Export drawing to WMF format. Drawing data is passed as zero-indexed multipart/form-data as well as export WMF options serialized as JSON. Order of drawing data and WMF options could vary.

### **PutDrawingWmfRequest** Parameters
```csharp
PutDrawingWmfRequest(
    System.IO.Stream drawingData, 
    string outPath = null, 
    string exportOptions = null, 
    string storage = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **drawingData** | **System.IO.Stream**| Input drawing | 
 **outPath** | **string**| Path to updated file (if this is empty, response contains streamed file). | [optional] 
 **exportOptions** | **string**| JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/WmfOptionsDTO model definition. | [optional] 
 **storage** | **string**| Your Aspose Cloud Storage name. | [optional] 

### Return type

**System.IO.Stream**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="storageexists"></a>
## **StorageExists**
> [StorageExist](StorageExist.md) StorageExists(StorageExistsRequest request)

Check if storage exists

### **StorageExistsRequest** Parameters
```csharp
StorageExistsRequest(
    string storageName)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="token"></a>
## **Token**
> string Token(TokenRequest request)



### **TokenRequest** Parameters
```csharp
TokenRequest(
    GetAccessTokenRequest request)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**GetAccessTokenRequest**](GetAccessTokenRequest.md)|  | 

### Return type

**string**

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

<a name="uploadfile"></a>
## **UploadFile**
> [FilesUploadResult](FilesUploadResult.md) UploadFile(UploadFileRequest request)

Upload file

### **UploadFileRequest** Parameters
```csharp
UploadFileRequest(
    string path, 
    System.IO.Stream file, 
    string storageName = null)
```

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.              | 
 **file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

[[Back to top]](#) [[Back to API list]](API_README.md#documentation-for-api-endpoints) [[Back to Model list]](API_README.md#documentation-for-models) [[Back to API_README]](API_README.md)

