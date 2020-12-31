﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
//   Copyright (c) 2018 Aspose.CAD for Cloud
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

namespace Aspose.CAD.Cloud.Sdk
{
    /// <summary>
    /// Represents a set of configuration settings.
    /// </summary>
    public class Configuration
    {
        internal const string DefaultBaseUrl = "https://api.aspose.cloud";
        internal const AvailableApiVersions DefaultApiVersion = AvailableApiVersions.V3;
        
        private bool debugMode = false;

        /// <summary>
        /// Aspose Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl { get; set; } = DefaultBaseUrl;

        /// <summary>
        /// Gets or sets the API version.
        /// </summary>
        public AvailableApiVersions ApiVersion { get; set; } = AvailableApiVersions.V3;
        
        /// <summary>
        /// Gets or sets the app key.
        /// </summary>
        public string AppKey { get; set; }

        /// <summary>
        /// Gets or sets the app sid.
        /// </summary>
        public string AppSid { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether client will be used to connect to on-premise API.
        /// </summary>
        public bool OnPremise { get; set; }

        internal string GetApiRootUrl()
        {
            ApiBaseUrl = ApiBaseUrl.Replace("http:", "https:");
            var result = this.ApiBaseUrl.TrimEnd('/') + "/" + EnumDescriptionAttributeHelper.GetDescription(this.ApiVersion);
            return result.Trim('/');
        }       
    }
}