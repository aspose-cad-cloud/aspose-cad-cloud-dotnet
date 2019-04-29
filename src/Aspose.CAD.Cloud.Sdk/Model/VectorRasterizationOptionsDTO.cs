// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="VectorRasterizationOptionsDTO.cs">
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
  /// Base raster export options class
  /// </summary>  
  public class VectorRasterizationOptionsDTO 
  {                       
        /// <summary>
        /// Gets or sets UnitType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitTypeEnum
        { 
            /// <summary>
            /// Enum Kilometer for "Kilometer"
            /// </summary>            
            Kilometer,
            
            /// <summary>
            /// Enum Meter for "Meter"
            /// </summary>            
            Meter,
            
            /// <summary>
            /// Enum Centimenter for "Centimenter"
            /// </summary>            
            Centimenter,
            
            /// <summary>
            /// Enum Millimeter for "Millimeter"
            /// </summary>            
            Millimeter,
            
            /// <summary>
            /// Enum Micrometer for "Micrometer"
            /// </summary>            
            Micrometer,
            
            /// <summary>
            /// Enum Nanometer for "Nanometer"
            /// </summary>            
            Nanometer,
            
            /// <summary>
            /// Enum Angstrom for "Angstrom"
            /// </summary>            
            Angstrom,
            
            /// <summary>
            /// Enum Decimeter for "Decimeter"
            /// </summary>            
            Decimeter,
            
            /// <summary>
            /// Enum Decameter for "Decameter"
            /// </summary>            
            Decameter,
            
            /// <summary>
            /// Enum Hectometer for "Hectometer"
            /// </summary>            
            Hectometer,
            
            /// <summary>
            /// Enum Gigameter for "Gigameter"
            /// </summary>            
            Gigameter,
            
            /// <summary>
            /// Enum AstronomicalUnit for "AstronomicalUnit"
            /// </summary>            
            AstronomicalUnit,
            
            /// <summary>
            /// Enum LightYear for "LightYear"
            /// </summary>            
            LightYear,
            
            /// <summary>
            /// Enum Parsec for "Parsec"
            /// </summary>            
            Parsec,
            
            /// <summary>
            /// Enum Mile for "Mile"
            /// </summary>            
            Mile,
            
            /// <summary>
            /// Enum Yard for "Yard"
            /// </summary>            
            Yard,
            
            /// <summary>
            /// Enum Foot for "Foot"
            /// </summary>            
            Foot,
            
            /// <summary>
            /// Enum Inch for "Inch"
            /// </summary>            
            Inch,
            
            /// <summary>
            /// Enum Mil for "Mil"
            /// </summary>            
            Mil,
            
            /// <summary>
            /// Enum MicroInch for "MicroInch"
            /// </summary>            
            MicroInch,
            
            /// <summary>
            /// Enum Custom for "Custom"
            /// </summary>            
            Custom,
            
            /// <summary>
            /// Enum Unitless for "Unitless"
            /// </summary>            
            Unitless            
        }

        /// <summary>
        /// Gets or sets UnitType
        /// </summary>
        public UnitTypeEnum? UnitType { get; set; }

        /// <summary>
        /// Gets or sets the border X.
        /// </summary>  
        public double? BorderX { get; set; }

        /// <summary>
        /// Gets or sets the border Y.
        /// </summary>  
        public double? BorderY { get; set; }

        /// <summary>
        /// Gets or sets the page height.
        /// </summary>  
        public double? PageHeight { get; set; }

        /// <summary>
        /// Gets or sets the page width.
        /// </summary>  
        public double? PageWidth { get; set; }

        /// <summary>
        /// Gets or sets a background color.
        /// </summary>  
        public Color BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets a foreground color.
        /// </summary>  
        public Color DrawColor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether content of a drawing is represented as image inside Pdf. Applicable only for CAD to Pdf export. Default is false.
        /// </summary>  
        public bool? ContentAsBitmap { get; set; }

        /// <summary>
        /// Gets or sets options to render bitmap inside pdf (if ContentAsBitmap is set to true).
        /// </summary>  
        public GraphicsOptions GraphicsOptions { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class VectorRasterizationOptionsDTO {\n");
          sb.Append("  BorderX: ").Append(this.BorderX).Append("\n");
          sb.Append("  BorderY: ").Append(this.BorderY).Append("\n");
          sb.Append("  PageHeight: ").Append(this.PageHeight).Append("\n");
          sb.Append("  PageWidth: ").Append(this.PageWidth).Append("\n");
          sb.Append("  BackgroundColor: ").Append(this.BackgroundColor).Append("\n");
          sb.Append("  DrawColor: ").Append(this.DrawColor).Append("\n");
          sb.Append("  UnitType: ").Append(this.UnitType).Append("\n");
          sb.Append("  ContentAsBitmap: ").Append(this.ContentAsBitmap).Append("\n");
          sb.Append("  GraphicsOptions: ").Append(this.GraphicsOptions).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
