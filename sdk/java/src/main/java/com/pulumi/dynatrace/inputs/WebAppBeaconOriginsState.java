// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace.inputs;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.String;
import java.util.Objects;
import java.util.Optional;
import javax.annotation.Nullable;


public final class WebAppBeaconOriginsState extends com.pulumi.resources.ResourceArgs {

    public static final WebAppBeaconOriginsState Empty = new WebAppBeaconOriginsState();

    /**
     * Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
     * 
     */
    @Import(name="matcher")
    private @Nullable Output<String> matcher;

    /**
     * @return Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
     * 
     */
    public Optional<Output<String>> matcher() {
        return Optional.ofNullable(this.matcher);
    }

    /**
     * Pattern
     * 
     */
    @Import(name="pattern")
    private @Nullable Output<String> pattern;

    /**
     * @return Pattern
     * 
     */
    public Optional<Output<String>> pattern() {
        return Optional.ofNullable(this.pattern);
    }

    private WebAppBeaconOriginsState() {}

    private WebAppBeaconOriginsState(WebAppBeaconOriginsState $) {
        this.matcher = $.matcher;
        this.pattern = $.pattern;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(WebAppBeaconOriginsState defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private WebAppBeaconOriginsState $;

        public Builder() {
            $ = new WebAppBeaconOriginsState();
        }

        public Builder(WebAppBeaconOriginsState defaults) {
            $ = new WebAppBeaconOriginsState(Objects.requireNonNull(defaults));
        }

        /**
         * @param matcher Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
         * 
         * @return builder
         * 
         */
        public Builder matcher(@Nullable Output<String> matcher) {
            $.matcher = matcher;
            return this;
        }

        /**
         * @param matcher Possible Values: `CONTAINS`, `ENDS_WITH`, `EQUALS`, `STARTS_WITH`
         * 
         * @return builder
         * 
         */
        public Builder matcher(String matcher) {
            return matcher(Output.of(matcher));
        }

        /**
         * @param pattern Pattern
         * 
         * @return builder
         * 
         */
        public Builder pattern(@Nullable Output<String> pattern) {
            $.pattern = pattern;
            return this;
        }

        /**
         * @param pattern Pattern
         * 
         * @return builder
         * 
         */
        public Builder pattern(String pattern) {
            return pattern(Output.of(pattern));
        }

        public WebAppBeaconOriginsState build() {
            return $;
        }
    }

}