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

    public sealed class ServiceAnomaliesLoadGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration of traffic drops detection
        /// </summary>
        [Input("drops")]
        public Input<Inputs.ServiceAnomaliesLoadDropsGetArgs>? Drops { get; set; }

        /// <summary>
        /// The configuration of traffic spikes detection
        /// </summary>
        [Input("spikes")]
        public Input<Inputs.ServiceAnomaliesLoadSpikesGetArgs>? Spikes { get; set; }

        public ServiceAnomaliesLoadGetArgs()
        {
        }
        public static new ServiceAnomaliesLoadGetArgs Empty => new ServiceAnomaliesLoadGetArgs();
    }
}