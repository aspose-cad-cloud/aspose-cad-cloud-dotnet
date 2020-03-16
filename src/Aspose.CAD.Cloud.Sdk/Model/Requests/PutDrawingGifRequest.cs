// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutDrawingGifRequest.cs">
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
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.PutDrawingGif" /> operation.
  /// </summary>  
  public class PutDrawingGifRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PutDrawingGifRequest"/> class.
        /// </summary>        
        public PutDrawingGifRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PutDrawingGifRequest"/> class.
        /// </summary>
        /// <param name="drawingData">Input drawing</param>
        /// <param name="exportOptions">JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/GifOptionsDTO model definition.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed file).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PutDrawingGifRequest(System.IO.Stream drawingData, string exportOptions = null, string outPath = null, string storage = null)             
        {
            this.DrawingData = drawingData;
            this.ExportOptions = exportOptions;
            this.OutPath = outPath;
            this.Storage = storage;
        }

        /// <summary>
        /// Input drawing
        /// </summary>  
        public System.IO.Stream DrawingData { get; set; }

        /// <summary>
        /// JSON-serialized export options passed as zero-indexed multipart/form-data. Follow #/definitions/GifOptionsDTO model definition.
        /// </summary>  
        public string ExportOptions { get; set; }

        /// <summary>
        /// Path to updated file (if this is empty, response contains streamed file).
        /// </summary>  
        public string OutPath { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string Storage { get; set; }
  }
}
