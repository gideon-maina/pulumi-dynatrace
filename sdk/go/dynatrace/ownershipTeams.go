// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type OwnershipTeams struct {
	pulumi.CustomResourceState

	// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
	AdditionalInformation OwnershipTeamsAdditionalInformationPtrOutput `pulumi:"additionalInformation"`
	// Define options for messaging integration or other means of contacting this team.
	ContactDetails OwnershipTeamsContactDetailsPtrOutput `pulumi:"contactDetails"`
	// Description
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
	ExternalId pulumi.StringPtrOutput `pulumi:"externalId"`
	// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
	Identifier pulumi.StringOutput `pulumi:"identifier"`
	// Include links to online resources where information relevant to this team’s responsibilities can be found.
	Links OwnershipTeamsLinksPtrOutput `pulumi:"links"`
	// Team name
	Name pulumi.StringOutput `pulumi:"name"`
	// Turn on all responsibility assignments that apply to this team.
	Responsibilities OwnershipTeamsResponsibilitiesOutput `pulumi:"responsibilities"`
	// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
	SupplementaryIdentifiers OwnershipTeamsSupplementaryIdentifiersPtrOutput `pulumi:"supplementaryIdentifiers"`
}

// NewOwnershipTeams registers a new resource with the given unique name, arguments, and options.
func NewOwnershipTeams(ctx *pulumi.Context,
	name string, args *OwnershipTeamsArgs, opts ...pulumi.ResourceOption) (*OwnershipTeams, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Identifier == nil {
		return nil, errors.New("invalid value for required argument 'Identifier'")
	}
	if args.Responsibilities == nil {
		return nil, errors.New("invalid value for required argument 'Responsibilities'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource OwnershipTeams
	err := ctx.RegisterResource("dynatrace:index/ownershipTeams:OwnershipTeams", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOwnershipTeams gets an existing OwnershipTeams resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOwnershipTeams(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OwnershipTeamsState, opts ...pulumi.ResourceOption) (*OwnershipTeams, error) {
	var resource OwnershipTeams
	err := ctx.ReadResource("dynatrace:index/ownershipTeams:OwnershipTeams", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OwnershipTeams resources.
type ownershipTeamsState struct {
	// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
	AdditionalInformation *OwnershipTeamsAdditionalInformation `pulumi:"additionalInformation"`
	// Define options for messaging integration or other means of contacting this team.
	ContactDetails *OwnershipTeamsContactDetails `pulumi:"contactDetails"`
	// Description
	Description *string `pulumi:"description"`
	// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
	ExternalId *string `pulumi:"externalId"`
	// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
	Identifier *string `pulumi:"identifier"`
	// Include links to online resources where information relevant to this team’s responsibilities can be found.
	Links *OwnershipTeamsLinks `pulumi:"links"`
	// Team name
	Name *string `pulumi:"name"`
	// Turn on all responsibility assignments that apply to this team.
	Responsibilities *OwnershipTeamsResponsibilities `pulumi:"responsibilities"`
	// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
	SupplementaryIdentifiers *OwnershipTeamsSupplementaryIdentifiers `pulumi:"supplementaryIdentifiers"`
}

type OwnershipTeamsState struct {
	// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
	AdditionalInformation OwnershipTeamsAdditionalInformationPtrInput
	// Define options for messaging integration or other means of contacting this team.
	ContactDetails OwnershipTeamsContactDetailsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
	ExternalId pulumi.StringPtrInput
	// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
	Identifier pulumi.StringPtrInput
	// Include links to online resources where information relevant to this team’s responsibilities can be found.
	Links OwnershipTeamsLinksPtrInput
	// Team name
	Name pulumi.StringPtrInput
	// Turn on all responsibility assignments that apply to this team.
	Responsibilities OwnershipTeamsResponsibilitiesPtrInput
	// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
	SupplementaryIdentifiers OwnershipTeamsSupplementaryIdentifiersPtrInput
}

func (OwnershipTeamsState) ElementType() reflect.Type {
	return reflect.TypeOf((*ownershipTeamsState)(nil)).Elem()
}

type ownershipTeamsArgs struct {
	// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
	AdditionalInformation *OwnershipTeamsAdditionalInformation `pulumi:"additionalInformation"`
	// Define options for messaging integration or other means of contacting this team.
	ContactDetails *OwnershipTeamsContactDetails `pulumi:"contactDetails"`
	// Description
	Description *string `pulumi:"description"`
	// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
	ExternalId *string `pulumi:"externalId"`
	// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
	Identifier string `pulumi:"identifier"`
	// Include links to online resources where information relevant to this team’s responsibilities can be found.
	Links *OwnershipTeamsLinks `pulumi:"links"`
	// Team name
	Name *string `pulumi:"name"`
	// Turn on all responsibility assignments that apply to this team.
	Responsibilities OwnershipTeamsResponsibilities `pulumi:"responsibilities"`
	// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
	SupplementaryIdentifiers *OwnershipTeamsSupplementaryIdentifiers `pulumi:"supplementaryIdentifiers"`
}

// The set of arguments for constructing a OwnershipTeams resource.
type OwnershipTeamsArgs struct {
	// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
	AdditionalInformation OwnershipTeamsAdditionalInformationPtrInput
	// Define options for messaging integration or other means of contacting this team.
	ContactDetails OwnershipTeamsContactDetailsPtrInput
	// Description
	Description pulumi.StringPtrInput
	// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
	ExternalId pulumi.StringPtrInput
	// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
	Identifier pulumi.StringInput
	// Include links to online resources where information relevant to this team’s responsibilities can be found.
	Links OwnershipTeamsLinksPtrInput
	// Team name
	Name pulumi.StringPtrInput
	// Turn on all responsibility assignments that apply to this team.
	Responsibilities OwnershipTeamsResponsibilitiesInput
	// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
	SupplementaryIdentifiers OwnershipTeamsSupplementaryIdentifiersPtrInput
}

func (OwnershipTeamsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ownershipTeamsArgs)(nil)).Elem()
}

type OwnershipTeamsInput interface {
	pulumi.Input

	ToOwnershipTeamsOutput() OwnershipTeamsOutput
	ToOwnershipTeamsOutputWithContext(ctx context.Context) OwnershipTeamsOutput
}

func (*OwnershipTeams) ElementType() reflect.Type {
	return reflect.TypeOf((**OwnershipTeams)(nil)).Elem()
}

func (i *OwnershipTeams) ToOwnershipTeamsOutput() OwnershipTeamsOutput {
	return i.ToOwnershipTeamsOutputWithContext(context.Background())
}

func (i *OwnershipTeams) ToOwnershipTeamsOutputWithContext(ctx context.Context) OwnershipTeamsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OwnershipTeamsOutput)
}

// OwnershipTeamsArrayInput is an input type that accepts OwnershipTeamsArray and OwnershipTeamsArrayOutput values.
// You can construct a concrete instance of `OwnershipTeamsArrayInput` via:
//
//	OwnershipTeamsArray{ OwnershipTeamsArgs{...} }
type OwnershipTeamsArrayInput interface {
	pulumi.Input

	ToOwnershipTeamsArrayOutput() OwnershipTeamsArrayOutput
	ToOwnershipTeamsArrayOutputWithContext(context.Context) OwnershipTeamsArrayOutput
}

type OwnershipTeamsArray []OwnershipTeamsInput

func (OwnershipTeamsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OwnershipTeams)(nil)).Elem()
}

