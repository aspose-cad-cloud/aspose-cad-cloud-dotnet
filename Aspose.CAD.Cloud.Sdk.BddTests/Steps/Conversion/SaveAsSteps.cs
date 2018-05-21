﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SaveAsSteps.cs">
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

namespace Aspose.CAD.Cloud.Sdk.BddTests.Steps.Conversion
{
    using System.IO;

    using Aspose.CAD.Cloud.Sdk.BddTests.Base.Context;
    using Aspose.CAD.Cloud.Sdk.Model;
    using Aspose.CAD.Cloud.Sdk.Model.Requests;

    using NUnit.Framework;

    using TechTalk.SpecFlow;

    /// <summary>
    /// Steps for SaveUs feature
    /// </summary>
    [Binding]
    public class SaveAsSteps
    {
        private BaseContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsSteps"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public SaveAsSteps(BaseContext context)
        {
            this.context = context;
        }

        private MemoryStream File
        {
            get { return this.context.Response as MemoryStream; }
        }

        private SaveAsPostImageSaveAsRequest Request
        {
            get
            {
                return (SaveAsPostImageSaveAsRequest)ScenarioContext.Current["Request"];
            }
        }

        /// <summary>
        /// Initialize context before each scenario.
        /// </summary>
        [BeforeScenario("saveAs")]
        public static void BeforeScenario()
        {
            ScenarioContext.Current["Request"] = new SaveAsPostImageSaveAsRequest() {};
        }

        /// <summary>
        /// Sets saveFormat to SaveOptionsData
        /// </summary>
        /// <param name="saveFormat">format in which document will be converted</param>
        [Given(@"I have specified save format (.*) drawing to be converted")]
        public void GivenIHaveSpecifiedSaveFormatDocumentToBeConverted(string saveFormat)
        {
            this.Request.format = saveFormat;
        }

        /// <summary>
        /// Sets destination file name
        /// </summary>
        /// <param name="destFileName">destionation file name</param>
        [Given(@"I have specified destFileName (.*)")]
        public void GivenIHaveSpecifiedDestFileName(string destFileName)
        {
            this.Request.outPath = destFileName;
        }

        /// <summary>
        /// Executes conversion
        /// </summary>
        [When(@"I execute conversion from storage \(POST SaveAs\)")]
        public void WhenIExecuteConversion()
        {
            this.context.Response = this.context.SaveAsApi.SaveAsPostImageSaveAs(this.Request);
        }

        /// <summary>
        /// Checks that document converted properly
        /// </summary>
        [Then(@"drawing is converted to the corresponding format")]
        public void ThenSymbolsAreEncodedProperly()
        {
        }        
    }
}