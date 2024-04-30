// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ConvertRequest.cs">
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
  /// Request model for <see cref="Aspose.Cad.Cloud.Sdk.Api.CadApi.Convert" /> operation.
  /// </summary>  
  public class ConvertRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertRequest"/> class.
        /// </summary>        
        public ConvertRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertRequest"/> class.
        /// </summary>
        /// <param name="outputFormat">Output DXF, DWG, DGN, DWF, DWFX, IFC, STL, STP, STEP, CGM, GLB, GLTF, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG, PNG, BMP, DIB, TIFF, TIF, JPEG, GIF, PSD, JPG, JPE, JIF, JFIF, PSD, WEBP, DCM, DICOM, JP2, J2K, JPF, JPM, JPG2, J2C, JPC, JPX, MJ2 , DJVU file format.</param>
        /// <param name="drawing">Form-data file</param>
        /// <param name="outputTypeExt">For output pdf format: PDF_15, PDFa_1a OR PDFa_1b. Null for another format</param>
        public ConvertRequest(string outputFormat, System.IO.Stream drawing = null, string outputTypeExt = null)             
        {
            this.OutputFormat = outputFormat;
            this.Drawing = drawing;
            this.OutputTypeExt = outputTypeExt;
        }

        /// <summary>
        /// Output DXF, DWG, DGN, DWF, DWFX, IFC, STL, STP, STEP, CGM, GLB, GLTF, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG, PNG, BMP, DIB, TIFF, TIF, JPEG, GIF, PSD, JPG, JPE, JIF, JFIF, PSD, WEBP, DCM, DICOM, JP2, J2K, JPF, JPM, JPG2, J2C, JPC, JPX, MJ2 , DJVU file format.
        /// </summary>  
        public string OutputFormat { get; set; }

        /// <summary>
        /// Form-data file
        /// </summary>  
        public System.IO.Stream Drawing { get; set; }

        /// <summary>
        /// For output pdf format: PDF_15, PDFa_1a OR PDFa_1b. Null for another format
        /// </summary>  
        public string OutputTypeExt { get; set; }
  }
}
