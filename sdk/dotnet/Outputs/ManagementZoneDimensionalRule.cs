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
    public sealed class ManagementZoneDimensionalRule
    {
        /// <summary>
        /// The target of the rule. Possible values are
        ///    - `ANY`
        ///    - `LOG`
        ///    - `METRIC`
        /// </summary>
        public readonly string AppliesTo;
        /// <summary>
        /// A list of conditions for the management zone. The management zone applies only if **all** conditions are fulfilled
        /// </summary>
        public readonly ImmutableArray<Outputs.ManagementZoneDimensionalRuleCondition> Conditions;
        /// <summary>
        /// The rule is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private ManagementZoneDimensionalRule(
            string appliesTo,

            ImmutableArray<Outputs.ManagementZoneDimensionalRuleCondition> conditions,

            bool? enabled,

            string? unknowns)
        {
            AppliesTo = appliesTo;
            Conditions = conditions;
            Enabled = enabled;
            Unknowns = unknowns;
        }
    }
}