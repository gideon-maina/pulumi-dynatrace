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

__all__ = ['ServiceAnomaliesArgs', 'ServiceAnomalies']

@pulumi.input_type
class ServiceAnomaliesArgs:
    def __init__(__self__, *,
                 failure_rates: Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']] = None,
                 load: Optional[pulumi.Input['ServiceAnomaliesLoadArgs']] = None,
                 load_drops: Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']] = None,
                 response_times: Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']] = None):
        """
        The set of arguments for constructing a ServiceAnomalies resource.
        :param pulumi.Input['ServiceAnomaliesFailureRatesArgs'] failure_rates: Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesLoadArgs'] load: The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesLoadDropsArgs'] load_drops: The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesResponseTimesArgs'] response_times: Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        if failure_rates is not None:
            pulumi.set(__self__, "failure_rates", failure_rates)
        if load is not None:
            pulumi.set(__self__, "load", load)
        if load_drops is not None:
            pulumi.set(__self__, "load_drops", load_drops)
        if response_times is not None:
            pulumi.set(__self__, "response_times", response_times)

    @property
    @pulumi.getter(name="failureRates")
    def failure_rates(self) -> Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']]:
        """
        Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        """
        return pulumi.get(self, "failure_rates")

    @failure_rates.setter
    def failure_rates(self, value: Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']]):
        pulumi.set(self, "failure_rates", value)

    @property
    @pulumi.getter
    def load(self) -> Optional[pulumi.Input['ServiceAnomaliesLoadArgs']]:
        """
        The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load")

    @load.setter
    def load(self, value: Optional[pulumi.Input['ServiceAnomaliesLoadArgs']]):
        pulumi.set(self, "load", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']]:
        """
        The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']]):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="responseTimes")
    def response_times(self) -> Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']]:
        """
        Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        return pulumi.get(self, "response_times")

    @response_times.setter
    def response_times(self, value: Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']]):
        pulumi.set(self, "response_times", value)


@pulumi.input_type
class _ServiceAnomaliesState:
    def __init__(__self__, *,
                 failure_rates: Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']] = None,
                 load: Optional[pulumi.Input['ServiceAnomaliesLoadArgs']] = None,
                 load_drops: Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']] = None,
                 response_times: Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']] = None):
        """
        Input properties used for looking up and filtering ServiceAnomalies resources.
        :param pulumi.Input['ServiceAnomaliesFailureRatesArgs'] failure_rates: Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesLoadArgs'] load: The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesLoadDropsArgs'] load_drops: The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        :param pulumi.Input['ServiceAnomaliesResponseTimesArgs'] response_times: Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        if failure_rates is not None:
            pulumi.set(__self__, "failure_rates", failure_rates)
        if load is not None:
            pulumi.set(__self__, "load", load)
        if load_drops is not None:
            pulumi.set(__self__, "load_drops", load_drops)
        if response_times is not None:
            pulumi.set(__self__, "response_times", response_times)

    @property
    @pulumi.getter(name="failureRates")
    def failure_rates(self) -> Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']]:
        """
        Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        """
        return pulumi.get(self, "failure_rates")

    @failure_rates.setter
    def failure_rates(self, value: Optional[pulumi.Input['ServiceAnomaliesFailureRatesArgs']]):
        pulumi.set(self, "failure_rates", value)

    @property
    @pulumi.getter
    def load(self) -> Optional[pulumi.Input['ServiceAnomaliesLoadArgs']]:
        """
        The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load")

    @load.setter
    def load(self, value: Optional[pulumi.Input['ServiceAnomaliesLoadArgs']]):
        pulumi.set(self, "load", value)

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']]:
        """
        The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load_drops")

    @load_drops.setter
    def load_drops(self, value: Optional[pulumi.Input['ServiceAnomaliesLoadDropsArgs']]):
        pulumi.set(self, "load_drops", value)

    @property
    @pulumi.getter(name="responseTimes")
    def response_times(self) -> Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']]:
        """
        Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        return pulumi.get(self, "response_times")

    @response_times.setter
    def response_times(self, value: Optional[pulumi.Input['ServiceAnomaliesResponseTimesArgs']]):
        pulumi.set(self, "response_times", value)


class ServiceAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rates: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesFailureRatesArgs']]] = None,
                 load: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadDropsArgs']]] = None,
                 response_times: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesResponseTimesArgs']]] = None,
                 __props__=None):
        """
        Create a ServiceAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesFailureRatesArgs']] failure_rates: Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadArgs']] load: The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadDropsArgs']] load_drops: The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesResponseTimesArgs']] response_times: Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[ServiceAnomaliesArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ServiceAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ServiceAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ServiceAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 failure_rates: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesFailureRatesArgs']]] = None,
                 load: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadArgs']]] = None,
                 load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadDropsArgs']]] = None,
                 response_times: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesResponseTimesArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ServiceAnomaliesArgs.__new__(ServiceAnomaliesArgs)

            __props__.__dict__["failure_rates"] = failure_rates
            __props__.__dict__["load"] = load
            __props__.__dict__["load_drops"] = load_drops
            __props__.__dict__["response_times"] = response_times
        super(ServiceAnomalies, __self__).__init__(
            'dynatrace:index/serviceAnomalies:ServiceAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            failure_rates: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesFailureRatesArgs']]] = None,
            load: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadArgs']]] = None,
            load_drops: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadDropsArgs']]] = None,
            response_times: Optional[pulumi.Input[pulumi.InputType['ServiceAnomaliesResponseTimesArgs']]] = None) -> 'ServiceAnomalies':
        """
        Get an existing ServiceAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesFailureRatesArgs']] failure_rates: Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadArgs']] load: The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesLoadDropsArgs']] load_drops: The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        :param pulumi.Input[pulumi.InputType['ServiceAnomaliesResponseTimesArgs']] response_times: Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ServiceAnomaliesState.__new__(_ServiceAnomaliesState)

        __props__.__dict__["failure_rates"] = failure_rates
        __props__.__dict__["load"] = load
        __props__.__dict__["load_drops"] = load_drops
        __props__.__dict__["response_times"] = response_times
        return ServiceAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="failureRates")
    def failure_rates(self) -> pulumi.Output[Optional['outputs.ServiceAnomaliesFailureRates']]:
        """
        Configuration of failure rate increase detection. Detecting failure rate increases will be disabled if this block is omitted.
        """
        return pulumi.get(self, "failure_rates")

    @property
    @pulumi.getter
    def load(self) -> pulumi.Output[Optional['outputs.ServiceAnomaliesLoad']]:
        """
        The configuration of load spikes detection. Detecting load spikes will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load")

    @property
    @pulumi.getter(name="loadDrops")
    def load_drops(self) -> pulumi.Output[Optional['outputs.ServiceAnomaliesLoadDrops']]:
        """
        The configuration of load drops detection. Detecting load drops will be disabled if this block is omitted.
        """
        return pulumi.get(self, "load_drops")

    @property
    @pulumi.getter(name="responseTimes")
    def response_times(self) -> pulumi.Output[Optional['outputs.ServiceAnomaliesResponseTimes']]:
        """
        Configuration of response time degradation detection. Detecting response time degradation will be disabled if this block is omitted.
        """
        return pulumi.get(self, "response_times")
