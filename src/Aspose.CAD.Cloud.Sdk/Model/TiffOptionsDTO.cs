// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TiffOptionsDTO.cs">
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
  /// Export options for TIFF format
  /// </summary>  
  public class TiffOptionsDTO : DrawingOptionsBaseDTO 
  {                       
        /// <summary>
        /// Bytes order (little/big-endian notation)
        /// </summary>
        /// <value>Bytes order (little/big-endian notation)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ByteOrderEnum
        { 
            /// <summary>
            /// Enum LittleEndian for "LittleEndian"
            /// </summary>            
            LittleEndian,
            
            /// <summary>
            /// Enum BigEndian for "BigEndian"
            /// </summary>            
            BigEndian            
        }

        /// <summary>
        /// Compression level
        /// </summary>
        /// <value>Compression level</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CompressionEnum
        { 
            /// <summary>
            /// Enum None for "None"
            /// </summary>            
            None,
            
            /// <summary>
            /// Enum CcittRle for "CcittRle"
            /// </summary>            
            CcittRle,
            
            /// <summary>
            /// Enum CcittFax3 for "CcittFax3"
            /// </summary>            
            CcittFax3,
            
            /// <summary>
            /// Enum CcittFax4 for "CcittFax4"
            /// </summary>            
            CcittFax4,
            
            /// <summary>
            /// Enum Lzw for "Lzw"
            /// </summary>            
            Lzw,
            
            /// <summary>
            /// Enum Ojpeg for "Ojpeg"
            /// </summary>            
            Ojpeg,
            
            /// <summary>
            /// Enum Jpeg for "Jpeg"
            /// </summary>            
            Jpeg,
            
            /// <summary>
            /// Enum AdobeDeflate for "AdobeDeflate"
            /// </summary>            
            AdobeDeflate,
            
            /// <summary>
            /// Enum Next for "Next"
            /// </summary>            
            Next,
            
            /// <summary>
            /// Enum CcittRleW for "CcittRleW"
            /// </summary>            
            CcittRleW,
            
            /// <summary>
            /// Enum Packbits for "Packbits"
            /// </summary>            
            Packbits,
            
            /// <summary>
            /// Enum Thunderscan for "Thunderscan"
            /// </summary>            
            Thunderscan,
            
            /// <summary>
            /// Enum It8Ctpad for "It8Ctpad"
            /// </summary>            
            It8Ctpad,
            
            /// <summary>
            /// Enum It8Lw for "It8Lw"
            /// </summary>            
            It8Lw,
            
            /// <summary>
            /// Enum It8Mp for "It8Mp"
            /// </summary>            
            It8Mp,
            
            /// <summary>
            /// Enum It8Bl for "It8Bl"
            /// </summary>            
            It8Bl,
            
            /// <summary>
            /// Enum PixarFilm for "PixarFilm"
            /// </summary>            
            PixarFilm,
            
            /// <summary>
            /// Enum PixarLog for "PixarLog"
            /// </summary>            
            PixarLog,
            
            /// <summary>
            /// Enum Deflate for "Deflate"
            /// </summary>            
            Deflate,
            
            /// <summary>
            /// Enum Dcs for "Dcs"
            /// </summary>            
            Dcs,
            
            /// <summary>
            /// Enum Jbig for "Jbig"
            /// </summary>            
            Jbig,
            
            /// <summary>
            /// Enum Sgilog for "Sgilog"
            /// </summary>            
            Sgilog,
            
            /// <summary>
            /// Enum Sgilog24 for "Sgilog24"
            /// </summary>            
            Sgilog24,
            
            /// <summary>
            /// Enum Jp2000 for "Jp2000"
            /// </summary>            
            Jp2000            
        }

        /// <summary>
        /// Expected TIFF sub-format
        /// </summary>
        /// <value>Expected TIFF sub-format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExpectedFormatEnum
        { 
            /// <summary>
            /// Enum Default for "Default"
            /// </summary>            
            Default,
            
            /// <summary>
            /// Enum TiffLzwBw for "TiffLzwBw"
            /// </summary>            
            TiffLzwBw,
            
            /// <summary>
            /// Enum TiffLzwRgb for "TiffLzwRgb"
            /// </summary>            
            TiffLzwRgb,
            
            /// <summary>
            /// Enum TiffLzwRgba for "TiffLzwRgba"
            /// </summary>            
            TiffLzwRgba,
            
            /// <summary>
            /// Enum TiffLzwCmyk for "TiffLzwCmyk"
            /// </summary>            
            TiffLzwCmyk,
            
            /// <summary>
            /// Enum TiffCcittFax3 for "TiffCcittFax3"
            /// </summary>            
            TiffCcittFax3,
            
            /// <summary>
            /// Enum TiffCcittFax4 for "TiffCcittFax4"
            /// </summary>            
            TiffCcittFax4,
            
            /// <summary>
            /// Enum TiffDeflateBw for "TiffDeflateBw"
            /// </summary>            
            TiffDeflateBw,
            
            /// <summary>
            /// Enum TiffDeflateRgb for "TiffDeflateRgb"
            /// </summary>            
            TiffDeflateRgb,
            
            /// <summary>
            /// Enum TiffDeflateRgba for "TiffDeflateRgba"
            /// </summary>            
            TiffDeflateRgba,
            
            /// <summary>
            /// Enum TiffCcitRle for "TiffCcitRle"
            /// </summary>            
            TiffCcitRle,
            
            /// <summary>
            /// Enum TiffJpegRgb for "TiffJpegRgb"
            /// </summary>            
            TiffJpegRgb,
            
            /// <summary>
            /// Enum TiffJpegYCbCr for "TiffJpegYCbCr"
            /// </summary>            
            TiffJpegYCbCr,
            
            /// <summary>
            /// Enum TiffNoCompressionBw for "TiffNoCompressionBw"
            /// </summary>            
            TiffNoCompressionBw,
            
            /// <summary>
            /// Enum TiffNoCompressionRgb for "TiffNoCompressionRgb"
            /// </summary>            
            TiffNoCompressionRgb,
            
            /// <summary>
            /// Enum TiffNoCompressionRgba for "TiffNoCompressionRgba"
            /// </summary>            
            TiffNoCompressionRgba            
        }

        /// <summary>
        /// Photometric options
        /// </summary>
        /// <value>Photometric options</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhotometricEnum
        { 
            /// <summary>
            /// Enum MinIsWhite for "MinIsWhite"
            /// </summary>            
            MinIsWhite,
            
            /// <summary>
            /// Enum MinIsBlack for "MinIsBlack"
            /// </summary>            
            MinIsBlack,
            
            /// <summary>
            /// Enum Rgb for "Rgb"
            /// </summary>            
            Rgb,
            
            /// <summary>
            /// Enum Palette for "Palette"
            /// </summary>            
            Palette,
            
            /// <summary>
            /// Enum Mask for "Mask"
            /// </summary>            
            Mask,
            
            /// <summary>
            /// Enum Separated for "Separated"
            /// </summary>            
            Separated,
            
            /// <summary>
            /// Enum Ycbcr for "Ycbcr"
            /// </summary>            
            Ycbcr,
            
            /// <summary>
            /// Enum Cielab for "Cielab"
            /// </summary>            
            Cielab,
            
            /// <summary>
            /// Enum Icclab for "Icclab"
            /// </summary>            
            Icclab,
            
            /// <summary>
            /// Enum Itulab for "Itulab"
            /// </summary>            
            Itulab,
            
            /// <summary>
            /// Enum Logl for "Logl"
            /// </summary>            
            Logl,
            
            /// <summary>
            /// Enum Logluv for "Logluv"
            /// </summary>            
            Logluv            
        }

        /// <summary>
        /// Bytes order (little/big-endian notation)
        /// </summary>
        public ByteOrderEnum? ByteOrder { get; set; }

        /// <summary>
        /// Compression level
        /// </summary>
        public CompressionEnum? Compression { get; set; }

        /// <summary>
        /// Expected TIFF sub-format
        /// </summary>
        public ExpectedFormatEnum? ExpectedFormat { get; set; }

        /// <summary>
        /// Photometric options
        /// </summary>
        public PhotometricEnum? Photometric { get; set; }

        /// <summary>
        /// Bits per pixel
        /// </summary>  
        public List<int?> BitsPerSample { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class TiffOptionsDTO {\n");
          sb.Append("  ByteOrder: ").Append(this.ByteOrder).Append("\n");
          sb.Append("  Compression: ").Append(this.Compression).Append("\n");
          sb.Append("  ExpectedFormat: ").Append(this.ExpectedFormat).Append("\n");
          sb.Append("  BitsPerSample: ").Append(this.BitsPerSample).Append("\n");
          sb.Append("  Photometric: ").Append(this.Photometric).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
