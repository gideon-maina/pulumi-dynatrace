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

    public sealed class CredentialsExternalGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("certificate")]
        public Input<string>? Certificate { get; set; }

        /// <summary>
        /// Required for Azure Client Secret. No further documentation available
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// Required for Azure Client Secret. No further documentation available
        /// </summary>
        [Input("clientid")]
        public Input<string>? Clientid { get; set; }

        [Input("credentialsUsedForExternalSynchronizations")]
        private InputList<string>? _credentialsUsedForExternalSynchronizations;

        /// <summary>
        /// No documentation available
        /// </summary>
        public InputList<string> CredentialsUsedForExternalSynchronizations
        {
            get => _credentialsUsedForExternalSynchronizations ?? (_credentialsUsedForExternalSynchronizations = new InputList<string>());
            set => _credentialsUsedForExternalSynchronizations = value;
        }

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("passwordSecretName")]
        public Input<string>? PasswordSecretName { get; set; }

        [Input("pathToCredentials")]
        public Input<string>? PathToCredentials { get; set; }

        [Input("roleid")]
        public Input<string>? Roleid { get; set; }

        [Input("secretid")]
        public Input<string>? Secretid { get; set; }

        /// <summary>
        /// Required for Azure Client Secret. No further documentation available
        /// </summary>
        [Input("tenantid")]
        public Input<string>? Tenantid { get; set; }

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("tokenSecretName")]
        public Input<string>? TokenSecretName { get; set; }

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("usernameSecretName")]
        public Input<string>? UsernameSecretName { get; set; }

        [Input("vaultNamespace")]
        public Input<string>? VaultNamespace { get; set; }

        /// <summary>
        /// No documentation available
        /// </summary>
        [Input("vaultUrl")]
        public Input<string>? VaultUrl { get; set; }

        public CredentialsExternalGetArgs()
        {
        }
        public static new CredentialsExternalGetArgs Empty => new CredentialsExternalGetArgs();
    }
}