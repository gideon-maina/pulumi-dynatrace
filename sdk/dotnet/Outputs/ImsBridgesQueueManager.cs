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
    public sealed class ImsBridgesQueueManager
    {
        /// <summary>
        /// Queue manager definition for IMS bridge
        /// </summary>
        public readonly ImmutableArray<Outputs.ImsBridgesQueueManagerQueueManager> QueueManagers;

        [OutputConstructor]
        private ImsBridgesQueueManager(ImmutableArray<Outputs.ImsBridgesQueueManagerQueueManager> queueManagers)
        {
            QueueManagers = queueManagers;
        }
    }
}