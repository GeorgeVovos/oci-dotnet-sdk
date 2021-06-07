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


namespace Oci.CoreService.Models
{
    
    public class CreateBootVolumeDetails 
    {
        
        /// <value>
        /// The availability domain of the volume. Omissible for cloning a volume. The new volume will be created in the availability domain of the source volume.
        /// <br/>
        /// Example: Uocm:PHX-AD-1
        /// </value>
        [JsonProperty(PropertyName = "availabilityDomain")]
        public string AvailabilityDomain { get; set; }
        
        /// <value>
        /// If provided, specifies the ID of the boot volume backup policy to assign to the newly
        /// created boot volume. If omitted, no policy will be assigned.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "backupPolicyId")]
        public string BackupPolicyId { get; set; }
        
        /// <value>
        /// The OCID of the compartment that contains the boot volume.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name. Does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The OCID of the Key Management key to assign as the master encryption key
        /// for the boot volume.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "kmsKeyId")]
        public string KmsKeyId { get; set; }
        
        /// <value>
        /// The size of the volume in GBs.
        /// </value>
        [JsonProperty(PropertyName = "sizeInGBs")]
        public System.Nullable<long> SizeInGBs { get; set; }
        
        /// <value>
        /// The number of volume performance units (VPUs) that will be applied to this volume per GB,
        /// representing the Block Volume service's elastic performance options.
        /// See [Block Volume Elastic Performance](https://docs.cloud.oracle.com/iaas/Content/Block/Concepts/blockvolumeelasticperformance.htm) for more information.
        /// <br/>
        /// Allowed values:
        /// <br/>
        ///   * `10`: Represents Balanced option.
        /// <br/>
        ///   * `20`: Represents Higher Performance option.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "vpusPerGB")]
        public System.Nullable<long> VpusPerGB { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "SourceDetails is required.")]
        [JsonProperty(PropertyName = "sourceDetails")]
        public BootVolumeSourceDetails SourceDetails { get; set; }
        
        /// <value>
        /// Specifies whether the auto-tune performance is enabled for this boot volume.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isAutoTuneEnabled")]
        public System.Nullable<bool> IsAutoTuneEnabled { get; set; }
        
        /// <value>
        /// The list of boot volume replicas to be enabled for this boot volume
        /// in the specified destination availability domains.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "bootVolumeReplicas")]
        public System.Collections.Generic.List<BootVolumeReplicaDetails> BootVolumeReplicas { get; set; }
        
    }
}
