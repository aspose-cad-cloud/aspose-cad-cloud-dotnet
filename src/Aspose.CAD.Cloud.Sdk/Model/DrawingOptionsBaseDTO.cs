// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DrawingOptionsBaseDTO.cs">
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
  /// Image options base class
  /// </summary>  
  public class DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Resulting rotation operation
        /// </summary>
        /// <value>Resulting rotation operation</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RotationEnum
        { 
            /// <summary>
            /// Enum RotateNoneFlipNone for "RotateNoneFlipNone"
            /// </summary>            
            RotateNoneFlipNone,
            
            /// <summary>
            /// Enum Rotate90FlipNone for "Rotate90FlipNone"
            /// </summary>            
            Rotate90FlipNone,
            
            /// <summary>
            /// Enum Rotate180FlipNone for "Rotate180FlipNone"
            /// </summary>            
            Rotate180FlipNone,
            
            /// <summary>
            /// Enum Rotate270FlipNone for "Rotate270FlipNone"
            /// </summary>            
            Rotate270FlipNone,
            
            /// <summary>
            /// Enum RotateNoneFlipX for "RotateNoneFlipX"
            /// </summary>            
            RotateNoneFlipX,
            
            /// <summary>
            /// Enum Rotate90FlipX for "Rotate90FlipX"
            /// </summary>            
            Rotate90FlipX,
            
            /// <summary>
            /// Enum Rotate180FlipX for "Rotate180FlipX"
            /// </summary>            
            Rotate180FlipX,
            
            /// <summary>
            /// Enum Rotate270FlipX for "Rotate270FlipX"
            /// </summary>            
            Rotate270FlipX,
            
            /// <summary>
            /// Enum RotateNoneFlipY for "RotateNoneFlipY"
            /// </summary>            
            RotateNoneFlipY,
            
            /// <summary>
            /// Enum Rotate90FlipY for "Rotate90FlipY"
            /// </summary>            
            Rotate90FlipY,
            
            /// <summary>
            /// Enum Rotate180FlipY for "Rotate180FlipY"
            /// </summary>            
            Rotate180FlipY,
            
            /// <summary>
            /// Enum Rotate270FlipY for "Rotate270FlipY"
            /// </summary>            
            Rotate270FlipY,
            
            /// <summary>
            /// Enum RotateNoneFlipXY for "RotateNoneFlipXY"
            /// </summary>            
            RotateNoneFlipXY,
            
            /// <summary>
            /// Enum Rotate90FlipXY for "Rotate90FlipXY"
            /// </summary>            
            Rotate90FlipXY,
            
            /// <summary>
            /// Enum Rotate180FlipXY for "Rotate180FlipXY"
            /// </summary>            
            Rotate180FlipXY,
            
            /// <summary>
            /// Enum Rotate270FlipXY for "Rotate270FlipXY"
            /// </summary>            
            Rotate270FlipXY            
        }

        /// <summary>
        /// Resulting rotation operation
        /// </summary>
        public RotationEnum? Rotation { get; set; }

        /// <summary>
        /// Layers to export
        /// </summary>  
        public List<string> Layers { get; set; }

        /// <summary>
        /// DPI resolution settings
        /// </summary>  
        public ResolutionSetting ResolutionSettings { get; set; }

        /// <summary>
        /// Raster options
        /// </summary>  
        public CadRasterizationOptionsDTO VectorRasterizationOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class DrawingOptionsBaseDTO {\n");
          sb.Append("  Rotation: ").Append(this.Rotation).Append("\n");
          sb.Append("  Layers: ").Append(this.Layers).Append("\n");
          sb.Append("  ResolutionSettings: ").Append(this.ResolutionSettings).Append("\n");
          sb.Append("  VectorRasterizationOptions: ").Append(this.VectorRasterizationOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
