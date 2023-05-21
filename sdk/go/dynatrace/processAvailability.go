// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type ProcessAvailability struct {
	pulumi.CustomResourceState

	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolOutput `pulumi:"enabled"`
	// Set of additional key-value properties to be attached to the triggered event.
	Metadata ProcessAvailabilityMetadataPtrOutput `pulumi:"metadata"`
	// Monitored rule name
	Name pulumi.StringOutput `pulumi:"name"`
	// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
	// detection rules associated with it.
	Rules ProcessAvailabilityRulesPtrOutput `pulumi:"rules"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrOutput `pulumi:"scope"`
}

// NewProcessAvailability registers a new resource with the given unique name, arguments, and options.
func NewProcessAvailability(ctx *pulumi.Context,
	name string, args *ProcessAvailabilityArgs, opts ...pulumi.ResourceOption) (*ProcessAvailability, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enabled == nil {
		return nil, errors.New("invalid value for required argument 'Enabled'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource ProcessAvailability
	err := ctx.RegisterResource("dynatrace:index/processAvailability:ProcessAvailability", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProcessAvailability gets an existing ProcessAvailability resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProcessAvailability(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProcessAvailabilityState, opts ...pulumi.ResourceOption) (*ProcessAvailability, error) {
	var resource ProcessAvailability
	err := ctx.ReadResource("dynatrace:index/processAvailability:ProcessAvailability", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProcessAvailability resources.
type processAvailabilityState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled *bool `pulumi:"enabled"`
	// Set of additional key-value properties to be attached to the triggered event.
	Metadata *ProcessAvailabilityMetadata `pulumi:"metadata"`
	// Monitored rule name
	Name *string `pulumi:"name"`
	// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
	// detection rules associated with it.
	Rules *ProcessAvailabilityRules `pulumi:"rules"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

type ProcessAvailabilityState struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolPtrInput
	// Set of additional key-value properties to be attached to the triggered event.
	Metadata ProcessAvailabilityMetadataPtrInput
	// Monitored rule name
	Name pulumi.StringPtrInput
	// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
	// detection rules associated with it.
	Rules ProcessAvailabilityRulesPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (ProcessAvailabilityState) ElementType() reflect.Type {
	return reflect.TypeOf((*processAvailabilityState)(nil)).Elem()
}

type processAvailabilityArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled bool `pulumi:"enabled"`
	// Set of additional key-value properties to be attached to the triggered event.
	Metadata *ProcessAvailabilityMetadata `pulumi:"metadata"`
	// Monitored rule name
	Name *string `pulumi:"name"`
	// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
	// detection rules associated with it.
	Rules *ProcessAvailabilityRules `pulumi:"rules"`
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope *string `pulumi:"scope"`
}

// The set of arguments for constructing a ProcessAvailability resource.
type ProcessAvailabilityArgs struct {
	// This setting is enabled (`true`) or disabled (`false`)
	Enabled pulumi.BoolInput
	// Set of additional key-value properties to be attached to the triggered event.
	Metadata ProcessAvailabilityMetadataPtrInput
	// Monitored rule name
	Name pulumi.StringPtrInput
	// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
	// detection rules associated with it.
	Rules ProcessAvailabilityRulesPtrInput
	// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
	Scope pulumi.StringPtrInput
}

func (ProcessAvailabilityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*processAvailabilityArgs)(nil)).Elem()
}

type ProcessAvailabilityInput interface {
	pulumi.Input

	ToProcessAvailabilityOutput() ProcessAvailabilityOutput
	ToProcessAvailabilityOutputWithContext(ctx context.Context) ProcessAvailabilityOutput
}

func (*ProcessAvailability) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessAvailability)(nil)).Elem()
}

func (i *ProcessAvailability) ToProcessAvailabilityOutput() ProcessAvailabilityOutput {
	return i.ToProcessAvailabilityOutputWithContext(context.Background())
}

func (i *ProcessAvailability) ToProcessAvailabilityOutputWithContext(ctx context.Context) ProcessAvailabilityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessAvailabilityOutput)
}

// ProcessAvailabilityArrayInput is an input type that accepts ProcessAvailabilityArray and ProcessAvailabilityArrayOutput values.
// You can construct a concrete instance of `ProcessAvailabilityArrayInput` via:
//
//	ProcessAvailabilityArray{ ProcessAvailabilityArgs{...} }
type ProcessAvailabilityArrayInput interface {
	pulumi.Input

	ToProcessAvailabilityArrayOutput() ProcessAvailabilityArrayOutput
	ToProcessAvailabilityArrayOutputWithContext(context.Context) ProcessAvailabilityArrayOutput
}

type ProcessAvailabilityArray []ProcessAvailabilityInput

func (ProcessAvailabilityArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessAvailability)(nil)).Elem()
}

func (i ProcessAvailabilityArray) ToProcessAvailabilityArrayOutput() ProcessAvailabilityArrayOutput {
	return i.ToProcessAvailabilityArrayOutputWithContext(context.Background())
}

func (i ProcessAvailabilityArray) ToProcessAvailabilityArrayOutputWithContext(ctx context.Context) ProcessAvailabilityArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessAvailabilityArrayOutput)
}

