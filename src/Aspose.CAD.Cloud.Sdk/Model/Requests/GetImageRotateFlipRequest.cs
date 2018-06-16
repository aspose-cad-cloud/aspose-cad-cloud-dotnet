
// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImageRotateFlipRequest.cs">
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
  /// Request model for <see cref="Aspose.CAD.Cloud.Sdk.CADApi.GetImageRotateFlip" /> operation.
  /// </summary>  
  public class GetImageRotateFlipRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageRotateFlipRequest"/> class.
        /// </summary>        
        public GetImageRotateFlipRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImageRotateFlipRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of image.</param>
        /// <param name="format">Output file format. Valid formats: BMP, PNG, JPG, JPEG, JPEG2000, TIF, TIFF, PSD, GIF, PDF, WMF.</param>
        /// <param name="method">Rotate and flip method. Valid methods: Rotate180FlipNone,  Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY.</param>
        /// <param name="folder">Original drawing folder.</param>
        /// <param name="storage">File storage, which has to be used.</param>
        /// <param name="outPath">Path to updated file, if this is empty, response contains streamed image.</param>
        public GetImageRotateFlipRequest(string name, string format, string method, string folder = null, string storage = null, string outPath = null)             
        {
            this.name = name;
            this.format = format;
            this.method = method;
            this.folder = folder;
            this.storage = storage;
            this.outPath = outPath;
        }
		
        /// <summary>
        /// Filename of image.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Output file format. Valid formats: BMP, PNG, JPG, JPEG, JPEG2000, TIF, TIFF, PSD, GIF, PDF, WMF.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Rotate and flip method. Valid methods: Rotate180FlipNone,  Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY, RotateNoneFlipY.
        /// </summary>  
        public string method { get; set; }

        /// <summary>
        /// Original drawing folder.
        /// </summary>  
        public string folder { get; set; }

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