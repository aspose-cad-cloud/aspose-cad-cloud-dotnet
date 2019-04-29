// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RdOptimizerSettings.cs">
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
  /// RD optimizer settings class
  /// </summary>  
  public class RdOptimizerSettings 
  {                       
        /// <summary>
        /// Gets or sets the BPP (bits per pixel) scale factor.
        /// </summary>  
        public int? BppScale { get; set; }

        /// <summary>
        /// Gets or sets the maximum R value for consideration in  in bits per pixel
        /// </summary>  
        public double? BppMax { get; set; }

        /// <summary>
        /// Gets or sets the maximum quantization value.
        /// </summary>  
        public int? MaxQ { get; set; }

        /// <summary>
        /// Gets the minimum allowed quantization value.
        /// </summary>  
        public int? MinQ { get; set; }

        /// <summary>
        /// Gets the maximum pixel value.
        /// </summary>  
        public int? MaxPixelValue { get; set; }

        /// <summary>
        /// Gets the PSNR maximum expected value.
        /// </summary>  
        public int? PsnrMax { get; set; }

        /// <summary>
        /// Gets the maximum R value for consideration.
        /// </summary>  
        public int? DiscretizedBppMax { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class RdOptimizerSettings {\n");
          sb.Append("  BppScale: ").Append(this.BppScale).Append("\n");
          sb.Append("  BppMax: ").Append(this.BppMax).Append("\n");
          sb.Append("  MaxQ: ").Append(this.MaxQ).Append("\n");
          sb.Append("  MinQ: ").Append(this.MinQ).Append("\n");
          sb.Append("  MaxPixelValue: ").Append(this.MaxPixelValue).Append("\n");
          sb.Append("  PsnrMax: ").Append(this.PsnrMax).Append("\n");
          sb.Append("  DiscretizedBppMax: ").Append(this.DiscretizedBppMax).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
