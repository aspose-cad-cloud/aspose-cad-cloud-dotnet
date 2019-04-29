// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RotateFlipApiTests.cs">
//   Copyright (c) 2018 Aspose.Imaging for Cloud
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
using Aspose.CAD.Cloud.Sdk.Model.Requests;
using Aspose.CAD.Cloud.Sdk.Test.Base;

namespace Aspose.CAD.Cloud.Sdk.Test.Api
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using NUnit.Framework;

    /// <summary>
    ///  Class for testing RotateFlipApi
    /// </summary>
    [TestFixture]
    public class RotateFlipApiTests : ApiTester
    {
        private readonly string[] _rotateFlipMethods = new[]
        {
            "Rotate180FlipNone", "Rotate180FlipX", "Rotate180FlipXY", "Rotate180FlipY", "Rotate270FlipNone", "Rotate270FlipX",
            "Rotate270FlipXY", "Rotate270FlipY", "Rotate90FlipNone", "Rotate90FlipX", "Rotate90FlipXY", "Rotate90FlipY",
            "RotateNoneFlipNone", "RotateNoneFlipX", "RotateNoneFlipXY", "RotateNoneFlipY"
        };

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
        /// Test GetImageRotateFlip
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dxf", true)]
        public void GetImageRotateFlipTest(
            string formatExtension, 
            bool saveResultToStorage,
            params string[] additionalExportFormats)
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
                    foreach (var method in _rotateFlipMethods)
                    {
                        outName = $"{name}_{method}.{format}";

                        this.TestRawGetRequest(
                            $"Input image: {name}; Output format: {format}; Method: {method}",
                            name,
                            outName,
                            delegate (string fileName, string folder, string outPath)
                            {
                                var request = new GetImageRotateFlipRequest(fileName, format, method, folder, storage, outPath);
                                return CadApi.GetImageRotateFlip(request);
                            },
                            cloudFolder,
                            storage);
                    }

                    break;
                }
            }
        }

        /// <summary>
        /// Test PostImageRotateFlip
        /// </summary>
        /// <param name="formatExtension">Format extension to search for input images in the test folder</param>
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// <param name="additionalExportFormats">Additional formats to export to</param>
        [TestCase(".dwg", true)]
        public void PostImageRotateFlipTest(string formatExtension, bool saveResultToStorage, params string[] additionalExportFormats)
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
                    foreach (var method in _rotateFlipMethods)
                    {
                        outName = $"{name}_{method}.{format}";

                        this.TestRawPostRequest(
                            $"Input image: {name}; Output format: {format}; Method: {method}",
                            name,
                            outName,
                            delegate (Stream inputStream, string outPath)
                            {
                                var request = new PostImageRotateFlipRequest(inputStream, format, method, outPath);
                                return CadApi.PostImageRotateFlip(request);
                            },
                            folder,
                            storage);
                    }

                    break;
                }
            }
        }
    }
}
