// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// The synthetic locations data source queries for all available Synthetic Nodes. The data source doesn't need to get configured. It always provides the full list of synthetic nodes.
func GetSyntheticNodes(ctx *pulumi.Context, opts ...pulumi.InvokeOption) (*GetSyntheticNodesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSyntheticNodesResult
	err := ctx.Invoke("dynatrace:index/getSyntheticNodes:getSyntheticNodes", nil, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of values returned by getSyntheticNodes.
type GetSyntheticNodesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id    string                  `pulumi:"id"`
	Nodes []GetSyntheticNodesNode `pulumi:"nodes"`
}

func GetSyntheticNodesOutput(ctx *pulumi.Context, opts ...pulumi.InvokeOption) GetSyntheticNodesResultOutput {
	return pulumi.ToOutput(0).ApplyT(func(int) (GetSyntheticNodesResult, error) {
		r, err := GetSyntheticNodes(ctx, opts...)
		var s GetSyntheticNodesResult
		if r != nil {
			s = *r
		}
		return s, err
	}).(GetSyntheticNodesResultOutput)
}

// A collection of values returned by getSyntheticNodes.
type GetSyntheticNodesResultOutput struct{ *pulumi.OutputState }

func (GetSyntheticNodesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSyntheticNodesResult)(nil)).Elem()
}

func (o GetSyntheticNodesResultOutput) ToGetSyntheticNodesResultOutput() GetSyntheticNodesResultOutput {
	return o
}

func (o GetSyntheticNodesResultOutput) ToGetSyntheticNodesResultOutputWithContext(ctx context.Context) GetSyntheticNodesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetSyntheticNodesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSyntheticNodesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSyntheticNodesResultOutput) Nodes() GetSyntheticNodesNodeArrayOutput {
	return o.ApplyT(func(v GetSyntheticNodesResult) []GetSyntheticNodesNode { return v.Nodes }).(GetSyntheticNodesNodeArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSyntheticNodesResultOutput{})
}