// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.dynatrace.DiskOptionsArgs;
import com.pulumi.dynatrace.Utilities;
import com.pulumi.dynatrace.inputs.DiskOptionsState;
import com.pulumi.dynatrace.outputs.DiskOptionsExclusions;
import java.lang.Boolean;
import java.lang.String;
import java.util.Optional;
import javax.annotation.Nullable;

@ResourceType(type="dynatrace:index/diskOptions:DiskOptions")
public class DiskOptions extends com.pulumi.resources.CustomResource {
    /**
     * OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
     * disks from the monitoring list.
     * 
     */
    @Export(name="exclusions", refs={DiskOptionsExclusions.class}, tree="[0]")
    private Output</* @Nullable */ DiskOptionsExclusions> exclusions;

    /**
     * @return OneAgent automatically detects and monitors all your mount points, however you can create exception rules to remove
     * disks from the monitoring list.
     * 
     */
    public Output<Optional<DiskOptionsExclusions>> exclusions() {
        return Codegen.optional(this.exclusions);
    }
    /**
     * When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
     * Requires OneAgent 1.209 or later
     * 
     */
    @Export(name="nfsShowAll", refs={Boolean.class}, tree="[0]")
    private Output<Boolean> nfsShowAll;

    /**
     * @return When disabled OneAgent will try to deduplicate some of nfs disks. Disabled by default, applies only to Linux hosts.
     * Requires OneAgent 1.209 or later
     * 
     */
    public Output<Boolean> nfsShowAll() {
        return this.nfsShowAll;
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
    public DiskOptions(String name) {
        this(name, DiskOptionsArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public DiskOptions(String name, DiskOptionsArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public DiskOptions(String name, DiskOptionsArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/diskOptions:DiskOptions", name, args == null ? DiskOptionsArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private DiskOptions(String name, Output<String> id, @Nullable DiskOptionsState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/diskOptions:DiskOptions", name, state, makeResourceOptions(options, id));
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
    public static DiskOptions get(String name, Output<String> id, @Nullable DiskOptionsState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new DiskOptions(name, id, state, options);
    }
}