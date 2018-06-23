// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BmpApiTests.cs">
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

using System.Net;
using Aspose.CAD.Cloud.Sdk.Model;
using Aspose.CAD.Cloud.Sdk.Model.Requests;

namespace Aspose.CAD.Cloud.Sdk.Test.Api
{
	using System;
	using System.IO;
	using NUnit.Framework;

    /// <summary>
    ///  Class for testing PropertiesApi
    /// </summary>
    [TestFixture]
    public class PropertiesApiTests : ApiTester
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
        /// Test GetImageBmp
        /// <param name="saveResultToStorage">If result should be saved to storage</param>
        /// </summary>
        [TestCase(true)]
        [TestCase(false)]
        public void GetImagePropertiesTest(bool saveResultToStorage)
        {
            string name = "Nikon_D90_Camera.dgn";
            int? bitsPerPixel = 32;
            var size = 1000l;
            int? horizontalResolution = 300;
            int? verticalResolution = 300;
            string folder = CloudTestFolder;
            string storage = DefaultStorage;

            this.TestRequestWithTypedResponse(
                $"Input image: {name}; Bits per pixel: {bitsPerPixel}; Horizontal resolution: {horizontalResolution}; Vertical resolution: {verticalResolution}",
                name,
                delegate()
                {
                    var request = new GetImagePropertiesRequest(name, folder, storage);
                    var properties = CadApi.GetImageProperties(request);
                    return properties;
                },
                (response, refInfo) =>
                {
                    Assert.AreEqual(response.Code, HttpStatusCode.OK);
                },
                folder,
                storage);
        }
    }
}
