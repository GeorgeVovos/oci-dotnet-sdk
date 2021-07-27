/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DatabaseService.Models
{
    /// <summary>
    /// An Oracle Autonomous Database.
    /// 
    /// </summary>
    public class AutonomousDatabase 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Autonomous Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the compartment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
                ///
        /// <value>
        /// The current state of the Autonomous Database.
        /// </value>
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "STOPPING")]
            Stopping,
            [EnumMember(Value = "STOPPED")]
            Stopped,
            [EnumMember(Value = "STARTING")]
            Starting,
            [EnumMember(Value = "TERMINATING")]
            Terminating,
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            [EnumMember(Value = "UNAVAILABLE")]
            Unavailable,
            [EnumMember(Value = "RESTORE_IN_PROGRESS")]
            RestoreInProgress,
            [EnumMember(Value = "RESTORE_FAILED")]
            RestoreFailed,
            [EnumMember(Value = "BACKUP_IN_PROGRESS")]
            BackupInProgress,
            [EnumMember(Value = "SCALE_IN_PROGRESS")]
            ScaleInProgress,
            [EnumMember(Value = "AVAILABLE_NEEDS_ATTENTION")]
            AvailableNeedsAttention,
            [EnumMember(Value = "UPDATING")]
            Updating,
            [EnumMember(Value = "MAINTENANCE_IN_PROGRESS")]
            MaintenanceInProgress,
            [EnumMember(Value = "RESTARTING")]
            Restarting,
            [EnumMember(Value = "RECREATING")]
            Recreating,
            [EnumMember(Value = "ROLE_CHANGE_IN_PROGRESS")]
            RoleChangeInProgress,
            [EnumMember(Value = "UPGRADING")]
            Upgrading,
            [EnumMember(Value = "INACCESSIBLE")]
            Inaccessible
        };

        /// <value>
        /// The current state of the Autonomous Database.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Information about the current lifecycle state.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleDetails")]
        public string LifecycleDetails { get; set; }
        
        /// <value>
        /// The OCID of the key container that is used as the master encryption key in database transparent data encryption (TDE) operations.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the Oracle Cloud Infrastructure [vault](https://docs.cloud.oracle.com/Content/KeyManagement/Concepts/keyoverview.htm#concepts).
        /// </value>
        [JsonProperty(PropertyName = "vaultId")]
        public string VaultId { get; set; }
        
        /// <value>
        /// KMS key lifecycle details.
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyLifecycleDetails")]
        public string KmsKeyLifecycleDetails { get; set; }
        
        /// <value>
        /// The database name.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DbName is required.")]
        [JsonProperty(PropertyName = "dbName")]
        public string DbName { get; set; }
        
        /// <value>
        /// Indicates if this is an Always Free resource. The default value is false. Note that Always Free Autonomous Databases have 1 CPU and 20GB of memory. For Always Free databases, memory and CPU cannot be scaled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFreeTier")]
        public System.Nullable<bool> IsFreeTier { get; set; }
        
        /// <value>
        /// System tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
        /// <value>
        /// The date and time the Always Free database will be stopped because of inactivity. If this time is reached without any database activity, the database will automatically be put into the STOPPED state.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeReclamationOfFreeAutonomousDatabase")]
        public System.Nullable<System.DateTime> TimeReclamationOfFreeAutonomousDatabase { get; set; }
        
        /// <value>
        /// The date and time the Always Free database will be automatically deleted because of inactivity. If the database is in the STOPPED state and without activity until this time, it will be deleted.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeDeletionOfFreeAutonomousDatabase")]
        public System.Nullable<System.DateTime> TimeDeletionOfFreeAutonomousDatabase { get; set; }
        
        [JsonProperty(PropertyName = "backupConfig")]
        public AutonomousDatabaseBackupConfig BackupConfig { get; set; }
        
        /// <value>
        /// Key History Entry.
        /// </value>
        [JsonProperty(PropertyName = "keyHistoryEntry")]
        public System.Collections.Generic.List<AutonomousDatabaseKeyHistoryEntry> KeyHistoryEntry { get; set; }
        
        /// <value>
        /// The number of OCPU cores to be made available to the database. For Autonomous Databases on dedicated Exadata infrastructure, the maximum number of cores is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details. 
        /// <br/>
        /// **Note:** This parameter cannot be used with the `ocpuCount` parameter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CpuCoreCount is required.")]
        [JsonProperty(PropertyName = "cpuCoreCount")]
        public System.Nullable<int> CpuCoreCount { get; set; }
        
        /// <value>
        /// The number of OCPU cores to be made available to the database. 
        /// <br/>
        /// The following points apply:
        /// - For Autonomous Databases on dedicated Exadata infrastructure, to provision less than 1 core, enter a fractional value in an increment of 0.1. For example, you can provision 0.3 or 0.4 cores, but not 0.35 cores. (Note that fractional OCPU values are not supported for Autonomous Databasese on shared Exadata infrastructure.)
        /// - To provision 1 or more cores, you must enter an integer between 1 and the maximum number of cores available for the infrastructure shape. For example, you can provision 2 cores or 3 cores, but not 2.5 cores. This applies to Autonomous Databases on both shared and dedicated Exadata infrastructure.
        /// <br/>
        /// For Autonomous Databases on dedicated Exadata infrastructure, the maximum number of cores is determined by the infrastructure shape. See [Characteristics of Infrastructure Shapes](https://www.oracle.com/pls/topic/lookup?ctx=en/cloud/paas/autonomous-database&id=ATPFG-GUID-B0F033C1-CC5A-42F0-B2E7-3CECFEDA1FD1) for shape details.
        /// <br/>
        /// **Note:** This parameter cannot be used with the `cpuCoreCount` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "ocpuCount")]
        public System.Nullable<float> OcpuCount { get; set; }
        
        /// <value>
        /// The quantity of data in the database, in terabytes.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DataStorageSizeInTBs is required.")]
        [JsonProperty(PropertyName = "dataStorageSizeInTBs")]
        public System.Nullable<int> DataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// The quantity of data in the database, in gigabytes.
        /// </value>
        [JsonProperty(PropertyName = "dataStorageSizeInGBs")]
        public System.Nullable<int> DataStorageSizeInGBs { get; set; }
                ///
        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        ///
        public enum InfrastructureTypeEnum {
            [EnumMember(Value = "CLOUD")]
            Cloud,
            [EnumMember(Value = "CLOUD_AT_CUSTOMER")]
            CloudAtCustomer
        };

        /// <value>
        /// The infrastructure type this resource belongs to.
        /// </value>
        [JsonProperty(PropertyName = "infrastructureType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InfrastructureTypeEnum> InfrastructureType { get; set; }
        
        /// <value>
        /// True if the database uses [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDedicated")]
        public System.Nullable<bool> IsDedicated { get; set; }
        
        /// <value>
        /// The Autonomous Container Database [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "autonomousContainerDatabaseId")]
        public string AutonomousContainerDatabaseId { get; set; }
        
        /// <value>
        /// The date and time the Autonomous Database was created.
        /// </value>
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
        /// <value>
        /// The user-friendly name for the Autonomous Database. The name does not have to be unique.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The URL of the Service Console for the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "serviceConsoleUrl")]
        public string ServiceConsoleUrl { get; set; }
        
        /// <value>
        /// The connection string used to connect to the Autonomous Database. The username for the Service Console is ADMIN. Use the password you entered when creating the Autonomous Database for the password value.
        /// </value>
        [JsonProperty(PropertyName = "connectionStrings")]
        public AutonomousDatabaseConnectionStrings ConnectionStrings { get; set; }
        
        [JsonProperty(PropertyName = "connectionUrls")]
        public AutonomousDatabaseConnectionUrls ConnectionUrls { get; set; }
                ///
        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
        /// 
        /// </value>
        ///
        public enum LicenseModelEnum {
            [EnumMember(Value = "LICENSE_INCLUDED")]
            LicenseIncluded,
            [EnumMember(Value = "BRING_YOUR_OWN_LICENSE")]
            BringYourOwnLicense
        };

        /// <value>
        /// The Oracle license model that applies to the Oracle Autonomous Database. Bring your own license (BYOL) allows you to apply your current on-premises Oracle software licenses to equivalent, highly automated Oracle PaaS and IaaS services in the cloud.
        /// License Included allows you to subscribe to new Oracle Database software licenses and the Database service.
        /// Note that when provisioning an Autonomous Database on [dedicated Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adbddoverview.htm), this attribute must be null because the attribute is already set at the
        /// Autonomous Exadata Infrastructure level. When using [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI), if a value is not specified, the system will supply the value of `BRING_YOUR_OWN_LICENSE`.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "licenseModel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LicenseModelEnum> LicenseModel { get; set; }
        
        /// <value>
        /// The amount of storage that has been used, in terabytes.
        /// </value>
        [JsonProperty(PropertyName = "usedDataStorageSizeInTBs")]
        public System.Nullable<int> UsedDataStorageSizeInTBs { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no predefined name, type, or namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// For more information, see [Resource Tags](https://docs.cloud.oracle.com/Content/General/Concepts/resourcetags.htm).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the subnet the resource is associated with.
        /// <br/>
        /// **Subnet Restrictions:**
        /// - For bare metal DB systems and for single node virtual machine DB systems, do not use a subnet that overlaps with 192.168.16.16/28.
        /// - For Exadata and virtual machine 2-node RAC systems, do not use a subnet that overlaps with 192.168.128.0/20.
        /// - For Autonomous Database, setting this will disable public secure access to the database.
        /// <br/>
        /// These subnets are used by the Oracle Clusterware private interconnect on the database instance.
        /// Specifying an overlapping subnet will cause the private interconnect to malfunction.
        /// This restriction applies to both the client subnet and the backup subnet.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "subnetId")]
        public string SubnetId { get; set; }
        
        /// <value>
        /// A list of the [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the network security groups (NSGs) that this resource belongs to. Setting this to an empty array after the list is created removes the resource from all NSGs. For more information about NSGs, see [Security Rules](https://docs.cloud.oracle.com/Content/Network/Concepts/securityrules.htm).
        /// **NsgIds restrictions:**
        /// - Autonomous Databases with private access require at least 1 Network Security Group (NSG). The nsgIds array cannot be empty.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "nsgIds")]
        public System.Collections.Generic.List<string> NsgIds { get; set; }
        
        /// <value>
        /// The private endpoint for the resource.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpoint")]
        public string PrivateEndpoint { get; set; }
        
        /// <value>
        /// The private endpoint label for the resource. Setting this to an empty string, after the private endpoint database gets created, will change the same private endpoint database to the public endpoint database.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointLabel")]
        public string PrivateEndpointLabel { get; set; }
        
        /// <value>
        /// The private endpoint Ip address for the resource.
        /// </value>
        [JsonProperty(PropertyName = "privateEndpointIp")]
        public string PrivateEndpointIp { get; set; }
        
        /// <value>
        /// A valid Oracle Database version for Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dbVersion")]
        public string DbVersion { get; set; }
        
        /// <value>
        /// Indicates if the Autonomous Database version is a preview version.
        /// </value>
        [JsonProperty(PropertyName = "isPreview")]
        public System.Nullable<bool> IsPreview { get; set; }
                ///
        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        ///
        public enum DbWorkloadEnum {
            [EnumMember(Value = "OLTP")]
            Oltp,
            [EnumMember(Value = "DW")]
            Dw,
            [EnumMember(Value = "AJD")]
            Ajd,
            [EnumMember(Value = "APEX")]
            Apex
        };

        /// <value>
        /// The Autonomous Database workload type. The following values are valid:
        /// <br/>
        /// - OLTP - indicates an Autonomous Transaction Processing database
        /// - DW - indicates an Autonomous Data Warehouse database
        /// - AJD - indicates an Autonomous JSON Database
        /// - APEX - indicates an Autonomous Database with the Oracle APEX Application Development workload type.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "dbWorkload")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DbWorkloadEnum> DbWorkload { get; set; }
        
        /// <value>
        /// Indicates if the database-level access control is enabled.
        /// If disabled, database access is defined by the network security rules.
        /// If enabled, database access is restricted to the IP addresses defined by the rules specified with the `whitelistedIps` property. While specifying `whitelistedIps` rules is optional,
        ///  if database-level access control is enabled and no rules are specified, the database will become inaccessible. The rules can be added later using the `UpdateAutonomousDatabase` API operation or edit option in console.
        /// When creating a database clone, the desired access control setting should be specified. By default, database-level access control will be disabled for the clone.
        /// <br/>
        /// This property is applicable only to Autonomous Databases on the Exadata Cloud@Customer platform.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAccessControlEnabled")]
        public System.Nullable<bool> IsAccessControlEnabled { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "whitelistedIps")]
        public System.Collections.Generic.List<string> WhitelistedIps { get; set; }
        
        /// <value>
        /// This field will be null if the Autonomous Database is not Data Guard enabled or Access Control is disabled.
        /// It's value would be `TRUE` if Autonomous Database is Data Guard enabled and Access Control is enabled and if the Autonomous Database uses primary IP access control list (ACL) for standby.
        /// It's value would be `FALSE` if Autonomous Database is Data Guard enabled and Access Control is enabled and if the Autonomous Database uses different IP access control list (ACL) for standby compared to primary.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "arePrimaryWhitelistedIpsUsed")]
        public System.Nullable<bool> ArePrimaryWhitelistedIpsUsed { get; set; }
        
        /// <value>
        /// The client IP access control list (ACL). This feature is available for autonomous databases on [shared Exadata infrastructure](https://docs.cloud.oracle.com/Content/Database/Concepts/adboverview.htm#AEI) and on Exadata Cloud@Customer.
        /// Only clients connecting from an IP address included in the ACL may access the Autonomous Database instance.
        /// <br/>
        /// For shared Exadata infrastructure, this is an array of CIDR (Classless Inter-Domain Routing) notations for a subnet or VCN OCID.
        /// Use a semicolon (;) as a deliminator between the VCN-specific subnets or IPs.
        /// Example: [&quot;1.1.1.1&quot;,&quot;1.1.1.0/24&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id>&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id1>;1.1.1.1&quot;,&quot;ocid1.vcn.oc1.sea.<unique_id2>;1.1.0.0/16&quot;]For Exadata Cloud@Customer, this is an array of IP addresses or CIDR (Classless Inter-Domain Routing) notations.
        /// </value>
        [JsonProperty(PropertyName = "standbyWhitelistedIps")]
        public System.Collections.Generic.List<string> StandbyWhitelistedIps { get; set; }
        
        /// <value>
        /// Information about Oracle APEX Application Development.
        /// </value>
        [JsonProperty(PropertyName = "apexDetails")]
        public AutonomousDatabaseApex ApexDetails { get; set; }
        
        /// <value>
        /// Indicates if auto scaling is enabled for the Autonomous Database CPU core count.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoScalingEnabled")]
        public System.Nullable<bool> IsAutoScalingEnabled { get; set; }
                ///
        /// <value>
        /// Status of the Data Safe registration for this Autonomous Database.
        /// </value>
        ///
        public enum DataSafeStatusEnum {
            [EnumMember(Value = "REGISTERING")]
            Registering,
            [EnumMember(Value = "REGISTERED")]
            Registered,
            [EnumMember(Value = "DEREGISTERING")]
            Deregistering,
            [EnumMember(Value = "NOT_REGISTERED")]
            NotRegistered,
            [EnumMember(Value = "FAILED")]
            Failed
        };

        /// <value>
        /// Status of the Data Safe registration for this Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "dataSafeStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataSafeStatusEnum> DataSafeStatus { get; set; }
                ///
        /// <value>
        /// Status of Operations Insights for this Autonomous Database.
        /// </value>
        ///
        public enum OperationsInsightsStatusEnum {
            [EnumMember(Value = "ENABLING")]
            Enabling,
            [EnumMember(Value = "ENABLED")]
            Enabled,
            [EnumMember(Value = "DISABLING")]
            Disabling,
            [EnumMember(Value = "NOT_ENABLED")]
            NotEnabled,
            [EnumMember(Value = "FAILED_ENABLING")]
            FailedEnabling,
            [EnumMember(Value = "FAILED_DISABLING")]
            FailedDisabling
        };

        /// <value>
        /// Status of Operations Insights for this Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "operationsInsightsStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OperationsInsightsStatusEnum> OperationsInsightsStatus { get; set; }
        
        /// <value>
        /// The date and time when maintenance will begin.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceBegin")]
        public System.Nullable<System.DateTime> TimeMaintenanceBegin { get; set; }
        
        /// <value>
        /// The date and time when maintenance will end.
        /// </value>
        [JsonProperty(PropertyName = "timeMaintenanceEnd")]
        public System.Nullable<System.DateTime> TimeMaintenanceEnd { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database is a refreshable clone.
        /// </value>
        [JsonProperty(PropertyName = "isRefreshableClone")]
        public System.Nullable<bool> IsRefreshableClone { get; set; }
        
        /// <value>
        /// The date and time when last refresh happened.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastRefresh")]
        public System.Nullable<System.DateTime> TimeOfLastRefresh { get; set; }
        
        /// <value>
        /// The refresh point timestamp (UTC). The refresh point is the time to which the database was most recently refreshed. Data created after the refresh point is not included in the refresh.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastRefreshPoint")]
        public System.Nullable<System.DateTime> TimeOfLastRefreshPoint { get; set; }
        
        /// <value>
        /// The date and time of next refresh.
        /// </value>
        [JsonProperty(PropertyName = "timeOfNextRefresh")]
        public System.Nullable<System.DateTime> TimeOfNextRefresh { get; set; }
                ///
        /// <value>
        /// The `DATABASE OPEN` mode. You can open the database in `READ_ONLY` or `READ_WRITE` mode.
        /// </value>
        ///
        public enum OpenModeEnum {
            [EnumMember(Value = "READ_ONLY")]
            ReadOnly,
            [EnumMember(Value = "READ_WRITE")]
            ReadWrite
        };

        /// <value>
        /// The `DATABASE OPEN` mode. You can open the database in `READ_ONLY` or `READ_WRITE` mode.
        /// </value>
        [JsonProperty(PropertyName = "openMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<OpenModeEnum> OpenMode { get; set; }
                ///
        /// <value>
        /// The refresh status of the clone. REFRESHING indicates that the clone is currently being refreshed with data from the source Autonomous Database.
        /// </value>
        ///
        public enum RefreshableStatusEnum {
            [EnumMember(Value = "REFRESHING")]
            Refreshing,
            [EnumMember(Value = "NOT_REFRESHING")]
            NotRefreshing
        };

        /// <value>
        /// The refresh status of the clone. REFRESHING indicates that the clone is currently being refreshed with data from the source Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "refreshableStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RefreshableStatusEnum> RefreshableStatus { get; set; }
                ///
        /// <value>
        /// The refresh mode of the clone. AUTOMATIC indicates that the clone is automatically being refreshed with data from the source Autonomous Database.
        /// </value>
        ///
        public enum RefreshableModeEnum {
            [EnumMember(Value = "AUTOMATIC")]
            Automatic,
            [EnumMember(Value = "MANUAL")]
            Manual
        };

        /// <value>
        /// The refresh mode of the clone. AUTOMATIC indicates that the clone is automatically being refreshed with data from the source Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "refreshableMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RefreshableModeEnum> RefreshableMode { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the source Autonomous Database that was cloned to create the current Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "sourceId")]
        public string SourceId { get; set; }
                ///
        /// <value>
        /// The Autonomous Database permission level. Restricted mode allows access only to admin users.
        /// </value>
        ///
        public enum PermissionLevelEnum {
            [EnumMember(Value = "RESTRICTED")]
            Restricted,
            [EnumMember(Value = "UNRESTRICTED")]
            Unrestricted
        };

        /// <value>
        /// The Autonomous Database permission level. Restricted mode allows access only to admin users.
        /// </value>
        [JsonProperty(PropertyName = "permissionLevel")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PermissionLevelEnum> PermissionLevel { get; set; }
        
        /// <value>
        /// The timestamp of the last switchover operation for the Autonomous Database.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastSwitchover")]
        public System.Nullable<System.DateTime> TimeOfLastSwitchover { get; set; }
        
        /// <value>
        /// The timestamp of the last failover operation.
        /// </value>
        [JsonProperty(PropertyName = "timeOfLastFailover")]
        public System.Nullable<System.DateTime> TimeOfLastFailover { get; set; }
        
        /// <value>
        /// Indicates whether the Autonomous Database has Data Guard enabled.
        /// </value>
        [JsonProperty(PropertyName = "isDataGuardEnabled")]
        public System.Nullable<bool> IsDataGuardEnabled { get; set; }
        
        /// <value>
        /// Indicates the number of seconds of data loss for a Data Guard failover.
        /// </value>
        [JsonProperty(PropertyName = "failedDataRecoveryInSeconds")]
        public System.Nullable<int> FailedDataRecoveryInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "standbyDb")]
        public AutonomousDatabaseStandbySummary StandbyDb { get; set; }
                ///
        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        ///
        public enum RoleEnum {
            [EnumMember(Value = "PRIMARY")]
            Primary,
            [EnumMember(Value = "STANDBY")]
            Standby,
            [EnumMember(Value = "DISABLED_STANDBY")]
            DisabledStandby
        };

        /// <value>
        /// The Data Guard role of the Autonomous Container Database or Autonomous Database, if Autonomous Data Guard is enabled.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "role")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<RoleEnum> Role { get; set; }
        
        /// <value>
        /// List of Oracle Database versions available for a database upgrade. If there are no version upgrades available, this list is empty.
        /// </value>
        [JsonProperty(PropertyName = "availableUpgradeVersions")]
        public System.Collections.Generic.List<string> AvailableUpgradeVersions { get; set; }
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of the key store.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreId")]
        public string KeyStoreId { get; set; }
        
        /// <value>
        /// The wallet name for Oracle Key Vault.
        /// </value>
        [JsonProperty(PropertyName = "keyStoreWalletName")]
        public string KeyStoreWalletName { get; set; }
        
        /// <value>
        /// The list of regions that support the creation of Autonomous Data Guard standby database.
        /// </value>
        [JsonProperty(PropertyName = "supportedRegionsToCloneTo")]
        public System.Collections.Generic.List<string> SupportedRegionsToCloneTo { get; set; }
        
        /// <value>
        /// Customer Contacts.
        /// </value>
        [JsonProperty(PropertyName = "customerContacts")]
        public System.Collections.Generic.List<CustomerContact> CustomerContacts { get; set; }
        
        /// <value>
        /// The date and time that Autonomous Data Guard was enabled for an Autonomous Database where the standby was provisioned in the same region as the primary database.
        /// </value>
        [JsonProperty(PropertyName = "timeLocalDataGuardEnabled")]
        public System.Nullable<System.DateTime> TimeLocalDataGuardEnabled { get; set; }
                ///
        /// <value>
        /// The Autonomous Data Guard region type of the Autonomous Database. For Autonomous Databases on shared Exadata infrastructure, Data Guard associations have designated primary and standby regions, and these region types do not change when the database changes roles. The standby regions in Data Guard associations can be the same region designated as the primary region, or they can be remote regions. Certain database administrative operations may be available only in the primary region of the Data Guard association, and cannot be performed when the database using the \"primary\" role is operating in a remote Data Guard standby region.```
        /// </value>
        ///
        public enum DataguardRegionTypeEnum {
            [EnumMember(Value = "PRIMARY_DG_REGION")]
            PrimaryDgRegion,
            [EnumMember(Value = "REMOTE_STANDBY_DG_REGION")]
            RemoteStandbyDgRegion
        };

        /// <value>
        /// The Autonomous Data Guard region type of the Autonomous Database. For Autonomous Databases on shared Exadata infrastructure, Data Guard associations have designated primary and standby regions, and these region types do not change when the database changes roles. The standby regions in Data Guard associations can be the same region designated as the primary region, or they can be remote regions. Certain database administrative operations may be available only in the primary region of the Data Guard association, and cannot be performed when the database using the \"primary\" role is operating in a remote Data Guard standby region.```
        /// </value>
        [JsonProperty(PropertyName = "dataguardRegionType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DataguardRegionTypeEnum> DataguardRegionType { get; set; }
        
        /// <value>
        /// The date and time the Autonomous Data Guard role was switched for the Autonomous Database. For databases that have standbys in both the primary Data Guard region and a remote Data Guard standby region, this is the latest timestamp of either the database using the \"primary\" role in the primary Data Guard region, or database located in the remote Data Guard standby region.
        /// </value>
        [JsonProperty(PropertyName = "timeDataGuardRoleChanged")]
        public System.Nullable<System.DateTime> TimeDataGuardRoleChanged { get; set; }
        
        /// <value>
        /// The list of [OCIDs](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of standby databases located in Autonomous Data Guard remote regions that are associated with the source database. Note that for shared Exadata infrastructure, standby databases located in the same region as the source primary database do not have OCIDs.
        /// </value>
        [JsonProperty(PropertyName = "peerDbIds")]
        public System.Collections.Generic.List<string> PeerDbIds { get; set; }
        
    }
}
