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
    public sealed class HostAnomaliesMemory
    {
        /// <summary>
        /// The detection is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Custom thresholds for high memory usage. If not set then the automatic mode is used. **Both** conditions must be met to trigger an alert
        /// </summary>
        public readonly Outputs.HostAnomaliesMemoryThresholds? Thresholds;

        [OutputConstructor]
        private HostAnomaliesMemory(
            bool enabled,

            Outputs.HostAnomaliesMemoryThresholds? thresholds)
        {
            Enabled = enabled;
            Thresholds = thresholds;
        }
    }
}