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

    public sealed class HostAnomaliesV2NetworkNetworkTcpProblemsDetectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alert if the percentage of new connection failures is higher than the specified threshold **and** the number of failed connections is higher than the defined threshold for the defined amount of samples
        /// </summary>
        [Input("customThresholds")]
        public Input<Inputs.HostAnomaliesV2NetworkNetworkTcpProblemsDetectionCustomThresholdsArgs>? CustomThresholds { get; set; }

        /// <summary>
        /// Detection mode for TCP connectivity problems
        /// </summary>
        [Input("detectionMode")]
        public Input<string>? DetectionMode { get; set; }

        /// <summary>
        /// Detect TCP connectivity problems for process
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        public HostAnomaliesV2NetworkNetworkTcpProblemsDetectionArgs()
        {
        }
        public static new HostAnomaliesV2NetworkNetworkTcpProblemsDetectionArgs Empty => new HostAnomaliesV2NetworkNetworkTcpProblemsDetectionArgs();
    }
}