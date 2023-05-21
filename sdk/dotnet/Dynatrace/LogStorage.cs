// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Lbrlabs.PulumiPackage.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/logStorage:LogStorage")]
    public partial class LogStorage : global::Pulumi.CustomResource
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Output("matchers")]
        public Output<Outputs.LogStorageMatchers?> Matchers { get; private set; } = null!;

        /// <summary>
        /// Name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// If `true` matching logs will be included in storage. If `false` matching logs will be excluded from storage.
        /// </summary>
        [Output("sendToStorage")]
        public Output<bool> SendToStorage { get; private set; } = null!;


        /// <summary>
        /// Create a LogStorage resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogStorage(string name, LogStorageArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/logStorage:LogStorage", name, args ?? new LogStorageArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogStorage(string name, Input<string> id, LogStorageState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/logStorage:LogStorage", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/lbrlabs",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing LogStorage resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogStorage Get(string name, Input<string> id, LogStorageState? state = null, CustomResourceOptions? options = null)
        {
            return new LogStorage(name, id, state, options);
        }
    }

    public sealed class LogStorageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("matchers")]
        public Input<Inputs.LogStorageMatchersArgs>? Matchers { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// If `true` matching logs will be included in storage. If `false` matching logs will be excluded from storage.
        /// </summary>
        [Input("sendToStorage", required: true)]
        public Input<bool> SendToStorage { get; set; } = null!;

        public LogStorageArgs()
        {
        }
        public static new LogStorageArgs Empty => new LogStorageArgs();
    }

    public sealed class LogStorageState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// no documentation available
        /// </summary>
        [Input("matchers")]
        public Input<Inputs.LogStorageMatchersGetArgs>? Matchers { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// If `true` matching logs will be included in storage. If `false` matching logs will be excluded from storage.
        /// </summary>
        [Input("sendToStorage")]
        public Input<bool>? SendToStorage { get; set; }

        public LogStorageState()
        {
        }
        public static new LogStorageState Empty => new LogStorageState();
    }
}