// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiTester.cs">
//   Copyright (c) 2018 Aspose.CAD for Cloud
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using Aspose.CAD.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.CAD.Cloud.Sdk.Test.Base
{
    /// <summary>
    /// Base class for API tester
    /// </summary>
    public abstract class ApiTester
    {
        #region Consts

        /// <summary>
        /// The server access file
        /// </summary>
        private const string ServerAccessFile = "serverAccess.json";

        /// <summary>
        /// The application key
        /// </summary>
        private const string AppKey = "xxx";

        /// <summary>
        /// The application SID
        /// </summary>
        private const string AppSid = "xxx";

        /// <summary>
        /// The base URL
        /// </summary>
        private const string BaseUrl = "http://api.aspose.cloud/";

        /// <summary>
        /// The local test folder
        /// </summary>
        protected const string LocalTestFolder = @"TestData";

        /// <summary>
        /// The local test folder
        /// </summary>
        protected const string LocalReferenceFolder = @"ReferenceData";

        /// <summary>
        /// The cloud test folder
        /// </summary>
        protected const string CloudTestFolder = "CloudTestDotNet";

        /// <summary>
        /// The cloud references folder
        /// </summary>
        protected const string CloudReferencesFolder = "CloudTestDotNetReferences";

        /// <summary>
        /// The cloud temp folder
        /// </summary>
        protected const string CloudTempFolder = "Temp";

        /// <summary>
        /// The default storage
        /// </summary>
        protected const string DefaultStorage = "CAD-QA";

        /// <summary>
        /// The size difference division
        /// </summary>
        protected const long SizeDiffDivision = 20;

        #endregion

        protected static string LocalTestFolderFullPath => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), LocalTestFolder);

        protected static string LocalReferenceFolderFullPath => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), LocalReferenceFolder);

        #region Fields

        protected List<FileResponse> InputTestFiles;

        /// <summary>
        /// Aspose.CAD API
        /// </summary>
        protected CadApi CadApi;

        /// <summary>
        /// Aspose.Storage API
        /// </summary>
        protected StorageApi StorageApi;

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether resulting images should be removed from cloud storage.
        /// </summary>
        /// <value>
        ///   <c>true</c> if resulting images should be removed from cloud storage; otherwise, <c>false</c>.
        /// </value>
        public bool RemoveResult { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [automatic recover reference] (i.e. if resulting images of failed tests are considered as new valid references).
        /// Please, change this value ONLY if you clearly understand the consequences, or it may lead to replacement of the images you need, so they will be lost.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic recover reference]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoRecoverReference => bool.Parse(Environment.GetEnvironmentVariable("ReuploadTestData") ?? bool.FalseString);

        /// <summary>
        /// Forces reference file to be re-uploaded even if exists
        /// </summary>
        public bool ForceReferenceOverride => bool.Parse(Environment.GetEnvironmentVariable("UpdateTestData") ?? bool.FalseString);

        #endregion

        /// <summary>
        /// The basic export formats
        /// </summary>
        protected readonly string[] BasicExportFormats = new string[]
        {
            "jpg",
            "bmp",
            "psd",
            "tiff",
            "gif",
            "png",
            "j2k",
            "wmf",
            "pdf",
            "svg"
        };

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate that tests properties.
        /// </summary>
        /// <param name="originalProperties">The original properties.</param>
        /// <param name="resultProperties">The result properties.</param>
        protected delegate void PropertiesTesterDelegate(CadResponse originalProperties, CadResponse resultProperties);

        /// <summary>
        /// Typical GET request delegate that accepts image file name from Storage.
        /// </summary>
        /// <param name="fileName">File name of a drawing.</param>
        /// <returns></returns>
        protected delegate Stream GetRequestInvokerDelegate(string outPath);

        /// <summary>
        /// Typical POST request delegate that accepts input drawing stream.
        /// </summary>
        /// <param name="inputStream">The input drawing stream.</param>
        /// <returns></returns>
        protected delegate Stream PostRequestInvokerDelegate(Stream inputStream, string outPath);

        /// <summary>
        /// POST request delegate that accepts input drawing file name and export options which will be serialized as JSON.
        /// </summary>
        /// <param name="fileName">File name of a drawing.</param>
        /// /// <param name="exportOptions">The export options.</param>
        /// <returns></returns>
        protected delegate Stream PostRequestWithOptionsInvokerDelegate<T>(T exportOptions, string outPath) where T: DrawingOptionsBaseDTO;

        /// <summary>
        /// Typical PUT request delegate that accepts input drawing stream and export options which will be serialized as JSON.
        /// </summary>
        /// <param name="inputStream">The input drawing stream.</param>
        /// /// <param name="exportOptions">The export options.</param>
        /// <returns></returns>
        protected delegate Stream PutRequestInvokerDelegate(Stream inputStream, DrawingOptionsBaseDTO exportOptions, string outPath);

        /// <summary>
        /// Custom response validator delegate
        /// </summary>
        /// <typeparam name="T">response type</typeparam>
        /// <param name="response">typed response</param>
        /// <param name="referenceInfo">etalon file info</param>
        protected delegate void ResponseValidatorDelegate<T>(T response, Stream resultStream, FileResponse referenceInfo);

        #endregion

        #region Methods

        /// <summary>
        /// Creates the API instances using given access parameters.
        /// </summary>
        /// <param name="appKey">The application key.</param>
        /// <param name="appSid">The application sid.</param>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="apiVersion">The API version.</param>
        /// <param name="authType">Type of the authentication.</param>
        /// <param name="debug">if set to <c>true</c> [debug].</param>
        /// <exception cref="System.ArgumentException">Please, specify valid access data (AppKey, AppSid, Base URL)</exception>
        protected void CreateApiInstances(
            string appKey = AppKey, string appSid = AppSid, string baseUrl = BaseUrl, 
            Configuration.AvailiableApiVersions apiVersion = Configuration.AvailiableApiVersions.V3, 
            AuthType authType = AuthType.OAuth2, bool debug = true)
        {
            if (appKey == AppKey || appSid == AppSid || string.IsNullOrEmpty(baseUrl))
            {
                string serverAccessPath = Path.Combine(LocalTestFolderFullPath, ServerAccessFile);

                FileInfo serverFileInfo = new FileInfo( serverAccessPath);
                if (serverFileInfo.Exists && serverFileInfo.Length > 0)
                {
                    var accessData = JsonConvert.DeserializeObject<ServerAccessData>(File.ReadAllText(serverAccessPath));
                    appKey = accessData.AppKey;
                    appSid = accessData.AppSid;
                    baseUrl = accessData.BaseURL;
                }
                else
                {
                    throw new ArgumentException("Please, specify valid access data (AppKey, AppSid, Base URL)");
                }
            }

            CadApi = new CadApi(new Configuration()
            {
                ApiBaseUrl =
#if LOCAL
                    "https://localhost:44350",
#else
                    baseUrl,
#endif
                AppKey = appKey,
                AppSid = appSid,
                AuthType = authType,
                DebugMode = debug,
                Version = apiVersion
            });

            StorageApi = new StorageApi(new Storage.Cloud.Sdk.Configuration()
            {
                ApiBaseUrl = baseUrl,
                AppKey = appKey,
                AppSid = appSid,
                DebugMode = debug,
                AuthType = (Storage.Cloud.Sdk.Api.AuthType)(int)authType
            });

            RemoveSigningRequestHandler(StorageApi);

            UploadInputTestFiles(false);

            InputTestFiles = FetchInputTestFilesInfo().ToList();
        }

        private void RemoveSigningRequestHandler(StorageApi storageApi)
        {
            var apiInvokerField = storageApi.GetType().GetField("apiInvoker", BindingFlags.Instance | BindingFlags.NonPublic);
            var apiInvoker = apiInvokerField.GetValue(storageApi);
            var requestHandlersField = apiInvoker.GetType().GetField("requestHandlers", BindingFlags.Instance | BindingFlags.NonPublic);
            var list = requestHandlersField.GetValue(apiInvoker) as IList;
            if (list.Count == 4)
            {
                list.RemoveAt(list.Count - 1);
            }
        }

        private void EnsureDirectiryExists(string directoryPath, string storage)
        {
            var filesResponse = StorageApi.GetListFiles(new GetListFilesRequest(directoryPath, storage));
            if (filesResponse == null)
            {
                StorageApi.PutCreateFolder(new PutCreateFolderRequest(directoryPath, storage, storage));
            }
        }

        private void UploadInputTestFiles(bool forceOverride = false)
        {
            if (ForceReferenceOverride)
            {
                Directory.CreateDirectory(LocalReferenceFolderFullPath);
                EnsureFilesExists(CloudTestFolder, DefaultStorage, LocalTestFolderFullPath, forceOverride);
                EnsureFilesExists(CloudReferencesFolder, DefaultStorage, LocalReferenceFolderFullPath, forceOverride);
            }
        }

        private void EnsureFilesExists(string cloudFolder, string storage, string localFolder, bool forceOverride)
        {
            EnsureDirectiryExists(cloudFolder, storage);
            var filesResponse = StorageApi.GetListFiles(new GetListFilesRequest(cloudFolder, storage));

            Assert.AreEqual(filesResponse.Code, (int)HttpStatusCode.OK);
            var files = filesResponse.Files;

            foreach (var file in Directory.GetFiles(Path.GetFullPath(localFolder), "*.*", SearchOption.TopDirectoryOnly))
            {
                if (file.ToLower().EndsWith(".json"))
                {
                    continue;
                }

                var fileInfo = new FileInfo(file);
                var fullStorageFileName =
                    string.IsNullOrEmpty(cloudFolder) ? fileInfo.Name : cloudFolder + "\\" + fileInfo.Name;

                var putInputFile = forceOverride;
                if (CheckFileExistsOnCloud(fileInfo.Name, files))
                {
                    if (forceOverride)
                    {
                        StorageApi.DeleteFile(new DeleteFileRequest(fullStorageFileName, "", storage));
                    }
                }
                else
                {
                    putInputFile = true;
                }

                if (putInputFile)
                {
                    using (var fs = File.OpenRead(fileInfo.FullName))
                    {
                        StorageApi.PutCreate(new PutCreateRequest(fullStorageFileName, fs, null, storage));
                    }
                }
            }
        }

        /// <summary>
        /// Checks the size difference.
        /// </summary>
        /// <param name="size1">The size 1.</param>
        /// <param name="size2">The size 2.</param>
        /// <param name="diffDivision">The difference division.</param>
        /// <exception cref="System.Exception">Size differs by more than {100 / diffDivision}%</exception>
        protected void CheckSizeDiff(long size1, long size2, long diffDivision = SizeDiffDivision)
        {
            long avg = (size1 + size2) / 2;
            long diffVal = avg / diffDivision;
            if (Math.Abs(size1 - size2) > diffVal)
            {
                throw new Exception($"Size differs by more than {100 / diffDivision}%: {size1} bytes VS {size2} bytes");
            }
        }

        /// <summary>
        /// Checks if input file exists.
        /// </summary>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="cloudFileInfos">cloud files metadata</param>
        /// <returns></returns>
        protected bool CheckFileExistsOnCloud(string inputFileName, ICollection<FileResponse> cloudFileInfos)
        {
            foreach (var storageFileInfo in cloudFileInfos)
            {
                if (storageFileInfo.Name == inputFileName)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the storage file information.
        /// </summary>
        /// <param name="folder">The folder which contains a file.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="storage">The storage.</param>
        /// <returns></returns>
        protected FileResponse GetStorageFileInfo(string folder, string fileName, string storage)
        {
            var fileListResponse = StorageApi.GetListFiles(new GetListFilesRequest(folder, storage));

            foreach (var storageFileInfo in fileListResponse.Files)
            {
                if (storageFileInfo.Name == fileName)
                {
                    return storageFileInfo;
                }
            }

            return null;
        }

        /// <summary>
        /// Fetches the input test files info.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<FileResponse> FetchInputTestFilesInfo()
        {
            if (StorageApi.GetIsExist(
                    new GetIsExistRequest(CloudTempFolder, null, DefaultStorage)).FileExist.IsExist != true)
            {
                StorageApi.PutCreateFolder(new PutCreateFolderRequest(CloudTempFolder, DefaultStorage));
            }

            if (StorageApi.GetIsExist(
                    new GetIsExistRequest(CloudTestFolder, null, DefaultStorage)).FileExist.IsExist != true)
            {
                StorageApi.PutCreateFolder(new PutCreateFolderRequest(CloudTestFolder, DefaultStorage));
            }

            if (StorageApi.GetIsExist(
                    new GetIsExistRequest(CloudReferencesFolder, null, DefaultStorage)).FileExist.IsExist != true)
            {
                StorageApi.PutCreateFolder(new PutCreateFolderRequest(CloudReferencesFolder, DefaultStorage));
            }

#if LOCAL
            if (!Directory.Exists(LocalReferenceFolderFullPath))
            {
                Directory.CreateDirectory(LocalReferenceFolderFullPath);
            }

            return Directory
                .EnumerateFiles(LocalTestFolderFullPath, "*.*", SearchOption.TopDirectoryOnly)
                .Where(x => Path.GetExtension(x) != ".js")
                .Select(x => Path.GetFileName(x))
                .Select(x => new FileResponse()
                {
                    Name = x
                });
#endif

            var filesResponse = StorageApi.GetListFiles(new GetListFilesRequest(CloudTestFolder, DefaultStorage));
            
            return filesResponse?.Files;
        }

        /// <summary>
        /// Obtains the length of the typical POST request response.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <param name="requestInvoker">The request invoker.</param>
        /// <param name="outPath">The output path to save the result.</param>
        /// <param name="storage">The storage.</param>
        /// <returns></returns>
        private long ObtainPostResponseLength(string inputPath, string outPath, string storage, PostRequestInvokerDelegate requestInvoker)
        {
            var inputDownloadResponse = StorageApi.GetDownload(new GetDownloadRequest(inputPath, null, storage));

            using (inputDownloadResponse)
            {
                using (var response = requestInvoker.Invoke(inputDownloadResponse, outPath))
                {
                    if (string.IsNullOrEmpty(outPath))
                    {
                        Assert.NotNull(response);
                        return response.Length;
                    }

                    return 0;
                }
            }
        }

        /// <summary>
        /// Tests the typical GET request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="requestInvoker">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRawGetRequest(
            string parametersLine, 
            string inputFileName, 
            string resultFileName, 
            bool saveResultToStorage,
            GetRequestInvokerDelegate requestInvoker,
            string folder = CloudTestFolder, 
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine, 
                inputFileName, 
                resultFileName,
                saveResultToStorage,
                () =>
                {
                    var stream = requestInvoker.Invoke(saveResultToStorage ? $"{CloudTempFolder}/{resultFileName}" : null);
                    return stream;
                },
                (_, stream, refInfo) =>
                {
                    var referenceLength = refInfo.Size ?? 0;
                    CheckSizeDiff(referenceLength, stream.Length);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical POST request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRawPostRequest(
            string parametersLine,
            string inputFileName,
            string resultFileName,
            bool saveResultToStorage,
            PostRequestInvokerDelegate invokeRequestFunc,
            string folder = CloudTestFolder,
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine,
                null,
                resultFileName,
                saveResultToStorage,
                () =>
                {
                    using (var fs = File.OpenRead(Path.Combine(LocalTestFolderFullPath, inputFileName)))
                    {
                        var stream = invokeRequestFunc.Invoke(fs, saveResultToStorage ? $"{CloudTempFolder}/{resultFileName}" : null);
                        return stream;
                    }
                },
                (_, stream, refInfo) =>
                {
                    var referenceLength = refInfo.Size ?? 0;
                    CheckSizeDiff(referenceLength, stream.Length);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical POST request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="exportOptions">Export options</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestPostWithOptionsRequest<T>(
            string parametersLine,
            string inputFileName,
            string resultFileName,
            bool saveResultToStorage,
            T exportOptions,
            PostRequestWithOptionsInvokerDelegate<T> invokeRequestFunc,
            string folder = CloudTestFolder,
            string storage = DefaultStorage) where T: DrawingOptionsBaseDTO
        {
            TestRequestInternal(
                parametersLine,
                null,
                resultFileName,
                saveResultToStorage,
                () =>
                {
                    var stream = invokeRequestFunc.Invoke(exportOptions, saveResultToStorage ? $"{CloudTempFolder}/{resultFileName}" : null);
                    return stream;
                },
                (_, stream, refInfo) =>
                {
                    var referenceLength = refInfo.Size ?? 0;
                    CheckSizeDiff(referenceLength, stream.Length);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical PUT request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="exportOptions">Export options</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRawPutRequest(
            string parametersLine,
            string inputFileName,
            string resultFileName,
            bool saveResultToStorage,
            DrawingOptionsBaseDTO exportOptions,
            PutRequestInvokerDelegate invokeRequestFunc,
            string folder = CloudTestFolder,
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine,
                null,
                resultFileName,
                saveResultToStorage,
                () =>
                {
                    using (var fs = File.OpenRead(Path.Combine(LocalTestFolderFullPath, inputFileName)))
                    {
                        var ms = new MemoryStream();
                        fs.CopyTo(ms);
                        ms.Seek(0, SeekOrigin.Begin);

                        var stream = invokeRequestFunc.Invoke(ms, exportOptions, saveResultToStorage ? $"{CloudTempFolder}/{resultFileName}" : null);
                        return stream;
                    }
                },
                (_, stream, refInfo) =>
                {
                    var referenceLength = refInfo.Size ?? 0;
                    CheckSizeDiff(referenceLength, stream.Length);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="customResponseTester">The response tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRequestWithTypedResponse<T>(
            string parametersLine,
            string inputFileName,
            Func<T> invokeRequestFunc,
            ResponseValidatorDelegate<T> customResponseTester,
            string folder = CloudTestFolder,
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine,
                inputFileName,
                null,
                false,
                () =>
                {
                    var response = invokeRequestFunc.Invoke();
                    return response;
                },
                customResponseTester,
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="customResponseTester">The response tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        private void TestRequestInternal<T>(
            string parametersLine, 
            string inputFileName, 
            string resultFileName, 
            bool saveResultToStorage,
            Func<T> invokeRequestFunc, 
            ResponseValidatorDelegate<T> customResponseTester,
            string folder = CloudTestFolder, 
            string storage = DefaultStorage)
        {
            Console.WriteLine(GetCallerMethodName());

            if (!string.IsNullOrEmpty(inputFileName) && !CheckFileExistsOnCloud(inputFileName, InputTestFiles))
            {
                throw new ArgumentException(
                    $"Input file {inputFileName} doesn't exist in the specified storage folder: {folder}. Please, upload it first.");
            }

            bool passed = false;
            string outPath = null;
            string referencePath = CloudReferencesFolder;
            try
            {
                Console.WriteLine(parametersLine);

                if (saveResultToStorage)
                {
                    outPath = CloudTempFolder + "/" + resultFileName;

                    // remove output file from the storage (if exists)
                    if (StorageApi.GetIsExist(new GetIsExistRequest(outPath, null, storage)).FileExist.IsExist ?? false)
                    {
                        StorageApi.DeleteFile(new DeleteFileRequest(outPath, null, storage));
                    }
                }

                var response = invokeRequestFunc.Invoke();

                var download = saveResultToStorage
                                    ? StorageApi.GetDownload(new GetDownloadRequest(outPath, null, storage))
                                    : response as Stream;

                if (AutoRecoverReference && download != null)
                {
                    var hasToUpload = ForceReferenceOverride;
                    if (!StorageApi.GetIsExist(new GetIsExistRequest(referencePath + "/" + resultFileName, null, storage)).FileExist.IsExist ?? false)
                    {
                        hasToUpload = true;
                    }
                    else if (ForceReferenceOverride)
                    {
                        hasToUpload = true;
                        StorageApi.DeleteFile(new DeleteFileRequest(referencePath + "/" + resultFileName, null, storage));
                    }

                    if (hasToUpload)
                    {
                        StorageApi.PutCreate(new PutCreateRequest(referencePath + "/" + resultFileName, download, null, storage));
                    }

#if DEBUG
                    if (!string.IsNullOrEmpty(resultFileName) && download != null)
                    {
                        using (var fs = File.OpenWrite(Path.Combine(LocalReferenceFolderFullPath, resultFileName)))
                        {
                            download.CopyTo(fs);
                        }
                    }
#endif
                }

                if (saveResultToStorage)
                {
                    var resultInfo = GetStorageFileInfo(CloudTempFolder, resultFileName, storage);
                    if (resultInfo == null)
                    {
                        throw new ArgumentException(
                            $"Result file {resultFileName} doesn't exist in the specified storage folder: {folder}. Result isn't present in the storage by an unknown reason.");
                    }
                }

                var referenceInfo = GetStorageFileInfo(referencePath, resultFileName, storage);
                if (!string.IsNullOrEmpty(outPath) && referenceInfo == null)
                {
                    throw new ArgumentException(
                        $"Reference result file {resultFileName} doesn't exist in the specified storage folder: {referencePath}. Please, upload it first.");
                }

                // check resulting image from response stream
                customResponseTester?.Invoke(response, download, referenceInfo);

                passed = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (saveResultToStorage 
                    && !passed 
                    && this.AutoRecoverReference 
                    && (StorageApi.GetIsExist(new GetIsExistRequest(outPath, null, storage)).FileExist.IsExist ?? false))
                {
                    var moveFileResponse = StorageApi.PostMoveFile(new PostMoveFileRequest(outPath, referencePath + "/" + resultFileName, null, storage, storage));
                    Assert.AreEqual(moveFileResponse.Status, HttpStatusCode.OK.ToString());
                }
                else if (saveResultToStorage 
                         && this.RemoveResult 
                         && (StorageApi.GetIsExist(new GetIsExistRequest(outPath, null, storage)).FileExist.IsExist ?? false))
                {
                    StorageApi.DeleteFile(new DeleteFileRequest(outPath, null, storage));
                }

                Console.WriteLine($"Test passed: {passed}");
            }
        }

        private static string GetCallerMethodName()
        {
            StackTrace st = new StackTrace();
            var frameNumber = 1;
            while (true)
            {
                var sf = st.GetFrame(frameNumber++);
                var typeName = sf.GetMethod().DeclaringType.Name;
                if (typeName != typeof(ApiTester).Name)
                {
                    return sf.GetMethod().Name;
                }
            }
        }

#endregion
    }
}
