// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PngOptionsDTO.cs">
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
  /// Export options for PNG format
  /// </summary>  
  public class PngOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Color type
        /// </summary>
        /// <value>Color type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorTypeEnum
        { 
            /// <summary>
            /// Enum Grayscale for "Grayscale"
            /// </summary>            
            Grayscale,
            
            /// <summary>
            /// Enum Truecolor for "Truecolor"
            /// </summary>            
            Truecolor,
            
            /// <summary>
            /// Enum IndexedColor for "IndexedColor"
            /// </summary>            
            IndexedColor,
            
            /// <summary>
            /// Enum GrayscaleWithAlpha for "GrayscaleWithAlpha"
            /// </summary>            
            GrayscaleWithAlpha,
            
            /// <summary>
            /// Enum TruecolorWithAlpha for "TruecolorWithAlpha"
            /// </summary>            
            TruecolorWithAlpha            
        }

        /// <summary>
        /// Filter type
        /// </summary>
        /// <value>Filter type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FilterTypeEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum Sub for "Sub"
            /// </summary>            
            Sub,
            
            /// <summary>
            /// Enum Up for "Up"
            /// </summary>            
            Up,
            
            /// <summary>
            /// Enum Avg for "Avg"
            /// </summary>            
            Avg,
            
            /// <summary>
            /// Enum Paeth for "Paeth"
            /// </summary>            
            Paeth,
            
            /// <summary>
            /// Enum Adaptive for "Adaptive"
            /// </summary>            
            Adaptive            
        }

        /// <summary>
        /// Color type
        /// </summary>
        public ColorTypeEnum? ColorType { get; set; }

        /// <summary>
        /// Filter type
        /// </summary>
        public FilterTypeEnum? FilterType { get; set; }

        /// <summary>
        /// Determines whether 'progressive' method is used
        /// </summary>  
        public bool? Progressive { get; set; }

        /// <summary>
        /// Compression level
        /// </summary>  
        public int? CompressionLevel { get; set; }

        /// <summary>
        /// Bits depth
        /// </summary>  
        public int? BitDepth { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PngOptionsDTO {\n");
          sb.Append("  ColorType: ").Append(this.ColorType).Append("\n");
          sb.Append("  Progressive: ").Append(this.Progressive).Append("\n");
          sb.Append("  FilterType: ").Append(this.FilterType).Append("\n");
          sb.Append("  CompressionLevel: ").Append(this.CompressionLevel).Append("\n");
          sb.Append("  BitDepth: ").Append(this.BitDepth).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
