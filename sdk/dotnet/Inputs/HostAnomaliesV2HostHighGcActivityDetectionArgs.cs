// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Inputs
{

    public sealed class HostAnomaliesV2HostHighGcActivityDetectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if the GC time **or** the GC suspension is exceeded
        /// </summary>
        [Input("customThresholds")]
        public Input<Inputs.HostAnomaliesV2HostHighGcActivityDetectionCustomThresholdsArgs>? CustomThresholds { get; set; }

        /// <summary>
        /// Detection mode for high GC activity
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// You may also configure high GC activity alerting for .NET processes on [extensions events page](https://www.terraform.io/#settings/anomalydetection/extensionevents).
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public HostAnomaliesV2HostHighGcActivityDetectionArgs()
        {
        }
        public static new HostAnomaliesV2HostHighGcActivityDetectionArgs Empty => new HostAnomaliesV2HostHighGcActivityDetectionArgs();
    }
}