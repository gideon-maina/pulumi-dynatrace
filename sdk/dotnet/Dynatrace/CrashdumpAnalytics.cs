// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.PulumiPackage.Dynatrace
{
    [DynatraceResourceType("dynatrace:index/crashdumpAnalytics:CrashdumpAnalytics")]
    public partial class CrashdumpAnalytics : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Disable the feature to stop receiving information about crash details and potential problems. We recommend keeping the feature enabled.
        /// </summary>
        [Output("enableCrashDumpAnalytics")]
        public Output<bool> EnableCrashDumpAnalytics { get; private set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST HOST_GROUP environment)
        /// </summary>
        [Output("hostId")]
        public Output<string> HostId { get; private set; } = null!;


        /// <summary>
        /// Create a CrashdumpAnalytics resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CrashdumpAnalytics(string name, CrashdumpAnalyticsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/crashdumpAnalytics:CrashdumpAnalytics", name, args ?? new CrashdumpAnalyticsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CrashdumpAnalytics(string name, Input<string> id, CrashdumpAnalyticsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/crashdumpAnalytics:CrashdumpAnalytics", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CrashdumpAnalytics resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CrashdumpAnalytics Get(string name, Input<string> id, CrashdumpAnalyticsState? state = null, CustomResourceOptions? options = null)
        {
            return new CrashdumpAnalytics(name, id, state, options);
        }
    }

    public sealed class CrashdumpAnalyticsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Disable the feature to stop receiving information about crash details and potential problems. We recommend keeping the feature enabled.
        /// </summary>
        [Input("enableCrashDumpAnalytics", required: true)]
        public Input<bool> EnableCrashDumpAnalytics { get; set; } = null!;

        /// <summary>
        /// The scope of this setting (HOST HOST_GROUP environment)
        /// </summary>
        [Input("hostId", required: true)]
        public Input<string> HostId { get; set; } = null!;

        public CrashdumpAnalyticsArgs()
        {
        }
        public static new CrashdumpAnalyticsArgs Empty => new CrashdumpAnalyticsArgs();
    }

    public sealed class CrashdumpAnalyticsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Disable the feature to stop receiving information about crash details and potential problems. We recommend keeping the feature enabled.
        /// </summary>
        [Input("enableCrashDumpAnalytics")]
        public Input<bool>? EnableCrashDumpAnalytics { get; set; }

        /// <summary>
        /// The scope of this setting (HOST HOST_GROUP environment)
        /// </summary>
        [Input("hostId")]
        public Input<string>? HostId { get; set; }

        public CrashdumpAnalyticsState()
        {
        }
        public static new CrashdumpAnalyticsState Empty => new CrashdumpAnalyticsState();
    }
}