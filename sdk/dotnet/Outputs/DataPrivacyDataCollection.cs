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
    public sealed class DataPrivacyDataCollection
    {
        /// <summary>
        /// With [Data-collection and opt-in mode](https://dt-url.net/7l3p0p3h) enabled, Real User Monitoring data isn't captured until dtrum.enable() is called for specific user sessions.
        /// </summary>
        public readonly bool OptInModeEnabled;

        [OutputConstructor]
        private DataPrivacyDataCollection(bool optInModeEnabled)
        {
            OptInModeEnabled = optInModeEnabled;
        }
    }
}