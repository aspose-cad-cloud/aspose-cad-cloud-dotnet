// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetDrawingPropertiesRequest.cs">
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
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.GetDrawingProperties" /> operation.
  /// </summary>  
  public class GetDrawingPropertiesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrawingPropertiesRequest"/> class.
        /// </summary>        
        public GetDrawingPropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDrawingPropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">Filename of an input drawing on a storage.</param>
        /// <param name="folder">Folder with a drawing to get properties for.</param>
        /// <param name="storage">Your Aspose Cloud Storage name.</param>
        public GetDrawingPropertiesRequest(string name, string folder = null, string storage = null)             
        {
            this.Name = name;
            this.Folder = folder;
            this.Storage = storage;
        }

        /// <summary>
        /// Filename of an input drawing on a storage.
        /// </summary>  
        public string Name { get; set; }

        /// <summary>
        /// Folder with a drawing to get properties for.
        /// </summary>  
        public string Folder { get; set; }

        /// <summary>
        /// Your Aspose Cloud Storage name.
        /// </summary>  
        public string Storage { get; set; }
  }
}
