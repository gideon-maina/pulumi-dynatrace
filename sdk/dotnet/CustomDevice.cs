// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace
{
    /// <summary>
    /// &gt; This resource requires the API token scopes **Read entities** (`entities.read`) and **Write entities** (`entities.write`)
    /// 
    /// ## Dynatrace Documentation
    /// 
    /// - Monitored entities API - https://www.dynatrace.com/support/help/dynatrace-api/environment-api/entity-v2
    /// 
    /// ## Resource Example Usage
    /// 
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Dynatrace = Pulumiverse.Dynatrace;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var _name_ = new Dynatrace.CustomDevice("#name#", new()
    ///     {
    ///         CustomDeviceId = "customDeviceId",
    ///         DisplayName = "customDevicename",
    ///     });
    /// 
    /// });
    /// ```
    /// </summary>
    [DynatraceResourceType("dynatrace:index/customDevice:CustomDevice")]
    public partial class CustomDevice : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        /// </summary>
        [Output("configUrl")]
        public Output<string?> ConfigUrl { get; private set; } = null!;

        [Output("customDeviceId")]
        public Output<string> CustomDeviceId { get; private set; } = null!;

        /// <summary>
        /// The name of the custom device, displayed in the UI.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The list of DNS names related to the custom device.
        /// </summary>
        [Output("dnsNames")]
        public Output<ImmutableArray<string>> DnsNames { get; private set; } = null!;

        /// <summary>
        /// The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        /// </summary>
        [Output("entityId")]
        public Output<string> EntityId { get; private set; } = null!;

        /// <summary>
        /// The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        /// </summary>
        [Output("faviconUrl")]
        public Output<string?> FaviconUrl { get; private set; } = null!;

        /// <summary>
        /// User defined group of entity. Changing the group requires a new custom device to be created.
        /// </summary>
        [Output("group")]
        public Output<string> Group { get; private set; } = null!;

        /// <summary>
        /// The list of IP addresses that belong to the custom device.
        /// </summary>
        [Output("ipAddresses")]
        public Output<ImmutableArray<string>> IpAddresses { get; private set; } = null!;

        /// <summary>
        /// The list of ports the custom devices listens to.
        /// </summary>
        [Output("listenPorts")]
        public Output<ImmutableArray<int>> ListenPorts { get; private set; } = null!;

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Output("properties")]
        public Output<ImmutableDictionary<string, string>?> Properties { get; private set; } = null!;

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Output("props")]
        public Output<string?> Props { get; private set; } = null!;

        /// <summary>
        /// The technology type definition of the custom device.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        /// </summary>
        [Output("uiBased")]
        public Output<bool?> UiBased { get; private set; } = null!;


        /// <summary>
        /// Create a CustomDevice resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomDevice(string name, CustomDeviceArgs args, CustomResourceOptions? options = null)
            : base("dynatrace:index/customDevice:CustomDevice", name, args ?? new CustomDeviceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomDevice(string name, Input<string> id, CustomDeviceState? state = null, CustomResourceOptions? options = null)
            : base("dynatrace:index/customDevice:CustomDevice", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CustomDevice resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomDevice Get(string name, Input<string> id, CustomDeviceState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomDevice(name, id, state, options);
        }
    }

    public sealed class CustomDeviceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        /// </summary>
        [Input("configUrl")]
        public Input<string>? ConfigUrl { get; set; }

        [Input("customDeviceId")]
        public Input<string>? CustomDeviceId { get; set; }

        /// <summary>
        /// The name of the custom device, displayed in the UI.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        [Input("dnsNames")]
        private InputList<string>? _dnsNames;

        /// <summary>
        /// The list of DNS names related to the custom device.
        /// </summary>
        public InputList<string> DnsNames
        {
            get => _dnsNames ?? (_dnsNames = new InputList<string>());
            set => _dnsNames = value;
        }

        /// <summary>
        /// The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        /// </summary>
        [Input("faviconUrl")]
        public Input<string>? FaviconUrl { get; set; }

        /// <summary>
        /// User defined group of entity. Changing the group requires a new custom device to be created.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("ipAddresses")]
        private InputList<string>? _ipAddresses;

        /// <summary>
        /// The list of IP addresses that belong to the custom device.
        /// </summary>
        public InputList<string> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<string>());
            set => _ipAddresses = value;
        }

        [Input("listenPorts")]
        private InputList<int>? _listenPorts;

        /// <summary>
        /// The list of ports the custom devices listens to.
        /// </summary>
        public InputList<int> ListenPorts
        {
            get => _listenPorts ?? (_listenPorts = new InputList<int>());
            set => _listenPorts = value;
        }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Obsolete(@"Please use the attribute `props` instead")]
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Input("props")]
        public Input<string>? Props { get; set; }

        /// <summary>
        /// The technology type definition of the custom device.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        /// </summary>
        [Input("uiBased")]
        public Input<bool>? UiBased { get; set; }

        public CustomDeviceArgs()
        {
        }
        public static new CustomDeviceArgs Empty => new CustomDeviceArgs();
    }

    public sealed class CustomDeviceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The URL of a configuration web page for the custom device, such as a login page for a firewall or router.
        /// </summary>
        [Input("configUrl")]
        public Input<string>? ConfigUrl { get; set; }

        [Input("customDeviceId")]
        public Input<string>? CustomDeviceId { get; set; }

        /// <summary>
        /// The name of the custom device, displayed in the UI.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("dnsNames")]
        private InputList<string>? _dnsNames;

        /// <summary>
        /// The list of DNS names related to the custom device.
        /// </summary>
        public InputList<string> DnsNames
        {
            get => _dnsNames ?? (_dnsNames = new InputList<string>());
            set => _dnsNames = value;
        }

        /// <summary>
        /// The Dynatrace EntityID of this resource. If you need to refer to this custom device within other resources you want to use this ID
        /// </summary>
        [Input("entityId")]
        public Input<string>? EntityId { get; set; }

        /// <summary>
        /// The icon to be displayed for your custom component within Smartscape. Provide the full URL of the icon file.
        /// </summary>
        [Input("faviconUrl")]
        public Input<string>? FaviconUrl { get; set; }

        /// <summary>
        /// User defined group of entity. Changing the group requires a new custom device to be created.
        /// </summary>
        [Input("group")]
        public Input<string>? Group { get; set; }

        [Input("ipAddresses")]
        private InputList<string>? _ipAddresses;

        /// <summary>
        /// The list of IP addresses that belong to the custom device.
        /// </summary>
        public InputList<string> IpAddresses
        {
            get => _ipAddresses ?? (_ipAddresses = new InputList<string>());
            set => _ipAddresses = value;
        }

        [Input("listenPorts")]
        private InputList<int>? _listenPorts;

        /// <summary>
        /// The list of ports the custom devices listens to.
        /// </summary>
        public InputList<int> ListenPorts
        {
            get => _listenPorts ?? (_listenPorts = new InputList<int>());
            set => _listenPorts = value;
        }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Obsolete(@"Please use the attribute `props` instead")]
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// The list of key-value pair properties that will be shown beneath the infographics of your custom device.
        /// </summary>
        [Input("props")]
        public Input<string>? Props { get; set; }

        /// <summary>
        /// The technology type definition of the custom device.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// If `true` the custom device will be handled as if it was created via UI. It will be refreshed automatically and won't age out. This attribute is taken into consideration when creating the custom device. Changing it afterwards won't have an effect.
        /// </summary>
        [Input("uiBased")]
        public Input<bool>? UiBased { get; set; }

        public CustomDeviceState()
        {
        }
        public static new CustomDeviceState Empty => new CustomDeviceState();
    }
}