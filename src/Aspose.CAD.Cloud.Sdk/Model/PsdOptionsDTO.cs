// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PsdOptionsDTO.cs">
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
  /// Export options for PSD format
  /// </summary>  
  public class PsdOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Compression method
        /// </summary>
        /// <value>Compression method</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionMethodEnum
        { 
            /// <summary>
            /// Enum Raw for "Raw"
            /// </summary>            
            Raw,
            
            /// <summary>
            /// Enum RLE for "RLE"
            /// </summary>            
            RLE,
            
            /// <summary>
            /// Enum ZipWithoutPrediction for "ZipWithoutPrediction"
            /// </summary>            
            ZipWithoutPrediction,
            
            /// <summary>
            /// Enum ZipWithPrediction for "ZipWithPrediction"
            /// </summary>            
            ZipWithPrediction            
        }

        /// <summary>
        /// Color mode
        /// </summary>
        /// <value>Color mode</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ColorModeEnum
        { 
            /// <summary>
            /// Enum Bitmap for "Bitmap"
            /// </summary>            
            Bitmap,
            
            /// <summary>
            /// Enum Grayscale for "Grayscale"
            /// </summary>            
            Grayscale,
            
            /// <summary>
            /// Enum Indexed for "Indexed"
            /// </summary>            
            Indexed,
            
            /// <summary>
            /// Enum Rgb for "Rgb"
            /// </summary>            
            Rgb,
            
            /// <summary>
            /// Enum Cmyk for "Cmyk"
            /// </summary>            
            Cmyk,
            
            /// <summary>
            /// Enum Multichannel for "Multichannel"
            /// </summary>            
            Multichannel,
            
            /// <summary>
            /// Enum Duotone for "Duotone"
            /// </summary>            
            Duotone,
            
            /// <summary>
            /// Enum Lab for "Lab"
            /// </summary>            
            Lab            
        }

        /// <summary>
        /// Compression method
        /// </summary>
        public CompressionMethodEnum? CompressionMethod { get; set; }

        /// <summary>
        /// Color mode
        /// </summary>
        public ColorModeEnum? ColorMode { get; set; }

        /// <summary>
        /// PSD format version
        /// </summary>  
        public int? Version { get; set; }

        /// <summary>
        /// Bits count per channel
        /// </summary>  
        public int? ChannelBitsCount { get; set; }

        /// <summary>
        /// Channels count
        /// </summary>  
        public int? ChannelsCount { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PsdOptionsDTO {\n");
          sb.Append("  Version: ").Append(this.Version).Append("\n");
          sb.Append("  CompressionMethod: ").Append(this.CompressionMethod).Append("\n");
          sb.Append("  ColorMode: ").Append(this.ColorMode).Append("\n");
          sb.Append("  ChannelBitsCount: ").Append(this.ChannelBitsCount).Append("\n");
          sb.Append("  ChannelsCount: ").Append(this.ChannelsCount).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
