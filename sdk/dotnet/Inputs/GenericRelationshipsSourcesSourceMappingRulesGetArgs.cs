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

    public sealed class GenericRelationshipsSourcesSourceMappingRulesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("mappingRules", required: true)]
        private InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleGetArgs>? _mappingRules;
        public InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleGetArgs> MappingRules
        {
            get => _mappingRules ?? (_mappingRules = new InputList<Inputs.GenericRelationshipsSourcesSourceMappingRulesMappingRuleGetArgs>());
            set => _mappingRules = value;
        }

        public GenericRelationshipsSourcesSourceMappingRulesGetArgs()
        {
        }
        public static new GenericRelationshipsSourcesSourceMappingRulesGetArgs Empty => new GenericRelationshipsSourcesSourceMappingRulesGetArgs();
    }
}