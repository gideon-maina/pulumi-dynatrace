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

    public sealed class DashboardTileFilterConfigFiltersFilterMatchGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The entity type (e.g. HOST, SERVICE, ...)
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("values")]
        private InputList<string>? _values;

        /// <summary>
        /// the tiles this Dashboard consist of
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public DashboardTileFilterConfigFiltersFilterMatchGetArgs()
        {
        }
        public static new DashboardTileFilterConfigFiltersFilterMatchGetArgs Empty => new DashboardTileFilterConfigFiltersFilterMatchGetArgs();
    }
}