// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkRequest.cs">
//   Copyright (c) 2018 Aspose.CAD Cloud
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
namespace Aspose.CAD.Cloud.Sdk.Model.Requests 
{
  using Aspose.CAD.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.Watermark" /> operation.
  /// </summary>  
  public class WatermarkRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkRequest"/> class.
        /// </summary>        
        public WatermarkRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkRequest"/> class.
        /// </summary>
        /// <param name="outputFormat"></param>
        /// <param name="drawing"></param>
        /// <param name="watermarkRgb"></param>
        /// <param name="outputTypeExt"></param>
        public WatermarkRequest(string outputFormat, System.IO.Stream drawing = null, string watermarkRgb = null, string outputTypeExt = null)             
        {
            this.OutputFormat = outputFormat;
            this.Drawing = drawing;
            this.WatermarkRgb = watermarkRgb;
            this.OutputTypeExt = outputTypeExt;
        }

        /// <summary>
        /// Gets or sets outputFormat
        /// </summary>  
        public string OutputFormat { get; set; }

        /// <summary>
        /// Gets or sets drawing
        /// </summary>  
        public System.IO.Stream Drawing { get; set; }

        /// <summary>
        /// Gets or sets watermarkRgb
        /// </summary>  
        public string WatermarkRgb { get; set; }

        /// <summary>
        /// Gets or sets outputTypeExt
        /// </summary>  
        public string OutputTypeExt { get; set; }
  }
}
