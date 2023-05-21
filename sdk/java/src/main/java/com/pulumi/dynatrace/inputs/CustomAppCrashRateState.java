// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.CustomAppCrashRateCrashRateIncreaseArgs;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class CustomAppCrashRateState extends com.pulumi.resources.ResourceArgs {

    public static final CustomAppCrashRateState Empty = new CustomAppCrashRateState();

    /**
     * Crash rate increase
     * 
     */
    @Import(name="crashRateIncrease")
    private @Nullable Output<CustomAppCrashRateCrashRateIncreaseArgs> crashRateIncrease;

    /**
     * @return Crash rate increase
     * 
     */
    public Optional<Output<CustomAppCrashRateCrashRateIncreaseArgs>> crashRateIncrease() {
        return Optional.ofNullable(this.crashRateIncrease);
    }

    /**
     * The scope of this setting (CUSTOM_APPLICATION environment)
     * 
     */
    @Import(name="scope")
    private @Nullable Output<String> scope;

    /**
     * @return The scope of this setting (CUSTOM_APPLICATION environment)
     * 
     */
    public Optional<Output<String>> scope() {
        return Optional.ofNullable(this.scope);
    }

    private CustomAppCrashRateState() {}

    private CustomAppCrashRateState(CustomAppCrashRateState $) {
        this.crashRateIncrease = $.crashRateIncrease;
        this.scope = $.scope;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(CustomAppCrashRateState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private CustomAppCrashRateState $;

        public Builder() {
            $ = new CustomAppCrashRateState();
        }

        public Builder(CustomAppCrashRateState defaults) {
            $ = new CustomAppCrashRateState(Objects.requireNonNull(defaults));
        }

        /**
         * @param crashRateIncrease Crash rate increase
         * 
         * @return builder
         * 
         */
        public Builder crashRateIncrease(@Nullable Output<CustomAppCrashRateCrashRateIncreaseArgs> crashRateIncrease) {
            $.crashRateIncrease = crashRateIncrease;
            return this;
        }

        /**
         * @param crashRateIncrease Crash rate increase
         * 
         * @return builder
         * 
         */
        public Builder crashRateIncrease(CustomAppCrashRateCrashRateIncreaseArgs crashRateIncrease) {
            return crashRateIncrease(Output.of(crashRateIncrease));
        }

        /**
         * @param scope The scope of this setting (CUSTOM_APPLICATION environment)
         * 
         * @return builder
         * 
         */
        public Builder scope(@Nullable Output<String> scope) {
            $.scope = scope;
            return this;
        }

        /**
         * @param scope The scope of this setting (CUSTOM_APPLICATION environment)
         * 
         * @return builder
         * 
         */
        public Builder scope(String scope) {
            return scope(Output.of(scope));
        }

        public CustomAppCrashRateState build() {
            return $;
        }
    }

}