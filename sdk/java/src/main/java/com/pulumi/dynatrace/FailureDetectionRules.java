// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.dynatrace.FailureDetectionRulesArgs;
import com.pulumi.dynatrace.Utilities;
import com.pulumi.dynatrace.inputs.FailureDetectionRulesState;
import com.pulumi.dynatrace.outputs.FailureDetectionRulesConditions;
import java.lang.Boolean;
import java.lang.String;
import java.util.Optional;
import javax.annotation.Nullable;

@ResourceType(type="dynatrace:index/failureDetectionRules:FailureDetectionRules")
public class FailureDetectionRules extends com.pulumi.resources.CustomResource {
    /**
     * Conditions
     * 
     */
    @Export(name="conditions", refs={FailureDetectionRulesConditions.class}, tree="[0]")
    private Output<FailureDetectionRulesConditions> conditions;

    /**
     * @return Conditions
     * 
     */
    public Output<FailureDetectionRulesConditions> conditions() {
        return this.conditions;
    }
    /**
     * Rule description
     * 
     */
    @Export(name="description", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> description;

    /**
     * @return Rule description
     * 
     */
    public Output<Optional<String>> description() {
        return Codegen.optional(this.description);
    }
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    @Export(name="enabled", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> enabled;

    /**
     * @return This setting is enabled (`true`) or disabled (`false`)
     * 
     */
    public Output<Boolean> enabled() {
        return this.enabled;
    }
    /**
     * Rule name
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return Rule name
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * Failure detection parameters
     * 
     */
    @Export(name="parameterId", refs={String.class}, tree="[0]")
    private Output<String> parameterId;

    /**
     * @return Failure detection parameters
     * 
     */
    public Output<String> parameterId() {
        return this.parameterId;
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public FailureDetectionRules(String name) {
        this(name, FailureDetectionRulesArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public FailureDetectionRules(String name, FailureDetectionRulesArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public FailureDetectionRules(String name, FailureDetectionRulesArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/failureDetectionRules:FailureDetectionRules", name, args == null ? FailureDetectionRulesArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private FailureDetectionRules(String name, Output<String> id, @Nullable FailureDetectionRulesState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/failureDetectionRules:FailureDetectionRules", name, state, makeResourceOptions(options, id));
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<String> id) {
        var defaultOptions = com.pulumi.resources.CustomResourceOptions.builder()
            .version(Utilities.getVersion())
            .build();
        return com.pulumi.resources.CustomResourceOptions.merge(defaultOptions, options, id);
    }

    /**
     * Get an existing Host resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state
     * @param options Optional settings to control the behavior of the CustomResource.
     */
    public static FailureDetectionRules get(String name, Output<String> id, @Nullable FailureDetectionRulesState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new FailureDetectionRules(name, id, state, options);
    }
}