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
    public sealed class CustomAppCrashRateCrashRateIncrease
    {
        /// <summary>
        /// Alert crash rate increases when auto-detected baseline is exceeded by a certain number of users
        /// </summary>
        public readonly Outputs.CustomAppCrashRateCrashRateIncreaseCrashRateIncreaseAuto? CrashRateIncreaseAuto;
        /// <summary>
        /// Alert crash rate increases when the defined threshold is exceeded by a certain number of users
        /// </summary>
        public readonly Outputs.CustomAppCrashRateCrashRateIncreaseCrashRateIncreaseFixed? CrashRateIncreaseFixed;
        /// <summary>
        /// Possible Values: `Auto`, `Fixed`
        /// </summary>
        public readonly string? DetectionMode;
        /// <summary>
        /// This setting is enabled (`true`) or disabled (`false`)
        /// </summary>
        public readonly bool Enabled;

        [OutputConstructor]
        private CustomAppCrashRateCrashRateIncrease(
            Outputs.CustomAppCrashRateCrashRateIncreaseCrashRateIncreaseAuto? crashRateIncreaseAuto,

            Outputs.CustomAppCrashRateCrashRateIncreaseCrashRateIncreaseFixed? crashRateIncreaseFixed,

            string? detectionMode,

            bool enabled)
        {
            CrashRateIncreaseAuto = crashRateIncreaseAuto;
            CrashRateIncreaseFixed = crashRateIncreaseFixed;
            DetectionMode = detectionMode;
            Enabled = enabled;
        }
    }
}