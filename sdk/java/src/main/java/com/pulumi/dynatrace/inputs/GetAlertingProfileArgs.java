// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;


public final class GetAlertingProfileArgs extends com.pulumi.resources.InvokeArgs {

    public static final GetAlertingProfileArgs Empty = new GetAlertingProfileArgs();

    @Import(name="name", required=true)
    private Output<String> name;

    public Output<String> name() {
        return this.name;
    }

    private GetAlertingProfileArgs() {}

    private GetAlertingProfileArgs(GetAlertingProfileArgs $) {
        this.name = $.name;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(GetAlertingProfileArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private GetAlertingProfileArgs $;

        public Builder() {
            $ = new GetAlertingProfileArgs();
        }

        public Builder(GetAlertingProfileArgs defaults) {
            $ = new GetAlertingProfileArgs(Objects.requireNonNull(defaults));
        }

        public Builder name(Output<String> name) {
            $.name = name;
            return this;
        }

        public Builder name(String name) {
            return name(Output.of(name));
        }

        public GetAlertingProfileArgs build() {
            $.name = Objects.requireNonNull($.name, "expected parameter 'name' to be non-null");
            return $;
        }
    }

}