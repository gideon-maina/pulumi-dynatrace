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

    public sealed class AutomationWorkflowTriggerEventGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// If specified the workflow is getting triggered based on a schedule
        /// </summary>
        [Input("active")]
        public Input<bool>? Active { get; set; }

        /// <summary>
        /// If specified the workflow is getting triggered based on events
        /// </summary>
        [Input("config")]
        public Input<Inputs.AutomationWorkflowTriggerEventConfigGetArgs>? Config { get; set; }

        public AutomationWorkflowTriggerEventGetArgs()
        {
        }
        public static new AutomationWorkflowTriggerEventGetArgs Empty => new AutomationWorkflowTriggerEventGetArgs();
    }
}