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

    public sealed class RequestNamingConditionsConditionComparisonServiceTypeGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Operator of the comparison. You can reverse it by setting `negate` to `true`. Possible values are `EQUALS`, `EQUALS_ANY_OF` and `EXISTS`
        /// </summary>
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        [Input("unknowns")]
        public Input<string>? Unknowns { get; set; }

        /// <summary>
        /// The value to compare to. Possible values are `BACKGROUND_ACTIVITY`, `CICS_SERVICE`, `CUSTOM_SERVICE`, `DATABASE_SERVICE`, `ENTERPRISE_SERVICE_BUS_SERVICE`, `EXTERNAL`, `IBM_INTEGRATION_BUS_SERVICE`, `IMS_SERVICE`, `MESSAGING_SERVICE`, `RMI_SERVICE`, `RPC_SERVICE`, `WEB_REQUEST_SERVICE` and `WEB_SERVICE`
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// The values to compare to. Possible values are `BACKGROUND_ACTIVITY`, `CICS_SERVICE`, `CUSTOM_SERVICE`, `DATABASE_SERVICE`, `ENTERPRISE_SERVICE_BUS_SERVICE`, `EXTERNAL`, `IBM_INTEGRATION_BUS_SERVICE`, `IMS_SERVICE`, `MESSAGING_SERVICE`, `RMI_SERVICE`, `RPC_SERVICE`, `WEB_REQUEST_SERVICE` and `WEB_SERVICE`
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public RequestNamingConditionsConditionComparisonServiceTypeGetArgs()
        {
        }
        public static new RequestNamingConditionsConditionComparisonServiceTypeGetArgs Empty => new RequestNamingConditionsConditionComparisonServiceTypeGetArgs();
    }
}