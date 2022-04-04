// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CadApi.cs">
//   Copyright (c) 2018-2019 Aspose Pty Ltd. All rights reserved.
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

namespace Aspose.CAD.Cloud.Sdk.Api
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.CAD.Cloud.Sdk;
    using Aspose.CAD.Cloud.Sdk.RequestHandlers;
    using Aspose.CAD.Cloud.Sdk.Model;
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    
    /// <summary>
    /// Aspose.CAD Cloud API.
    /// </summary>
    public class CadApi
    {                 
        #region Fields

        /// <summary>
        /// The configuration
        /// </summary>
        public readonly Configuration Configuration;
        
        /// <summary>
        /// The API invoker
        /// </summary>
        private readonly ApiInvoker apiInvoker;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CadApi"/> class for Aspose Cloud-hosted solution usage.
        /// </summary>
        /// <param name="appKey">
        /// The app key.
        /// </param>
        /// <param name="appSid">
        /// The app SID.
        /// </param>
        /// <param name="baseUrl">
        /// The base URL. Use <see cref="Configuration.DefaultBaseUrl"/> to set the default base URL.
        /// </param>
        /// <param name="apiVersion">
        /// The API version.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public CadApi(string appKey, string appSid, string baseUrl = Configuration.DefaultBaseUrl, 
            AvailableApiVersions apiVersion = Configuration.DefaultApiVersion, bool debug = false)
            : this(new Configuration
            {
                AppKey = appKey,
                AppSid = appSid,
                ApiBaseUrl = baseUrl,
                ApiVersion = apiVersion,
                DebugMode = debug,
                OnPremise = false
            })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadApi"/> class for on-premise solution with metered license usage.
        /// </summary>
        /// <param name="baseUrl">
        /// The base URL of your server.
        /// </param>
        /// <param name="apiVersion">
        /// The API version.
        /// </param>
        /// <param name="debug">
        /// If debug mode is enabled.
        /// </param>
        public CadApi(string baseUrl, AvailableApiVersions apiVersion = Configuration.DefaultApiVersion, bool debug = false)
            : this(new Configuration
            {
                ApiBaseUrl = baseUrl,
                ApiVersion = apiVersion,
                DebugMode = debug,
                OnPremise = true
            })
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        private CadApi(Configuration configuration)
        {
            this.Configuration = configuration;
            var requestHandlers = new List<IRequestHandler>();
            if (!configuration.OnPremise)
            {
                requestHandlers.Add(new OAuthRequestHandler(this.Configuration));
            }
            
            requestHandlers.Add(new DebugLogRequestHandler(this.Configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(requestHandlers, this.Configuration);
        }

        #endregion
    
        #region Methods
        
        /// <summary>
        /// Copy file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CopyFileRequest" /></param>            
        public void CopyFile(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/file/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Copy folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CopyFolderRequest" /></param>            
        public void CopyFolder(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Create the folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="CreateFolderRequest" /></param>            
        public void CreateFolder(CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Delete file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteFileRequest" /></param>            
        public void DeleteFile(DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Delete folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DeleteFolderRequest" /></param>            
        public void DeleteFolder(DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.Recursive);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "DELETE", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Download file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream DownloadFile(DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Get disc usage 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage"/></returns>            
        public DiscUsage GetDiscUsage(GetDiscUsageRequest request)
        {
            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/disc";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (DiscUsage)SerializationHelper.Deserialize<DiscUsage>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Retrieves info about an existing drawing.              
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDrawingPropertiesRequest" /></param>
        /// <returns><see cref="CadResponse"/></returns>            
        public CadResponse GetDrawingProperties(GetDrawingPropertiesRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetDrawingProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (CadResponse)SerializationHelper.Deserialize<CadResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Resize an existing drawing. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDrawingResizeRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/resize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newWidth", request.NewWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "newHeight", request.NewHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Rotate/flip an existing drawing. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDrawingRotateFlipRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/rotateflip";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotateFlipType", request.RotateFlipType);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to another format. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetDrawingSaveAsRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/saveAs/{outputFormat}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "outputFormat", request.OutputFormat);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Get file versions 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions"/></returns>            
        public FileVersions GetFileVersions(GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFileVersions");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/version/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FileVersions)SerializationHelper.Deserialize<FileVersions>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Get all files and folders within a folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="GetFilesListRequest" /></param>
        /// <returns><see cref="FilesList"/></returns>            
        public FilesList GetFilesList(GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/folder/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FilesList)SerializationHelper.Deserialize<FilesList>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Move file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="MoveFileRequest" /></param>            
        public void MoveFile(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/file/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Move folder 
        /// </summary>
        /// <param name="request">Specific request.<see cref="MoveFolderRequest" /></param>            
        public void MoveFolder(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.SrcPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }

            // verify the required parameter 'destPath' is set
            if (request.DestPath == null) 
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/folder/move/{srcPath}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.SrcPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.DestPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.SrcStorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.DestStorageName);
            
            this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
        }
        
        /// <summary>
        /// Check if file or folder exists 
        /// </summary>
        /// <param name="request">Specific request.<see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist"/></returns>            
        public ObjectExist ObjectExists(ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling ObjectExists");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/exist/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.VersionId);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (ObjectExist)SerializationHelper.Deserialize<ObjectExist>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Export an existing drawing to BMP format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingBmpRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/bmp";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to DXF format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingDXFRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingDXF(PostDrawingDXFRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingDXF");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingDXF");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/dxf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to Dwf format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingDwfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingDwf(PostDrawingDwfRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingDwf");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingDwf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/dwf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to Fbx format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingFbxRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingFbx(PostDrawingFbxRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingFbx");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingFbx");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/fbx";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing into GIF format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingGifRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/gif";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing into JPEG format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingJpegRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/jpeg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing into JPEG2000 format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingJpeg2000Request" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/jpeg2000";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to Obj format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingObjRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PostDrawingObj(PostDrawingObjRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.Name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PostDrawingObj");
            }

            // verify the required parameter 'options' is set
            if (request.Options == null) 
            {
                throw new ApiException(400, "Missing required parameter 'options' when calling PostDrawingObj");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/obj";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to PDF format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingPdfRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/pdf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing into PNG format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingPngRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/png";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Retrieves info about drawing which is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingPropertiesRequest" /></param>
        /// <returns><see cref="CadResponse"/></returns>            
        public CadResponse PostDrawingProperties(PostDrawingPropertiesRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PostDrawingProperties");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/properties";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            
            if (request.DrawingData != null) 
            {
                formParams.Add("drawingData", this.apiInvoker.ToFileInfo(request.DrawingData, "drawingData"));
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (CadResponse)SerializationHelper.Deserialize<CadResponse>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Export an existing drawing into PSD format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingPsdRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/psd";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Resize a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingResizeRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/resize";
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
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Rotate/flip a drawing. Drawing data is passed as a zero-indexed multipart/form-data content or as raw body stream. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingRotateFlipRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/rotateflip";
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
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export existing drawing to another format. Drawing data is passed as zero-indexed multipart/form-data content or as raw body stream.              
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingSaveAsRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/saveAs/{outputFormat}";
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
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to SVG format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingSvgRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/svg";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing into TIFF format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingTiffRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/tiff";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export an existing drawing to WMF format with export settings specified. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PostDrawingWmfRequest" /></param>
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
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/{name}/wmf";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.Name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.Folder);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "outPath", request.OutPath);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.Storage);
            var postBody = SerializationHelper.Serialize(request.Options);
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "POST", 
                postBody, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to BMP format. Drawing data is passed as zero-indexed multipart/form-data as well as export BMP options serialized as JSON. Order of drawing data and BMP options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingBmpRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingBmp(PutDrawingBmpRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingBmp");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/bmp";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to DXF format. Drawing data is passed as zero-indexed multipart/form-data as well as export DXF options serialized as JSON. Order of drawing data and DXF options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingDXFRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingDXF(PutDrawingDXFRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingDXF");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/dxf";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to Dwf format. Drawing data is passed as zero-indexed multipart/form-data as well as export Dwf options serialized as JSON. Order of drawing data and Dwf options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingDwfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingDwf(PutDrawingDwfRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingDwf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/dwf";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to Fbx format. Drawing data is passed as zero-indexed multipart/form-data as well as export Fbx options serialized as JSON. Order of drawing data and Fbx options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingFbxRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingFbx(PutDrawingFbxRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingFbx");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/fbx";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to GIF format. Drawing data is passed as zero-indexed multipart/form-data as well as export GIF options serialized as JSON. Order of drawing data and GIF options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingGifRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingGif(PutDrawingGifRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingGif");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/gif";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to JPEG format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG options serialized as JSON. Order of drawing data and JPEG options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingJpegRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingJpeg(PutDrawingJpegRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingJpeg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/jpeg";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to JPEG2000 format. Drawing data is passed as zero-indexed multipart/form-data as well as export JPEG2000 options serialized as JSON. Order of drawing data and JPEG2000 options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingJpeg2000Request" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingJpeg2000(PutDrawingJpeg2000Request request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingJpeg2000");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/jpeg2000";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to Obj format. Drawing data is passed as zero-indexed multipart/form-data as well as export Obj options serialized as JSON. Order of drawing data and Obj options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingObjRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingObj(PutDrawingObjRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingObj");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/obj";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to PDF format. Drawing data is passed as zero-indexed multipart/form-data as well as export PDF options serialized as JSON. Order of drawing data and PDF options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingPdfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPdf(PutDrawingPdfRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPdf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/pdf";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to PNG format. Drawing data is passed as zero-indexed multipart/form-data as well as export PNG options serialized as JSON. Order of drawing data and PNG options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingPngRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPng(PutDrawingPngRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPng");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/png";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to PSD format. Drawing data is passed as zero-indexed multipart/form-data as well as export PSD options serialized as JSON. Order of drawing data and PSD options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingPsdRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingPsd(PutDrawingPsdRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingPsd");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/psd";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to SVG format. Drawing data is passed as zero-indexed multipart/form-data as well as export SVG options serialized as JSON. Order of drawing data and SVG options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingSvgRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingSvg(PutDrawingSvgRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingSvg");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/svg";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to TIFF format. Drawing data is passed as zero-indexed multipart/form-data as well as export TIFF options serialized as JSON. Order of drawing data and TIFF options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingTiffRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingTiff(PutDrawingTiffRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingTiff");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/tiff";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Export drawing to WMF format. Drawing data is passed as zero-indexed multipart/form-data as well as export WMF options serialized as JSON. Order of drawing data and WMF options could vary. 
        /// </summary>
        /// <param name="request">Specific request.<see cref="PutDrawingWmfRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream PutDrawingWmf(PutDrawingWmfRequest request)
        {
            // verify the required parameter 'drawingData' is set
            if (request.DrawingData == null) 
            {
                throw new ApiException(400, "Missing required parameter 'drawingData' when calling PutDrawingWmf");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/wmf";
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
                formParams.Add("exportOptions", request.ExportOptions);
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            return response;
            
        }
        
        /// <summary>
        /// Check if storage exists 
        /// </summary>
        /// <param name="request">Specific request.<see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist"/></returns>            
        public StorageExist StorageExists(StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.StorageName == null) 
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/{storageName}/exist";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.StorageName);
            
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "GET", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (StorageExist)SerializationHelper.Deserialize<StorageExist>(StreamHelper.ToString(response));
        }
        
        /// <summary>
        /// Upload file 
        /// </summary>
        /// <param name="request">Specific request.<see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>            
        public FilesUploadResult UploadFile(UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.Path == null) 
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling UploadFile");
            }

            // create path and map variables
            var resourcePath = this.Configuration.GetApiRootUrl() + "/cad/storage/file/{path}";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.Path);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.StorageName);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            var response = this.apiInvoker.InvokeBinaryApi(
                resourcePath, 
                "PUT", 
                null, 
                null, 
                formParams);
            
            if (response == null)
            {
                return null;
            }
      
            return (FilesUploadResult)SerializationHelper.Deserialize<FilesUploadResult>(StreamHelper.ToString(response));
        }
        
        #endregion
    }
}
