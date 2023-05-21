// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class MonitoredTechnologiesPhpState extends com.pulumi.resources.ResourceArgs {

    public static final MonitoredTechnologiesPhpState Empty = new MonitoredTechnologiesPhpState();

    /**
     * Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
     * 
     */
    @Import(name="enablePhpCliServer")
    private @Nullable Output<Boolean> enablePhpCliServer;

    /**
     * @return Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
     * 
     */
    public Optional<Output<Boolean>> enablePhpCliServer() {
        return Optional.ofNullable(this.enablePhpCliServer);
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="enabled")
    private @Nullable Output<Boolean> enabled;

    /**
     * @return This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    public Optional<Output<Boolean>> enabled() {
        return Optional.ofNullable(this.enabled);
    }

    /**
     * Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it&#39;s ignored and permanently enabled
     * 
     */
    @Import(name="enabledFastCgi")
    private @Nullable Output<Boolean> enabledFastCgi;

    /**
     * @return Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it&#39;s ignored and permanently enabled
     * 
     */
    public Optional<Output<Boolean>> enabledFastCgi() {
        return Optional.ofNullable(this.enabledFastCgi);
    }

    /**
     * The scope of this settings. If the settings should cover the whole environment, just don&#39;t specify any scope.
     * 
     */
    @Import(name="hostId")
    private @Nullable Output<String> hostId;

    /**
     * @return The scope of this settings. If the settings should cover the whole environment, just don&#39;t specify any scope.
     * 
     */
    public Optional<Output<String>> hostId() {
        return Optional.ofNullable(this.hostId);
    }

    private MonitoredTechnologiesPhpState() {}

    private MonitoredTechnologiesPhpState(MonitoredTechnologiesPhpState $) {
        this.enablePhpCliServer = $.enablePhpCliServer;
        this.enabled = $.enabled;
        this.enabledFastCgi = $.enabledFastCgi;
        this.hostId = $.hostId;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(MonitoredTechnologiesPhpState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private MonitoredTechnologiesPhpState $;

        public Builder() {
            $ = new MonitoredTechnologiesPhpState();
        }

        public Builder(MonitoredTechnologiesPhpState defaults) {
            $ = new MonitoredTechnologiesPhpState(Objects.requireNonNull(defaults));
        }

        /**
         * @param enablePhpCliServer Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
         * 
         * @return builder
         * 
         */
        public Builder enablePhpCliServer(@Nullable Output<Boolean> enablePhpCliServer) {
            $.enablePhpCliServer = enablePhpCliServer;
            return this;
        }

        /**
         * @param enablePhpCliServer Requires enabled PHP monitoring and Dynatrace OneAgent version 1.261 or later
         * 
         * @return builder
         * 
         */
        public Builder enablePhpCliServer(Boolean enablePhpCliServer) {
            return enablePhpCliServer(Output.of(enablePhpCliServer));
        }

        /**
         * @param enabled This setting is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder enabled(@Nullable Output<Boolean> enabled) {
            $.enabled = enabled;
            return this;
        }

        /**
         * @param enabled This setting is enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder enabled(Boolean enabled) {
            return enabled(Output.of(enabled));
        }

        /**
         * @param enabledFastCgi Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it&#39;s ignored and permanently enabled
         * 
         * @return builder
         * 
         */
        public Builder enabledFastCgi(@Nullable Output<Boolean> enabledFastCgi) {
            $.enabledFastCgi = enabledFastCgi;
            return this;
        }

        /**
         * @param enabledFastCgi Requires PHP monitoring enabled and from Dynatrace OneAgent version 1.191 it&#39;s ignored and permanently enabled
         * 
         * @return builder
         * 
         */
        public Builder enabledFastCgi(Boolean enabledFastCgi) {
            return enabledFastCgi(Output.of(enabledFastCgi));
        }

        /**
         * @param hostId The scope of this settings. If the settings should cover the whole environment, just don&#39;t specify any scope.
         * 
         * @return builder
         * 
         */
        public Builder hostId(@Nullable Output<String> hostId) {
            $.hostId = hostId;
            return this;
        }

        /**
         * @param hostId The scope of this settings. If the settings should cover the whole environment, just don&#39;t specify any scope.
         * 
         * @return builder
         * 
         */
        public Builder hostId(String hostId) {
            return hostId(Output.of(hostId));
        }

        public MonitoredTechnologiesPhpState build() {
            return $;
        }
    }

}