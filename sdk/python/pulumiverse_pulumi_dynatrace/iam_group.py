# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = ['IamGroupArgs', 'IamGroup']

@pulumi.input_type
class IamGroupArgs:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 federated_attribute_values: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input['IamGroupPermissionsArgs']] = None):
        """
        The set of arguments for constructing a IamGroup resource.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if federated_attribute_values is not None:
            pulumi.set(__self__, "federated_attribute_values", federated_attribute_values)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="federatedAttributeValues")
    def federated_attribute_values(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "federated_attribute_values")

    @federated_attribute_values.setter
    def federated_attribute_values(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "federated_attribute_values", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input['IamGroupPermissionsArgs']]:
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input['IamGroupPermissionsArgs']]):
        pulumi.set(self, "permissions", value)


@pulumi.input_type
class _IamGroupState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 federated_attribute_values: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input['IamGroupPermissionsArgs']] = None):
        """
        Input properties used for looking up and filtering IamGroup resources.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if federated_attribute_values is not None:
            pulumi.set(__self__, "federated_attribute_values", federated_attribute_values)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="federatedAttributeValues")
    def federated_attribute_values(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "federated_attribute_values")

    @federated_attribute_values.setter
    def federated_attribute_values(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "federated_attribute_values", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input['IamGroupPermissionsArgs']]:
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input['IamGroupPermissionsArgs']]):
        pulumi.set(self, "permissions", value)


class IamGroup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 federated_attribute_values: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[pulumi.InputType['IamGroupPermissionsArgs']]] = None,
                 __props__=None):
        """
        ## Dynatrace Documentation

        - Dynatrace IAM - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions

        - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started

        ## Prerequisites

        Using this resource requires an OAuth client to be configured within your account settings.
        The scopes of the OAuth Client need to include `account-idm-read`, `account-idm-write`, `account-env-read`, `account-env-write`, `iam-policies-management`, `iam:policies:write`, `iam:policies:read`, `iam:bindings:write`, `iam:bindings:read` and `iam:effective-permissions:read`.

        Finally the provider configuration requires the credentials for that OAuth Client.
        The configuration section of your provider needs to look like this.
        ```python
        import pulumi
        ```

        ## Resource Example Usage

        ```python
        import pulumi
        import pulumiverse_pulumi_dynatrace as dynatrace

        restricted = dynatrace.IamGroup("restricted", permissions=dynatrace.IamGroupPermissionsArgs(
            permissions=[dynatrace.IamGroupPermissionsPermissionArgs(
                name="tenant-viewer",
                scope="<environment-id>:<managementzone-id>",
                type="management-zone",
            )],
        ))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[IamGroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        ## Dynatrace Documentation

        - Dynatrace IAM - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions

        - Settings API - https://www.dynatrace.com/support/help/how-to-use-dynatrace/user-management-and-sso/manage-groups-and-permissions/iam/iam-getting-started

        ## Prerequisites

        Using this resource requires an OAuth client to be configured within your account settings.
        The scopes of the OAuth Client need to include `account-idm-read`, `account-idm-write`, `account-env-read`, `account-env-write`, `iam-policies-management`, `iam:policies:write`, `iam:policies:read`, `iam:bindings:write`, `iam:bindings:read` and `iam:effective-permissions:read`.

        Finally the provider configuration requires the credentials for that OAuth Client.
        The configuration section of your provider needs to look like this.
        ```python
        import pulumi
        ```

        ## Resource Example Usage

        ```python
        import pulumi
        import pulumiverse_pulumi_dynatrace as dynatrace

        restricted = dynatrace.IamGroup("restricted", permissions=dynatrace.IamGroupPermissionsArgs(
            permissions=[dynatrace.IamGroupPermissionsPermissionArgs(
                name="tenant-viewer",
                scope="<environment-id>:<managementzone-id>",
                type="management-zone",
            )],
        ))
        ```

        :param str resource_name: The name of the resource.
        :param IamGroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(IamGroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 federated_attribute_values: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[pulumi.InputType['IamGroupPermissionsArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = IamGroupArgs.__new__(IamGroupArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["federated_attribute_values"] = federated_attribute_values
            __props__.__dict__["name"] = name
            __props__.__dict__["permissions"] = permissions
        super(IamGroup, __self__).__init__(
            'dynatrace:index/iamGroup:IamGroup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            federated_attribute_values: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            name: Optional[pulumi.Input[str]] = None,
            permissions: Optional[pulumi.Input[pulumi.InputType['IamGroupPermissionsArgs']]] = None) -> 'IamGroup':
        """
        Get an existing IamGroup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _IamGroupState.__new__(_IamGroupState)

        __props__.__dict__["description"] = description
        __props__.__dict__["federated_attribute_values"] = federated_attribute_values
        __props__.__dict__["name"] = name
        __props__.__dict__["permissions"] = permissions
        return IamGroup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="federatedAttributeValues")
    def federated_attribute_values(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "federated_attribute_values")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Optional['outputs.IamGroupPermissions']]:
        return pulumi.get(self, "permissions")
