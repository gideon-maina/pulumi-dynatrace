// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class LimitOutboundConnections extends pulumi.CustomResource {
    /**
     * Get an existing LimitOutboundConnections resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LimitOutboundConnectionsState, opts?: pulumi.CustomResourceOptions): LimitOutboundConnections {
        return new LimitOutboundConnections(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/limitOutboundConnections:LimitOutboundConnections';

    /**
     * Returns true if the given object is an instance of LimitOutboundConnections.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LimitOutboundConnections {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LimitOutboundConnections.__pulumiType;
    }

    /**
     * no documentation available
     */
    public readonly allowedOutboundConnections!: pulumi.Output<outputs.LimitOutboundConnectionsAllowedOutboundConnections>;

    /**
     * Create a LimitOutboundConnections resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LimitOutboundConnectionsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LimitOutboundConnectionsArgs | LimitOutboundConnectionsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LimitOutboundConnectionsState | undefined;
            resourceInputs["allowedOutboundConnections"] = state ? state.allowedOutboundConnections : undefined;
        } else {
            const args = argsOrState as LimitOutboundConnectionsArgs | undefined;
            if ((!args || args.allowedOutboundConnections === undefined) && !opts.urn) {
                throw new Error("Missing required property 'allowedOutboundConnections'");
            }
            resourceInputs["allowedOutboundConnections"] = args ? args.allowedOutboundConnections : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LimitOutboundConnections.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LimitOutboundConnections resources.
 */
export interface LimitOutboundConnectionsState {
    /**
     * no documentation available
     */
    allowedOutboundConnections?: pulumi.Input<inputs.LimitOutboundConnectionsAllowedOutboundConnections>;
}

/**
 * The set of arguments for constructing a LimitOutboundConnections resource.
 */
export interface LimitOutboundConnectionsArgs {
    /**
     * no documentation available
     */
    allowedOutboundConnections: pulumi.Input<inputs.LimitOutboundConnectionsAllowedOutboundConnections>;
}