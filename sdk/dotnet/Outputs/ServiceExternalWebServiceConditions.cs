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
    public sealed class ServiceExternalWebServiceConditions
    {
        public readonly ImmutableArray<Outputs.ServiceExternalWebServiceConditionsCondition> Conditions;

        [OutputConstructor]
        private ServiceExternalWebServiceConditions(ImmutableArray<Outputs.ServiceExternalWebServiceConditionsCondition> conditions)
        {
            Conditions = conditions;
        }
    }
}