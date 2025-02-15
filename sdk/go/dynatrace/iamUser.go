// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dynatrace

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumiverse/pulumi-dynatrace/sdk/go/dynatrace/internal"
)

// > This resource is excluded by default in the export utility since it is part of the account management API. You can, of course, specify that resource explicitly in order to export it. In that case, don't forget to specify the environment variables `DT_CLIENT_ID`, `DT_ACCOUNT_ID` and `DT_CLIENT_SECRET` for authentication.
//
// > This resource requires the API token scopes **Allow read access for identity resources (users and groups)** (`account-idm-read`) and **Allow write access for identity resources (users and groups)** (`account-idm-write`)
//
// ## Dynatrace Documentation
//
// - Dynatrace IAM - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions
//
// - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started
//
// ## Prerequisites
//
// Using this resource requires an OAuth client to be configured within your account settings.
// The scopes of the OAuth Client need to include `account-idm-read`, `account-idm-write`, `account-env-read`, `account-env-write`, `iam-policies-management`, `iam:policies:write`, `iam:policies:read`, `iam:bindings:write`, `iam:bindings:read` and `iam:effective-permissions:read`.
//
// Finally the provider configuration requires the credentials for that OAuth Client.
// The configuration section of your provider needs to look like this.
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			return nil
//		})
//	}
//
// ```
//
// ## Resource Example Usage
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
//			_, err := dynatrace.NewIamUser(ctx, "johnDoeGmailCom", &dynatrace.IamUserArgs{
//				Email: pulumi.String("john.doe@gmail.com"),
//				Groups: pulumi.StringArray{
//					data.Dynatrace_iam_group.Restricted.Id,
//				},
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
type IamUser struct {
	pulumi.CustomResourceState

	Email  pulumi.StringOutput      `pulumi:"email"`
	Groups pulumi.StringArrayOutput `pulumi:"groups"`
	Uid    pulumi.StringOutput      `pulumi:"uid"`
}

// NewIamUser registers a new resource with the given unique name, arguments, and options.
func NewIamUser(ctx *pulumi.Context,
	name string, args *IamUserArgs, opts ...pulumi.ResourceOption) (*IamUser, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Email == nil {
		return nil, errors.New("invalid value for required argument 'Email'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IamUser
	err := ctx.RegisterResource("dynatrace:index/iamUser:IamUser", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIamUser gets an existing IamUser resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIamUser(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IamUserState, opts ...pulumi.ResourceOption) (*IamUser, error) {
	var resource IamUser
	err := ctx.ReadResource("dynatrace:index/iamUser:IamUser", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IamUser resources.
type iamUserState struct {
	Email  *string  `pulumi:"email"`
	Groups []string `pulumi:"groups"`
	Uid    *string  `pulumi:"uid"`
}

type IamUserState struct {
	Email  pulumi.StringPtrInput
	Groups pulumi.StringArrayInput
	Uid    pulumi.StringPtrInput
}

func (IamUserState) ElementType() reflect.Type {
	return reflect.TypeOf((*iamUserState)(nil)).Elem()
}

type iamUserArgs struct {
	Email  string   `pulumi:"email"`
	Groups []string `pulumi:"groups"`
}

// The set of arguments for constructing a IamUser resource.
type IamUserArgs struct {
	Email  pulumi.StringInput
	Groups pulumi.StringArrayInput
}

func (IamUserArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*iamUserArgs)(nil)).Elem()
}

type IamUserInput interface {
	pulumi.Input

	ToIamUserOutput() IamUserOutput
	ToIamUserOutputWithContext(ctx context.Context) IamUserOutput
}

func (*IamUser) ElementType() reflect.Type {
	return reflect.TypeOf((**IamUser)(nil)).Elem()
}

func (i *IamUser) ToIamUserOutput() IamUserOutput {
	return i.ToIamUserOutputWithContext(context.Background())
}

func (i *IamUser) ToIamUserOutputWithContext(ctx context.Context) IamUserOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamUserOutput)
}

// IamUserArrayInput is an input type that accepts IamUserArray and IamUserArrayOutput values.
// You can construct a concrete instance of `IamUserArrayInput` via:
//
//	IamUserArray{ IamUserArgs{...} }
type IamUserArrayInput interface {
	pulumi.Input

	ToIamUserArrayOutput() IamUserArrayOutput
	ToIamUserArrayOutputWithContext(context.Context) IamUserArrayOutput
}

type IamUserArray []IamUserInput

func (IamUserArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamUser)(nil)).Elem()
}

