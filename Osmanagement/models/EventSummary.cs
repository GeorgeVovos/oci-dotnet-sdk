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


namespace Oci.OsmanagementService.Models
{
    /// <summary>
    /// Summary of the Event.
    /// </summary>
    public class EventSummary 
    {
        
        /// <value>
        /// OCID identifier of the event
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        
        /// <value>
        /// Unique OCI identifier of the instance where the event occurred
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// human readable description of the event
        /// </value>
        [JsonProperty(PropertyName = "summary")]
        public string Summary { get; set; }
        
        /// <value>
        /// Type of the event.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "EventType is required.")]
        [JsonProperty(PropertyName = "eventType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<EventType> EventType { get; set; }
        
        /// <value>
        /// Event occurrence count. Number of time the same event happened on the system.
        /// </value>
        [JsonProperty(PropertyName = "count")]
        public System.Nullable<int> Count { get; set; }
        
        /// <value>
        /// Time of the occurrence of the event
        /// </value>
        [JsonProperty(PropertyName = "timestamp")]
        public System.Nullable<System.DateTime> Timestamp { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Usage of system tag keys. These predefined keys are scoped to namespaces.
        /// Example: {&quot;orcl-cloud&quot;: {&quot;free-tier-retained&quot;: &quot;true&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "systemTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> SystemTags { get; set; }
        
    }
}
