# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetAwsIamExternalResult',
    'AwaitableGetAwsIamExternalResult',
    'get_aws_iam_external',
    'get_aws_iam_external_output',
]

@pulumi.output_type
class GetAwsIamExternalResult:
    """
    A collection of values returned by getAwsIamExternal.
    """
    def __init__(__self__, id=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")


class AwaitableGetAwsIamExternalResult(GetAwsIamExternalResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAwsIamExternalResult(
            id=self.id)


def get_aws_iam_external(opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAwsIamExternalResult:
    """
    The AWS IAM external data source allows the AWS IAM external ID to be retrieved.
    """
    __args__ = dict()
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getAwsIamExternal:getAwsIamExternal', __args__, opts=opts, typ=GetAwsIamExternalResult).value

    return AwaitableGetAwsIamExternalResult(
        id=pulumi.get(__ret__, 'id'))


@_utilities.lift_output_func(get_aws_iam_external)
def get_aws_iam_external_output(opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAwsIamExternalResult]:
    """
    The AWS IAM external data source allows the AWS IAM external ID to be retrieved.
    """
    ...