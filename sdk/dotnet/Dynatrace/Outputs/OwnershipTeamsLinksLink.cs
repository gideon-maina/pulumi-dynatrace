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
    public sealed class OwnershipTeamsLinksLink
    {
        public readonly string LinkType;
        public readonly string Url;

        [OutputConstructor]
        private OwnershipTeamsLinksLink(
            string linkType,

            string url)
        {
            LinkType = linkType;
            Url = url;
        }
    }
}