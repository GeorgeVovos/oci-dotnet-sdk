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


namespace Oci.LoganalyticsService.Models
{
    /// <summary>
    /// LogAnalyticsLookup
    /// </summary>
    public class LogAnalyticsLookup 
    {
        
        /// <value>
        /// The active edit version.
        /// </value>
        [JsonProperty(PropertyName = "activeEditVersion")]
        public System.Nullable<long> ActiveEditVersion { get; set; }
        
        /// <value>
        /// The canonical link.
        /// </value>
        [JsonProperty(PropertyName = "canonicalLink")]
        public string CanonicalLink { get; set; }
        
        /// <value>
        /// The lookup description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// The edit version.
        /// </value>
        [JsonProperty(PropertyName = "editVersion")]
        public System.Nullable<long> EditVersion { get; set; }
        
        /// <value>
        /// The lookup fields.
        /// </value>
        [JsonProperty(PropertyName = "fields")]
        public System.Collections.Generic.List<LookupField> Fields { get; set; }
        
        /// <value>
        /// The lookup reference as an integer.
        /// </value>
        [JsonProperty(PropertyName = "lookupReference")]
        public System.Nullable<long> LookupReference { get; set; }
        
        /// <value>
        /// The lookup reference as a string.
        /// </value>
        [JsonProperty(PropertyName = "lookupReferenceString")]
        public string LookupReferenceString { get; set; }
                ///
        /// <value>
        /// The lookup type.  Valid values are LOOKUP or DICTIONARY.
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "Lookup")]
            Lookup,
            [EnumMember(Value = "Dictionary")]
            Dictionary
        };

        /// <value>
        /// The lookup type.  Valid values are LOOKUP or DICTIONARY.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The lookup name.
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// A flag indicating if the lookup is custom (user-defined) or
        /// built in.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isBuiltIn")]
        public System.Nullable<long> IsBuiltIn { get; set; }
        
        /// <value>
        /// A flag indicating if the lookup is hidden or not.  A hidden lookup will
        /// not be returned in list operations by default.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isHidden")]
        public System.Nullable<bool> IsHidden { get; set; }
        
        /// <value>
        /// The lookup display name.
        /// </value>
        [JsonProperty(PropertyName = "lookupDisplayName")]
        public string LookupDisplayName { get; set; }
        
        [JsonProperty(PropertyName = "referringSources")]
        public AutoLookups ReferringSources { get; set; }
        
        [JsonProperty(PropertyName = "statusSummary")]
        public StatusSummary StatusSummary { get; set; }
        
        /// <value>
        /// The last updated date.
        /// </value>
        [JsonProperty(PropertyName = "timeUpdated")]
        public System.Nullable<System.DateTime> TimeUpdated { get; set; }
        
    }
}
