// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import java.lang.Double;
import java.util.Objects;

@CustomType
public final class WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest {
    private Double slowestDegradationMilliseconds;
    private Double slowestDegradationPercent;

    private WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest() {}
    public Double slowestDegradationMilliseconds() {
        return this.slowestDegradationMilliseconds;
    }
    public Double slowestDegradationPercent() {
        return this.slowestDegradationPercent;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private Double slowestDegradationMilliseconds;
        private Double slowestDegradationPercent;
        public Builder() {}
        public Builder(WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.slowestDegradationMilliseconds = defaults.slowestDegradationMilliseconds;
    	      this.slowestDegradationPercent = defaults.slowestDegradationPercent;
        }

        @CustomType.Setter
        public Builder slowestDegradationMilliseconds(Double slowestDegradationMilliseconds) {
            this.slowestDegradationMilliseconds = Objects.requireNonNull(slowestDegradationMilliseconds);
            return this;
        }
        @CustomType.Setter
        public Builder slowestDegradationPercent(Double slowestDegradationPercent) {
            this.slowestDegradationPercent = Objects.requireNonNull(slowestDegradationPercent);
            return this;
        }
        public WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest build() {
            final var o = new WebAppAnomaliesResponseTimeResponseTimeAutoResponseTimeSlowest();
            o.slowestDegradationMilliseconds = slowestDegradationMilliseconds;
            o.slowestDegradationPercent = slowestDegradationPercent;
            return o;
        }
    }
}