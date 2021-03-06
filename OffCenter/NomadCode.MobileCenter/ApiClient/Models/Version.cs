// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace NomadCode.MobileCenter.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class Version
    {
        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version() { }

        /// <summary>
        /// Initializes a new instance of the Version class.
        /// </summary>
        public Version(string versionProperty = default(string), long? count = default(long?), long? previousCount = default(long?))
        {
            VersionProperty = versionProperty;
            Count = count;
            PreviousCount = previousCount;
        }

        /// <summary>
        /// version
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string VersionProperty { get; set; }

        /// <summary>
        /// version count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// the count of previous time range of the version
        /// </summary>
        [JsonProperty(PropertyName = "previous_count")]
        public long? PreviousCount { get; set; }

    }
}
