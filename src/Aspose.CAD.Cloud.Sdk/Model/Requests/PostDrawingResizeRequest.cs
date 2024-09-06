// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostDrawingResizeRequest.cs">
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
  /// Request model for <see cref="Aspose.CAD.Cloud.Sdk.Api.CadApi.PostDrawingResize" /> operation.
  /// </summary>  
  public class PostDrawingResizeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingResizeRequest"/> class.
        /// </summary>        
        public PostDrawingResizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingResizeRequest"/> class.
        /// </summary>
        /// <param name="drawingData">Input drawing</param>
        /// <param name="outputFormat">Resulting file format.</param>
        /// <param name="newWidth">New width.</param>
        /// <param name="newHeight">New height.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed file).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PostDrawingResizeRequest(System.IO.Stream drawingData, string outputFormat, int? newWidth, int? newHeight, string outPath = null, string storage = null)             
        {
            this.DrawingData = drawingData;
            this.OutputFormat = outputFormat;
            this.NewWidth = newWidth;
            this.NewHeight = newHeight;
            this.OutPath = outPath;
            this.Storage = storage;
        }

        /// <summary>
        /// Input drawing
        /// </summary>  
        public System.IO.Stream DrawingData { get; set; }

        /// <summary>
        /// Resulting file format.
        /// </summary>  
        public string OutputFormat { get; set; }

        /// <summary>
        /// New width.
        /// </summary>  
        public int? NewWidth { get; set; }

        /// <summary>
        /// New height.
        /// </summary>  
        public int? NewHeight { get; set; }

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
