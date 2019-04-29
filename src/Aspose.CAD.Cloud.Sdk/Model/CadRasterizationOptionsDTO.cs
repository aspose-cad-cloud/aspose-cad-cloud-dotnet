// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="CadRasterizationOptionsDTO.cs">
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
  /// Raster export options
  /// </summary>  
  public class CadRasterizationOptionsDTO : VectorRasterizationOptionsDTO 
  {                       
        /// <summary>
        /// Drawing mode
        /// </summary>
        /// <value>Drawing mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DrawTypeEnum
        { 
            /// <summary>
            /// Enum UseDrawColor for "UseDrawColor"
            /// </summary>            
            UseDrawColor,
            
            /// <summary>
            /// Enum UseObjectColor for "UseObjectColor"
            /// </summary>            
            UseObjectColor            
        }

        /// <summary>
        /// Drawing mode
        /// </summary>
        public DrawTypeEnum? DrawType { get; set; }

        /// <summary>
        /// Zoom factor
        /// </summary>  
        public double? Zoom { get; set; }

        /// <summary>
        /// Pen options
        /// </summary>  
        public PenOptions PenOptions { get; set; }

        /// <summary>
        /// Determines whether layout has to be scaled automatically
        /// </summary>  
        public bool? AutomaticLayoutsScaling { get; set; }

        /// <summary>
        /// Layers to export
        /// </summary>  
        public List<string> Layers { get; set; }

        /// <summary>
        /// Layouts to export
        /// </summary>  
        public List<string> Layouts { get; set; }

        /// <summary>
        /// Determines whether scaling has to be turned off
        /// </summary>  
        public bool? NoScaling { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class CadRasterizationOptionsDTO {\n");
          sb.Append("  Zoom: ").Append(this.Zoom).Append("\n");
          sb.Append("  PenOptions: ").Append(this.PenOptions).Append("\n");
          sb.Append("  AutomaticLayoutsScaling: ").Append(this.AutomaticLayoutsScaling).Append("\n");
          sb.Append("  Layers: ").Append(this.Layers).Append("\n");
          sb.Append("  Layouts: ").Append(this.Layouts).Append("\n");
          sb.Append("  DrawType: ").Append(this.DrawType).Append("\n");
          sb.Append("  NoScaling: ").Append(this.NoScaling).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
