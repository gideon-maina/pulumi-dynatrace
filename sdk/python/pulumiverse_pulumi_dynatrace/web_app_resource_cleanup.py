# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['WebAppResourceCleanupArgs', 'WebAppResourceCleanup']

@pulumi.input_type
class WebAppResourceCleanupArgs:
    def __init__(__self__, *,
                 regular_expression: pulumi.Input[str],
                 replace_with: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a WebAppResourceCleanup resource.
        :param pulumi.Input[str] regular_expression: For example: `(.*)(journeyId=)-?\\d+(.*)`
        :param pulumi.Input[str] replace_with: For example: `$1$2\\*$3`
        :param pulumi.Input[str] name: For example: *Mask journeyId*
        """
        pulumi.set(__self__, "regular_expression", regular_expression)
        pulumi.set(__self__, "replace_with", replace_with)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="regularExpression")
    def regular_expression(self) -> pulumi.Input[str]:
        """
        For example: `(.*)(journeyId=)-?\\d+(.*)`
        """
        return pulumi.get(self, "regular_expression")

    @regular_expression.setter
    def regular_expression(self, value: pulumi.Input[str]):
        pulumi.set(self, "regular_expression", value)

    @property
    @pulumi.getter(name="replaceWith")
    def replace_with(self) -> pulumi.Input[str]:
        """
        For example: `$1$2\\*$3`
        """
        return pulumi.get(self, "replace_with")

    @replace_with.setter
    def replace_with(self, value: pulumi.Input[str]):
        pulumi.set(self, "replace_with", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        For example: *Mask journeyId*
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _WebAppResourceCleanupState:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 regular_expression: Optional[pulumi.Input[str]] = None,
                 replace_with: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering WebAppResourceCleanup resources.
        :param pulumi.Input[str] name: For example: *Mask journeyId*
        :param pulumi.Input[str] regular_expression: For example: `(.*)(journeyId=)-?\\d+(.*)`
        :param pulumi.Input[str] replace_with: For example: `$1$2\\*$3`
        """
        if name is not None:
            pulumi.set(__self__, "name", name)
        if regular_expression is not None:
            pulumi.set(__self__, "regular_expression", regular_expression)
        if replace_with is not None:
            pulumi.set(__self__, "replace_with", replace_with)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        For example: *Mask journeyId*
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="regularExpression")
    def regular_expression(self) -> Optional[pulumi.Input[str]]:
        """
        For example: `(.*)(journeyId=)-?\\d+(.*)`
        """
        return pulumi.get(self, "regular_expression")

    @regular_expression.setter
    def regular_expression(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "regular_expression", value)

    @property
    @pulumi.getter(name="replaceWith")
    def replace_with(self) -> Optional[pulumi.Input[str]]:
        """
        For example: `$1$2\\*$3`
        """
        return pulumi.get(self, "replace_with")

    @replace_with.setter
    def replace_with(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replace_with", value)


class WebAppResourceCleanup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 regular_expression: Optional[pulumi.Input[str]] = None,
                 replace_with: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a WebAppResourceCleanup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: For example: *Mask journeyId*
        :param pulumi.Input[str] regular_expression: For example: `(.*)(journeyId=)-?\\d+(.*)`
        :param pulumi.Input[str] replace_with: For example: `$1$2\\*$3`
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: WebAppResourceCleanupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a WebAppResourceCleanup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param WebAppResourceCleanupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(WebAppResourceCleanupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 regular_expression: Optional[pulumi.Input[str]] = None,
                 replace_with: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = WebAppResourceCleanupArgs.__new__(WebAppResourceCleanupArgs)

            __props__.__dict__["name"] = name
            if regular_expression is None and not opts.urn:
                raise TypeError("Missing required property 'regular_expression'")
            __props__.__dict__["regular_expression"] = regular_expression
            if replace_with is None and not opts.urn:
                raise TypeError("Missing required property 'replace_with'")
            __props__.__dict__["replace_with"] = replace_with
        super(WebAppResourceCleanup, __self__).__init__(
            'dynatrace:index/webAppResourceCleanup:WebAppResourceCleanup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            name: Optional[pulumi.Input[str]] = None,
            regular_expression: Optional[pulumi.Input[str]] = None,
            replace_with: Optional[pulumi.Input[str]] = None) -> 'WebAppResourceCleanup':
        """
        Get an existing WebAppResourceCleanup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: For example: *Mask journeyId*
        :param pulumi.Input[str] regular_expression: For example: `(.*)(journeyId=)-?\\d+(.*)`
        :param pulumi.Input[str] replace_with: For example: `$1$2\\*$3`
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _WebAppResourceCleanupState.__new__(_WebAppResourceCleanupState)

        __props__.__dict__["name"] = name
        __props__.__dict__["regular_expression"] = regular_expression
        __props__.__dict__["replace_with"] = replace_with
        return WebAppResourceCleanup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        For example: *Mask journeyId*
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="regularExpression")
    def regular_expression(self) -> pulumi.Output[str]:
        """
        For example: `(.*)(journeyId=)-?\\d+(.*)`
        """
        return pulumi.get(self, "regular_expression")

    @property
    @pulumi.getter(name="replaceWith")
    def replace_with(self) -> pulumi.Output[str]:
        """
        For example: `$1$2\\*$3`
        """
        return pulumi.get(self, "replace_with")
