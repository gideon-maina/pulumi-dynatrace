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
    /// <summary>
    /// &gt; This resource requires one of the cluster API token scopes **Control Management** (`ControlManagement`), **Service Provider API** (`ServiceProviderAPI`), or **Unattended Install** (`UnattendedInstall`)
    /// 
    /// ## Dynatrace Documentation
    /// 
    /// - Can I use a proxy for internet access? - https://www.dynatrace.com/support/help/managed-cluster/configuration/can-i-use-a-proxy-for-internet-access
    /// 
    /// - Cluster API v1 - https://www.dynatrace.com/support/help/managed-cluster/cluster-api/cluster-api-v1
    /// 
    /// ## Resource Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Dynatrace = Pulumiverse.PulumiPackage.Dynatrace;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var test = new Dynatrace.ManagedInternetProxy("test", new()
    ///     {
    ///         NonProxyHosts = new[]
    ///         {
    ///             "string",
    ///         },
    ///         Password = "string",
    ///         Port = 65535,
    ///         Scheme = "http",
    ///         Server = "zAOE-GV81/65oVgaIlPYTCADGSPFJ9ZqXYNGbxn97dbq:flAI2E8e8bfOvlmaGu",
    ///         User = "string",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [DynatraceResourceType("dynatrace:index/managedInternetProxy:ManagedInternetProxy")]
    public partial class ManagedInternetProxy : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Definition of hosts for which proxy won't be used. You can define multiple hosts. Each host can start or end with wildcard '*' for instance to match whole domain.
        /// </summary>
        [Output("nonProxyHosts")]
        public Output<ImmutableArray<string>> NonProxyHosts { get; private set; } = null!;

        /// <summary>
        /// Password of proxy server, null means do not change previous value
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// Port of proxy server
        /// </summary>
        [Output("port")]
        public Output<int> Port { get; private set; } = null!;

        /// <summary>
        /// Protocol which proxy server uses
        /// </summary>
        [Output("scheme")]
        public Output<string> Scheme { get; private set; } = null!;

        /// <summary>
        /// Address (either IP or Hostname) of proxy server
        /// </summary>
        [Output("server")]
        public Output<string> Server { get; private set; } = null!;

        /// <summary>
        /// User of proxy server, null means do not change previous value
        /// </summary>
        [Output("user")]
        public Output<string?> User { get; private set; } = null!;


        /// <summary>
        /// Create a ManagedInternetProxy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ManagedInternetProxy(string name, ManagedInternetProxyArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedInternetProxy:ManagedInternetProxy", name, args ?? new ManagedInternetProxyArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ManagedInternetProxy(string name, Input<string> id, ManagedInternetProxyState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/managedInternetProxy:ManagedInternetProxy", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/pulumiverse",
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ManagedInternetProxy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ManagedInternetProxy Get(string name, Input<string> id, ManagedInternetProxyState? state = null, CustomResourceOptions? options = null)
        {
            return new ManagedInternetProxy(name, id, state, options);
        }
    }

    public sealed class ManagedInternetProxyArgs : global::Pulumi.ResourceArgs
    {
        [Input("nonProxyHosts")]
        private InputList<string>? _nonProxyHosts;

        /// <summary>
        /// Definition of hosts for which proxy won't be used. You can define multiple hosts. Each host can start or end with wildcard '*' for instance to match whole domain.
        /// </summary>
        public InputList<string> NonProxyHosts
        {
            get => _nonProxyHosts ?? (_nonProxyHosts = new InputList<string>());
            set => _nonProxyHosts = value;
        }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password of proxy server, null means do not change previous value
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Port of proxy server
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        /// <summary>
        /// Protocol which proxy server uses
        /// </summary>
        [Input("scheme", required: true)]
        public Input<string> Scheme { get; set; } = null!;

        /// <summary>
        /// Address (either IP or Hostname) of proxy server
        /// </summary>
        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        /// <summary>
        /// User of proxy server, null means do not change previous value
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public ManagedInternetProxyArgs()
        {
        }
        public static new ManagedInternetProxyArgs Empty => new ManagedInternetProxyArgs();
    }

    public sealed class ManagedInternetProxyState : global::Pulumi.ResourceArgs
    {
        [Input("nonProxyHosts")]
        private InputList<string>? _nonProxyHosts;

        /// <summary>
        /// Definition of hosts for which proxy won't be used. You can define multiple hosts. Each host can start or end with wildcard '*' for instance to match whole domain.
        /// </summary>
        public InputList<string> NonProxyHosts
        {
            get => _nonProxyHosts ?? (_nonProxyHosts = new InputList<string>());
            set => _nonProxyHosts = value;
        }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password of proxy server, null means do not change previous value
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Port of proxy server
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        /// <summary>
        /// Protocol which proxy server uses
        /// </summary>
        [Input("scheme")]
        public Input<string>? Scheme { get; set; }

        /// <summary>
        /// Address (either IP or Hostname) of proxy server
        /// </summary>
        [Input("server")]
        public Input<string>? Server { get; set; }

        /// <summary>
        /// User of proxy server, null means do not change previous value
        /// </summary>
        [Input("user")]
        public Input<string>? User { get; set; }

        public ManagedInternetProxyState()
        {
        }
        public static new ManagedInternetProxyState Empty => new ManagedInternetProxyState();
    }
}