
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostChangeImageScaleRequest.cs">
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

namespace Aspose.CAD.Cloud.Sdk.Model.Requests 
{
  using Aspose.CAD.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.CAD.Cloud.Sdk.CADApi.PostChangeImageScale" /> operation.
  /// </summary>  
  public class PostChangeImageScaleRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostChangeImageScaleRequest"/> class.
        /// </summary>        
        public PostChangeImageScaleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostChangeImageScaleRequest"/> class.
        /// </summary>
        /// <param name="document">Drawing to convert</param>
        /// <param name="format">Output file format. Valid formats: BMP, PNG, JPG, JPEG, JPEG2000, TIF, TIFF, PSD, GIF, PDF, WMF.</param>
        /// <param name="newWidth">New width of the scaled image.</param>
        /// <param name="newHeight">New height of the scaled image.</param>
        /// <param name="storage">File storage, which has to be used.</param>
        /// <param name="outPath">Path to updated file, if this is empty, response contains streamed image. </param>
        public PostChangeImageScaleRequest(System.IO.Stream document, string format, int? newWidth, int? newHeight, string storage = null, string outPath = null)             
        {
            this.document = document;
            this.format = format;
            this.newWidth = newWidth;
            this.newHeight = newHeight;
            this.storage = storage;
            this.outPath = outPath;
        }
		
        /// <summary>
        /// Drawing to convert
        /// </summary>  
        public System.IO.Stream document { get; set; }

        /// <summary>
        /// Output file format. Valid formats: BMP, PNG, JPG, JPEG, JPEG2000, TIF, TIFF, PSD, GIF, PDF, WMF.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// New width of the scaled image.
        /// </summary>  
        public int? newWidth { get; set; }

        /// <summary>
        /// New height of the scaled image.
        /// </summary>  
        public int? newHeight { get; set; }

        /// <summary>
        /// File storage, which has to be used.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Path to updated file, if this is empty, response contains streamed image. 
        /// </summary>  
        public string outPath { get; set; }
  }
}