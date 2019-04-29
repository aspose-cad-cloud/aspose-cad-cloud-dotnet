// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsApiTests.cs">
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
	using System.IO;
	using System.Collections.Generic;
	using NUnit.Framework;

	using Aspose.CAD.Cloud.Sdk.Model.Requests;
	using Aspose.CAD.Cloud.Sdk.Test.Base;

    /// <summary>
    ///  Class for testing SaveAsApi
    /// </summary>
    [TestFixture]
    public class SaveAsApiTests : ApiTester
    {
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
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
        /// Performs SaveAs (export to another format) operation test with GET method, taking input data from storage.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If resulting image should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dwg", false)]
        [TestCase(".dwg", true)]
        [TestCase(".dxf", true)]
        [TestCase(".dxf", false)]
        [TestCase(".dgn", true)]
        [TestCase(".dgn", false)]
        [TestCase(".stl", true)]
        [TestCase(".stl", false)]
        [TestCase(".ifc", true)]
        [TestCase(".ifc", false)]
        [TestCase(".dwf", true)]
        [TestCase(".dwf", false)]
        public void GetImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
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
                    outName = $"{name}.{format}";

                    this.TestRawGetRequest(
                        $"Input image: {name}; Output format: {format}",
                        name,
                        outName,
                        delegate (string fileName, string folder, string outPath)
                        {
                            var request = new GetImageSaveAsRequest(fileName, format, folder, storage, null, outPath);
                            return CadApi.GetImageSaveAs(request);
                        },
                        cloudFolder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Performs SaveAs (export to another format) operation test with POST method, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If resulting image should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dwg", false)]
        [TestCase(".dwg", true)]
        [TestCase(".dxf", false)]
        [TestCase(".dxf", true)]
        [TestCase(".dgn", false)]
        [TestCase(".dgn", true)]
        [TestCase(".stl", false)]
        [TestCase(".stl", true)]
        [TestCase(".ifc", false)]
        [TestCase(".ifc", true)]
        [TestCase(".dwf", false)]
        [TestCase(".dwf", true)]
        public void PostImageSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
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
                    outName = $"{name}.{format}";

                    this.TestRawPostRequest(
                        $"Input image: {name}; Output format: {format}",
                        name,
                        outName,
                        delegate (Stream inputStream, string outPath)
                        {
                            var request = new PostImageSaveAsRequest(inputStream, format, null, outPath, storage);
                            return CadApi.PostImageSaveAs(request);
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}
