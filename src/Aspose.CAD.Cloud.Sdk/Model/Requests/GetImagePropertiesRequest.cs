// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetImagePropertiesRequest.cs">
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
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.GetImageProperties" /> operation.
  /// </summary>  
  public class GetImagePropertiesRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetImagePropertiesRequest"/> class.
        /// </summary>        
        public GetImagePropertiesRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetImagePropertiesRequest"/> class.
        /// </summary>
        /// <param name="name">The image name.</param>
        /// <param name="folder">Original drawing folder.</param>
        /// <param name="storage">File storage, which has to be used.</param>
        public GetImagePropertiesRequest(string name, string folder = null, string storage = null)             
        {
            this.name = name;
            this.folder = folder;
            this.storage = storage;
        }

        /// <summary>
        /// The image name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// Original drawing folder.
        /// </summary>  
        public string folder { get; set; }

        /// <summary>
        /// File storage, which has to be used.
        /// </summary>  
        public string storage { get; set; }
  }
}