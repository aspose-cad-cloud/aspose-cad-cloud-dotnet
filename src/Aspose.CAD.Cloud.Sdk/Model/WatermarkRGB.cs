// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="WatermarkRGB.cs">
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
  /// Watermark text with RGB values
  /// </summary>  
  public class WatermarkRGB 
  {                       
        /// <summary>
        /// Watermark text.
        /// </summary>  
        public string Text { get; set; }

        /// <summary>
        /// Red light(0-255).
        /// </summary>  
        public int? R { get; set; }

        /// <summary>
        /// Green light(0-255).
        /// </summary>  
        public int? G { get; set; }

        /// <summary>
        /// Blue light(0-255).
        /// </summary>  
        public int? B { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class WatermarkRGB {\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  R: ").Append(this.R).Append("\n");
          sb.Append("  G: ").Append(this.G).Append("\n");
          sb.Append("  B: ").Append(this.B).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
