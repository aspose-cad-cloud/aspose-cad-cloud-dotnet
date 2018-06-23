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

using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Text;
using Aspose.CAD.Cloud.Sdk.Model.Requests;
using Aspose.CAD.Cloud.Sdk.Test.Base;
using Com.Aspose.Storage.Model;
using Newtonsoft.Json.Serialization;
using NUnit.Framework;

namespace Aspose.CAD.Cloud.Sdk.Test.Api
{
    using System;
    using System.IO;

    using Aspose.CAD.Cloud.Sdk.Client;
    using Aspose.CAD.Cloud.Sdk.Model;
    using Com.Aspose.Storage.Api;

    using Newtonsoft.Json;

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
        protected const string LocalTestFolder = "..\\..\\..\\..\\TestData\\";

        /// <summary>
        /// The local test folder
        /// </summary>
        protected const string LocalReferenceFolder = "..\\..\\..\\..\\ReferenceData\\";

        /// <summary>
        /// The cloud test folder
        /// </summary>
        protected const string CloudTestFolder = "CloudTestDotNet";

        /// <summary>
        /// The cloud test source file sub folder
        /// </summary>
        protected const string CloudTestSourceSubFolder = "Common";

        /// <summary>
        /// The cloud references folder
        /// </summary>
        protected const string CloudReferencesFolder = "CloudTestReferences";

        /// <summary>
        /// The default storage
        /// </summary>
        protected const string DefaultStorage = "DefaultStorage";

        /// <summary>
        /// The size difference division
        /// </summary>
        protected const long SizeDiffDivision = 20;

        #endregion

        #region Fields

        protected List<FilesList.StorageFileInfo> InputTestFiles;

        /// <summary>
        /// Aspose.CAD API
        /// </summary>
        protected CADApi CadApi;

        /// <summary>
        /// Aspose.Storage API
        /// </summary>
        protected StorageApi StorageApi;

        /// <summary>
        /// The basic export formats
        /// </summary>
        protected readonly string[] BasicExportFormats = new string[]
        {
            "bmp",
            "jpg",
            "psd",
            "tiff",
            "gif",
            "png",
            "j2k",
            "wmf",
            "pdf"
        };

        #endregion

        #region Delegates

        /// <summary>
        /// Delegate that tests properties.
        /// </summary>
        /// <param name="originalProperties">The original properties.</param>
        /// <param name="resultProperties">The result properties.</param>
        protected delegate void PropertiesTesterDelegate(ImagePropertiesResponse originalProperties, ImagePropertiesResponse resultProperties);

        /// <summary>
        /// Typical GET request delegate that accepts image file name from Storage.
        /// </summary>
        /// <param name="fileName">File name of the image.</param>
        /// <param name="folder">Folder of the image.</param>
        /// <returns></returns>
        protected delegate Stream GetRequestInvokerDelegate(string fileName, string folder, string outPath);

        /// <summary>
        /// Typical POST request delegate that accepts input image stream.
        /// </summary>
        /// <param name="inputStream">The input image stream.</param>
        /// <returns></returns>
        protected delegate Stream PostRequestInvokerDelegate(Stream inputStream, string outPath);

