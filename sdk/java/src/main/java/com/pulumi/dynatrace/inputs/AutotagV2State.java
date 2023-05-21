// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import com.pulumi.dynatrace.inputs.AutotagV2RulesArgs;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class AutotagV2State extends com.pulumi.resources.ResourceArgs {

    public static final AutotagV2State Empty = new AutotagV2State();

    /**
     * Description
     * 
     */
    @Import(name="description")
    private @Nullable Output<String> description;

    /**
     * @return Description
     * 
     */
    public Optional<Output<String>> description() {
        return Optional.ofNullable(this.description);
    }

    /**
     * Tag name
     * 
     */
    @Import(name="name")
    private @Nullable Output<String> name;

    /**
     * @return Tag name
     * 
     */
    public Optional<Output<String>> name() {
        return Optional.ofNullable(this.name);
    }

    /**
     * Rules
     * 
     */
    @Import(name="rules")
    private @Nullable Output<AutotagV2RulesArgs> rules;

    /**
     * @return Rules
     * 
     */
    public Optional<Output<AutotagV2RulesArgs>> rules() {
        return Optional.ofNullable(this.rules);
    }

    private AutotagV2State() {}

    private AutotagV2State(AutotagV2State $) {
        this.description = $.description;
        this.name = $.name;
        this.rules = $.rules;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(AutotagV2State defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private AutotagV2State $;

        public Builder() {
            $ = new AutotagV2State();
        }

        public Builder(AutotagV2State defaults) {
            $ = new AutotagV2State(Objects.requireNonNull(defaults));
        }

        /**
         * @param description Description
         * 
         * @return builder
         * 
         */
        public Builder description(@Nullable Output<String> description) {
            $.description = description;
            return this;
        }

        /**
         * @param description Description
         * 
         * @return builder
         * 
         */
        public Builder description(String description) {
            return description(Output.of(description));
        }

        /**
         * @param name Tag name
         * 
         * @return builder
         * 
         */
        public Builder name(@Nullable Output<String> name) {
            $.name = name;
            return this;
        }

        /**
         * @param name Tag name
         * 
         * @return builder
         * 
         */
        public Builder name(String name) {
            return name(Output.of(name));
        }

        /**
         * @param rules Rules
         * 
         * @return builder
         * 
         */
        public Builder rules(@Nullable Output<AutotagV2RulesArgs> rules) {
            $.rules = rules;
            return this;
        }

        /**
         * @param rules Rules
         * 
         * @return builder
         * 
         */
        public Builder rules(AutotagV2RulesArgs rules) {
            return rules(Output.of(rules));
        }

        public AutotagV2State build() {
            return $;
        }
    }

}