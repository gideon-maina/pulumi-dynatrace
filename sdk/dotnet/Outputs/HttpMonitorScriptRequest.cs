// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace Pulumiverse.Dynatrace.Outputs
{

    [OutputType]
    public sealed class HttpMonitorScriptRequest
    {
        /// <summary>
        /// Authentication options for this request
        /// </summary>
        public readonly Outputs.HttpMonitorScriptRequestAuthentication? Authentication;
        /// <summary>
        /// The body of the HTTP request.
        /// </summary>
        public readonly string? Body;
        /// <summary>
        /// The setup of the monitor
        /// </summary>
        public readonly Outputs.HttpMonitorScriptRequestConfiguration? Configuration;
        /// <summary>
        /// A short description of the event to appear in the web UI.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// The HTTP method of the request.
        /// </summary>
        public readonly string Method;
        /// <summary>
        /// Javascript code to execute after sending the request.
        /// </summary>
        public readonly string? PostProcessing;
        /// <summary>
        /// Javascript code to execute before sending the request.
        /// </summary>
        public readonly string? PreProcessing;
        /// <summary>
        /// Adapt request timeout option - the maximum time this request is allowed to consume. Keep in mind the maximum timeout of the complete monitor is 60 seconds
        /// </summary>
        public readonly int? RequestTimeout;
        /// <summary>
        /// The URL to check.
        /// </summary>
        public readonly string Url;
        /// <summary>
        /// Validation helps you verify that your HTTP monitor loads the expected content
        /// </summary>
        public readonly Outputs.HttpMonitorScriptRequestValidation? Validation;

        [OutputConstructor]
        private HttpMonitorScriptRequest(
            Outputs.HttpMonitorScriptRequestAuthentication? authentication,

            string? body,

            Outputs.HttpMonitorScriptRequestConfiguration? configuration,

            string? description,

            string method,

            string? postProcessing,

            string? preProcessing,

            int? requestTimeout,

            string url,

            Outputs.HttpMonitorScriptRequestValidation? validation)
        {
            Authentication = authentication;
            Body = body;
            Configuration = configuration;
            Description = description;
            Method = method;
            PostProcessing = postProcessing;
            PreProcessing = preProcessing;
            RequestTimeout = requestTimeout;
            Url = url;
            Validation = validation;
        }
    }
}