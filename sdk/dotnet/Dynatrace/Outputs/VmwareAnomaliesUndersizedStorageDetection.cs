// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class VmwareAnomaliesUndersizedStorageDetection
    {
        /// <summary>
        /// Alert if **any** condition is met in 3 out of 5 samples
        /// </summary>
        public readonly Outputs.VmwareAnomaliesUndersizedStorageDetectionCustomThresholds? CustomThresholds;
        /// <summary>
        /// Possible Values: `Auto`, `Custom`
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private VmwareAnomaliesUndersizedStorageDetection(
            Outputs.VmwareAnomaliesUndersizedStorageDetectionCustomThresholds? customThresholds,

            string? detectionMode,

            bool enabled)
        {
            CustomThresholds = customThresholds;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}