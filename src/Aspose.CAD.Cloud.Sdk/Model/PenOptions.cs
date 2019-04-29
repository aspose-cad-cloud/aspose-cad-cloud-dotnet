// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PenOptions.cs">
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
  /// Drawing pen options
  /// </summary>  
  public class PenOptions 
  {                       
        /// <summary>
        /// Gets or sets the start cap.
        /// </summary>
        /// <value>Gets or sets the start cap.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StartCapEnum
        { 
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>            
            Flat,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>            
            Square,
            
            /// <summary>
            /// Enum Round for "Round"
            /// </summary>            
            Round,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>            
            Triangle,
            
            /// <summary>
            /// Enum NoAnchor for "NoAnchor"
            /// </summary>            
            NoAnchor,
            
            /// <summary>
            /// Enum SquareAnchor for "SquareAnchor"
            /// </summary>            
            SquareAnchor,
            
            /// <summary>
            /// Enum RoundAnchor for "RoundAnchor"
            /// </summary>            
            RoundAnchor,
            
            /// <summary>
            /// Enum DiamondAnchor for "DiamondAnchor"
            /// </summary>            
            DiamondAnchor,
            
            /// <summary>
            /// Enum ArrowAnchor for "ArrowAnchor"
            /// </summary>            
            ArrowAnchor,
            
            /// <summary>
            /// Enum AnchorMask for "AnchorMask"
            /// </summary>            
            AnchorMask,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom            
        }

        /// <summary>
        /// Gets or sets the end cap.
        /// </summary>
        /// <value>Gets or sets the end cap.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EndCapEnum
        { 
            /// <summary>
            /// Enum Flat for "Flat"
            /// </summary>            
            Flat,
            
            /// <summary>
            /// Enum Square for "Square"
            /// </summary>            
            Square,
            
            /// <summary>
            /// Enum Round for "Round"
            /// </summary>            
            Round,
            
            /// <summary>
            /// Enum Triangle for "Triangle"
            /// </summary>            
            Triangle,
            
            /// <summary>
            /// Enum NoAnchor for "NoAnchor"
            /// </summary>            
            NoAnchor,
            
            /// <summary>
            /// Enum SquareAnchor for "SquareAnchor"
            /// </summary>            
            SquareAnchor,
            
            /// <summary>
            /// Enum RoundAnchor for "RoundAnchor"
            /// </summary>            
            RoundAnchor,
            
            /// <summary>
            /// Enum DiamondAnchor for "DiamondAnchor"
            /// </summary>            
            DiamondAnchor,
            
            /// <summary>
            /// Enum ArrowAnchor for "ArrowAnchor"
            /// </summary>            
            ArrowAnchor,
            
            /// <summary>
            /// Enum AnchorMask for "AnchorMask"
            /// </summary>            
            AnchorMask,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom            
        }

        /// <summary>
        /// Gets or sets the start cap.
        /// </summary>
        public StartCapEnum? StartCap { get; set; }

        /// <summary>
        /// Gets or sets the end cap.
        /// </summary>
        public EndCapEnum? EndCap { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class PenOptions {\n");
          sb.Append("  StartCap: ").Append(this.StartCap).Append("\n");
          sb.Append("  EndCap: ").Append(this.EndCap).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
