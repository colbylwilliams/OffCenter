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

    /// <summary>
    /// Physical device dimensions
    /// </summary>
    public partial class DeviceDimensions
    {
        /// <summary>
        /// Initializes a new instance of the DeviceDimensions class.
        /// </summary>
        public DeviceDimensions() { }

        /// <summary>
        /// Initializes a new instance of the DeviceDimensions class.
        /// </summary>
        public DeviceDimensions(object depth = default(object), object height = default(object), object width = default(object))
        {
            Depth = depth;
            Height = height;
            Width = width;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "depth")]
        public object Depth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public object Height { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public object Width { get; set; }

    }
}
