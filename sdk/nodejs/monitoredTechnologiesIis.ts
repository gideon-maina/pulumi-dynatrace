// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class MonitoredTechnologiesIis extends pulumi.CustomResource {
    /**
     * Get an existing MonitoredTechnologiesIis resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MonitoredTechnologiesIisState, opts?: pulumi.CustomResourceOptions): MonitoredTechnologiesIis {
        return new MonitoredTechnologiesIis(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'dynatrace:index/monitoredTechnologiesIis:MonitoredTechnologiesIis';

    /**
     * Returns true if the given object is an instance of MonitoredTechnologiesIis.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MonitoredTechnologiesIis {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MonitoredTechnologiesIis.__pulumiType;
    }

    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    public readonly hostId!: pulumi.Output<string | undefined>;

    /**
     * Create a MonitoredTechnologiesIis resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MonitoredTechnologiesIisArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MonitoredTechnologiesIisArgs | MonitoredTechnologiesIisState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MonitoredTechnologiesIisState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["hostId"] = state ? state.hostId : undefined;
        } else {
            const args = argsOrState as MonitoredTechnologiesIisArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["hostId"] = args ? args.hostId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MonitoredTechnologiesIis.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MonitoredTechnologiesIis resources.
 */
export interface MonitoredTechnologiesIisState {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MonitoredTechnologiesIis resource.
 */
export interface MonitoredTechnologiesIisArgs {
    /**
     * This setting is enabled (`true`) or disabled (`false`)
     */
    enabled: pulumi.Input<boolean>;
    /**
     * The scope of this settings. If the settings should cover the whole environment, just don't specify any scope.
     */
    hostId?: pulumi.Input<string>;
}