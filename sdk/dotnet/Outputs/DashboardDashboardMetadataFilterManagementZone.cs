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
    public sealed class DashboardDashboardMetadataFilterManagementZone
    {
        /// <summary>
        /// a short description of the Dynatrace entity
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// the ID of the Dynatrace entity
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// the name of the Dynatrace entity
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DashboardDashboardMetadataFilterManagementZone(
            string? description,

            string id,

            string? name,

            string? unknowns)
        {
            Description = description;
            Id = id;
            Name = name;
            Unknowns = unknowns;
        }
    }
}