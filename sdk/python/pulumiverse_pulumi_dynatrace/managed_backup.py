# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ManagedBackupArgs', 'ManagedBackup']

@pulumi.input_type
class ManagedBackupArgs:
    def __init__(__self__, *,
                 cassandra_scheduled_time: pulumi.Input[int],
                 bandwidth_limit_mbits: Optional[pulumi.Input[int]] = None,
                 current_state: Optional[pulumi.Input[str]] = None,
                 datacenter: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 include_lm20_data: Optional[pulumi.Input[bool]] = None,
                 include_rum_data: Optional[pulumi.Input[bool]] = None,
                 include_ts_metric_data: Optional[pulumi.Input[bool]] = None,
                 max_es_snapshots_to_clean: Optional[pulumi.Input[int]] = None,
                 pause_backups: Optional[pulumi.Input[bool]] = None,
                 storage_path: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ManagedBackup resource.
        :param pulumi.Input[int] cassandra_scheduled_time: Hour to start Cassandra backups each day.
        :param pulumi.Input[int] bandwidth_limit_mbits: Cassandra backup bandwidth limit in Mbps
        :param pulumi.Input[str] current_state: For internal use: current state of rules in JSON format
        :param pulumi.Input[str] datacenter: Datacenter which will create backups
        :param pulumi.Input[bool] enabled: Backups are enabled (true) or disabled (false).
        :param pulumi.Input[bool] include_lm20_data: Include (true) or exclude (false) Log Monitoring v2 data
        :param pulumi.Input[bool] include_rum_data: Include user sessions (true) or GDPR compliance (false)
        :param pulumi.Input[bool] include_ts_metric_data: Include time series metric-data (true) or retain configuration data only (false))
        :param pulumi.Input[int] max_es_snapshots_to_clean: Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        :param pulumi.Input[bool] pause_backups: Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        :param pulumi.Input[str] storage_path: A full path to the backup archive
        """
        pulumi.set(__self__, "cassandra_scheduled_time", cassandra_scheduled_time)
        if bandwidth_limit_mbits is not None:
            pulumi.set(__self__, "bandwidth_limit_mbits", bandwidth_limit_mbits)
        if current_state is not None:
            pulumi.set(__self__, "current_state", current_state)
        if datacenter is not None:
            pulumi.set(__self__, "datacenter", datacenter)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if include_lm20_data is not None:
            pulumi.set(__self__, "include_lm20_data", include_lm20_data)
        if include_rum_data is not None:
            pulumi.set(__self__, "include_rum_data", include_rum_data)
        if include_ts_metric_data is not None:
            pulumi.set(__self__, "include_ts_metric_data", include_ts_metric_data)
        if max_es_snapshots_to_clean is not None:
            pulumi.set(__self__, "max_es_snapshots_to_clean", max_es_snapshots_to_clean)
        if pause_backups is not None:
            pulumi.set(__self__, "pause_backups", pause_backups)
        if storage_path is not None:
            pulumi.set(__self__, "storage_path", storage_path)

    @property
    @pulumi.getter(name="cassandraScheduledTime")
    def cassandra_scheduled_time(self) -> pulumi.Input[int]:
        """
        Hour to start Cassandra backups each day.
        """
        return pulumi.get(self, "cassandra_scheduled_time")

    @cassandra_scheduled_time.setter
    def cassandra_scheduled_time(self, value: pulumi.Input[int]):
        pulumi.set(self, "cassandra_scheduled_time", value)

    @property
    @pulumi.getter(name="bandwidthLimitMbits")
    def bandwidth_limit_mbits(self) -> Optional[pulumi.Input[int]]:
        """
        Cassandra backup bandwidth limit in Mbps
        """
        return pulumi.get(self, "bandwidth_limit_mbits")

    @bandwidth_limit_mbits.setter
    def bandwidth_limit_mbits(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "bandwidth_limit_mbits", value)

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> Optional[pulumi.Input[str]]:
        """
        For internal use: current state of rules in JSON format
        """
        return pulumi.get(self, "current_state")

    @current_state.setter
    def current_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "current_state", value)

    @property
    @pulumi.getter
    def datacenter(self) -> Optional[pulumi.Input[str]]:
        """
        Datacenter which will create backups
        """
        return pulumi.get(self, "datacenter")

    @datacenter.setter
    def datacenter(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "datacenter", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Backups are enabled (true) or disabled (false).
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="includeLm20Data")
    def include_lm20_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include (true) or exclude (false) Log Monitoring v2 data
        """
        return pulumi.get(self, "include_lm20_data")

    @include_lm20_data.setter
    def include_lm20_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_lm20_data", value)

    @property
    @pulumi.getter(name="includeRumData")
    def include_rum_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include user sessions (true) or GDPR compliance (false)
        """
        return pulumi.get(self, "include_rum_data")

    @include_rum_data.setter
    def include_rum_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_rum_data", value)

    @property
    @pulumi.getter(name="includeTsMetricData")
    def include_ts_metric_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include time series metric-data (true) or retain configuration data only (false))
        """
        return pulumi.get(self, "include_ts_metric_data")

    @include_ts_metric_data.setter
    def include_ts_metric_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_ts_metric_data", value)

    @property
    @pulumi.getter(name="maxEsSnapshotsToClean")
    def max_es_snapshots_to_clean(self) -> Optional[pulumi.Input[int]]:
        """
        Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        """
        return pulumi.get(self, "max_es_snapshots_to_clean")

    @max_es_snapshots_to_clean.setter
    def max_es_snapshots_to_clean(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_es_snapshots_to_clean", value)

    @property
    @pulumi.getter(name="pauseBackups")
    def pause_backups(self) -> Optional[pulumi.Input[bool]]:
        """
        Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        """
        return pulumi.get(self, "pause_backups")

    @pause_backups.setter
    def pause_backups(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "pause_backups", value)

    @property
    @pulumi.getter(name="storagePath")
    def storage_path(self) -> Optional[pulumi.Input[str]]:
        """
        A full path to the backup archive
        """
        return pulumi.get(self, "storage_path")

    @storage_path.setter
    def storage_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_path", value)


@pulumi.input_type
class _ManagedBackupState:
    def __init__(__self__, *,
                 bandwidth_limit_mbits: Optional[pulumi.Input[int]] = None,
                 cassandra_scheduled_time: Optional[pulumi.Input[int]] = None,
                 current_state: Optional[pulumi.Input[str]] = None,
                 datacenter: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 include_lm20_data: Optional[pulumi.Input[bool]] = None,
                 include_rum_data: Optional[pulumi.Input[bool]] = None,
                 include_ts_metric_data: Optional[pulumi.Input[bool]] = None,
                 max_es_snapshots_to_clean: Optional[pulumi.Input[int]] = None,
                 pause_backups: Optional[pulumi.Input[bool]] = None,
                 storage_path: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ManagedBackup resources.
        :param pulumi.Input[int] bandwidth_limit_mbits: Cassandra backup bandwidth limit in Mbps
        :param pulumi.Input[int] cassandra_scheduled_time: Hour to start Cassandra backups each day.
        :param pulumi.Input[str] current_state: For internal use: current state of rules in JSON format
        :param pulumi.Input[str] datacenter: Datacenter which will create backups
        :param pulumi.Input[bool] enabled: Backups are enabled (true) or disabled (false).
        :param pulumi.Input[bool] include_lm20_data: Include (true) or exclude (false) Log Monitoring v2 data
        :param pulumi.Input[bool] include_rum_data: Include user sessions (true) or GDPR compliance (false)
        :param pulumi.Input[bool] include_ts_metric_data: Include time series metric-data (true) or retain configuration data only (false))
        :param pulumi.Input[int] max_es_snapshots_to_clean: Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        :param pulumi.Input[bool] pause_backups: Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        :param pulumi.Input[str] storage_path: A full path to the backup archive
        """
        if bandwidth_limit_mbits is not None:
            pulumi.set(__self__, "bandwidth_limit_mbits", bandwidth_limit_mbits)
        if cassandra_scheduled_time is not None:
            pulumi.set(__self__, "cassandra_scheduled_time", cassandra_scheduled_time)
        if current_state is not None:
            pulumi.set(__self__, "current_state", current_state)
        if datacenter is not None:
            pulumi.set(__self__, "datacenter", datacenter)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if include_lm20_data is not None:
            pulumi.set(__self__, "include_lm20_data", include_lm20_data)
        if include_rum_data is not None:
            pulumi.set(__self__, "include_rum_data", include_rum_data)
        if include_ts_metric_data is not None:
            pulumi.set(__self__, "include_ts_metric_data", include_ts_metric_data)
        if max_es_snapshots_to_clean is not None:
            pulumi.set(__self__, "max_es_snapshots_to_clean", max_es_snapshots_to_clean)
        if pause_backups is not None:
            pulumi.set(__self__, "pause_backups", pause_backups)
        if storage_path is not None:
            pulumi.set(__self__, "storage_path", storage_path)

    @property
    @pulumi.getter(name="bandwidthLimitMbits")
    def bandwidth_limit_mbits(self) -> Optional[pulumi.Input[int]]:
        """
        Cassandra backup bandwidth limit in Mbps
        """
        return pulumi.get(self, "bandwidth_limit_mbits")

    @bandwidth_limit_mbits.setter
    def bandwidth_limit_mbits(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "bandwidth_limit_mbits", value)

    @property
    @pulumi.getter(name="cassandraScheduledTime")
    def cassandra_scheduled_time(self) -> Optional[pulumi.Input[int]]:
        """
        Hour to start Cassandra backups each day.
        """
        return pulumi.get(self, "cassandra_scheduled_time")

    @cassandra_scheduled_time.setter
    def cassandra_scheduled_time(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "cassandra_scheduled_time", value)

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> Optional[pulumi.Input[str]]:
        """
        For internal use: current state of rules in JSON format
        """
        return pulumi.get(self, "current_state")

    @current_state.setter
    def current_state(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "current_state", value)

    @property
    @pulumi.getter
    def datacenter(self) -> Optional[pulumi.Input[str]]:
        """
        Datacenter which will create backups
        """
        return pulumi.get(self, "datacenter")

    @datacenter.setter
    def datacenter(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "datacenter", value)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[pulumi.Input[bool]]:
        """
        Backups are enabled (true) or disabled (false).
        """
        return pulumi.get(self, "enabled")

    @enabled.setter
    def enabled(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enabled", value)

    @property
    @pulumi.getter(name="includeLm20Data")
    def include_lm20_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include (true) or exclude (false) Log Monitoring v2 data
        """
        return pulumi.get(self, "include_lm20_data")

    @include_lm20_data.setter
    def include_lm20_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_lm20_data", value)

    @property
    @pulumi.getter(name="includeRumData")
    def include_rum_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include user sessions (true) or GDPR compliance (false)
        """
        return pulumi.get(self, "include_rum_data")

    @include_rum_data.setter
    def include_rum_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_rum_data", value)

    @property
    @pulumi.getter(name="includeTsMetricData")
    def include_ts_metric_data(self) -> Optional[pulumi.Input[bool]]:
        """
        Include time series metric-data (true) or retain configuration data only (false))
        """
        return pulumi.get(self, "include_ts_metric_data")

    @include_ts_metric_data.setter
    def include_ts_metric_data(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_ts_metric_data", value)

    @property
    @pulumi.getter(name="maxEsSnapshotsToClean")
    def max_es_snapshots_to_clean(self) -> Optional[pulumi.Input[int]]:
        """
        Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        """
        return pulumi.get(self, "max_es_snapshots_to_clean")

    @max_es_snapshots_to_clean.setter
    def max_es_snapshots_to_clean(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_es_snapshots_to_clean", value)

    @property
    @pulumi.getter(name="pauseBackups")
    def pause_backups(self) -> Optional[pulumi.Input[bool]]:
        """
        Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        """
        return pulumi.get(self, "pause_backups")

    @pause_backups.setter
    def pause_backups(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "pause_backups", value)

    @property
    @pulumi.getter(name="storagePath")
    def storage_path(self) -> Optional[pulumi.Input[str]]:
        """
        A full path to the backup archive
        """
        return pulumi.get(self, "storage_path")

    @storage_path.setter
    def storage_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_path", value)


class ManagedBackup(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth_limit_mbits: Optional[pulumi.Input[int]] = None,
                 cassandra_scheduled_time: Optional[pulumi.Input[int]] = None,
                 current_state: Optional[pulumi.Input[str]] = None,
                 datacenter: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 include_lm20_data: Optional[pulumi.Input[bool]] = None,
                 include_rum_data: Optional[pulumi.Input[bool]] = None,
                 include_ts_metric_data: Optional[pulumi.Input[bool]] = None,
                 max_es_snapshots_to_clean: Optional[pulumi.Input[int]] = None,
                 pause_backups: Optional[pulumi.Input[bool]] = None,
                 storage_path: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ManagedBackup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth_limit_mbits: Cassandra backup bandwidth limit in Mbps
        :param pulumi.Input[int] cassandra_scheduled_time: Hour to start Cassandra backups each day.
        :param pulumi.Input[str] current_state: For internal use: current state of rules in JSON format
        :param pulumi.Input[str] datacenter: Datacenter which will create backups
        :param pulumi.Input[bool] enabled: Backups are enabled (true) or disabled (false).
        :param pulumi.Input[bool] include_lm20_data: Include (true) or exclude (false) Log Monitoring v2 data
        :param pulumi.Input[bool] include_rum_data: Include user sessions (true) or GDPR compliance (false)
        :param pulumi.Input[bool] include_ts_metric_data: Include time series metric-data (true) or retain configuration data only (false))
        :param pulumi.Input[int] max_es_snapshots_to_clean: Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        :param pulumi.Input[bool] pause_backups: Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        :param pulumi.Input[str] storage_path: A full path to the backup archive
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ManagedBackupArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ManagedBackup resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ManagedBackupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ManagedBackupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bandwidth_limit_mbits: Optional[pulumi.Input[int]] = None,
                 cassandra_scheduled_time: Optional[pulumi.Input[int]] = None,
                 current_state: Optional[pulumi.Input[str]] = None,
                 datacenter: Optional[pulumi.Input[str]] = None,
                 enabled: Optional[pulumi.Input[bool]] = None,
                 include_lm20_data: Optional[pulumi.Input[bool]] = None,
                 include_rum_data: Optional[pulumi.Input[bool]] = None,
                 include_ts_metric_data: Optional[pulumi.Input[bool]] = None,
                 max_es_snapshots_to_clean: Optional[pulumi.Input[int]] = None,
                 pause_backups: Optional[pulumi.Input[bool]] = None,
                 storage_path: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ManagedBackupArgs.__new__(ManagedBackupArgs)

            __props__.__dict__["bandwidth_limit_mbits"] = bandwidth_limit_mbits
            if cassandra_scheduled_time is None and not opts.urn:
                raise TypeError("Missing required property 'cassandra_scheduled_time'")
            __props__.__dict__["cassandra_scheduled_time"] = cassandra_scheduled_time
            __props__.__dict__["current_state"] = current_state
            __props__.__dict__["datacenter"] = datacenter
            __props__.__dict__["enabled"] = enabled
            __props__.__dict__["include_lm20_data"] = include_lm20_data
            __props__.__dict__["include_rum_data"] = include_rum_data
            __props__.__dict__["include_ts_metric_data"] = include_ts_metric_data
            __props__.__dict__["max_es_snapshots_to_clean"] = max_es_snapshots_to_clean
            __props__.__dict__["pause_backups"] = pause_backups
            __props__.__dict__["storage_path"] = storage_path
        super(ManagedBackup, __self__).__init__(
            'dynatrace:index/managedBackup:ManagedBackup',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            bandwidth_limit_mbits: Optional[pulumi.Input[int]] = None,
            cassandra_scheduled_time: Optional[pulumi.Input[int]] = None,
            current_state: Optional[pulumi.Input[str]] = None,
            datacenter: Optional[pulumi.Input[str]] = None,
            enabled: Optional[pulumi.Input[bool]] = None,
            include_lm20_data: Optional[pulumi.Input[bool]] = None,
            include_rum_data: Optional[pulumi.Input[bool]] = None,
            include_ts_metric_data: Optional[pulumi.Input[bool]] = None,
            max_es_snapshots_to_clean: Optional[pulumi.Input[int]] = None,
            pause_backups: Optional[pulumi.Input[bool]] = None,
            storage_path: Optional[pulumi.Input[str]] = None) -> 'ManagedBackup':
        """
        Get an existing ManagedBackup resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] bandwidth_limit_mbits: Cassandra backup bandwidth limit in Mbps
        :param pulumi.Input[int] cassandra_scheduled_time: Hour to start Cassandra backups each day.
        :param pulumi.Input[str] current_state: For internal use: current state of rules in JSON format
        :param pulumi.Input[str] datacenter: Datacenter which will create backups
        :param pulumi.Input[bool] enabled: Backups are enabled (true) or disabled (false).
        :param pulumi.Input[bool] include_lm20_data: Include (true) or exclude (false) Log Monitoring v2 data
        :param pulumi.Input[bool] include_rum_data: Include user sessions (true) or GDPR compliance (false)
        :param pulumi.Input[bool] include_ts_metric_data: Include time series metric-data (true) or retain configuration data only (false))
        :param pulumi.Input[int] max_es_snapshots_to_clean: Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        :param pulumi.Input[bool] pause_backups: Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        :param pulumi.Input[str] storage_path: A full path to the backup archive
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ManagedBackupState.__new__(_ManagedBackupState)

        __props__.__dict__["bandwidth_limit_mbits"] = bandwidth_limit_mbits
        __props__.__dict__["cassandra_scheduled_time"] = cassandra_scheduled_time
        __props__.__dict__["current_state"] = current_state
        __props__.__dict__["datacenter"] = datacenter
        __props__.__dict__["enabled"] = enabled
        __props__.__dict__["include_lm20_data"] = include_lm20_data
        __props__.__dict__["include_rum_data"] = include_rum_data
        __props__.__dict__["include_ts_metric_data"] = include_ts_metric_data
        __props__.__dict__["max_es_snapshots_to_clean"] = max_es_snapshots_to_clean
        __props__.__dict__["pause_backups"] = pause_backups
        __props__.__dict__["storage_path"] = storage_path
        return ManagedBackup(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="bandwidthLimitMbits")
    def bandwidth_limit_mbits(self) -> pulumi.Output[Optional[int]]:
        """
        Cassandra backup bandwidth limit in Mbps
        """
        return pulumi.get(self, "bandwidth_limit_mbits")

    @property
    @pulumi.getter(name="cassandraScheduledTime")
    def cassandra_scheduled_time(self) -> pulumi.Output[int]:
        """
        Hour to start Cassandra backups each day.
        """
        return pulumi.get(self, "cassandra_scheduled_time")

    @property
    @pulumi.getter(name="currentState")
    def current_state(self) -> pulumi.Output[str]:
        """
        For internal use: current state of rules in JSON format
        """
        return pulumi.get(self, "current_state")

    @property
    @pulumi.getter
    def datacenter(self) -> pulumi.Output[Optional[str]]:
        """
        Datacenter which will create backups
        """
        return pulumi.get(self, "datacenter")

    @property
    @pulumi.getter
    def enabled(self) -> pulumi.Output[Optional[bool]]:
        """
        Backups are enabled (true) or disabled (false).
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="includeLm20Data")
    def include_lm20_data(self) -> pulumi.Output[Optional[bool]]:
        """
        Include (true) or exclude (false) Log Monitoring v2 data
        """
        return pulumi.get(self, "include_lm20_data")

    @property
    @pulumi.getter(name="includeRumData")
    def include_rum_data(self) -> pulumi.Output[Optional[bool]]:
        """
        Include user sessions (true) or GDPR compliance (false)
        """
        return pulumi.get(self, "include_rum_data")

    @property
    @pulumi.getter(name="includeTsMetricData")
    def include_ts_metric_data(self) -> pulumi.Output[Optional[bool]]:
        """
        Include time series metric-data (true) or retain configuration data only (false))
        """
        return pulumi.get(self, "include_ts_metric_data")

    @property
    @pulumi.getter(name="maxEsSnapshotsToClean")
    def max_es_snapshots_to_clean(self) -> pulumi.Output[Optional[int]]:
        """
        Max number of Elasticsearch snapshots to clean. Elasticsearch snapshots won't be created anymore if there will be more backups to clean than this value.
        """
        return pulumi.get(self, "max_es_snapshots_to_clean")

    @property
    @pulumi.getter(name="pauseBackups")
    def pause_backups(self) -> pulumi.Output[Optional[bool]]:
        """
        Pauses Elasticsearch and Cassandra backups. In comparison to enable/disable backup, this option does not modify any configuration like Elasticsearch properties.
        """
        return pulumi.get(self, "pause_backups")

    @property
    @pulumi.getter(name="storagePath")
    def storage_path(self) -> pulumi.Output[Optional[str]]:
        """
        A full path to the backup archive
        """
        return pulumi.get(self, "storage_path")
