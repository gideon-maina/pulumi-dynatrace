// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * The IAM policy data source allows the policy UUID to be retrieved by its name and account/environment (exclude for global).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const appengineadmin = dynatrace.getIamPolicy({
 *     name: "AppEngine - Admin",
 * });
 * export const policies = appengineadmin;
 * ```
 *
 * ## Example Output
 */
export function getIamPolicy(args: GetIamPolicyArgs, opts?: pulumi.InvokeOptions): Promise<GetIamPolicyResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("dynatrace:index/getIamPolicy:getIamPolicy", {
        "account": args.account,
        "environment": args.environment,
        "name": args.name,
        "uuid": args.uuid,
    }, opts);
}

/**
 * A collection of arguments for invoking getIamPolicy.
 */
export interface GetIamPolicyArgs {
    /**
     * The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
     */
    account?: string;
    /**
     * The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
     */
    environment?: string;
    /**
     * The name of the policy
     */
    name: string;
    /**
     * The UUID of the policy
     */
    uuid?: string;
}

/**
 * A collection of values returned by getIamPolicy.
 */
export interface GetIamPolicyResult {
    /**
     * The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
     */
    readonly account?: string;
    /**
     * The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
     */
    readonly environment?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The name of the policy
     */
    readonly name: string;
    /**
     * The UUID of the policy
     */
    readonly uuid: string;
}
/**
 * The IAM policy data source allows the policy UUID to be retrieved by its name and account/environment (exclude for global).
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as dynatrace from "@pulumi/dynatrace";
 *
 * const appengineadmin = dynatrace.getIamPolicy({
 *     name: "AppEngine - Admin",
 * });
 * export const policies = appengineadmin;
 * ```
 *
 * ## Example Output
 */
export function getIamPolicyOutput(args: GetIamPolicyOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIamPolicyResult> {
    return pulumi.output(args).apply((a: any) => getIamPolicy(a, opts))
}

/**
 * A collection of arguments for invoking getIamPolicy.
 */
export interface GetIamPolicyOutputArgs {
    /**
     * The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
     */
    account?: pulumi.Input<string>;
    /**
     * The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
     */
    environment?: pulumi.Input<string>;
    /**
     * The name of the policy
     */
    name: pulumi.Input<string>;
    /**
     * The UUID of the policy
     */
    uuid?: pulumi.Input<string>;
}
