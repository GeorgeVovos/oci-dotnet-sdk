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


namespace Oci.OperatoraccesscontrolService.Models
{
    /// <summary>
    /// Information about the new operator control.
    /// </summary>
    public class UpdateOperatorControlDetails 
    {
        
        /// <value>
        /// Name of the operator control.
        /// </value>
        [JsonProperty(PropertyName = "operatorControlName")]
        public string OperatorControlName { get; set; }
        
        /// <value>
        /// Description of the operator control.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// List of users who can approve an access request associated with a target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "approversList")]
        public System.Collections.Generic.List<string> ApproversList { get; set; }
        
        /// <value>
        /// List of user groups who can approve an access request associated with a target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "approverGroupsList")]
        public System.Collections.Generic.List<string> ApproverGroupsList { get; set; }
        
        /// <value>
        /// List of pre-approved operator actions. Access requests associated with a resource governed by this operator control will be
        /// automatically approved if the access request only contain operator actions in the pre-approved list.    
        /// 
        /// </value>
        [JsonProperty(PropertyName = "preApprovedOpActionList")]
        public System.Collections.Generic.List<string> PreApprovedOpActionList { get; set; }
        
        /// <value>
        /// Whether all the operator actions have been pre-approved. If yes, all access requests associated with a resource governed by this operator control 
        /// will be auto-approved.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isFullyPreApproved")]
        public System.Nullable<bool> IsFullyPreApproved { get; set; }
        
        /// <value>
        /// List of emailId.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "emailIdList")]
        public System.Collections.Generic.List<string> EmailIdList { get; set; }
        
        /// <value>
        /// System message that would be displayed to the operator users on accessing the target resource under the governance of this operator control.
        /// </value>
        [JsonProperty(PropertyName = "systemMessage")]
        public string SystemMessage { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
