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

    public sealed class HostNamingConditionConditionIndexedTagValueGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The origin of the tag, such as AWS or Cloud Foundry. Possible values are AWS, AWS_GENERIC, AZURE, CLOUD_FOUNDRY, CONTEXTLESS, ENVIRONMENT, GOOGLE_CLOUD and KUBERNETES. Custom tags use the `CONTEXTLESS` value
        /// </summary>
        [Input("context", required: true)]
        public Input<string> Context { get; set; } = null!;

        /// <summary>
        /// The key of the tag. Custom tags have the tag value here
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Any attributes that aren't yet supported by this provider but have meanwhile gotten introduced by a newer version of the Dynatrace REST API
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The value of the tag. Not applicable to custom tags
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public HostNamingConditionConditionIndexedTagValueGetArgs()
        {
        }
        public static new HostNamingConditionConditionIndexedTagValueGetArgs Empty => new HostNamingConditionConditionIndexedTagValueGetArgs();
    }
}