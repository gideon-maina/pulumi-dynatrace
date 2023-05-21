// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.outputs;

import com.pulumi.core.annotations.CustomType;
import com.pulumi.dynatrace.outputs.ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection;
import java.lang.Double;
import java.lang.String;
import java.util.Objects;

@CustomType
public final class ServiceAnomaliesV2FailureRateFixedDetection {
    private ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection overAlertingProtection;
    private String sensitivity;
    private Double threshold;

    private ServiceAnomaliesV2FailureRateFixedDetection() {}
    public ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection overAlertingProtection() {
        return this.overAlertingProtection;
    }
    public String sensitivity() {
        return this.sensitivity;
    }
    public Double threshold() {
        return this.threshold;
    }

    public static Builder builder() {
        return new Builder();
    }

    public static Builder builder(ServiceAnomaliesV2FailureRateFixedDetection defaults) {
        return new Builder(defaults);
    }
    @CustomType.Builder
    public static final class Builder {
        private ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection overAlertingProtection;
        private String sensitivity;
        private Double threshold;
        public Builder() {}
        public Builder(ServiceAnomaliesV2FailureRateFixedDetection defaults) {
    	      Objects.requireNonNull(defaults);
    	      this.overAlertingProtection = defaults.overAlertingProtection;
    	      this.sensitivity = defaults.sensitivity;
    	      this.threshold = defaults.threshold;
        }

        @CustomType.Setter
        public Builder overAlertingProtection(ServiceAnomaliesV2FailureRateFixedDetectionOverAlertingProtection overAlertingProtection) {
            this.overAlertingProtection = Objects.requireNonNull(overAlertingProtection);
            return this;
        }
        @CustomType.Setter
        public Builder sensitivity(String sensitivity) {
            this.sensitivity = Objects.requireNonNull(sensitivity);
            return this;
        }
        @CustomType.Setter
        public Builder threshold(Double threshold) {
            this.threshold = Objects.requireNonNull(threshold);
            return this;
        }
        public ServiceAnomaliesV2FailureRateFixedDetection build() {
            final var o = new ServiceAnomaliesV2FailureRateFixedDetection();
            o.overAlertingProtection = overAlertingProtection;
            o.sensitivity = sensitivity;
            o.threshold = threshold;
            return o;
        }
    }
}