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

    public sealed class CustomAnomaliesStrategyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// An auto-adaptive baseline strategy to detect anomalies within metrics that show a regular change over time, as the baseline is also updated automatically. An example is to detect an anomaly in the number of received network packets or within the number of user actions over time
        /// </summary>
        [Input("auto")]
        public Input<Inputs.CustomAnomaliesStrategyAutoGetArgs>? Auto { get; set; }

        [Input("generics")]
        private InputList<Inputs.CustomAnomaliesStrategyGenericGetArgs>? _generics;

        /// <summary>
        /// A generic monitoring strategy
        /// </summary>
        public InputList<Inputs.CustomAnomaliesStrategyGenericGetArgs> Generics
        {
            get => _generics ?? (_generics = new InputList<Inputs.CustomAnomaliesStrategyGenericGetArgs>());
            set => _generics = value;
        }

        /// <summary>
        /// A static threshold monitoring strategy to alert on hard limits within a given metric. An example is the violation of a critical memory limit
        /// </summary>
        [Input("static")]
        public Input<Inputs.CustomAnomaliesStrategyStaticGetArgs>? Static { get; set; }

        public CustomAnomaliesStrategyGetArgs()
        {
        }
        public static new CustomAnomaliesStrategyGetArgs Empty => new CustomAnomaliesStrategyGetArgs();
    }
}