func (i IamUserArray) ToIamUserArrayOutput() IamUserArrayOutput {
	return i.ToIamUserArrayOutputWithContext(context.Background())
}

func (i IamUserArray) ToIamUserArrayOutputWithContext(ctx context.Context) IamUserArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamUserArrayOutput)
}

// IamUserMapInput is an input type that accepts IamUserMap and IamUserMapOutput values.
// You can construct a concrete instance of `IamUserMapInput` via:
//
//	IamUserMap{ "key": IamUserArgs{...} }
type IamUserMapInput interface {
	pulumi.Input

	ToIamUserMapOutput() IamUserMapOutput
	ToIamUserMapOutputWithContext(context.Context) IamUserMapOutput
}

type IamUserMap map[string]IamUserInput

func (IamUserMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamUser)(nil)).Elem()
}

func (i IamUserMap) ToIamUserMapOutput() IamUserMapOutput {
	return i.ToIamUserMapOutputWithContext(context.Background())
}

func (i IamUserMap) ToIamUserMapOutputWithContext(ctx context.Context) IamUserMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IamUserMapOutput)
}

type IamUserOutput struct{ *pulumi.OutputState }

func (IamUserOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IamUser)(nil)).Elem()
}

func (o IamUserOutput) ToIamUserOutput() IamUserOutput {
	return o
}

func (o IamUserOutput) ToIamUserOutputWithContext(ctx context.Context) IamUserOutput {
	return o
}

func (o IamUserOutput) Email() pulumi.StringOutput {
	return o.ApplyT(func(v *IamUser) pulumi.StringOutput { return v.Email }).(pulumi.StringOutput)
}

func (o IamUserOutput) Groups() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *IamUser) pulumi.StringArrayOutput { return v.Groups }).(pulumi.StringArrayOutput)
}

func (o IamUserOutput) Uid() pulumi.StringOutput {
	return o.ApplyT(func(v *IamUser) pulumi.StringOutput { return v.Uid }).(pulumi.StringOutput)
}

type IamUserArrayOutput struct{ *pulumi.OutputState }

func (IamUserArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IamUser)(nil)).Elem()
}

func (o IamUserArrayOutput) ToIamUserArrayOutput() IamUserArrayOutput {
	return o
}

func (o IamUserArrayOutput) ToIamUserArrayOutputWithContext(ctx context.Context) IamUserArrayOutput {
	return o
}

func (o IamUserArrayOutput) Index(i pulumi.IntInput) IamUserOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IamUser {
		return vs[0].([]*IamUser)[vs[1].(int)]
	}).(IamUserOutput)
}

type IamUserMapOutput struct{ *pulumi.OutputState }

func (IamUserMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IamUser)(nil)).Elem()
}

func (o IamUserMapOutput) ToIamUserMapOutput() IamUserMapOutput {
	return o
}

func (o IamUserMapOutput) ToIamUserMapOutputWithContext(ctx context.Context) IamUserMapOutput {
	return o
}

func (o IamUserMapOutput) MapIndex(k pulumi.StringInput) IamUserOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IamUser {
		return vs[0].(map[string]*IamUser)[vs[1].(string)]
	}).(IamUserOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IamUserInput)(nil)).Elem(), &IamUser{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamUserArrayInput)(nil)).Elem(), IamUserArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IamUserMapInput)(nil)).Elem(), IamUserMap{})
	pulumi.RegisterOutputType(IamUserOutput{})
	pulumi.RegisterOutputType(IamUserArrayOutput{})
	pulumi.RegisterOutputType(IamUserMapOutput{})
}
