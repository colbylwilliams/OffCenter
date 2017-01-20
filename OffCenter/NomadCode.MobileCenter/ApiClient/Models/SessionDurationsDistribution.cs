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

    public partial class SessionDurationsDistribution
    {
        /// <summary>
        /// Initializes a new instance of the SessionDurationsDistribution
        /// class.
        /// </summary>
        public SessionDurationsDistribution() { }

        /// <summary>
        /// Initializes a new instance of the SessionDurationsDistribution
        /// class.
        /// </summary>
        public SessionDurationsDistribution(IList<SessionDurationsDistributionDistributionItem> distribution = default(IList<SessionDurationsDistributionDistributionItem>), string previousAverageDuration = default(string), string averageDuration = default(string))
        {
            Distribution = distribution;
            PreviousAverageDuration = previousAverageDuration;
            AverageDuration = averageDuration;
        }

        /// <summary>
        /// the count of sessions in these buckets
        /// </summary>
        [JsonProperty(PropertyName = "distribution")]
        public IList<SessionDurationsDistributionDistributionItem> Distribution { get; set; }

        /// <summary>
        /// the previous average session duration for previous time range
        /// </summary>
        [JsonProperty(PropertyName = "previous_average_duration")]
        public string PreviousAverageDuration { get; set; }

        /// <summary>
        /// the average session duration for current time range
        /// </summary>
        [JsonProperty(PropertyName = "average_duration")]
        public string AverageDuration { get; set; }

    }
}