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

    public sealed class BrowserMonitorScriptConfigurationCookiesGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cookies", required: true)]
        private InputList<Inputs.BrowserMonitorScriptConfigurationCookiesCookieGetArgs>? _cookies;

        /// <summary>
        /// A request cookie
        /// </summary>
        public InputList<Inputs.BrowserMonitorScriptConfigurationCookiesCookieGetArgs> Cookies
        {
            get => _cookies ?? (_cookies = new InputList<Inputs.BrowserMonitorScriptConfigurationCookiesCookieGetArgs>());
            set => _cookies = value;
        }

        public BrowserMonitorScriptConfigurationCookiesGetArgs()
        {
        }
        public static new BrowserMonitorScriptConfigurationCookiesGetArgs Empty => new BrowserMonitorScriptConfigurationCookiesGetArgs();
    }
}