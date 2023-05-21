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
    public sealed class ServiceAnomaliesV2LoadSpikes
    {
        /// <summary>
        /// Detect service load spikes
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Threshold
        /// </summary>
        public readonly double? LoadSpikePercent;
        /// <summary>
        /// Time span
        /// </summary>
        public readonly int? MinutesAbnormalState;

        [OutputConstructor]
        private ServiceAnomaliesV2LoadSpikes(
            bool enabled,

            double? loadSpikePercent,

            int? minutesAbnormalState)
        {
            Enabled = enabled;
            LoadSpikePercent = loadSpikePercent;
            MinutesAbnormalState = minutesAbnormalState;
        }
    }
}