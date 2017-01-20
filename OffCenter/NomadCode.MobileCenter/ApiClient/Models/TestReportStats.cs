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

    public partial class TestReportStats
    {
        /// <summary>
        /// Initializes a new instance of the TestReportStats class.
        /// </summary>
        public TestReportStats() { }

        /// <summary>
        /// Initializes a new instance of the TestReportStats class.
        /// </summary>
        public TestReportStats(double? os = default(double?), double? devices = default(double?), double? filesize = default(double?), double? totalDeviceMinutes = default(double?), double? devicesNotRunned = default(double?), double? failed = default(double?), double? skipped = default(double?), double? passed = default(double?), double? total = default(double?), double? devicesFinished = default(double?), double? devicesFailed = default(double?), double? devicesSkipped = default(double?), double? stepCount = default(double?))
        {
            Os = os;
            Devices = devices;
            Filesize = filesize;
            TotalDeviceMinutes = totalDeviceMinutes;
            DevicesNotRunned = devicesNotRunned;
            Failed = failed;
            Skipped = skipped;
            Passed = passed;
            Total = total;
            DevicesFinished = devicesFinished;
            DevicesFailed = devicesFailed;
            DevicesSkipped = devicesSkipped;
            StepCount = stepCount;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public double? Os { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public double? Devices { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filesize")]
        public double? Filesize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalDeviceMinutes")]
        public double? TotalDeviceMinutes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices_not_runned")]
        public double? DevicesNotRunned { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "failed")]
        public double? Failed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skipped")]
        public double? Skipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "passed")]
        public double? Passed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "total")]
        public double? Total { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices_finished")]
        public double? DevicesFinished { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices_failed")]
        public double? DevicesFailed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices_skipped")]
        public double? DevicesSkipped { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "step_count")]
        public double? StepCount { get; set; }

    }
}