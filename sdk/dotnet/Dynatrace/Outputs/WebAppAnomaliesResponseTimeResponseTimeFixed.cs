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
    public sealed class WebAppAnomaliesResponseTimeResponseTimeFixed
    {
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedOverAlertingProtection OverAlertingProtection;
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeAll ResponseTimeAll;
        public readonly Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeSlowest ResponseTimeSlowest;
        public readonly string Sensitivity;

        [OutputConstructor]
        private WebAppAnomaliesResponseTimeResponseTimeFixed(
            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedOverAlertingProtection overAlertingProtection,

            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeAll responseTimeAll,

            Outputs.WebAppAnomaliesResponseTimeResponseTimeFixedResponseTimeSlowest responseTimeSlowest,

            string sensitivity)
        {
            OverAlertingProtection = overAlertingProtection;
            ResponseTimeAll = responseTimeAll;
            ResponseTimeSlowest = responseTimeSlowest;
            Sensitivity = sensitivity;
        }
    }
}