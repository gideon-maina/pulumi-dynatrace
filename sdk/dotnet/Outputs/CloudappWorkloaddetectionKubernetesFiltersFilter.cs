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
    public sealed class CloudappWorkloaddetectionKubernetesFiltersFilter
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// ID calculation based on
        /// </summary>
        public readonly Outputs.CloudappWorkloaddetectionKubernetesFiltersFilterInclusionToggles InclusionToggles;
        /// <summary>
        /// When namespace
        /// </summary>
        public readonly Outputs.CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilter MatchFilter;

        [OutputConstructor]
        private CloudappWorkloaddetectionKubernetesFiltersFilter(
            bool enabled,

            Outputs.CloudappWorkloaddetectionKubernetesFiltersFilterInclusionToggles inclusionToggles,

            Outputs.CloudappWorkloaddetectionKubernetesFiltersFilterMatchFilter matchFilter)
        {
            Enabled = enabled;
            InclusionToggles = inclusionToggles;
            MatchFilter = matchFilter;
        }
    }
}