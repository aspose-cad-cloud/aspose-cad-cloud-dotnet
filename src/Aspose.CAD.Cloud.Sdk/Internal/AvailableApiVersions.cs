using System;

namespace Aspose.CAD.Cloud.Sdk
{
    /// <summary>
    /// The available api versions.
    /// </summary>
    public enum AvailableApiVersions
    {
        /// <summary>
        /// Current API version
        /// </summary>
        [EnumDescription("v1.0")]
        V1 = 0,

        /// <summary>
        /// Don't use it, added for backward campability
        /// </summary>
        [Obsolete]
        [EnumDescription("v1.1")]
        V11 = 99,

        /// <summary>
        /// Stable version
        /// </summary>
        [EnumDescription("v2.0")]
        V2 = 1,

        /// <summary>
        /// Frozen version
        /// </summary>
        [EnumDescription("v3.0")]
        V3 = 2
    }
}