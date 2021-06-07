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


namespace Oci.ApplicationmigrationService.Models
{
    /// <summary>
    /// / Basic details about the source, import manifest and object storage bucket as well as object name of the archive that should be used during import
    /// </summary>
    public class ImportSourceDetails : SourceDetails
    {
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Manifest is required.")]
        [JsonProperty(PropertyName = "manifest")]
        public ImportManifest Manifest { get; set; }
        
        /// <value>
        /// the object storage namespace where the bucket and uploaded object resides
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Namespace is required.")]
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// the bucket wherein the export archive exists in object storage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Bucket is required.")]
        [JsonProperty(PropertyName = "bucket")]
        public string Bucket { get; set; }
        
        /// <value>
        /// the name of the archive as it exists in object storage
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ObjectName is required.")]
        [JsonProperty(PropertyName = "objectName")]
        public string ObjectName { get; set; }
        
        [JsonProperty(PropertyName = "type")]
        private readonly string type = "IMPORT";
    }
}
