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

__all__ = [
    'GetAlertingProfilesResult',
    'AwaitableGetAlertingProfilesResult',
    'get_alerting_profiles',
    'get_alerting_profiles_output',
]

@pulumi.output_type
class GetAlertingProfilesResult:
    """
    A collection of values returned by getAlertingProfiles.
    """
    def __init__(__self__, id=None, profiles=None, values=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if profiles and not isinstance(profiles, dict):
            raise TypeError("Expected argument 'profiles' to be a dict")
        pulumi.set(__self__, "profiles", profiles)
        if values and not isinstance(values, list):
            raise TypeError("Expected argument 'values' to be a list")
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def profiles(self) -> Optional[Mapping[str, str]]:
        return pulumi.get(self, "profiles")

    @property
    @pulumi.getter
    def values(self) -> Sequence['outputs.GetAlertingProfilesValueResult']:
        return pulumi.get(self, "values")


class AwaitableGetAlertingProfilesResult(GetAlertingProfilesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetAlertingProfilesResult(
            id=self.id,
            profiles=self.profiles,
            values=self.values)


def get_alerting_profiles(profiles: Optional[Mapping[str, str]] = None,
                          opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetAlertingProfilesResult:
    """
    The alerting profiles data source allows retrieval of all alerting profiles.
    """
    __args__ = dict()
    __args__['profiles'] = profiles
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('dynatrace:index/getAlertingProfiles:getAlertingProfiles', __args__, opts=opts, typ=GetAlertingProfilesResult).value

    return AwaitableGetAlertingProfilesResult(
        id=pulumi.get(__ret__, 'id'),
        profiles=pulumi.get(__ret__, 'profiles'),
        values=pulumi.get(__ret__, 'values'))


@_utilities.lift_output_func(get_alerting_profiles)
def get_alerting_profiles_output(profiles: Optional[pulumi.Input[Optional[Mapping[str, str]]]] = None,
                                 opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetAlertingProfilesResult]:
    """
    The alerting profiles data source allows retrieval of all alerting profiles.
    """
    ...