func (i OwnershipTeamsArray) ToOwnershipTeamsArrayOutput() OwnershipTeamsArrayOutput {
	return i.ToOwnershipTeamsArrayOutputWithContext(context.Background())
}

func (i OwnershipTeamsArray) ToOwnershipTeamsArrayOutputWithContext(ctx context.Context) OwnershipTeamsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OwnershipTeamsArrayOutput)
}

// OwnershipTeamsMapInput is an input type that accepts OwnershipTeamsMap and OwnershipTeamsMapOutput values.
// You can construct a concrete instance of `OwnershipTeamsMapInput` via:
//
//	OwnershipTeamsMap{ "key": OwnershipTeamsArgs{...} }
type OwnershipTeamsMapInput interface {
	pulumi.Input

	ToOwnershipTeamsMapOutput() OwnershipTeamsMapOutput
	ToOwnershipTeamsMapOutputWithContext(context.Context) OwnershipTeamsMapOutput
}

type OwnershipTeamsMap map[string]OwnershipTeamsInput

func (OwnershipTeamsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OwnershipTeams)(nil)).Elem()
}

func (i OwnershipTeamsMap) ToOwnershipTeamsMapOutput() OwnershipTeamsMapOutput {
	return i.ToOwnershipTeamsMapOutputWithContext(context.Background())
}

func (i OwnershipTeamsMap) ToOwnershipTeamsMapOutputWithContext(ctx context.Context) OwnershipTeamsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OwnershipTeamsMapOutput)
}

type OwnershipTeamsOutput struct{ *pulumi.OutputState }

func (OwnershipTeamsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OwnershipTeams)(nil)).Elem()
}

func (o OwnershipTeamsOutput) ToOwnershipTeamsOutput() OwnershipTeamsOutput {
	return o
}

func (o OwnershipTeamsOutput) ToOwnershipTeamsOutputWithContext(ctx context.Context) OwnershipTeamsOutput {
	return o
}

