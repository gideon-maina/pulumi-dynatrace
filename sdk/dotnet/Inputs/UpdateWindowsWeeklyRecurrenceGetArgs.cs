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

    public sealed class UpdateWindowsWeeklyRecurrenceGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Every **X** weeks:
        /// * `1` = every week,
        /// * `2` = every two weeks,
        /// * `3` = every three weeks,
        /// * etc.
        /// </summary>
        [Input("every", required: true)]
        public Input<int> Every { get; set; } = null!;

        /// <summary>
        /// Recurrence range
        /// </summary>
        [Input("recurrenceRange", required: true)]
        public Input<Inputs.UpdateWindowsWeeklyRecurrenceRecurrenceRangeGetArgs> RecurrenceRange { get; set; } = null!;

        /// <summary>
        /// Day of the week
        /// </summary>
        [Input("selectedWeekDays", required: true)]
        public Input<Inputs.UpdateWindowsWeeklyRecurrenceSelectedWeekDaysGetArgs> SelectedWeekDays { get; set; } = null!;

        /// <summary>
        /// Update time
        /// </summary>
        [Input("updateTime", required: true)]
        public Input<Inputs.UpdateWindowsWeeklyRecurrenceUpdateTimeGetArgs> UpdateTime { get; set; } = null!;

        public UpdateWindowsWeeklyRecurrenceGetArgs()
        {
        }
        public static new UpdateWindowsWeeklyRecurrenceGetArgs Empty => new UpdateWindowsWeeklyRecurrenceGetArgs();
    }
}