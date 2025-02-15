// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// The IAM policy data source allows the policy UUID to be retrieved by its name and account/environment (exclude for global).
//
// ## Example Usage
//
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			appengineadmin, err := dynatrace.LookupIamPolicy(ctx, &dynatrace.LookupIamPolicyArgs{
//				Name: "AppEngine - Admin",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			ctx.Export("policies", appengineadmin)
//			return nil
//		})
//	}
//
// ```
//
// ## Example Output
func LookupIamPolicy(ctx *pulumi.Context, args *LookupIamPolicyArgs, opts ...pulumi.InvokeOption) (*LookupIamPolicyResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupIamPolicyResult
	err := ctx.Invoke("dynatrace:index/getIamPolicy:getIamPolicy", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getIamPolicy.
type LookupIamPolicyArgs struct {
	// The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
	Account *string `pulumi:"account"`
	// The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
	Environment *string `pulumi:"environment"`
	// The name of the policy
	Name string `pulumi:"name"`
	// The UUID of the policy
	Uuid *string `pulumi:"uuid"`
}

// A collection of values returned by getIamPolicy.
type LookupIamPolicyResult struct {
	// The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
	Account *string `pulumi:"account"`
	// The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
	Environment *string `pulumi:"environment"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The name of the policy
	Name string `pulumi:"name"`
	// The UUID of the policy
	Uuid string `pulumi:"uuid"`
}

func LookupIamPolicyOutput(ctx *pulumi.Context, args LookupIamPolicyOutputArgs, opts ...pulumi.InvokeOption) LookupIamPolicyResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupIamPolicyResult, error) {
			args := v.(LookupIamPolicyArgs)
			r, err := LookupIamPolicy(ctx, &args, opts...)
			var s LookupIamPolicyResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupIamPolicyResultOutput)
}

// A collection of arguments for invoking getIamPolicy.
type LookupIamPolicyOutputArgs struct {
	// The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
	Account pulumi.StringPtrInput `pulumi:"account"`
	// The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
	Environment pulumi.StringPtrInput `pulumi:"environment"`
	// The name of the policy
	Name pulumi.StringInput `pulumi:"name"`
	// The UUID of the policy
	Uuid pulumi.StringPtrInput `pulumi:"uuid"`
}

func (LookupIamPolicyOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamPolicyArgs)(nil)).Elem()
}

// A collection of values returned by getIamPolicy.
type LookupIamPolicyResultOutput struct{ *pulumi.OutputState }

func (LookupIamPolicyResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupIamPolicyResult)(nil)).Elem()
}

func (o LookupIamPolicyResultOutput) ToLookupIamPolicyResultOutput() LookupIamPolicyResultOutput {
	return o
}

func (o LookupIamPolicyResultOutput) ToLookupIamPolicyResultOutputWithContext(ctx context.Context) LookupIamPolicyResultOutput {
	return o
}

// The account that policiy is defined for. Omit if the policy is not defined for an account but for an environment or is global
func (o LookupIamPolicyResultOutput) Account() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIamPolicyResult) *string { return v.Account }).(pulumi.StringPtrOutput)
}

// The environment that policiy is defined for. Omit if the policy is not defined for an environment but for an account or is global
func (o LookupIamPolicyResultOutput) Environment() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupIamPolicyResult) *string { return v.Environment }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupIamPolicyResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamPolicyResult) string { return v.Id }).(pulumi.StringOutput)
}

// The name of the policy
func (o LookupIamPolicyResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamPolicyResult) string { return v.Name }).(pulumi.StringOutput)
}

// The UUID of the policy
func (o LookupIamPolicyResultOutput) Uuid() pulumi.StringOutput {
	return o.ApplyT(func(v LookupIamPolicyResult) string { return v.Uuid }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupIamPolicyResultOutput{})
}
