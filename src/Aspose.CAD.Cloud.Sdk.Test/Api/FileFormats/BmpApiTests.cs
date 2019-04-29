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

using Aspose.CAD.Cloud.Sdk.Model;
using Aspose.CAD.Cloud.Sdk.Test.Base;
using Newtonsoft.Json;

namespace Aspose.CAD.Cloud.Sdk.Test.Api.FileFormats
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;

    /// <summary>
    ///  Class for testing SaveAsApi
    /// </summary>
    [TestFixture]
    public class BmpApiTests : ApiTester
    {
        private const string OutputFormatExtension = "bmp";

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
        /// Performs Bmp (export to BMP format) operation test with POST method, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
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
        [TestCase(".cf2", false)]
        [TestCase(".cf2", true)]
        [TestCase(".dwt", false)]
        [TestCase(".dwt", true)]
        public void PostDrawingSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { OutputFormatExtension };

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

                var exportOptions = new BmpOptionsDTO()
                {
                    VectorRasterizationOptions = new CadRasterizationOptionsDTO()
                    {
                        PageHeight = 200,
                        PageWidth = 300
                    }
                };

                foreach (string format in formatsToExport)
                {
                    outName = $"{name}_opts.{format}";

                    this.TestPostWithOptionsRequest(
                        $"Input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        saveResultToStorage,
                        exportOptions,
                        delegate (BmpOptionsDTO options, string outPath)
                        {
                            var request = new PostDrawingBmpRequest(name, options, folder, outPath, storage);
                            return CadApi.PostDrawingBmp(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Performs Bmp (export to BMP format) operation test with PUT method, sending input data and export options serialized as JSON as multipart/form-data.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
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
        [TestCase(".cf2", false)]
        [TestCase(".cf2", true)]
        [TestCase(".dwt", false)]
        [TestCase(".dwt", true)]
        public void PutDrawingSaveAsTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { OutputFormatExtension };

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

                var exportOptions = new BmpOptionsDTO()
                {
                    VectorRasterizationOptions = new CadRasterizationOptionsDTO()
                    {
                        PageHeight = 200,
                        PageWidth = 300
                    }
                };

                foreach (string format in formatsToExport)
                {
                    outName = $"{name}_opts.{format}";

                    this.TestRawPutRequest(
                        $"Input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        saveResultToStorage,
                        exportOptions,
                        delegate (Stream inputStream, DrawingOptionsBaseDTO options, string outPath)
                        {
                            var request = new PutDrawingBmpRequest(inputStream, outPath, JsonConvert.SerializeObject(exportOptions), storage);
                            return CadApi.PutDrawingBmp(request);
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}
