// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;

@CustomType
public final class BusinessEventsOneagentTriggersTriggerSource {
    private String dataSource;
    private @Nullable String path;

    private BusinessEventsOneagentTriggersTriggerSource() {}
    public String dataSource() {
        return this.dataSource;
    }
    public Optional<String> path() {
        return Optional.ofNullable(this.path);
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(BusinessEventsOneagentTriggersTriggerSource defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private String dataSource;
        private @Nullable String path;
        public Builder() {}
        public Builder(BusinessEventsOneagentTriggersTriggerSource defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.dataSource = defaults.dataSource;
    	      this.path = defaults.path;
        }

        @CustomType.Setter
        public Builder dataSource(String dataSource) {
            this.dataSource = Objects.requireNonNull(dataSource);
            return this;
        }
        @CustomType.Setter
        public Builder path(@Nullable String path) {
            this.path = path;
            return this;
        }
        public BusinessEventsOneagentTriggersTriggerSource build() {
            final var o = new BusinessEventsOneagentTriggersTriggerSource();
            o.dataSource = dataSource;
            o.path = path;
            return o;
        }
    }
}