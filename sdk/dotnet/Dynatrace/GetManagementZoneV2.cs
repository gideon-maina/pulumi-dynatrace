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
    public static class GetManagementZoneV2
    {
        /// <summary>
        /// The management zone data source allows the management zone ID to be retrieved by its name.
        /// 
        /// &gt; This data source requires the API token scopes **Read settings** (`settings.read`)
        /// 
        /// - `name` queries for all management zones with the specified name
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.PulumiPackage.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetManagementZoneV2.Invoke(new()
        ///     {
        ///         Name = "Example",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.CalculatedServiceMetric("#name#", new()
        ///     {
        ///         Conditions = new[]
        ///         {
        ///             new Dynatrace.Inputs.CalculatedServiceMetricConditionArgs
        ///             {
        ///                 Conditions = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionArgs
        ///                     {
        ///                         Attribute = "HTTP_REQUEST_METHOD",
        ///                         Comparison = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonArgs
        ///                         {
        ///                             HttpMethod = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs
        ///                             {
        ///                                 Operator = "EQUALS_ANY_OF",
        ///                                 Values = new[]
        ///                                 {
        ///                                     "POST",
        ///                                     "GET",
        ///                                 },
        ///                             },
        ///                             Negate = false,
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         Enabled = true,
        ///         ManagementZones = new[]
        ///         {
        ///             test.Apply(getManagementZoneV2Result =&gt; getManagementZoneV2Result.LegacyId),
        ///         },
        ///         MetricDefinition = new Dynatrace.Inputs.CalculatedServiceMetricMetricDefinitionArgs
        ///         {
        ///             Metric = "REQUEST_ATTRIBUTE",
        ///             RequestAttribute = "foo",
        ///         },
        ///         MetricKey = "calc:service.#name#",
        ///         Unit = "MILLI_SECOND_PER_MINUTE",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetManagementZoneV2Result> InvokeAsync(GetManagementZoneV2Args args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetManagementZoneV2Result>("dynatrace:index/getManagementZoneV2:getManagementZoneV2", args ?? new GetManagementZoneV2Args(), options.WithDefaults());

        /// <summary>
        /// The management zone data source allows the management zone ID to be retrieved by its name.
        /// 
        /// &gt; This data source requires the API token scopes **Read settings** (`settings.read`)
        /// 
        /// - `name` queries for all management zones with the specified name
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Dynatrace = Pulumi.Dynatrace;
        /// using Dynatrace = Pulumiverse.PulumiPackage.Dynatrace;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var test = Dynatrace.GetManagementZoneV2.Invoke(new()
        ///     {
        ///         Name = "Example",
        ///     });
        /// 
        ///     var _name_ = new Dynatrace.CalculatedServiceMetric("#name#", new()
        ///     {
        ///         Conditions = new[]
        ///         {
        ///             new Dynatrace.Inputs.CalculatedServiceMetricConditionArgs
        ///             {
        ///                 Conditions = new[]
        ///                 {
        ///                     new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionArgs
        ///                     {
        ///                         Attribute = "HTTP_REQUEST_METHOD",
        ///                         Comparison = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonArgs
        ///                         {
        ///                             HttpMethod = new Dynatrace.Inputs.CalculatedServiceMetricConditionConditionComparisonHttpMethodArgs
        ///                             {
        ///                                 Operator = "EQUALS_ANY_OF",
        ///                                 Values = new[]
        ///                                 {
        ///                                     "POST",
        ///                                     "GET",
        ///                                 },
        ///                             },
        ///                             Negate = false,
        ///                         },
        ///                     },
        ///                 },
        ///             },
        ///         },
        ///         Enabled = true,
        ///         ManagementZones = new[]
        ///         {
        ///             test.Apply(getManagementZoneV2Result =&gt; getManagementZoneV2Result.LegacyId),
        ///         },
        ///         MetricDefinition = new Dynatrace.Inputs.CalculatedServiceMetricMetricDefinitionArgs
        ///         {
        ///             Metric = "REQUEST_ATTRIBUTE",
        ///             RequestAttribute = "foo",
        ///         },
        ///         MetricKey = "calc:service.#name#",
        ///         Unit = "MILLI_SECOND_PER_MINUTE",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetManagementZoneV2Result> Invoke(GetManagementZoneV2InvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetManagementZoneV2Result>("dynatrace:index/getManagementZoneV2:getManagementZoneV2", args ?? new GetManagementZoneV2InvokeArgs(), options.WithDefaults());
    }


    public sealed class GetManagementZoneV2Args : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetManagementZoneV2Args()
        {
        }
        public static new GetManagementZoneV2Args Empty => new GetManagementZoneV2Args();
    }

    public sealed class GetManagementZoneV2InvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetManagementZoneV2InvokeArgs()
        {
        }
        public static new GetManagementZoneV2InvokeArgs Empty => new GetManagementZoneV2InvokeArgs();
    }


    [OutputType]
    public sealed class GetManagementZoneV2Result
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string LegacyId;
        public readonly string Name;
        public readonly string Settings20Id;

        [OutputConstructor]
        private GetManagementZoneV2Result(
            string id,

            string legacyId,

            string name,

            string settings20Id)
        {
            Id = id;
            LegacyId = legacyId;
            Name = name;
            Settings20Id = settings20Id;
        }
    }
}