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

    public sealed class QueueManagerAliasQueueAliasQueueGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the alias queue
        /// </summary>
        [Input("aliasQueueName", required: true)]
        public Input<string> AliasQueueName { get; set; } = null!;

        /// <summary>
        /// The name of the base queue
        /// </summary>
        [Input("baseQueueName", required: true)]
        public Input<string> BaseQueueName { get; set; } = null!;

        [Input("clusterVisibilities")]
        private InputList<string>? _clusterVisibilities;

        /// <summary>
        /// Name of the cluster(s) this alias should be visible in
        /// </summary>
        public InputList<string> ClusterVisibilities
        {
            get => _clusterVisibilities ?? (_clusterVisibilities = new InputList<string>());
            set => _clusterVisibilities = value;
        }

        public QueueManagerAliasQueueAliasQueueGetArgs()
        {
        }
        public static new QueueManagerAliasQueueAliasQueueGetArgs Empty => new QueueManagerAliasQueueAliasQueueGetArgs();
    }
}