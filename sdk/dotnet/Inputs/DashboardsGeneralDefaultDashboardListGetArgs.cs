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

    public sealed class DashboardsGeneralDefaultDashboardListGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("defaultDashboards", required: true)]
        private InputList<Inputs.DashboardsGeneralDefaultDashboardListDefaultDashboardGetArgs>? _defaultDashboards;
        public InputList<Inputs.DashboardsGeneralDefaultDashboardListDefaultDashboardGetArgs> DefaultDashboards
        {
            get => _defaultDashboards ?? (_defaultDashboards = new InputList<Inputs.DashboardsGeneralDefaultDashboardListDefaultDashboardGetArgs>());
            set => _defaultDashboards = value;
        }

        public DashboardsGeneralDefaultDashboardListGetArgs()
        {
        }
        public static new DashboardsGeneralDefaultDashboardListGetArgs Empty => new DashboardsGeneralDefaultDashboardListGetArgs();
    }
}