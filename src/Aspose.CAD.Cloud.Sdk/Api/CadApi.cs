// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CadApi.cs">
//   Copyright (c) 2018 Aspose.CAD Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.CAD.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.CAD.Cloud.Sdk.Model;
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    using Aspose.CAD.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// Aspose.CAD Cloud API.
    /// </summary>
    public class CadApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="CadApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public CadApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public CadApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            requestHandlers.Add(new OAuthRequestHandler(this.configuration));
            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
            this.apiInvoker = new ApiInvoker(requestHandlers);
        }                            

        /// <summary>
        /// Retrieves info about an existing drawing.              
        /// </summary>
        /// <param name="request">Request. <see cref="GetDrawingPropertiesRequest" /></param> 
        /// <returns><see cref="CadResponse"/></returns>            
        public CadResponse GetDrawingProperties(GetDrawingPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDrawingProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (CadResponse)SerializationHelper.Deserialize(response, typeof(CadResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Resize an existing drawing. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDrawingResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDrawingResize(GetDrawingResizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDrawingResize");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling GetDrawingResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.NewWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling GetDrawingResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.NewHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling GetDrawingResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.NewWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.NewHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Rotate/flip an existing drawing. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDrawingRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDrawingRotateFlip(GetDrawingRotateFlipRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDrawingRotateFlip");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling GetDrawingRotateFlip");
            }

            // verify the required parameter 'rotateFlipType' is set
            if (request.RotateFlipType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipType' when calling GetDrawingRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipType", request.RotateFlipType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing to another format. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetDrawingSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetDrawingSaveAs(GetDrawingSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDrawingSaveAs");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling GetDrawingSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/saveAs/{outputFormat}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing to BMP format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingBmpRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingBmp(PostDrawingBmpRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingBmp");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingBmp");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/bmp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into GIF format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingGifRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingGif(PostDrawingGifRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingGif");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingGif");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/gif";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into JPEG format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingJpegRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingJpeg(PostDrawingJpegRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingJpeg");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingJpeg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/jpeg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into JPEG2000 format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingJpeg2000Request" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingJpeg2000(PostDrawingJpeg2000Request request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingJpeg2000");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/jpeg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing to PDF format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingPdfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingPdf(PostDrawingPdfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingPdf");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingPdf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into PNG format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingPngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingPng(PostDrawingPngRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingPng");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingPng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Retrieves info about drawing which is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingPropertiesRequest" /></param> 
        /// <returns><see cref="CadResponse"/></returns>            
        public CadResponse PostDrawingProperties(PostDrawingPropertiesRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostDrawingProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (CadResponse)SerializationHelper.Deserialize(response, typeof(CadResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into PSD format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingPsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingPsd(PostDrawingPsdRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingPsd");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingPsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Resize a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingResizeRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingResize(PostDrawingResizeRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostDrawingResize");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling PostDrawingResize");
            }

            // verify the required parameter 'newWidth' is set
            if (request.NewWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostDrawingResize");
            }

            // verify the required parameter 'newHeight' is set
            if (request.NewHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostDrawingResize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.NewWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.NewHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Rotate/flip a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingRotateFlip(PostDrawingRotateFlipRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostDrawingRotateFlip");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling PostDrawingRotateFlip");
            }

            // verify the required parameter 'rotateFlipType' is set
            if (request.RotateFlipType == null) 
            {
                throw new ApiException(400, "Missing required parameter 'rotateFlipType' when calling PostDrawingRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipType", request.RotateFlipType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export existing drawing to another format. Drawing data is passed as zero-indexed multipart/form-data content or as raw body stream.              
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingSaveAs(PostDrawingSaveAsRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostDrawingSaveAs");
            }

            // verify the required parameter 'outputFormat' is set
            if (request.OutputFormat == null) 
            {
                throw new ApiException(400, "Missing required parameter 'outputFormat' when calling PostDrawingSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/saveAs/{outputFormat}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing to SVG format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingSvgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingSvg(PostDrawingSvgRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingSvg");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingSvg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/svg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing into TIFF format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingTiff(PostDrawingTiffRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingTiff");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export an existing drawing to WMF format with export settings specified. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostDrawingWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingWmf(PostDrawingWmfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingWmf");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/wmf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to BMP format. Drawing data is passed as zero-indexed multipart/form-data as well as export BMP options serialized as JSON. Order of drawing data and BMP options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingBmpRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingBmp(PutDrawingBmpRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingBmp");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/bmp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to GIF format. Drawing data is passed as zero-indexed multipart/form-data as well as export GIF options serialized as JSON. Order of drawing data and GIF options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingGifRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingGif(PutDrawingGifRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingGif");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/gif";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to JPEG format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG options serialized as JSON. Order of drawing data and JPEG options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingJpegRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingJpeg(PutDrawingJpegRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingJpeg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/jpeg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to JPEG2000 format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG2000 options serialized as JSON. Order of drawing data and JPEG2000 options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingJpeg2000Request" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingJpeg2000(PutDrawingJpeg2000Request request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/jpeg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to PDF format. Drawing data is passed as zero-indexed multipart/form-data as well as export PDF options serialized as JSON. Order of drawing data and PDF options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingPdfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPdf(PutDrawingPdfRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPdf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to PNG format. Drawing data is passed as zero-indexed multipart/form-data as well as export PNG options serialized as JSON. Order of drawing data and PNG options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingPngRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPng(PutDrawingPngRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPng");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to PSD format. Drawing data is passed as zero-indexed multipart/form-data as well as export PSD options serialized as JSON. Order of drawing data and PSD options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingPsdRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPsd(PutDrawingPsdRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPsd");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to SVG format. Drawing data is passed as zero-indexed multipart/form-data as well as export SVG options serialized as JSON. Order of drawing data and SVG options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingSvgRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingSvg(PutDrawingSvgRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingSvg");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/svg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to TIFF format. Drawing data is passed as zero-indexed multipart/form-data as well as export TIFF options serialized as JSON. Order of drawing data and TIFF options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingTiffRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingTiff(PutDrawingTiffRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingTiff");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Export drawing to WMF format. Drawing data is passed as zero-indexed multipart/form-data as well as export WMF options serialized as JSON. Order of drawing data and WMF options could vary. 
        /// </summary>
        /// <param name="request">Request. <see cref="PutDrawingWmfRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingWmf(PutDrawingWmfRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingWmf");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/wmf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            
            if (request.ExportOptions != null) 
            {
                formParams.Add("exportOptions", request.ExportOptions); // form parameter
            }
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "PUT", 
                        null, 
                        null, 
                        formParams);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}

