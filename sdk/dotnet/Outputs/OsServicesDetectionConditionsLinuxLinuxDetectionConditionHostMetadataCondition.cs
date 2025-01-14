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
    public sealed class OsServicesDetectionConditionsLinuxLinuxDetectionConditionHostMetadataCondition
    {
        /// <summary>
        /// This string has to match a required format. See [OS services monitoring](https://dt-url.net/vl03xzk).
        /// </summary>
        public readonly string MetadataCondition;
        /// <summary>
        /// Key
        /// </summary>
        public readonly string MetadataKey;

        [OutputConstructor]
        private OsServicesDetectionConditionsLinuxLinuxDetectionConditionHostMetadataCondition(
            string metadataCondition,

            string metadataKey)
        {
            MetadataCondition = metadataCondition;
            MetadataKey = metadataKey;
        }
    }
}
