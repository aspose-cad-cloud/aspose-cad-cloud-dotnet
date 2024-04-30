// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CadResponse.cs">
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

namespace Aspose.CAD.Cloud.Sdk.Model 
{
  using System;  
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;

  /// <summary>
  /// Represents information about a drawing.
  /// </summary>  
  public class CadResponse 
  {                       
        /// <summary>
        /// Gets or sets the height of a drawing.
        /// </summary>  
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the width of a drawing.
        /// </summary>  
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the DWG properties.
        /// </summary>  
        public DwgProperties DwgProperties { get; set; }

        /// <summary>
        /// Gets or sets the DXF properties.
        /// </summary>  
        public DxfProperties DxfProperties { get; set; }

        /// <summary>
        /// Gets or sets the DWT properties.
        /// </summary>  
        public DwgProperties DwtProperties { get; set; }

        /// <summary>
        /// Gets or sets the DGN properties.
        /// </summary>  
        public DgnProperties DgnProperties { get; set; }

        /// <summary>
        /// Gets or sets the IFC properties.
        /// </summary>  
        public IfcProperties IfcProperties { get; set; }

        /// <summary>
        /// Gets or sets the IGS properties.
        /// </summary>  
        public IgsProperties IgsProperties { get; set; }

        /// <summary>
        /// Gets or sets the STL properties.
        /// </summary>  
        public StlProperties StlProperties { get; set; }

        /// <summary>
        /// Gets or sets the DWF properties.
        /// </summary>  
        public DwfProperties DwfProperties { get; set; }

        /// <summary>
        /// Gets or sets the Cf2 properties.
        /// </summary>  
        public Cf2Properties Cf2Properties { get; set; }

        /// <summary>
        /// Gets or sets the Cf2 properties.
        /// </summary>  
        public FbxProperties FbxProperties { get; set; }

        /// <summary>
        /// Gets or sets the FBX properties.
        /// </summary>  
        public ObjProperties ObjProperties { get; set; }

        /// <summary>
        /// Gets or sets the Cf2 properties.
        /// </summary>  
        public PltProperties PltProperties { get; set; }

        /// <summary>
        /// Gets or sets the STP properties.
        /// </summary>  
        public StpProperties StpProperties { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CadResponse {\n");
          sb.Append("  Height: ").Append(this.Height).Append("\n");
          sb.Append("  Width: ").Append(this.Width).Append("\n");
          sb.Append("  DwgProperties: ").Append(this.DwgProperties).Append("\n");
          sb.Append("  DxfProperties: ").Append(this.DxfProperties).Append("\n");
          sb.Append("  DwtProperties: ").Append(this.DwtProperties).Append("\n");
          sb.Append("  DgnProperties: ").Append(this.DgnProperties).Append("\n");
          sb.Append("  IfcProperties: ").Append(this.IfcProperties).Append("\n");
          sb.Append("  IgsProperties: ").Append(this.IgsProperties).Append("\n");
          sb.Append("  StlProperties: ").Append(this.StlProperties).Append("\n");
          sb.Append("  DwfProperties: ").Append(this.DwfProperties).Append("\n");
          sb.Append("  Cf2Properties: ").Append(this.Cf2Properties).Append("\n");
          sb.Append("  FbxProperties: ").Append(this.FbxProperties).Append("\n");
          sb.Append("  ObjProperties: ").Append(this.ObjProperties).Append("\n");
          sb.Append("  PltProperties: ").Append(this.PltProperties).Append("\n");
          sb.Append("  StpProperties: ").Append(this.StpProperties).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