        /// <summary>
        /// Custom response validator delegate
        /// </summary>
        /// <typeparam name="T">response type</typeparam>
        /// <param name="response">typed response</param>
        /// <param name="referenceInfo">etalon file info</param>
        protected delegate void ResponseValidatorDelegate<T>(T response, FilesList.StorageFileInfo referenceInfo);

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets a value indicating whether resulting images should be removed from cloud storage.
        /// </summary>
        /// <value>
        ///   <c>true</c> if resulting images should be removed from cloud storage; otherwise, <c>false</c>.
        /// </value>
        public bool RemoveResult { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [automatic recover reference] (i.e. if resulting images of failed tests are considered as new valid references).
        /// Please, change this value ONLY if you clearly understand the consequences, or it may lead to replacement of the images you need, so they will be lost.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [automatic recover reference]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoRecoverReference { get; set; } = false;

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
        protected void CreateApiInstances(string appKey = AppKey, string appSid = AppSid, string baseUrl = BaseUrl, string apiVersion = "v1.1",
            AuthType authType = AuthType.OAuth2, bool debug = false)
        {
            if (appKey == AppKey || appSid == AppSid || string.IsNullOrEmpty(baseUrl))
            {
                string serverAccessPath = Path.Combine(LocalTestFolder, ServerAccessFile);
                FileInfo serverFileInfo = new FileInfo(serverAccessPath);
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

            CadApi = new CADApi(appKey, appSid, baseUrl, apiVersion, authType, debug);
            StorageApi = new StorageApi(appKey, appSid, baseUrl + apiVersion);

#if GENERATE_TESTS_AND_REFERENCES
            UploadInputTestFiles(false);
#endif

            InputTestFiles = FetchInputTestFilesInfo();
        }

        private void EnsureDirectiryExists(string directoryPath, string storage)
        {
            ResponseMessage filesResponse = StorageApi.GetListFiles(directoryPath, storage);
            if (filesResponse == null)
            {
                StorageApi.PutCreateFolder(directoryPath, storage, storage);
            }
        }

        private void UploadInputTestFiles(bool forceOverride = false)
        {
            EnsureFilesExists(CloudTestFolder, DefaultStorage, LocalTestFolder, forceOverride);
            EnsureFilesExists(CloudReferencesFolder, DefaultStorage, LocalReferenceFolder, forceOverride);
        }

        private void EnsureFilesExists(string cloudFolder, string storage, string localFolder, bool forceOverride)
        {
            EnsureDirectiryExists(cloudFolder, storage);
            ResponseMessage filesResponse = StorageApi.GetListFiles(cloudFolder, storage);

            Assert.AreEqual(filesResponse.Code, (int)HttpStatusCode.OK);
            string responseFilesString = Encoding.UTF8.GetString(filesResponse.ResponseStream);
            List<FilesList.StorageFileInfo> files = JsonConvert.DeserializeObject<FilesList>(responseFilesString).Files;

            // skip files placed on root level!
            foreach (var dir in Directory.GetDirectories(Path.GetFullPath(localFolder)))
            {
                var dirInfo = new DirectoryInfo(dir);
                var cloudSubFolder = cloudFolder + "/" + dirInfo.Name;
                EnsureDirectiryExists(cloudSubFolder, storage);

                foreach (var file in Directory.GetFiles(Path.GetFullPath(dir), "*.*", SearchOption.TopDirectoryOnly))
                {
                    var fileInfo = new FileInfo(file);
                    var putInputFile = forceOverride;
                    if (CheckFileExistsOnCloud(fileInfo.Name, files))
                    {
                        if (forceOverride)
                        {
                            StorageApi.DeleteFile(fileInfo.Name, "", storage);
                        }
                    }
                    else
                    {
                        putInputFile = true;
                    }

                    if (putInputFile)
                    {
                        StorageApi.PutCreate(cloudSubFolder + "/" + fileInfo.Name, "", storage, File.ReadAllBytes(fileInfo.FullName));
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
        protected bool CheckFileExistsOnCloud(string inputFileName, ICollection<FilesList.StorageFileInfo> cloudFileInfos)
        {
            foreach (FilesList.StorageFileInfo storageFileInfo in cloudFileInfos)
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
        protected FilesList.StorageFileInfo GetStorageFileInfo(string folder, string fileName, string storage)
        {
            ResponseMessage fileListResponse = StorageApi.GetListFiles(folder, storage);
            FilesList references = JsonConvert.DeserializeObject<FilesList>(Encoding.UTF8.GetString(fileListResponse.ResponseStream));

            foreach (FilesList.StorageFileInfo storageFileInfo in references.Files)
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
        private List<FilesList.StorageFileInfo> FetchInputTestFilesInfo(string folder = "Common")
        {
            ResponseMessage filesResponse = StorageApi.GetListFiles(CloudTestFolder + "/" + folder, DefaultStorage);
            Assert.AreEqual(filesResponse.Code, (int)HttpStatusCode.OK);
            string responseString = Encoding.UTF8.GetString(filesResponse.ResponseStream);
            var filesList = JsonConvert.DeserializeObject<FilesList>(responseString);
            return filesList.Files;
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
            var inputDownloadResponse = StorageApi.GetDownload(inputPath, "", storage);
            Assert.AreEqual(inputDownloadResponse.Code, (int)HttpStatusCode.OK);
            using (MemoryStream ms = new MemoryStream(inputDownloadResponse.ResponseStream))
            {
                using (var response = requestInvoker.Invoke(ms, outPath))
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
        /// <param name="subfolder">The subfolder for both reference and input file.</param>
        /// <param name="requestInvoker">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRawGetRequest(
            string parametersLine, 
            string inputFileName, 
            string resultFileName, 
            string subfolder,
            GetRequestInvokerDelegate requestInvoker,
            string folder = CloudTestFolder, 
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine, 
                inputFileName, 
                resultFileName,
                subfolder,
                () =>
                {
                    var outPath = !string.IsNullOrEmpty(resultFileName) ? $"{folder}/{subfolder}/{resultFileName}" : null;
                    var stream = requestInvoker.Invoke($"{inputFileName}", $"{folder}/{CloudTestSourceSubFolder}", outPath);
                    return stream;
                },
                (stream, refInfo) =>
                {
                    long referenceLength = refInfo.Size;
                    CheckSizeDiff(referenceLength, stream.Length);
                },
                folder,
                storage);
        }

        /// <summary>
        /// Tests the typical GET request.
        /// </summary>
        /// <param name="parametersLine">The parameters line.</param>
        /// <param name="inputFileName">Name of the input file.</param>
        /// <param name="resultFileName">Name of the result file.</param>
        /// <param name="referenceSubfolder">The result reference subfolder.</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        protected void TestRawPostRequest(
            string parametersLine,
            string inputFileName,
            string resultFileName,
            string referenceSubfolder,
            PostRequestInvokerDelegate invokeRequestFunc,
            string folder = CloudTestFolder,
            string storage = DefaultStorage)
        {
            TestRequestInternal(
                parametersLine,
                inputFileName,
                resultFileName,
                referenceSubfolder,
                () =>
                {
                    using (var fs = File.OpenRead(Path.Combine(Path.Combine(LocalTestFolder, CloudTestSourceSubFolder), inputFileName)))
                    {
                        var stream = invokeRequestFunc.Invoke(fs, !string.IsNullOrEmpty(resultFileName) ? $"{folder}/{resultFileName}" : null);
                        return stream;
                    }
                },
                (stream, refInfo) =>
                {
                    long referenceLength = refInfo.Size;
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
                null,
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
        /// <param name="subfolder">The subfolder for reference and output file.</param>
        /// <param name="invokeRequestFunc">The invoke request function that returns response length.</param>
        /// <param name="customResponseTester">The response tester.</param>
        /// <param name="folder">The folder.</param>
        /// <param name="storage">The storage.</param>
        private void TestRequestInternal<T>(
            string parametersLine, 
            string inputFileName, 
            string resultFileName, 
            string subfolder,
            Func<T> invokeRequestFunc, 
            ResponseValidatorDelegate<T> customResponseTester,
            string folder = CloudTestFolder, 
            string storage = DefaultStorage)
        {
            Console.WriteLine(GetCallerMethodName());

            if (!CheckFileExistsOnCloud(inputFileName, InputTestFiles))
            {
                throw new ArgumentException(
                    $"Input file {inputFileName} doesn't exist in the specified storage folder: {folder}/{subfolder}. Please, upload it first.");
            }

            bool passed = false;
            string outPath = null;
            string referencePath = CloudReferencesFolder + "/" + subfolder;
            var saveResultToStorage = !string.IsNullOrEmpty(resultFileName);
            try
            {
                Console.WriteLine(parametersLine);

                if (saveResultToStorage)
                {
                    outPath = folder + "/" + subfolder + "/" + resultFileName;

                    // remove output file from the storage (if exists)
                    if (StorageApi.GetIsExist(outPath, "", storage).FileExist.IsExist)
                    {
                        StorageApi.DeleteFile(outPath, "", storage);
                    }
                }

                var response = invokeRequestFunc.Invoke();

#if GENERATE_TESTS_AND_REFERENCES
                var download = StorageApi.GetDownload(outPath, "", storage);
                if (!StorageApi.GetIsExist(referencePath + "/" + resultFileName, "", storage).FileExist.IsExist)
                {
                    StorageApi.PutCreate(referencePath + "/" + resultFileName, "", storage, download.ResponseStream);
                }
#endif

                if (saveResultToStorage)
                {
                    FilesList.StorageFileInfo resultInfo = GetStorageFileInfo(folder + "/" + subfolder, resultFileName, storage);
                    if (resultInfo == null)
                    {
                        throw new ArgumentException(
                            $"Result file {resultFileName} doesn't exist in the specified storage folder: {folder}. Result isn't present in the storage by an unknown reason.");
                    }
                }

                FilesList.StorageFileInfo referenceInfo = GetStorageFileInfo(referencePath, resultFileName, storage);
                if (referenceInfo == null)
                {
                    throw new ArgumentException(
                        $"Reference result file {resultFileName} doesn't exist in the specified storage folder: {referencePath}. Please, upload it first.");
                }

                // check resulting image from response stream
                customResponseTester?.Invoke(response, referenceInfo);

                passed = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if (saveResultToStorage && !passed && this.AutoRecoverReference && StorageApi.GetIsExist(outPath, "", storage).FileExist.IsExist)
                {
                    var moveFileResponse = StorageApi.PostMoveFile(outPath, referencePath + "/" + resultFileName, "", storage, storage);
                    Assert.AreEqual(moveFileResponse.Status, HttpStatusCode.OK.ToString());
                }
                else if (saveResultToStorage && this.RemoveResult && StorageApi.GetIsExist(outPath, "", storage).FileExist.IsExist)
                {
                    StorageApi.DeleteFile(outPath, "", storage);
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
