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
    [DynatraceResourceType("dynatrace:index/businessEventsBuckets:BusinessEventsBuckets")]
    public partial class BusinessEventsBuckets : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Events will be stored in the selected bucket. Analyze bucket contents in the [log &amp; event viewer.](https://www.terraform.io/ui/logs-events?advancedQueryMode=true&amp;query=fetch+bizevents)
        /// </summary>
        [Output("bucketName")]
        public Output<string> BucketName { get; private set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Output("enabled")]
        public Output<bool> Enabled { get; private set; } = null!;

        /// <summary>
        /// [See our documentation](https://dt-url.net/bp234rv)
        /// </summary>
        [Output("matcher")]
        public Output<string> Matcher { get; private set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Output("ruleName")]
        public Output<string> RuleName { get; private set; } = null!;


        /// <summary>
        /// Create a BusinessEventsBuckets resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BusinessEventsBuckets(string name, BusinessEventsBucketsArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/businessEventsBuckets:BusinessEventsBuckets", name, args ?? new BusinessEventsBucketsArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BusinessEventsBuckets(string name, Input<string> id, BusinessEventsBucketsState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/businessEventsBuckets:BusinessEventsBuckets", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BusinessEventsBuckets resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BusinessEventsBuckets Get(string name, Input<string> id, BusinessEventsBucketsState? state = null, CustomResourceOptions? options = null)
        {
            return new BusinessEventsBuckets(name, id, state, options);
        }
    }

    public sealed class BusinessEventsBucketsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Events will be stored in the selected bucket. Analyze bucket contents in the [log &amp; event viewer.](https://www.terraform.io/ui/logs-events?advancedQueryMode=true&amp;query=fetch+bizevents)
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// [See our documentation](https://dt-url.net/bp234rv)
        /// </summary>
        [Input("matcher", required: true)]
        public Input<string> Matcher { get; set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        public BusinessEventsBucketsArgs()
        {
        }
        public static new BusinessEventsBucketsArgs Empty => new BusinessEventsBucketsArgs();
    }

    public sealed class BusinessEventsBucketsState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Events will be stored in the selected bucket. Analyze bucket contents in the [log &amp; event viewer.](https://www.terraform.io/ui/logs-events?advancedQueryMode=true&amp;query=fetch+bizevents)
        /// </summary>
        [Input("bucketName")]
        public Input<string>? BucketName { get; set; }

        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// [See our documentation](https://dt-url.net/bp234rv)
        /// </summary>
        [Input("matcher")]
        public Input<string>? Matcher { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        public BusinessEventsBucketsState()
        {
        }
        public static new BusinessEventsBucketsState Empty => new BusinessEventsBucketsState();
    }
}