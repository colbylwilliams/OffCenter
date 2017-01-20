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

    public partial class CrashGroupCounts
    {
        /// <summary>
        /// Initializes a new instance of the CrashGroupCounts class.
        /// </summary>
        public CrashGroupCounts() { }

        /// <summary>
        /// Initializes a new instance of the CrashGroupCounts class.
        /// </summary>
        public CrashGroupCounts(double? crashGroupCount = default(double?))
        {
            CrashGroupCount = crashGroupCount;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "crash_group_count")]
        public double? CrashGroupCount { get; set; }

    }
}