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
    public sealed class DashboardTileFilterConfigChartConfigSeries
    {
        /// <summary>
        /// The charted aggregation of the metric
        /// </summary>
        public readonly string Aggregation;
        public readonly string? AggregationRate;
        /// <summary>
        /// Configuration of the charted metric splitting
        /// </summary>
        public readonly ImmutableArray<Outputs.DashboardTileFilterConfigChartConfigSeriesDimension> Dimensions;
        /// <summary>
        /// The visualization of the timeseries chart
        /// </summary>
        public readonly string EntityType;
        /// <summary>
        /// The name of the charted metric
        /// </summary>
        public readonly string Metric;
        /// <summary>
        /// The charted percentile. Only applicable if the **aggregation** is set to `PERCENTILE`
        /// </summary>
        public readonly int? Percentile;
        /// <summary>
        /// Sort ascending (`true`) or descending (`false`)
        /// </summary>
        public readonly bool? SortAscending;
        /// <summary>
        /// Sort the column (`true`) or (`false`)
        /// </summary>
        public readonly bool? SortColumn;
        /// <summary>
        /// The visualization of the timeseries chart. Possible values are `AREA`, `BAR` and `LINE`.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// allows for configuring properties that are not explicitly supported by the current version of this provider
        /// </summary>
        public readonly string? Unknowns;

        [OutputConstructor]
        private DashboardTileFilterConfigChartConfigSeries(
            string aggregation,

            string? aggregationRate,

            ImmutableArray<Outputs.DashboardTileFilterConfigChartConfigSeriesDimension> dimensions,

            string entityType,

            string metric,

            int? percentile,

            bool? sortAscending,

            bool? sortColumn,

            string type,

            string? unknowns)
        {
            Aggregation = aggregation;
            AggregationRate = aggregationRate;
            Dimensions = dimensions;
            EntityType = entityType;
            Metric = metric;
            Percentile = percentile;
            SortAscending = sortAscending;
            SortColumn = sortColumn;
            Type = type;
            Unknowns = unknowns;
        }
    }
}