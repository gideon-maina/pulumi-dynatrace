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
    public sealed class FailureDetectionRulesConditionsCondition
    {
        /// <summary>
        /// Possible Values: `PG_NAME`, `PG_TAG`, `SERVICE_MANAGEMENT_ZONE`, `SERVICE_NAME`, `SERVICE_TAG`, `SERVICE_TYPE`
        /// </summary>
        public readonly string Attribute;
        /// <summary>
        /// Condition to check the attribute against
        /// </summary>
        public readonly Outputs.FailureDetectionRulesConditionsConditionPredicate Predicate;

        [OutputConstructor]
        private FailureDetectionRulesConditionsCondition(
            string attribute,

            Outputs.FailureDetectionRulesConditionsConditionPredicate predicate)
        {
            Attribute = attribute;
            Predicate = predicate;
        }
    }
}