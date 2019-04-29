// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CadApi.cs">
//   Copyright (c) 2018 Aspose.Cad for Cloud
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
    /// Aspose.Cad for Cloud API.
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
        /// Change scale of an existing image 
        /// </summary>
        /// <param name="request">Request. <see cref="GetChangeImageScaleRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetChangeImageScale(GetChangeImageScaleRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetChangeImageScale");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetChangeImageScale");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling GetChangeImageScale");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling GetChangeImageScale");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Get properties of an image. 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImagePropertiesRequest" /></param> 
        /// <returns><see cref="ImagePropertiesResponse"/></returns>            
        public ImagePropertiesResponse GetImageProperties(GetImagePropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageProperties");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
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
                    return (ImagePropertiesResponse)SerializationHelper.Deserialize(response, typeof(ImagePropertiesResponse));
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
        /// Rotate and flip existing image 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageRotateFlip(GetImageRotateFlipRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling GetImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Export existing image to another format 
        /// </summary>
        /// <param name="request">Request. <see cref="GetImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream GetImageSaveAs(GetImageSaveAsRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling GetImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/{name}/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rasterOptions", request.rasterOptions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Change scale of an image from body 
        /// </summary>
        /// <param name="request">Request. <see cref="PostChangeImageScaleRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostChangeImageScale(PostChangeImageScaleRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.drawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostChangeImageScale");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostChangeImageScale");
            }

            // verify the required parameter 'newWidth' is set
            if (request.newWidth == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newWidth' when calling PostChangeImageScale");
            }

            // verify the required parameter 'newHeight' is set
            if (request.newHeight == null) 
            {
                throw new ApiException(400, "Missing required parameter 'newHeight' when calling PostChangeImageScale");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.newWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.newHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.drawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.drawingData, "drawingData"));
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Rotate and flip existing image and get it from response. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageRotateFlipRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageRotateFlip(PostImageRotateFlipRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.drawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageRotateFlip");
            }

            // verify the required parameter 'method' is set
            if (request.method == null) 
            {
                throw new ApiException(400, "Missing required parameter 'method' when calling PostImageRotateFlip");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "method", request.method);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            
            if (request.drawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.drawingData, "drawingData"));
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
        /// Export existing image to another format. Image is passed as request body. 
        /// </summary>
        /// <param name="request">Request. <see cref="PostImageSaveAsRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostImageSaveAs(PostImageSaveAsRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.drawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostImageSaveAs");
            }

            // verify the required parameter 'format' is set
            if (request.format == null) 
            {
                throw new ApiException(400, "Missing required parameter 'format' when calling PostImageSaveAs");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/cad/saveAs";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rasterOptions", request.rasterOptions);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.outPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            
            if (request.drawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.drawingData, "drawingData"));
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
                    return (System.IO.Stream)SerializationHelper.Deserialize(response, typeof(System.IO.Stream));
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
    }
}
