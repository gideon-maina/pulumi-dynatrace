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
    public sealed class HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsEventThresholds
    {
        /// <summary>
        /// The number of **10-second samples** that form the sliding evaluation window for dealerting.
        /// </summary>
        public readonly int DealertingEvaluationWindow;
        /// <summary>
        /// The number of **10-second samples** within the evaluation window that must be lower the threshold to close an event
        /// </summary>
        public readonly int DealertingSamples;
        /// <summary>
        /// The number of **10-second samples** that form the sliding evaluation window to detect violating samples.
        /// </summary>
        public readonly int ViolatingEvaluationWindow;
        /// <summary>
        /// The number of **10-second samples** within the evaluation window that must exceed the threshold to trigger an event
        /// </summary>
        public readonly int ViolatingSamples;

        [OutputConstructor]
        private HostAnomaliesV2HostHighMemoryDetectionCustomThresholdsEventThresholds(
            int dealertingEvaluationWindow,

            int dealertingSamples,

            int violatingEvaluationWindow,

            int violatingSamples)
        {
            DealertingEvaluationWindow = dealertingEvaluationWindow;
            DealertingSamples = dealertingSamples;
            ViolatingEvaluationWindow = violatingEvaluationWindow;
            ViolatingSamples = violatingSamples;
        }
    }
}