// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace.Inputs
{

    public sealed class RumProviderBreakdownDomainNamePatternListGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("domainNamePatterns", required: true)]
        private InputList<Inputs.RumProviderBreakdownDomainNamePatternListDomainNamePatternGetArgs>? _domainNamePatterns;
        public InputList<Inputs.RumProviderBreakdownDomainNamePatternListDomainNamePatternGetArgs> DomainNamePatterns
        {
            get => _domainNamePatterns ?? (_domainNamePatterns = new InputList<Inputs.RumProviderBreakdownDomainNamePatternListDomainNamePatternGetArgs>());
            set => _domainNamePatterns = value;
        }

        public RumProviderBreakdownDomainNamePatternListGetArgs()
        {
        }
        public static new RumProviderBreakdownDomainNamePatternListGetArgs Empty => new RumProviderBreakdownDomainNamePatternListGetArgs();
    }
}