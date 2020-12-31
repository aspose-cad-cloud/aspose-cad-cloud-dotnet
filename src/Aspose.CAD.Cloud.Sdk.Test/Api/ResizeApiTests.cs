// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ResizeApiTests.cs">
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

namespace Aspose.CAD.Cloud.Sdk.Test.Api
{
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    using Aspose.CAD.Cloud.Sdk.Test.Base;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    ///  Class for testing ResizeApi
    /// </summary>
    [TestFixture]
    public class ResizeApiTests : ApiTester
    {
        /// <summary>
        /// One time setup before all unit tests
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            // you can pass your own parameters here
            this.CreateApiInstances();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test GetDrawingResize
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dwg", false)]
        [TestCase(".dxf", true)]
        public void GetDrawingResizeTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 100;
            int? newHeight = 150;
            string cloudFolder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (var inputFile in InputTestFiles)
            {
                if (inputFile.Name.EndsWith(formatExtension))
                {
                    name = inputFile.Name;
                }
                else
                {
                    continue;
                }

                foreach (string format in formatsToExport)
                {
                    outName = $"{name}_resize.{format}";

                    this.TestRawGetRequest(
                        $"input drawing: {name}; Output format: {format}; New width: {newWidth}; New height: {newHeight}",
                        name,
                        outName,
                        saveResultToStorage,
                        delegate (string outPath)
                        {
                            var request = new GetDrawingResizeRequest(name, format, newWidth, newHeight, cloudFolder, outPath, storage);

                            var stream = CadApi.GetDrawingResize(request);
                            return stream;
                        },
                        cloudFolder,
                        storage);

                    break;
                }
            }
        }

        /// <summary>
        /// Test PutDrawingResize
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dwg", false)]
        [TestCase(".dxf", true)]
        public void PostDrawingResizeTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            int? newWidth = 100;
            int? newHeight = 150;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>(this.BasicExportFormats);
            foreach (string additionalExportFormat in additionalExportFormats)
            {
                if (!formatsToExport.Contains(additionalExportFormat))
                {
                    formatsToExport.Add(additionalExportFormat);
                }
            }

            foreach (var inputFile in InputTestFiles)
            {
                if (inputFile.Name.EndsWith(formatExtension))
                {
                    name = inputFile.Name;
                }
                else
                {
                    continue;
                }

                foreach (string format in formatsToExport)
                {
                    outName = $"{name}_resize.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}; New width: {newWidth}; New height: {newHeight}",
                        name,
                        outName,
                        saveResultToStorage,
                        delegate (Stream inputStream, string outPath)
                        {
                            var request = new PostDrawingResizeRequest(inputStream, format, newWidth, newHeight, outPath, storage);
                            return CadApi.PostDrawingResize(request);
                        },
                        folder,
                        storage);

                    break;
                }
            }
        }
    }
}
