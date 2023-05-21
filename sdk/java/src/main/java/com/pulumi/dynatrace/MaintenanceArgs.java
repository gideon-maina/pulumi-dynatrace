// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.MaintenanceFilterArgs;
import com.pulumi.dynatrace.inputs.MaintenanceGeneralPropertiesArgs;
import com.pulumi.dynatrace.inputs.MaintenanceScheduleArgs;
import java.lang.Boolean;
import java.lang.String;
import java.util.List;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class MaintenanceArgs extends com.pulumi.resources.ResourceArgs {

    public static final MaintenanceArgs Empty = new MaintenanceArgs();

    /**
     * The maintenance window is enabled or disabled
     * 
     */
    @Import(name="enabled")
    private @Nullable Output<Boolean> enabled;

    /**
     * @return The maintenance window is enabled or disabled
     * 
     */
    public Optional<Output<Boolean>> enabled() {
        return Optional.ofNullable(this.enabled);
    }

    /**
     * The filters of the maintenance window
     * 
     */
    @Import(name="filters")
    private @Nullable Output<List<MaintenanceFilterArgs>> filters;

    /**
     * @return The filters of the maintenance window
     * 
     */
    public Optional<Output<List<MaintenanceFilterArgs>>> filters() {
        return Optional.ofNullable(this.filters);
    }

    /**
     * The general properties of the maintenance window
     * 
     */
    @Import(name="generalProperties", required=true)
    private Output<MaintenanceGeneralPropertiesArgs> generalProperties;

    /**
     * @return The general properties of the maintenance window
     * 
     */
    public Output<MaintenanceGeneralPropertiesArgs> generalProperties() {
        return this.generalProperties;
    }

    /**
     * The ID of this setting when referred to by the Config REST API V1
     * 
     */
    @Import(name="legacyId")
    private @Nullable Output<String> legacyId;

    /**
     * @return The ID of this setting when referred to by the Config REST API V1
     * 
     */
    public Optional<Output<String>> legacyId() {
        return Optional.ofNullable(this.legacyId);
    }

    /**
     * The schedule of the maintenance window
     * 
     */
    @Import(name="schedule", required=true)
    private Output<MaintenanceScheduleArgs> schedule;

    /**
     * @return The schedule of the maintenance window
     * 
     */
    public Output<MaintenanceScheduleArgs> schedule() {
        return this.schedule;
    }

    private MaintenanceArgs() {}

    private MaintenanceArgs(MaintenanceArgs $) {
        this.enabled = $.enabled;
        this.filters = $.filters;
        this.generalProperties = $.generalProperties;
        this.legacyId = $.legacyId;
        this.schedule = $.schedule;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(MaintenanceArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private MaintenanceArgs $;

        public Builder() {
            $ = new MaintenanceArgs();
        }

        public Builder(MaintenanceArgs defaults) {
            $ = new MaintenanceArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param enabled The maintenance window is enabled or disabled
         * 
         * @return builder
         * 
         */
        public Builder enabled(@Nullable Output<Boolean> enabled) {
            $.enabled = enabled;
            return this;
        }

        /**
         * @param enabled The maintenance window is enabled or disabled
         * 
         * @return builder
         * 
         */
        public Builder enabled(Boolean enabled) {
            return enabled(Output.of(enabled));
        }

        /**
         * @param filters The filters of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder filters(@Nullable Output<List<MaintenanceFilterArgs>> filters) {
            $.filters = filters;
            return this;
        }

        /**
         * @param filters The filters of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder filters(List<MaintenanceFilterArgs> filters) {
            return filters(Output.of(filters));
        }

        /**
         * @param filters The filters of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder filters(MaintenanceFilterArgs... filters) {
            return filters(List.of(filters));
        }

        /**
         * @param generalProperties The general properties of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder generalProperties(Output<MaintenanceGeneralPropertiesArgs> generalProperties) {
            $.generalProperties = generalProperties;
            return this;
        }

        /**
         * @param generalProperties The general properties of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder generalProperties(MaintenanceGeneralPropertiesArgs generalProperties) {
            return generalProperties(Output.of(generalProperties));
        }

        /**
         * @param legacyId The ID of this setting when referred to by the Config REST API V1
         * 
         * @return builder
         * 
         */
        public Builder legacyId(@Nullable Output<String> legacyId) {
            $.legacyId = legacyId;
            return this;
        }

        /**
         * @param legacyId The ID of this setting when referred to by the Config REST API V1
         * 
         * @return builder
         * 
         */
        public Builder legacyId(String legacyId) {
            return legacyId(Output.of(legacyId));
        }

        /**
         * @param schedule The schedule of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder schedule(Output<MaintenanceScheduleArgs> schedule) {
            $.schedule = schedule;
            return this;
        }

        /**
         * @param schedule The schedule of the maintenance window
         * 
         * @return builder
         * 
         */
        public Builder schedule(MaintenanceScheduleArgs schedule) {
            return schedule(Output.of(schedule));
        }

        public MaintenanceArgs build() {
            $.generalProperties = Objects.requireNonNull($.generalProperties, "expected parameter 'generalProperties' to be non-null");
            $.schedule = Objects.requireNonNull($.schedule, "expected parameter 'schedule' to be non-null");
            return $;
        }
    }

}