// Define key/value pairs that further describe this team — for example, cost center, solution type, or business unit assignments.
func (o OwnershipTeamsOutput) AdditionalInformation() OwnershipTeamsAdditionalInformationPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) OwnershipTeamsAdditionalInformationPtrOutput { return v.AdditionalInformation }).(OwnershipTeamsAdditionalInformationPtrOutput)
}

// Define options for messaging integration or other means of contacting this team.
func (o OwnershipTeamsOutput) ContactDetails() OwnershipTeamsContactDetailsPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) OwnershipTeamsContactDetailsPtrOutput { return v.ContactDetails }).(OwnershipTeamsContactDetailsPtrOutput)
}

// Description
func (o OwnershipTeamsOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// This field should only be used for the automation purpose when importing team information. Once the external ID is created it can’t be changed.
func (o OwnershipTeamsOutput) ExternalId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) pulumi.StringPtrOutput { return v.ExternalId }).(pulumi.StringPtrOutput)
}

// The team identifier is used to reference the team from any entity in Dynatrace. This identifier can’t be edited once the team has been created.
func (o OwnershipTeamsOutput) Identifier() pulumi.StringOutput {
	return o.ApplyT(func(v *OwnershipTeams) pulumi.StringOutput { return v.Identifier }).(pulumi.StringOutput)
}

// Include links to online resources where information relevant to this team’s responsibilities can be found.
func (o OwnershipTeamsOutput) Links() OwnershipTeamsLinksPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) OwnershipTeamsLinksPtrOutput { return v.Links }).(OwnershipTeamsLinksPtrOutput)
}

// Team name
func (o OwnershipTeamsOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *OwnershipTeams) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Turn on all responsibility assignments that apply to this team.
func (o OwnershipTeamsOutput) Responsibilities() OwnershipTeamsResponsibilitiesOutput {
	return o.ApplyT(func(v *OwnershipTeams) OwnershipTeamsResponsibilitiesOutput { return v.Responsibilities }).(OwnershipTeamsResponsibilitiesOutput)
}

// The supplementary team identifiers can be optionally used in addition to the main team identifier to reference this team from any entity in Dynatrace. Up to 3 supplementary identifiers are supported.
func (o OwnershipTeamsOutput) SupplementaryIdentifiers() OwnershipTeamsSupplementaryIdentifiersPtrOutput {
	return o.ApplyT(func(v *OwnershipTeams) OwnershipTeamsSupplementaryIdentifiersPtrOutput {
		return v.SupplementaryIdentifiers
	}).(OwnershipTeamsSupplementaryIdentifiersPtrOutput)
}

type OwnershipTeamsArrayOutput struct{ *pulumi.OutputState }

func (OwnershipTeamsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OwnershipTeams)(nil)).Elem()
}

func (o OwnershipTeamsArrayOutput) ToOwnershipTeamsArrayOutput() OwnershipTeamsArrayOutput {
	return o
}

func (o OwnershipTeamsArrayOutput) ToOwnershipTeamsArrayOutputWithContext(ctx context.Context) OwnershipTeamsArrayOutput {
	return o
}

func (o OwnershipTeamsArrayOutput) Index(i pulumi.IntInput) OwnershipTeamsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OwnershipTeams {
		return vs[0].([]*OwnershipTeams)[vs[1].(int)]
	}).(OwnershipTeamsOutput)
}

type OwnershipTeamsMapOutput struct{ *pulumi.OutputState }

func (OwnershipTeamsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OwnershipTeams)(nil)).Elem()
}

func (o OwnershipTeamsMapOutput) ToOwnershipTeamsMapOutput() OwnershipTeamsMapOutput {
	return o
}

func (o OwnershipTeamsMapOutput) ToOwnershipTeamsMapOutputWithContext(ctx context.Context) OwnershipTeamsMapOutput {
	return o
}

func (o OwnershipTeamsMapOutput) MapIndex(k pulumi.StringInput) OwnershipTeamsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OwnershipTeams {
		return vs[0].(map[string]*OwnershipTeams)[vs[1].(string)]
	}).(OwnershipTeamsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OwnershipTeamsInput)(nil)).Elem(), &OwnershipTeams{})
	pulumi.RegisterInputType(reflect.TypeOf((*OwnershipTeamsArrayInput)(nil)).Elem(), OwnershipTeamsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OwnershipTeamsMapInput)(nil)).Elem(), OwnershipTeamsMap{})
	pulumi.RegisterOutputType(OwnershipTeamsOutput{})
	pulumi.RegisterOutputType(OwnershipTeamsArrayOutput{})
	pulumi.RegisterOutputType(OwnershipTeamsMapOutput{})
}