// ProcessAvailabilityMapInput is an input type that accepts ProcessAvailabilityMap and ProcessAvailabilityMapOutput values.
// You can construct a concrete instance of `ProcessAvailabilityMapInput` via:
//
//	ProcessAvailabilityMap{ "key": ProcessAvailabilityArgs{...} }
type ProcessAvailabilityMapInput interface {
	pulumi.Input

	ToProcessAvailabilityMapOutput() ProcessAvailabilityMapOutput
	ToProcessAvailabilityMapOutputWithContext(context.Context) ProcessAvailabilityMapOutput
}

type ProcessAvailabilityMap map[string]ProcessAvailabilityInput

func (ProcessAvailabilityMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessAvailability)(nil)).Elem()
}

func (i ProcessAvailabilityMap) ToProcessAvailabilityMapOutput() ProcessAvailabilityMapOutput {
	return i.ToProcessAvailabilityMapOutputWithContext(context.Background())
}

func (i ProcessAvailabilityMap) ToProcessAvailabilityMapOutputWithContext(ctx context.Context) ProcessAvailabilityMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProcessAvailabilityMapOutput)
}

type ProcessAvailabilityOutput struct{ *pulumi.OutputState }

func (ProcessAvailabilityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProcessAvailability)(nil)).Elem()
}

func (o ProcessAvailabilityOutput) ToProcessAvailabilityOutput() ProcessAvailabilityOutput {
	return o
}

func (o ProcessAvailabilityOutput) ToProcessAvailabilityOutputWithContext(ctx context.Context) ProcessAvailabilityOutput {
	return o
}

// This setting is enabled (`true`) or disabled (`false`)
func (o ProcessAvailabilityOutput) Enabled() pulumi.BoolOutput {
	return o.ApplyT(func(v *ProcessAvailability) pulumi.BoolOutput { return v.Enabled }).(pulumi.BoolOutput)
}

// Set of additional key-value properties to be attached to the triggered event.
func (o ProcessAvailabilityOutput) Metadata() ProcessAvailabilityMetadataPtrOutput {
	return o.ApplyT(func(v *ProcessAvailability) ProcessAvailabilityMetadataPtrOutput { return v.Metadata }).(ProcessAvailabilityMetadataPtrOutput)
}

// Monitored rule name
func (o ProcessAvailabilityOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *ProcessAvailability) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Define process detection rules by selecting a process property and a condition. Each monitoring rule can have multiple
// detection rules associated with it.
func (o ProcessAvailabilityOutput) Rules() ProcessAvailabilityRulesPtrOutput {
	return o.ApplyT(func(v *ProcessAvailability) ProcessAvailabilityRulesPtrOutput { return v.Rules }).(ProcessAvailabilityRulesPtrOutput)
}

// The scope of this setting (HOST, HOST_GROUP). Omit this property if you want to cover the whole environment.
func (o ProcessAvailabilityOutput) Scope() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ProcessAvailability) pulumi.StringPtrOutput { return v.Scope }).(pulumi.StringPtrOutput)
}

type ProcessAvailabilityArrayOutput struct{ *pulumi.OutputState }

func (ProcessAvailabilityArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProcessAvailability)(nil)).Elem()
}

func (o ProcessAvailabilityArrayOutput) ToProcessAvailabilityArrayOutput() ProcessAvailabilityArrayOutput {
	return o
}

func (o ProcessAvailabilityArrayOutput) ToProcessAvailabilityArrayOutputWithContext(ctx context.Context) ProcessAvailabilityArrayOutput {
	return o
}

func (o ProcessAvailabilityArrayOutput) Index(i pulumi.IntInput) ProcessAvailabilityOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProcessAvailability {
		return vs[0].([]*ProcessAvailability)[vs[1].(int)]
	}).(ProcessAvailabilityOutput)
}

type ProcessAvailabilityMapOutput struct{ *pulumi.OutputState }

func (ProcessAvailabilityMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProcessAvailability)(nil)).Elem()
}

func (o ProcessAvailabilityMapOutput) ToProcessAvailabilityMapOutput() ProcessAvailabilityMapOutput {
	return o
}

func (o ProcessAvailabilityMapOutput) ToProcessAvailabilityMapOutputWithContext(ctx context.Context) ProcessAvailabilityMapOutput {
	return o
}

func (o ProcessAvailabilityMapOutput) MapIndex(k pulumi.StringInput) ProcessAvailabilityOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProcessAvailability {
		return vs[0].(map[string]*ProcessAvailability)[vs[1].(string)]
	}).(ProcessAvailabilityOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessAvailabilityInput)(nil)).Elem(), &ProcessAvailability{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessAvailabilityArrayInput)(nil)).Elem(), ProcessAvailabilityArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProcessAvailabilityMapInput)(nil)).Elem(), ProcessAvailabilityMap{})
	pulumi.RegisterOutputType(ProcessAvailabilityOutput{})
	pulumi.RegisterOutputType(ProcessAvailabilityArrayOutput{})
	pulumi.RegisterOutputType(ProcessAvailabilityMapOutput{})
}