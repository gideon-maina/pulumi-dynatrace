// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.FailureDetectionRulesConditionsConditionArgs;
import java.util.List;
import java.util.Objects;


public final class FailureDetectionRulesConditionsArgs extends com.pulumi.resources.ResourceArgs {

    public static final FailureDetectionRulesConditionsArgs Empty = new FailureDetectionRulesConditionsArgs();

    @Import(name="conditions", required=true)
    private Output<List<FailureDetectionRulesConditionsConditionArgs>> conditions;

    public Output<List<FailureDetectionRulesConditionsConditionArgs>> conditions() {
        return this.conditions;
    }

    private FailureDetectionRulesConditionsArgs() {}

    private FailureDetectionRulesConditionsArgs(FailureDetectionRulesConditionsArgs $) {
        this.conditions = $.conditions;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(FailureDetectionRulesConditionsArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private FailureDetectionRulesConditionsArgs $;

        public Builder() {
            $ = new FailureDetectionRulesConditionsArgs();
        }

        public Builder(FailureDetectionRulesConditionsArgs defaults) {
            $ = new FailureDetectionRulesConditionsArgs(Objects.requireNonNull(defaults));
        }

        public Builder conditions(Output<List<FailureDetectionRulesConditionsConditionArgs>> conditions) {
            $.conditions = conditions;
            return this;
        }

        public Builder conditions(List<FailureDetectionRulesConditionsConditionArgs> conditions) {
            return conditions(Output.of(conditions));
        }

        public Builder conditions(FailureDetectionRulesConditionsConditionArgs... conditions) {
            return conditions(List.of(conditions));
        }

        public FailureDetectionRulesConditionsArgs build() {
            $.conditions = Objects.requireNonNull($.conditions, "expected parameter 'conditions' to be non-null");
            return $;
        }
    }

}