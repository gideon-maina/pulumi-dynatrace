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

    public sealed class CustomAnomaliesStrategyAutoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The condition for the **threshold** value check: `ABOVE` or `BELOW`
        /// </summary>
        [Input("alertCondition", required: true)]
        public Input<string> AlertCondition { get; set; } = null!;

        /// <summary>
        /// If true, also one-minute samples without data are counted as violating samples
        /// </summary>
        [Input("alertingOnMissingData")]
        public Input<bool>? AlertingOnMissingData { get; set; }

        /// <summary>
        /// The number of one-minute samples within the evaluation window that must go back to normal to close the event
        /// </summary>
        [Input("dealertingSamples", required: true)]
        public Input<int> DealertingSamples { get; set; } = null!;

        /// <summary>
        /// The number of one-minute samples that form the sliding evaluation window
        /// </summary>
        [Input("samples", required: true)]
        public Input<int> Samples { get; set; } = null!;

        /// <summary>
        /// Defines the factor of how many signal fluctuations are valid. Values above the baseline plus the signal fluctuation times the number of tolerated signal fluctuations are alerted
        /// </summary>
        [Input("signalFluctuations", required: true)]
        public Input<double> SignalFluctuations { get; set; } = null!;

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The number of one-minute samples within the evaluation window that must violate the threshold to trigger an event
        /// </summary>
        [Input("violatingSamples", required: true)]
        public Input<int> ViolatingSamples { get; set; } = null!;

        public CustomAnomaliesStrategyAutoArgs()
        {
        }
        public static new CustomAnomaliesStrategyAutoArgs Empty => new CustomAnomaliesStrategyAutoArgs();
    }
}