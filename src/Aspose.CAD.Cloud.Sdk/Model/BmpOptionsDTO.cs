// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BmpOptionsDTO.cs">
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
  /// Export options for BMP format
  /// </summary>  
  public class BmpOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Compression type
        /// </summary>
        /// <value>Compression type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        { 
            /// <summary>
            /// Enum Rgb for "Rgb"
            /// </summary>            
            Rgb,
            
            /// <summary>
            /// Enum Rle8 for "Rle8"
            /// </summary>            
            Rle8,
            
            /// <summary>
            /// Enum Rle4 for "Rle4"
            /// </summary>            
            Rle4,
            
            /// <summary>
            /// Enum Bitfields for "Bitfields"
            /// </summary>            
            Bitfields,
            
            /// <summary>
            /// Enum Jpeg for "Jpeg"
            /// </summary>            
            Jpeg,
            
            /// <summary>
            /// Enum Png for "Png"
            /// </summary>            
            Png,
            
            /// <summary>
            /// Enum AlphaBitfields for "AlphaBitfields"
            /// </summary>            
            AlphaBitfields            
        }

        /// <summary>
        /// Compression type
        /// </summary>
        public CompressionEnum? Compression { get; set; }

        /// <summary>
        /// Bits per pixel
        /// </summary>  
        public int? BitsPerPixel { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BmpOptionsDTO {\n");
          sb.Append("  BitsPerPixel: ").Append(this.BitsPerPixel).Append("\n");
          sb.Append("  Compression: ").Append(this.Compression).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
