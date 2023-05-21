// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.dynatrace.NettracerArgs;
import com.pulumi.dynatrace.Utilities;
import com.pulumi.dynatrace.inputs.NettracerState;
import java.lang.Boolean;
import java.lang.String;
import java.util.Optional;
import javax.annotation.Nullable;

@ResourceType(type="dynatrace:index/nettracer:Nettracer")
public class Nettracer extends com.pulumi.resources.CustomResource {
    /**
     * When disabled, OneAgent won&#39;t use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
     * 
     */
    @Export(name="netTracer", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> netTracer;

    /**
     * @return When disabled, OneAgent won&#39;t use NetTracer to collect network data from containers. Disabled by default. Applies only to Linux hosts. Requires OneAgent 1.231+.
     * 
     */
    public Output<Boolean> netTracer() {
        return this.netTracer;
    }
    /**
     * The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     * 
     */
    @Export(name="scope", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> scope;

    /**
     * @return The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
     * 
     */
    public Output<Optional<String>> scope() {
        return Codegen.optional(this.scope);
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public Nettracer(String name) {
        this(name, NettracerArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public Nettracer(String name, NettracerArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public Nettracer(String name, NettracerArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/nettracer:Nettracer", name, args == null ? NettracerArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private Nettracer(String name, Output<String> id, @Nullable NettracerState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/nettracer:Nettracer", name, state, makeResourceOptions(options, id));
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
    public static Nettracer get(String name, Output<String> id, @Nullable NettracerState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new Nettracer(name, id, state, options);
    }
}