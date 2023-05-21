// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Import;
import java.lang.Boolean;
import java.util.Objects;


public final class FrequentIssuesArgs extends com.pulumi.resources.ResourceArgs {

    public static final FrequentIssuesArgs Empty = new FrequentIssuesArgs();

    /**
     * Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="detectApps", required=true)
    private Output<Boolean> detectApps;

    /**
     * @return Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Boolean> detectApps() {
        return this.detectApps;
    }

    /**
     * Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="detectInfra", required=true)
    private Output<Boolean> detectInfra;

    /**
     * @return Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Boolean> detectInfra() {
        return this.detectInfra;
    }

    /**
     * Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
     * 
     */
    @Import(name="detectTxn", required=true)
    private Output<Boolean> detectTxn;

    /**
     * @return Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Boolean> detectTxn() {
        return this.detectTxn;
    }

    private FrequentIssuesArgs() {}

    private FrequentIssuesArgs(FrequentIssuesArgs $) {
        this.detectApps = $.detectApps;
        this.detectInfra = $.detectInfra;
        this.detectTxn = $.detectTxn;
    }

    public static Builder builder() {
        return new Builder();
    }
    public static Builder builder(FrequentIssuesArgs defaults) {
        return new Builder(defaults);
    }

    public static final class Builder {
        private FrequentIssuesArgs $;

        public Builder() {
            $ = new FrequentIssuesArgs();
        }

        public Builder(FrequentIssuesArgs defaults) {
            $ = new FrequentIssuesArgs(Objects.requireNonNull(defaults));
        }

        /**
         * @param detectApps Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectApps(Output<Boolean> detectApps) {
            $.detectApps = detectApps;
            return this;
        }

        /**
         * @param detectApps Detect frequent issues within applications, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectApps(Boolean detectApps) {
            return detectApps(Output.of(detectApps));
        }

        /**
         * @param detectInfra Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectInfra(Output<Boolean> detectInfra) {
            $.detectInfra = detectInfra;
            return this;
        }

        /**
         * @param detectInfra Detect frequent issues within infrastructure, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectInfra(Boolean detectInfra) {
            return detectInfra(Output.of(detectInfra));
        }

        /**
         * @param detectTxn Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectTxn(Output<Boolean> detectTxn) {
            $.detectTxn = detectTxn;
            return this;
        }

        /**
         * @param detectTxn Detect frequent issues within transactions and services, enabled (`true`) or disabled (`false`)
         * 
         * @return builder
         * 
         */
        public Builder detectTxn(Boolean detectTxn) {
            return detectTxn(Output.of(detectTxn));
        }

        public FrequentIssuesArgs build() {
            $.detectApps = Objects.requireNonNull($.detectApps, "expected parameter 'detectApps' to be non-null");
            $.detectInfra = Objects.requireNonNull($.detectInfra, "expected parameter 'detectInfra' to be non-null");
            $.detectTxn = Objects.requireNonNull($.detectTxn, "expected parameter 'detectTxn' to be non-null");
            return $;
        }
    }

}