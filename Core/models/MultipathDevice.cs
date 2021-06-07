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
    /// <summary>
    /// Secondary multipath device, it uses the charUsername and chapSecret from primary volume attachment
    /// </summary>
    public class MultipathDevice 
    {
        
        /// <value>
        /// The volume's iSCSI IP address.
        /// <br/>
        /// Example: 169.254.2.2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Ipv4 is required.")]
        [JsonProperty(PropertyName = "ipv4")]
        public string Ipv4 { get; set; }
        
        /// <value>
        /// The target volume's iSCSI Qualified Name in the format defined
        /// by [RFC 3720](https://tools.ietf.org/html/rfc3720#page-32).
        /// <br/>
        /// Example: iqn.2015-12.com.oracleiaas:40b7ee03-883f-46c6-a951-63d2841d2195
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Iqn is required.")]
        [JsonProperty(PropertyName = "iqn")]
        public string Iqn { get; set; }
        
        /// <value>
        /// The volume's iSCSI port, usually port 860 or 3260.
        /// <br/>
        /// Example: 3260
        /// </value>
        [JsonProperty(PropertyName = "port")]
        public System.Nullable<int> Port { get; set; }
        
    }
}
