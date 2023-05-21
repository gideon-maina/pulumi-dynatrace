// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.ServiceFullWebServiceIdContributorsServerNameServiceIdContributorArgs;
import java.lang.Boolean;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class ServiceFullWebServiceIdContributorsServerNameArgs extends com.pulumi.resources.ResourceArgs {

    public static final ServiceFullWebServiceIdContributorsServerNameArgs Empty = new ServiceFullWebServiceIdContributorsServerNameArgs();

    @Import(name="enableIdContributor", required=true)
    private Output<Boolean> enableIdContributor;

    public Output<Boolean> enableIdContributor() {
        return this.enableIdContributor;
    }

    @Import(name="serviceIdContributor")
    private @Nullable Output<ServiceFullWebServiceIdContributorsServerNameServiceIdContributorArgs> serviceIdContributor;

    public Optional<Output<ServiceFullWebServiceIdContributorsServerNameServiceIdContributorArgs>> serviceIdContributor() {
        return Optional.ofNullable(this.serviceIdContributor);
    }

    private ServiceFullWebServiceIdContributorsServerNameArgs() {}

    private ServiceFullWebServiceIdContributorsServerNameArgs(ServiceFullWebServiceIdContributorsServerNameArgs $) {
        this.enableIdContributor = $.enableIdContributor;
        this.serviceIdContributor = $.serviceIdContributor;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(ServiceFullWebServiceIdContributorsServerNameArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private ServiceFullWebServiceIdContributorsServerNameArgs $;

        public Builder() {
            $ = new ServiceFullWebServiceIdContributorsServerNameArgs();
        }

        public Builder(ServiceFullWebServiceIdContributorsServerNameArgs defaults) {
            $ = new ServiceFullWebServiceIdContributorsServerNameArgs(Objects.requireNonNull(defaults));
        }

        public Builder enableIdContributor(Output<Boolean> enableIdContributor) {
            $.enableIdContributor = enableIdContributor;
            return this;
        }

        public Builder enableIdContributor(Boolean enableIdContributor) {
            return enableIdContributor(Output.of(enableIdContributor));
        }

        public Builder serviceIdContributor(@Nullable Output<ServiceFullWebServiceIdContributorsServerNameServiceIdContributorArgs> serviceIdContributor) {
            $.serviceIdContributor = serviceIdContributor;
            return this;
        }

        public Builder serviceIdContributor(ServiceFullWebServiceIdContributorsServerNameServiceIdContributorArgs serviceIdContributor) {
            return serviceIdContributor(Output.of(serviceIdContributor));
        }

        public ServiceFullWebServiceIdContributorsServerNameArgs build() {
            $.enableIdContributor = Objects.requireNonNull($.enableIdContributor, "expected parameter 'enableIdContributor' to be non-null");
            return $;
        }
    }

}