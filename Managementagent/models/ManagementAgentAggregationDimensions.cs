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


namespace Oci.ManagementagentService.Models
{
    /// <summary>
    /// The Aggregation of Management Agent Dimensions
    /// </summary>
    public class ManagementAgentAggregationDimensions 
    {
        
        /// <value>
        /// The availability status of managementAgent
        /// </value>
        [JsonProperty(PropertyName = "availabilityStatus")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<AvailabilityStatus> AvailabilityStatus { get; set; }
        
        /// <value>
        /// Platform Type
        /// </value>
        [JsonProperty(PropertyName = "platformType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<PlatformTypes> PlatformType { get; set; }
        
        /// <value>
        /// Agent image version
        /// </value>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }
        
        /// <value>
        /// Whether or not a managementAgent has at least one plugin
        /// </value>
        [JsonProperty(PropertyName = "hasPlugins")]
        public System.Nullable<bool> HasPlugins { get; set; }
        
    }
}
