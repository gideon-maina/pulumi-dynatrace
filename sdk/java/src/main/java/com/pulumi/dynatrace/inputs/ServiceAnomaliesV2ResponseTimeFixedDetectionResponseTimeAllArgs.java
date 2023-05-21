// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Double;
import java.util.Objects;


public final class ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs extends com.pulumi.resources.ResourceArgs {

    public static final ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs Empty = new ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs();

    @Import(name="degradationMilliseconds", required=true)
    private Output<Double> degradationMilliseconds;

    public Output<Double> degradationMilliseconds() {
        return this.degradationMilliseconds;
    }

    private ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs() {}

    private ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs(ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs $) {
        this.degradationMilliseconds = $.degradationMilliseconds;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs $;

        public Builder() {
            $ = new ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs();
        }

        public Builder(ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs defaults) {
            $ = new ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs(Objects.requireNonNull(defaults));
        }

        public Builder degradationMilliseconds(Output<Double> degradationMilliseconds) {
            $.degradationMilliseconds = degradationMilliseconds;
            return this;
        }

        public Builder degradationMilliseconds(Double degradationMilliseconds) {
            return degradationMilliseconds(Output.of(degradationMilliseconds));
        }

        public ServiceAnomaliesV2ResponseTimeFixedDetectionResponseTimeAllArgs build() {
            $.degradationMilliseconds = Objects.requireNonNull($.degradationMilliseconds, "expected parameter 'degradationMilliseconds' to be non-null");
            return $;
        }
    }

}