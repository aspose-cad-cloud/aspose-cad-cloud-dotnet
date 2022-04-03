// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="X509Certificate2.cs">
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
  /// 
  /// </summary>  
  public class X509Certificate2 : X509Certificate 
  {                       
        /// <summary>
        /// Gets or sets Archived
        /// </summary>  
        public bool? Archived { get; set; }

        /// <summary>
        /// Gets or sets Extensions
        /// </summary>  
        public List<Object> Extensions { get; set; }

        /// <summary>
        /// Gets or sets FriendlyName
        /// </summary>  
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets HasPrivateKey
        /// </summary>  
        public bool? HasPrivateKey { get; set; }

        /// <summary>
        /// Gets or sets PrivateKey
        /// </summary>  
        public AsymmetricAlgorithm PrivateKey { get; set; }

        /// <summary>
        /// Gets or sets IssuerName
        /// </summary>  
        public X500DistinguishedName IssuerName { get; set; }

        /// <summary>
        /// Gets or sets NotAfter
        /// </summary>  
        public DateTime? NotAfter { get; set; }

        /// <summary>
        /// Gets or sets NotBefore
        /// </summary>  
        public DateTime? NotBefore { get; set; }

        /// <summary>
        /// Gets or sets PublicKey
        /// </summary>  
        public PublicKey PublicKey { get; set; }

        /// <summary>
        /// Gets or sets RawData
        /// </summary>  
        public byte[] RawData { get; set; }

        /// <summary>
        /// Gets or sets SerialNumber
        /// </summary>  
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or sets SignatureAlgorithm
        /// </summary>  
        public Oid SignatureAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets SubjectName
        /// </summary>  
        public X500DistinguishedName SubjectName { get; set; }

        /// <summary>
        /// Gets or sets Thumbprint
        /// </summary>  
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets Version
        /// </summary>  
        public int? Version { get; set; }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class X509Certificate2 {\n");
          sb.Append("  Archived: ").Append(this.Archived).Append("\n");
          sb.Append("  Extensions: ").Append(this.Extensions).Append("\n");
          sb.Append("  FriendlyName: ").Append(this.FriendlyName).Append("\n");
          sb.Append("  HasPrivateKey: ").Append(this.HasPrivateKey).Append("\n");
          sb.Append("  PrivateKey: ").Append(this.PrivateKey).Append("\n");
          sb.Append("  IssuerName: ").Append(this.IssuerName).Append("\n");
          sb.Append("  NotAfter: ").Append(this.NotAfter).Append("\n");
          sb.Append("  NotBefore: ").Append(this.NotBefore).Append("\n");
          sb.Append("  PublicKey: ").Append(this.PublicKey).Append("\n");
          sb.Append("  RawData: ").Append(this.RawData).Append("\n");
          sb.Append("  SerialNumber: ").Append(this.SerialNumber).Append("\n");
          sb.Append("  SignatureAlgorithm: ").Append(this.SignatureAlgorithm).Append("\n");
          sb.Append("  SubjectName: ").Append(this.SubjectName).Append("\n");
          sb.Append("  Thumbprint: ").Append(this.Thumbprint).Append("\n");
          sb.Append("  Version: ").Append(this.Version).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
