// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class HostAnomaliesV2HostHighMemoryDetection
    {
        /// <summary>
        /// Alert if **both** the memory usage and the memory page fault rate thresholds are exceeded on Windows or on Unix systems
        /// </summary>
        public readonly Outputs.HostAnomaliesV2HostHighMemoryDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Detection mode for high memory usage
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// Detect high memory usage on host
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private HostAnomaliesV2HostHighMemoryDetection(
            Outputs.HostAnomaliesV2HostHighMemoryDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}