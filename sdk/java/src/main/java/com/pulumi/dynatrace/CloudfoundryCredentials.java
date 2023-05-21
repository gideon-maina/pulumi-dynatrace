// *** WARNING: this file was generated by pulumi-java-gen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package com.pulumi.dynatrace;

import com.pulumi.core.Output;
import com.pulumi.core.annotations.Export;
import com.pulumi.core.annotations.ResourceType;
import com.pulumi.core.internal.Codegen;
import com.pulumi.dynatrace.CloudfoundryCredentialsArgs;
import com.pulumi.dynatrace.Utilities;
import com.pulumi.dynatrace.inputs.CloudfoundryCredentialsState;
import java.lang.Boolean;
import java.lang.String;
import java.util.List;
import java.util.Optional;
import javax.annotation.Nullable;

@ResourceType(type="dynatrace:index/cloudfoundryCredentials:CloudfoundryCredentials")
public class CloudfoundryCredentials extends com.pulumi.resources.CustomResource {
    /**
     * The monitoring is enabled (`true`) or disabled (`false`) for given credentials configuration.  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected.
     * 
     */
    @Export(name="active", refs={Boolean.class}, tree="[0]")
    private Output</* @Nullable */ Boolean> active;

    /**
     * @return The monitoring is enabled (`true`) or disabled (`false`) for given credentials configuration.  If not set on creation, the `true` value is used.  If the field is omitted during an update, the old value remains unaffected.
     * 
     */
    public Output<Optional<Boolean>> active() {
        return Codegen.optional(this.active);
    }
    /**
     * The URL of the Cloud Foundry foundation credentials.  The URL must be valid according to RFC 2396.  Leading or trailing whitespaces are not allowed.
     * 
     */
    @Export(name="apiUrl", refs={String.class}, tree="[0]")
    private Output<String> apiUrl;

    /**
     * @return The URL of the Cloud Foundry foundation credentials.  The URL must be valid according to RFC 2396.  Leading or trailing whitespaces are not allowed.
     * 
     */
    public Output<String> apiUrl() {
        return this.apiUrl;
    }
    /**
     * The login URL of the Cloud Foundry foundation credentials. The URL must be valid according to RFC 2396.  Leading or trailing whitespaces are not allowed.
     * 
     */
    @Export(name="loginUrl", refs={String.class}, tree="[0]")
    private Output<String> loginUrl;

    /**
     * @return The login URL of the Cloud Foundry foundation credentials. The URL must be valid according to RFC 2396.  Leading or trailing whitespaces are not allowed.
     * 
     */
    public Output<String> loginUrl() {
        return this.loginUrl;
    }
    /**
     * The name of the Cloud Foundry foundation credentials.  Allowed characters are letters, numbers, whitespaces, and the following characters: `.+-_`. Leading or trailing whitespace is not allowed.
     * 
     */
    @Export(name="name", refs={String.class}, tree="[0]")
    private Output<String> name;

    /**
     * @return The name of the Cloud Foundry foundation credentials.  Allowed characters are letters, numbers, whitespaces, and the following characters: `.+-_`. Leading or trailing whitespace is not allowed.
     * 
     */
    public Output<String> name() {
        return this.name;
    }
    /**
     * The password of the Cloud Foundry foundation credentials.
     * 
     */
    @Export(name="password", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> password;

    /**
     * @return The password of the Cloud Foundry foundation credentials.
     * 
     */
    public Output<Optional<String>> password() {
        return Codegen.optional(this.password);
    }
    /**
     * Any attributes that aren&#39;t yet supported by this provider
     * 
     */
    @Export(name="unknowns", refs={String.class}, tree="[0]")
    private Output</* @Nullable */ String> unknowns;

    /**
     * @return Any attributes that aren&#39;t yet supported by this provider
     * 
     */
    public Output<Optional<String>> unknowns() {
        return Codegen.optional(this.unknowns);
    }
    /**
     * The username of the Cloud Foundry foundation credentials.  Leading and trailing whitespaces are not allowed.
     * 
     */
    @Export(name="username", refs={String.class}, tree="[0]")
    private Output<String> username;

    /**
     * @return The username of the Cloud Foundry foundation credentials.  Leading and trailing whitespaces are not allowed.
     * 
     */
    public Output<String> username() {
        return this.username;
    }

    /**
     *
     * @param name The _unique_ name of the resulting resource.
     */
    public CloudfoundryCredentials(String name) {
        this(name, CloudfoundryCredentialsArgs.Empty);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     */
    public CloudfoundryCredentials(String name, CloudfoundryCredentialsArgs args) {
        this(name, args, null);
    }
    /**
     *
     * @param name The _unique_ name of the resulting resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param options A bag of options that control this resource's behavior.
     */
    public CloudfoundryCredentials(String name, CloudfoundryCredentialsArgs args, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/cloudfoundryCredentials:CloudfoundryCredentials", name, args == null ? CloudfoundryCredentialsArgs.Empty : args, makeResourceOptions(options, Codegen.empty()));
    }

    private CloudfoundryCredentials(String name, Output<String> id, @Nullable CloudfoundryCredentialsState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        super("dynatrace:index/cloudfoundryCredentials:CloudfoundryCredentials", name, state, makeResourceOptions(options, id));
    }

    private static com.pulumi.resources.CustomResourceOptions makeResourceOptions(@Nullable com.pulumi.resources.CustomResourceOptions options, @Nullable Output<String> id) {
        var defaultOptions = com.pulumi.resources.CustomResourceOptions.builder()
            .version(Utilities.getVersion())
            .additionalSecretOutputs(List.of(
                "password"
            ))
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
    public static CloudfoundryCredentials get(String name, Output<String> id, @Nullable CloudfoundryCredentialsState state, @Nullable com.pulumi.resources.CustomResourceOptions options) {
        return new CloudfoundryCredentials(name, id, state, options);
    }
}