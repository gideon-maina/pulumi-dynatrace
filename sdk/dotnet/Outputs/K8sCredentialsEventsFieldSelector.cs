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
    public sealed class K8sCredentialsEventsFieldSelector
    {
        /// <summary>
        /// Whether subscription to this events field selector is enabled (value set to `true`). If disabled (value set to `false`), Dynatrace will stop fetching events from the Kubernetes API for this events field selector
        /// </summary>
        public readonly bool Active;
        /// <summary>
        /// The field selector string (url decoding is applied) when storing it.
        /// </summary>
        public readonly string FieldSelector;
        /// <summary>
        /// A label of the events field selector.
        /// </summary>
        public readonly string Label;
        /// <summary>
        /// Any attributes that aren't yet supported by this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private K8sCredentialsEventsFieldSelector(
            bool active,

            string fieldSelector,

            string label,

            string? unknowns)
        {
            Active = active;
            FieldSelector = fieldSelector;
            Label = label;
            Unknowns = unknowns;
        }
    }
}