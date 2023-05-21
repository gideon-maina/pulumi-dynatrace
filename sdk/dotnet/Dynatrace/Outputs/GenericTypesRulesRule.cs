// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Outputs
{

    [OutputType]
    public sealed class GenericTypesRulesRule
    {
        public readonly Outputs.GenericTypesRulesRuleAttributes? Attributes;
        public readonly string? IconPattern;
        public readonly string IdPattern;
        public readonly string? InstanceNamePattern;
        public readonly Outputs.GenericTypesRulesRuleRequiredDimensions? RequiredDimensions;
        public readonly string? Role;
        public readonly Outputs.GenericTypesRulesRuleSources Sources;

        [OutputConstructor]
        private GenericTypesRulesRule(
            Outputs.GenericTypesRulesRuleAttributes? attributes,

            string? iconPattern,

            string idPattern,

            string? instanceNamePattern,

            Outputs.GenericTypesRulesRuleRequiredDimensions? requiredDimensions,

            string? role,

            Outputs.GenericTypesRulesRuleSources sources)
        {
            Attributes = attributes;
            IconPattern = iconPattern;
            IdPattern = idPattern;
            InstanceNamePattern = instanceNamePattern;
            RequiredDimensions = requiredDimensions;
            Role = role;
            Sources = sources;
        }
    }
}