// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GifOptionsDTO.cs">
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
  /// Export options for GIF format
  /// </summary>  
  public class GifOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Determines whether to do auto-correction of a palette
        /// </summary>  
        public bool? DoPaletteCorrection { get; set; }

        /// <summary>
        /// Color resolution
        /// </summary>  
        public int? ColorResolution { get; set; }

        /// <summary>
        /// Determines whether a palette is sorted
        /// </summary>  
        public bool? IsPaletteSorted { get; set; }

        /// <summary>
        /// Pixel aspect ration
        /// </summary>  
        public int? PixelAspectRatio { get; set; }

        /// <summary>
        /// Background color index
        /// </summary>  
        public int? BackgroundColorIndex { get; set; }

        /// <summary>
        /// Determines whether image has to have a trailer
        /// </summary>  
        public bool? HasTrailer { get; set; }

        /// <summary>
        /// Determines whether an image has to be interlaced
        /// </summary>  
        public bool? Interlaced { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class GifOptionsDTO {\n");
          sb.Append("  DoPaletteCorrection: ").Append(this.DoPaletteCorrection).Append("\n");
          sb.Append("  ColorResolution: ").Append(this.ColorResolution).Append("\n");
          sb.Append("  IsPaletteSorted: ").Append(this.IsPaletteSorted).Append("\n");
          sb.Append("  PixelAspectRatio: ").Append(this.PixelAspectRatio).Append("\n");
          sb.Append("  BackgroundColorIndex: ").Append(this.BackgroundColorIndex).Append("\n");
          sb.Append("  HasTrailer: ").Append(this.HasTrailer).Append("\n");
          sb.Append("  Interlaced: ").Append(this.Interlaced).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
