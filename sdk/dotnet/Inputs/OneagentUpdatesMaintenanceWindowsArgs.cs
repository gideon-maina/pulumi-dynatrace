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

    public sealed class OneagentUpdatesMaintenanceWindowsArgs : global::Pulumi.ResourceArgs
    {
        [Input("maintenanceWindows", required: true)]
        private InputList<Inputs.OneagentUpdatesMaintenanceWindowsMaintenanceWindowArgs>? _maintenanceWindows;
        public InputList<Inputs.OneagentUpdatesMaintenanceWindowsMaintenanceWindowArgs> MaintenanceWindows
        {
            get => _maintenanceWindows ?? (_maintenanceWindows = new InputList<Inputs.OneagentUpdatesMaintenanceWindowsMaintenanceWindowArgs>());
            set => _maintenanceWindows = value;
        }

        public OneagentUpdatesMaintenanceWindowsArgs()
        {
        }
        public static new OneagentUpdatesMaintenanceWindowsArgs Empty => new OneagentUpdatesMaintenanceWindowsArgs();
    }
}