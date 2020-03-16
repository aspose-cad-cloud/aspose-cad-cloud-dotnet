// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JpegOptionsDTO.cs">
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
  /// Export options for JPEG format
  /// </summary>  
  public class JpegOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Compression type
        /// </summary>
        /// <value>Compression type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionTypeEnum
        { 
            /// <summary>
            /// Enum Baseline for "Baseline"
            /// </summary>            
            Baseline,
            
            /// <summary>
            /// Enum Progressive for "Progressive"
            /// </summary>            
            Progressive,
            
            /// <summary>
            /// Enum Lossless for "Lossless"
            /// </summary>            
            Lossless,
            
            /// <summary>
            /// Enum JpegLs for "JpegLs"
            /// </summary>            
            JpegLs            
        }

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
            /// Enum YCbCr for "YCbCr"
            /// </summary>            
            YCbCr,
            
            /// <summary>
            /// Enum Cmyk for "Cmyk"
            /// </summary>            
            Cmyk,
            
            /// <summary>
            /// Enum Ycck for "Ycck"
            /// </summary>            
            Ycck,
            
            /// <summary>
            /// Enum Rgb for "Rgb"
            /// </summary>            
            Rgb            
        }

        /// <summary>
        /// Compression type
        /// </summary>
        public CompressionTypeEnum? CompressionType { get; set; }

        /// <summary>
        /// Color type
        /// </summary>
        public ColorTypeEnum? ColorType { get; set; }

        /// <summary>
        /// Comment to Resulting file
        /// </summary>  
        public string Comment { get; set; }

        /// <summary>
        /// Quality level
        /// </summary>  
        public int? Quality { get; set; }

        /// <summary>
        /// Optimizer settings
        /// </summary>  
        public RdOptimizerSettings RdOptSettings { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class JpegOptionsDTO {\n");
          sb.Append("  Comment: ").Append(this.Comment).Append("\n");
          sb.Append("  CompressionType: ").Append(this.CompressionType).Append("\n");
          sb.Append("  ColorType: ").Append(this.ColorType).Append("\n");
          sb.Append("  Quality: ").Append(this.Quality).Append("\n");
          sb.Append("  RdOptSettings: ").Append(this.RdOptSettings).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
