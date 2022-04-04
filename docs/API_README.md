<a name="documentation-for-api-endpoints"></a>
## Documentation for API endpoints

All URIs are relative to *https://api.aspose.cloud/v3.0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CadApi* | [**CopyFile**](CadApi.md#copyfile) | **PUT** /cad/storage/file/copy/{srcPath} | Copy file
*CadApi* | [**CopyFolder**](CadApi.md#copyfolder) | **PUT** /cad/storage/folder/copy/{srcPath} | Copy folder
*CadApi* | [**CreateFolder**](CadApi.md#createfolder) | **PUT** /cad/storage/folder/{path} | Create the folder
*CadApi* | [**DeleteFile**](CadApi.md#deletefile) | **DELETE** /cad/storage/file/{path} | Delete file
*CadApi* | [**DeleteFolder**](CadApi.md#deletefolder) | **DELETE** /cad/storage/folder/{path} | Delete folder
*CadApi* | [**DownloadFile**](CadApi.md#downloadfile) | **GET** /cad/storage/file/{path} | Download file
*CadApi* | [**GetDiscUsage**](CadApi.md#getdiscusage) | **GET** /cad/storage/disc | Get disc usage
*CadApi* | [**GetDrawingProperties**](CadApi.md#getdrawingproperties) | **GET** /cad/{name}/properties | Retrieves info about an existing drawing.             
*CadApi* | [**GetDrawingResize**](CadApi.md#getdrawingresize) | **GET** /cad/{name}/resize | Resize an existing drawing.
*CadApi* | [**GetDrawingRotateFlip**](CadApi.md#getdrawingrotateflip) | **GET** /cad/{name}/rotateflip | Rotate/flip an existing drawing.
*CadApi* | [**GetDrawingSaveAs**](CadApi.md#getdrawingsaveas) | **GET** /cad/{name}/saveAs/{outputFormat} | Export an existing drawing to another format.
*CadApi* | [**GetFileVersions**](CadApi.md#getfileversions) | **GET** /cad/storage/version/{path} | Get file versions
*CadApi* | [**GetFilesList**](CadApi.md#getfileslist) | **GET** /cad/storage/folder/{path} | Get all files and folders within a folder
*CadApi* | [**MoveFile**](CadApi.md#movefile) | **PUT** /cad/storage/file/move/{srcPath} | Move file
*CadApi* | [**MoveFolder**](CadApi.md#movefolder) | **PUT** /cad/storage/folder/move/{srcPath} | Move folder
*CadApi* | [**ObjectExists**](CadApi.md#objectexists) | **GET** /cad/storage/exist/{path} | Check if file or folder exists
*CadApi* | [**PostDrawingBmp**](CadApi.md#postdrawingbmp) | **POST** /cad/{name}/bmp | Export an existing drawing to BMP format with export settings specified.
*CadApi* | [**PostDrawingDXF**](CadApi.md#postdrawingdxf) | **POST** /cad/{name}/dxf | Export an existing drawing to DXF format with export settings specified.
*CadApi* | [**PostDrawingDwf**](CadApi.md#postdrawingdwf) | **POST** /cad/{name}/dwf | Export an existing drawing to Dwf format with export settings specified.
*CadApi* | [**PostDrawingFbx**](CadApi.md#postdrawingfbx) | **POST** /cad/{name}/fbx | Export an existing drawing to Fbx format with export settings specified.
*CadApi* | [**PostDrawingGif**](CadApi.md#postdrawinggif) | **POST** /cad/{name}/gif | Export an existing drawing into GIF format with export settings specified.
*CadApi* | [**PostDrawingJpeg**](CadApi.md#postdrawingjpeg) | **POST** /cad/{name}/jpeg | Export an existing drawing into JPEG format with export settings specified.
*CadApi* | [**PostDrawingJpeg2000**](CadApi.md#postdrawingjpeg2000) | **POST** /cad/{name}/jpeg2000 | Export an existing drawing into JPEG2000 format with export settings specified.
*CadApi* | [**PostDrawingObj**](CadApi.md#postdrawingobj) | **POST** /cad/{name}/obj | Export an existing drawing to Obj format with export settings specified.
*CadApi* | [**PostDrawingPdf**](CadApi.md#postdrawingpdf) | **POST** /cad/{name}/pdf | Export an existing drawing to PDF format with export settings specified.
*CadApi* | [**PostDrawingPng**](CadApi.md#postdrawingpng) | **POST** /cad/{name}/png | Export an existing drawing into PNG format with export settings specified.
*CadApi* | [**PostDrawingProperties**](CadApi.md#postdrawingproperties) | **POST** /cad/properties | Retrieves info about drawing which is passed as a zero-indexed multipart/form-data content or as raw body stream.
*CadApi* | [**PostDrawingPsd**](CadApi.md#postdrawingpsd) | **POST** /cad/{name}/psd | Export an existing drawing into PSD format with export settings specified.
*CadApi* | [**PostDrawingResize**](CadApi.md#postdrawingresize) | **POST** /cad/resize | Resize a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream.
*CadApi* | [**PostDrawingRotateFlip**](CadApi.md#postdrawingrotateflip) | **POST** /cad/rotateflip | Rotate/flip a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream.
*CadApi* | [**PostDrawingSaveAs**](CadApi.md#postdrawingsaveas) | **POST** /cad/saveAs/{outputFormat} | Export existing drawing to another format. Drawing data is passed as zero-indexed multipart/form-data content or as raw body stream.             
*CadApi* | [**PostDrawingSvg**](CadApi.md#postdrawingsvg) | **POST** /cad/{name}/svg | Export an existing drawing to SVG format with export settings specified.
*CadApi* | [**PostDrawingTiff**](CadApi.md#postdrawingtiff) | **POST** /cad/{name}/tiff | Export an existing drawing into TIFF format with export settings specified.
*CadApi* | [**PostDrawingWmf**](CadApi.md#postdrawingwmf) | **POST** /cad/{name}/wmf | Export an existing drawing to WMF format with export settings specified.
*CadApi* | [**PutDrawingBmp**](CadApi.md#putdrawingbmp) | **PUT** /cad/bmp | Export drawing to BMP format. Drawing data is passed as zero-indexed multipart/form-data as well as export BMP options serialized as JSON. Order of drawing data and BMP options could vary.
*CadApi* | [**PutDrawingDXF**](CadApi.md#putdrawingdxf) | **PUT** /cad/dxf | Export drawing to DXF format. Drawing data is passed as zero-indexed multipart/form-data as well as export DXF options serialized as JSON. Order of drawing data and DXF options could vary.
*CadApi* | [**PutDrawingDwf**](CadApi.md#putdrawingdwf) | **PUT** /cad/dwf | Export drawing to Dwf format. Drawing data is passed as zero-indexed multipart/form-data as well as export Dwf options serialized as JSON. Order of drawing data and Dwf options could vary.
*CadApi* | [**PutDrawingFbx**](CadApi.md#putdrawingfbx) | **PUT** /cad/fbx | Export drawing to Fbx format. Drawing data is passed as zero-indexed multipart/form-data as well as export Fbx options serialized as JSON. Order of drawing data and Fbx options could vary.
*CadApi* | [**PutDrawingGif**](CadApi.md#putdrawinggif) | **PUT** /cad/gif | Export drawing to GIF format. Drawing data is passed as zero-indexed multipart/form-data as well as export GIF options serialized as JSON. Order of drawing data and GIF options could vary.
*CadApi* | [**PutDrawingJpeg**](CadApi.md#putdrawingjpeg) | **PUT** /cad/jpeg | Export drawing to JPEG format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG options serialized as JSON. Order of drawing data and JPEG options could vary.
*CadApi* | [**PutDrawingJpeg2000**](CadApi.md#putdrawingjpeg2000) | **PUT** /cad/jpeg2000 | Export drawing to JPEG2000 format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG2000 options serialized as JSON. Order of drawing data and JPEG2000 options could vary.
*CadApi* | [**PutDrawingObj**](CadApi.md#putdrawingobj) | **PUT** /cad/obj | Export drawing to Obj format. Drawing data is passed as zero-indexed multipart/form-data as well as export Obj options serialized as JSON. Order of drawing data and Obj options could vary.
*CadApi* | [**PutDrawingPdf**](CadApi.md#putdrawingpdf) | **PUT** /cad/pdf | Export drawing to PDF format. Drawing data is passed as zero-indexed multipart/form-data as well as export PDF options serialized as JSON. Order of drawing data and PDF options could vary.
*CadApi* | [**PutDrawingPng**](CadApi.md#putdrawingpng) | **PUT** /cad/png | Export drawing to PNG format. Drawing data is passed as zero-indexed multipart/form-data as well as export PNG options serialized as JSON. Order of drawing data and PNG options could vary.
*CadApi* | [**PutDrawingPsd**](CadApi.md#putdrawingpsd) | **PUT** /cad/psd | Export drawing to PSD format. Drawing data is passed as zero-indexed multipart/form-data as well as export PSD options serialized as JSON. Order of drawing data and PSD options could vary.
*CadApi* | [**PutDrawingSvg**](CadApi.md#putdrawingsvg) | **PUT** /cad/svg | Export drawing to SVG format. Drawing data is passed as zero-indexed multipart/form-data as well as export SVG options serialized as JSON. Order of drawing data and SVG options could vary.
*CadApi* | [**PutDrawingTiff**](CadApi.md#putdrawingtiff) | **PUT** /cad/tiff | Export drawing to TIFF format. Drawing data is passed as zero-indexed multipart/form-data as well as export TIFF options serialized as JSON. Order of drawing data and TIFF options could vary.
*CadApi* | [**PutDrawingWmf**](CadApi.md#putdrawingwmf) | **PUT** /cad/wmf | Export drawing to WMF format. Drawing data is passed as zero-indexed multipart/form-data as well as export WMF options serialized as JSON. Order of drawing data and WMF options could vary.
*CadApi* | [**StorageExists**](CadApi.md#storageexists) | **GET** /cad/storage/{storageName}/exist | Check if storage exists
*CadApi* | [**UploadFile**](CadApi.md#uploadfile) | **PUT** /cad/storage/file/{path} | Upload file


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AsnEncodedData](AsnEncodedData.md)
 - [Model.AsymmetricAlgorithm](AsymmetricAlgorithm.md)
 - [Model.CadResponse](CadResponse.md)
 - [Model.Cf2Properties](Cf2Properties.md)
 - [Model.Color](Color.md)
 - [Model.DgnProperties](DgnProperties.md)
 - [Model.DiscUsage](DiscUsage.md)
 - [Model.DrawingOptionsBaseDTO](DrawingOptionsBaseDTO.md)
 - [Model.DwfProperties](DwfProperties.md)
 - [Model.DwgProperties](DwgProperties.md)
 - [Model.DxfProperties](DxfProperties.md)
 - [Model.Error](Error.md)
 - [Model.ErrorDetails](ErrorDetails.md)
 - [Model.FbxProperties](FbxProperties.md)
 - [Model.FileVersions](FileVersions.md)
 - [Model.FilesList](FilesList.md)
 - [Model.FilesUploadResult](FilesUploadResult.md)
 - [Model.GraphicsOptions](GraphicsOptions.md)
 - [Model.IfcProperties](IfcProperties.md)
 - [Model.IgsProperties](IgsProperties.md)
 - [Model.IntPtr](IntPtr.md)
 - [Model.KeySizes](KeySizes.md)
 - [Model.ObjProperties](ObjProperties.md)
 - [Model.ObjectExist](ObjectExist.md)
 - [Model.Oid](Oid.md)
 - [Model.PdfDigitalSignatureDetailsCore](PdfDigitalSignatureDetailsCore.md)
 - [Model.PdfDocumentInfo](PdfDocumentInfo.md)
 - [Model.PdfDocumentOptions](PdfDocumentOptions.md)
 - [Model.PenOptions](PenOptions.md)
 - [Model.PltProperties](PltProperties.md)
 - [Model.PublicKey](PublicKey.md)
 - [Model.RdOptimizerSettings](RdOptimizerSettings.md)
 - [Model.ResolutionSetting](ResolutionSetting.md)
 - [Model.StlProperties](StlProperties.md)
 - [Model.StorageExist](StorageExist.md)
 - [Model.StorageFile](StorageFile.md)
 - [Model.VectorRasterizationOptionsDTO](VectorRasterizationOptionsDTO.md)
 - [Model.X509Certificate](X509Certificate.md)
 - [Model.BmpOptionsDTO](BmpOptionsDTO.md)
 - [Model.CadRasterizationOptionsDTO](CadRasterizationOptionsDTO.md)
 - [Model.DwfOptionsDTO](DwfOptionsDTO.md)
 - [Model.DxfOptionsDTO](DxfOptionsDTO.md)
 - [Model.FbxOptionsDTO](FbxOptionsDTO.md)
 - [Model.FileVersion](FileVersion.md)
 - [Model.GifOptionsDTO](GifOptionsDTO.md)
 - [Model.Jpeg2000OptionsDTO](Jpeg2000OptionsDTO.md)
 - [Model.JpegOptionsDTO](JpegOptionsDTO.md)
 - [Model.ObjOptionsDTO](ObjOptionsDTO.md)
 - [Model.PdfOptionsDTO](PdfOptionsDTO.md)
 - [Model.PngOptionsDTO](PngOptionsDTO.md)
 - [Model.PsdOptionsDTO](PsdOptionsDTO.md)
 - [Model.SvgOptionsDTO](SvgOptionsDTO.md)
 - [Model.TiffOptionsDTO](TiffOptionsDTO.md)
 - [Model.WmfOptionsDTO](WmfOptionsDTO.md)
 - [Model.X500DistinguishedName](X500DistinguishedName.md)
 - [Model.X509Certificate2](X509Certificate2.md)

