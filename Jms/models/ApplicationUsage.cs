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


namespace Oci.JmsService.Models
{
    /// <summary>
    /// Application usage during a specified time period.
    /// An application is a Java application that can be executed by a Java Runtime installation.
    /// An application is independent of the Java Runtime or its installation.
    /// 
    /// </summary>
    public class ApplicationUsage 
    {
        
        /// <value>
        /// An internal identifier for the application that is unique to a Fleet.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationId is required.")]
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }
        
        /// <value>
        /// The name of the application.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "DisplayName is required.")]
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// The type of the application, denoted by how the application was started.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ApplicationType is required.")]
        [JsonProperty(PropertyName = "applicationType")]
        public string ApplicationType { get; set; }
        
        /// <value>
        /// The approximate count of installations running this application.
        /// </value>
        [JsonProperty(PropertyName = "approximateInstallationCount")]
        public System.Nullable<int> ApproximateInstallationCount { get; set; }
        
        /// <value>
        /// The approximate count of Java Runtimes running this application.
        /// </value>
        [JsonProperty(PropertyName = "approximateJreCount")]
        public System.Nullable<int> ApproximateJreCount { get; set; }
        
        /// <value>
        /// The approximate count of managed instances reporting this application.
        /// </value>
        [JsonProperty(PropertyName = "approximateManagedInstanceCount")]
        public System.Nullable<int> ApproximateManagedInstanceCount { get; set; }
        
        /// <value>
        /// Lower bound of the specified time period filter.
        /// </value>
        [JsonProperty(PropertyName = "timeStart")]
        public System.Nullable<System.DateTime> TimeStart { get; set; }
        
        /// <value>
        /// Upper bound of the specified time period filter.
        /// </value>
        [JsonProperty(PropertyName = "timeEnd")]
        public System.Nullable<System.DateTime> TimeEnd { get; set; }
        
        /// <value>
        /// The date and time the resource was _first_ reported to JMS.
        /// This is potentially _before_ the specified time period provided by the filters.
        /// For example, a resource can be first reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeFirstSeen")]
        public System.Nullable<System.DateTime> TimeFirstSeen { get; set; }
        
        /// <value>
        /// The date and time the resource was _last_ reported to JMS.
        /// This is potentially _after_ the specified time period provided by the filters.
        /// For example, a resource can be last reported to JMS before the start of a specified time period,
        /// if it is also reported during the time period.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "timeLastSeen")]
        public System.Nullable<System.DateTime> TimeLastSeen { get; set; }
        
    }
}
