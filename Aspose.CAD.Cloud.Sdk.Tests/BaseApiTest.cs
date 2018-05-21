﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BaseApiTest.cs">
//   Copyright (c) 2018 Aspose.Words for Cloud
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

namespace Aspose.CAD.Cloud.Sdk.Tests
{ 
    using System.IO;
    using System.Linq;
    using System.Text;

    using Aspose.CAD.Cloud.Sdk;    
    using Aspose.CAD.Cloud.Sdk.Model.Requests;
    using Aspose.CAD.Cloud.Sdk.Tests.Base;

    using NUnit.Framework;
    
    /// <summary>
    /// This is a test class for TestWordsApi and is intended
    /// to contain all TestWordsApi Unit Tests
    /// </summary>
    [TestFixture]
    public class BaseApiTest : BaseTestContext
    {     
        /// <summary>
        /// If file does not exist, 400 response should be returned with message "Error while loading file ".
        /// </summary>
        [Test]
        public void TestHandleErrors()
        {
            string name = "noFileWithThisName.docx";
            
            try
            {
                ////var request = new GetSectionsRequest(name);
                ////this.WordsApi.GetSections(request);

                Assert.Fail("Expected exception has not been thrown");
            }
            catch (ApiException apiException)
            {
                Assert.AreEqual(400, apiException.ErrorCode);
                Assert.IsTrue(apiException.Message.StartsWith("Error while loading file 'noFileWithThisName.docx' from storage:"), "Current message: " + apiException.Message);
            }
        }
        
        /// <summary>
        /// Check if all API methods have covered by tests
        /// </summary>
        [Test]
        public void TestApiCoverage()
        {
            var methods = typeof(PropertiesApi).GetMethods()
                                .Union(typeof(ResizeApi).GetMethods())
                                .Union(typeof(RotateFlipApi).GetMethods())
                                .Union(typeof(SaveAsApi).GetMethods())
                                .Where(p => p.IsPublic && p.DeclaringType != typeof(object))
                                .Select(p => p.Name)
                                .ToList();

            var unitTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.CAD.Cloud.Sdk.Tests");
            var bddTestFolder = Path.Combine(DirectoryHelper.GetRootSdkFolder(), "Aspose.CAD.Cloud.Sdk.BddTests");
            var unitTestFiles = DirectoryHelper.GetFilesByExtension(unitTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            var bddTestFiles = DirectoryHelper.GetFilesByExtension(bddTestFolder, ".cs", SearchOption.AllDirectories).ToList();
            unitTestFiles.AddRange(bddTestFiles);
            var filesContent = unitTestFiles.Select(File.ReadAllText).ToList();
            var strBuilder = new StringBuilder();
            foreach (var methodInfo in methods)
            {
                if (filesContent.All(p => !p.Contains(methodInfo)))
                {
                    strBuilder.AppendFormat("Uncovered api method {0}\n", methodInfo);
                }
            }

            Assert.IsTrue(strBuilder.Length == 0, strBuilder.ToString());
        }
    }
}
