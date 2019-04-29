// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostDrawingJpeg2000Request.cs">
//   Copyright (c) 2018 Aspose.Cad for Cloud
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
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.PostDrawingJpeg2000" /> operation.
  /// </summary>  
  public class PostDrawingJpeg2000Request  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingJpeg2000Request"/> class.
        /// </summary>        
        public PostDrawingJpeg2000Request()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostDrawingJpeg2000Request"/> class.
        /// </summary>
        /// <param name="name">Filename of an input drawing on a storage.</param>
        /// <param name="options">Export JPEG2000 options passed as a JSON on a request body.</param>
        /// <param name="folder">Folder with a drawing to process.</param>
        /// <param name="outPath">Path to updated file (if this is empty, response contains streamed file).</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public PostDrawingJpeg2000Request(string name, Jpeg2000OptionsDTO options, string folder = null, string outPath = null, string storage = null)             
        {
            this.Name = name;
            this.Options = options;
            this.Folder = folder;
            this.OutPath = outPath;
            this.Storage = storage;
        }

        /// <summary>
        /// Filename of an input drawing on a storage.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Export JPEG2000 options passed as a JSON on a request body.
        /// </summary>  
        public Jpeg2000OptionsDTO Options { get; set; }

        /// <summary>
        /// Folder with a drawing to process.
        /// </summary>  
        public string Folder { get; set; }

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