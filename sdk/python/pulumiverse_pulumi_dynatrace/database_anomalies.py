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

__all__ = ['DatabaseAnomaliesArgs', 'DatabaseAnomalies']

@pulumi.input_type
class DatabaseAnomaliesArgs:
    def __init__(__self__, *,
                 db_connect_failures: Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']] = None,
                 failure_rate: Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']] = None,
                 load: Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']] = None,
                 response_time: Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']] = None):
        """
        The set of arguments for constructing a DatabaseAnomalies resource.
        :param pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs'] db_connect_failures: Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        :param pulumi.Input['DatabaseAnomaliesFailureRateArgs'] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input['DatabaseAnomaliesLoadArgs'] load: Configuration for anomalies regarding load drops and spikes
        :param pulumi.Input['DatabaseAnomaliesResponseTimeArgs'] response_time: Configuration of response time degradation detection
        """
        if db_connect_failures is not None:
            pulumi.set(__self__, "db_connect_failures", db_connect_failures)
        if failure_rate is not None:
            pulumi.set(__self__, "failure_rate", failure_rate)
        if load is not None:
            pulumi.set(__self__, "load", load)
        if response_time is not None:
            pulumi.set(__self__, "response_time", response_time)

    @property
    @pulumi.getter(name="dbConnectFailures")
    def db_connect_failures(self) -> Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']]:
        """
        Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        """
        return pulumi.get(self, "db_connect_failures")

    @db_connect_failures.setter
    def db_connect_failures(self, value: Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']]):
        pulumi.set(self, "db_connect_failures", value)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter
    def load(self) -> Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']]:
        """
        Configuration for anomalies regarding load drops and spikes
        """
        return pulumi.get(self, "load")

    @load.setter
    def load(self, value: Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']]):
        pulumi.set(self, "load", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)


@pulumi.input_type
class _DatabaseAnomaliesState:
    def __init__(__self__, *,
                 db_connect_failures: Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']] = None,
                 failure_rate: Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']] = None,
                 load: Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']] = None,
                 response_time: Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']] = None):
        """
        Input properties used for looking up and filtering DatabaseAnomalies resources.
        :param pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs'] db_connect_failures: Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        :param pulumi.Input['DatabaseAnomaliesFailureRateArgs'] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input['DatabaseAnomaliesLoadArgs'] load: Configuration for anomalies regarding load drops and spikes
        :param pulumi.Input['DatabaseAnomaliesResponseTimeArgs'] response_time: Configuration of response time degradation detection
        """
        if db_connect_failures is not None:
            pulumi.set(__self__, "db_connect_failures", db_connect_failures)
        if failure_rate is not None:
            pulumi.set(__self__, "failure_rate", failure_rate)
        if load is not None:
            pulumi.set(__self__, "load", load)
        if response_time is not None:
            pulumi.set(__self__, "response_time", response_time)

    @property
    @pulumi.getter(name="dbConnectFailures")
    def db_connect_failures(self) -> Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']]:
        """
        Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        """
        return pulumi.get(self, "db_connect_failures")

    @db_connect_failures.setter
    def db_connect_failures(self, value: Optional[pulumi.Input['DatabaseAnomaliesDbConnectFailuresArgs']]):
        pulumi.set(self, "db_connect_failures", value)

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @failure_rate.setter
    def failure_rate(self, value: Optional[pulumi.Input['DatabaseAnomaliesFailureRateArgs']]):
        pulumi.set(self, "failure_rate", value)

    @property
    @pulumi.getter
    def load(self) -> Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']]:
        """
        Configuration for anomalies regarding load drops and spikes
        """
        return pulumi.get(self, "load")

    @load.setter
    def load(self, value: Optional[pulumi.Input['DatabaseAnomaliesLoadArgs']]):
        pulumi.set(self, "load", value)

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")

    @response_time.setter
    def response_time(self, value: Optional[pulumi.Input['DatabaseAnomaliesResponseTimeArgs']]):
        pulumi.set(self, "response_time", value)


class DatabaseAnomalies(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 db_connect_failures: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesDbConnectFailuresArgs']]] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesFailureRateArgs']]] = None,
                 load: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesLoadArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesResponseTimeArgs']]] = None,
                 __props__=None):
        """
        Create a DatabaseAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesDbConnectFailuresArgs']] db_connect_failures: Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesFailureRateArgs']] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesLoadArgs']] load: Configuration for anomalies regarding load drops and spikes
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesResponseTimeArgs']] response_time: Configuration of response time degradation detection
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[DatabaseAnomaliesArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DatabaseAnomalies resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DatabaseAnomaliesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DatabaseAnomaliesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 db_connect_failures: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesDbConnectFailuresArgs']]] = None,
                 failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesFailureRateArgs']]] = None,
                 load: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesLoadArgs']]] = None,
                 response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesResponseTimeArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DatabaseAnomaliesArgs.__new__(DatabaseAnomaliesArgs)

            __props__.__dict__["db_connect_failures"] = db_connect_failures
            __props__.__dict__["failure_rate"] = failure_rate
            __props__.__dict__["load"] = load
            __props__.__dict__["response_time"] = response_time
        super(DatabaseAnomalies, __self__).__init__(
            'dynatrace:index/databaseAnomalies:DatabaseAnomalies',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            db_connect_failures: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesDbConnectFailuresArgs']]] = None,
            failure_rate: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesFailureRateArgs']]] = None,
            load: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesLoadArgs']]] = None,
            response_time: Optional[pulumi.Input[pulumi.InputType['DatabaseAnomaliesResponseTimeArgs']]] = None) -> 'DatabaseAnomalies':
        """
        Get an existing DatabaseAnomalies resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesDbConnectFailuresArgs']] db_connect_failures: Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesFailureRateArgs']] failure_rate: Configuration of failure rate increase detection
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesLoadArgs']] load: Configuration for anomalies regarding load drops and spikes
        :param pulumi.Input[pulumi.InputType['DatabaseAnomaliesResponseTimeArgs']] response_time: Configuration of response time degradation detection
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DatabaseAnomaliesState.__new__(_DatabaseAnomaliesState)

        __props__.__dict__["db_connect_failures"] = db_connect_failures
        __props__.__dict__["failure_rate"] = failure_rate
        __props__.__dict__["load"] = load
        __props__.__dict__["response_time"] = response_time
        return DatabaseAnomalies(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="dbConnectFailures")
    def db_connect_failures(self) -> pulumi.Output[Optional['outputs.DatabaseAnomaliesDbConnectFailures']]:
        """
        Parameters of the failed database connections detection.  The alert is triggered when failed connections number exceeds **connectionFailsCount** during any **timePeriodMinutes** minutes period
        """
        return pulumi.get(self, "db_connect_failures")

    @property
    @pulumi.getter(name="failureRate")
    def failure_rate(self) -> pulumi.Output[Optional['outputs.DatabaseAnomaliesFailureRate']]:
        """
        Configuration of failure rate increase detection
        """
        return pulumi.get(self, "failure_rate")

    @property
    @pulumi.getter
    def load(self) -> pulumi.Output[Optional['outputs.DatabaseAnomaliesLoad']]:
        """
        Configuration for anomalies regarding load drops and spikes
        """
        return pulumi.get(self, "load")

    @property
    @pulumi.getter(name="responseTime")
    def response_time(self) -> pulumi.Output[Optional['outputs.DatabaseAnomaliesResponseTime']]:
        """
        Configuration of response time degradation detection
        """
        return pulumi.get(self, "response_time")
