// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="LiveApi.cs">
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

namespace Aspose.CAD.Cloud.Sdk.Test.Api
{
    using System.Collections.Generic;
    using System.IO;
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    using NUnit.Framework;

    /// <summary>
    ///  Class for testing SaveAsApi
    /// </summary>
    [TestFixture]
    public class LiveApiTests : ApiTester
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
        /// Conversion operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".png")]
        public void PaperToCadTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { "dxf" };

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
                    outName = $"{name}_live_api_paper_to_cad.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new PaperToCadRequest(inputStream, format);
                            return CadApi.PaperToCad(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Conversion operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void ConvertTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { "pdf", "png" };

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
                    outName = $"{name}_live_api_convert.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new ConvertRequest(inputStream, format);
                            return CadApi.Convert(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Watermark operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void WatermarkTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            var watermarkRgb = new WatermarkRGB()
            {
                Text = "watermark",
                R = 255,
                G = 0,
                B = 0
            };

            List<string> formatsToExport = new List<string>() { "pdf", "png" };

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
                    outName = $"{name}_live_api_watermark.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new WatermarkRequest(inputStream,
                                format,
                                JsonConvert.SerializeObject(watermarkRgb));
                            return CadApi.Watermark(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Extract Text operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void ExtractTextTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { "txt" };

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
                    outName = $"{name}_live_api_extract_text.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new ExtractTextRequest(inputStream);
                            return CadApi.ExtractText(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Extract metadata operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void ExtractMetadataTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { "txt", "json", "xml" };

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
                    outName = $"{name}_live_api_extract_metadata.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new ExtractMetadataRequest(inputStream, format);
                            return CadApi.ExtractMetadata(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Get metadata operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void PostEditMetadataTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            List<string> formatsToExport = new List<string>() { "json" };

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
                    outName = $"{name}_live_api_post_edit_metadata.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new EditMetadataRequest(inputStream);
                            return CadApi.EditMetadata(request);
                        },
                        folder,
                        storage);
                }
            }
        }

        /// <summary>
        /// Save metadata operation test, sending input data in request stream.
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input drawings in the test folder</param>
        [TestCase(".dxf")]
        public void PutEditMetadataTest(string formatExtension)
        {
            string name = null;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;
            string outName = null;

            var dxfMetadata =
                "{\"Name\":\"DxfImage\",\"Level\":0,\"Components\":[{\"Name\":\"SummaryInfoWrapper\",\"Level\":0,\"Components\":[{\"Name\":\"Title\",\"Value\":\"TestValue\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"Subject\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"Author\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"Keywords\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"Comments\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"LastSavedBy\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"RevisionNumber\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"HyperlinkBase\",\"Type\":\"String\",\"Level\":0,\"Components\":[]},{\"Name\":\"EditingTime\",\"Value\":\"01:59:54.7930000\",\"Type\":\"TimeSpan\",\"Level\":0,\"Components\":[]},{\"Name\":\"CreateDateTime\",\"Value\":\"1888-04-12T07:59:59\",\"Type\":\"DateTime\",\"Level\":0,\"Components\":[]},{\"Name\":\"ModifiedDateTime\",\"Value\":\"1998-03-26T10:23:29\",\"Type\":\"DateTime\",\"Level\":0,\"Components\":[]},{\"Name\":\"CreateDateTimeUtc\",\"Type\":\"DateTime\",\"Level\":0,\"Components\":[]},{\"Name\":\"ModifiedDateTimeUtc\",\"Type\":\"DateTime\",\"Level\":0,\"Components\":[]}]}]}";

            List<string> formatsToExport = new List<string>() { "dxf" };

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
                    outName = $"{name}_live_api_put_edit_metadata.{format}";

                    this.TestRawPostRequest(
                        $"input drawing: {name}; Output format: {format}",
                        name,
                        outName,
                        false,
                        delegate(Stream inputStream, string outPath)
                        {
                            var request = new PutEditMetadataRequest(inputStream, dxfMetadata);
                            return CadApi.PutEditMetadata(request);
                        },
                        folder,
                        storage);
                }
            }
        }
    }
}