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
    public sealed class CalculatedServiceMetricConditionConditionComparisonTag
    {
        /// <summary>
        /// Operator of the comparison. You can reverse it by setting `negate` to `true`. Possible values are `EQUALS`, `EQUALS_ANY_OF`, `TAG_KEY_EQUALS` and `TAG_KEY_EQUALS_ANY_OF`
        /// </summary>
        public readonly string? Operator;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;
        /// <summary>
        /// The values to compare to
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonTagValue? Value;
        /// <summary>
        /// The values to compare to
        /// </summary>
        public readonly Outputs.CalculatedServiceMetricConditionConditionComparisonTagValues? Values;

        [OutputConstructor]
        private CalculatedServiceMetricConditionConditionComparisonTag(
            string? @operator,

            string? unknowns,

            Outputs.CalculatedServiceMetricConditionConditionComparisonTagValue? value,

            Outputs.CalculatedServiceMetricConditionConditionComparisonTagValues? values)
        {
            Operator = @operator;
            Unknowns = unknowns;
            Value = value;
            Values = values;
        }
    }
}