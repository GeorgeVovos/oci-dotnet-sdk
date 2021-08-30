/*
 * Copyright (c) 2020, 2021, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatacatalogService.Models
{
  /// <summary>
  /// Enum representing whether or not to emit an event when a relevant action (e.g. modifying a custom property value) is performed by the user on this type.
    /// ENABLED - Event is emitted.
    /// DISABLED - Event is not emitted.
    /// 
  /// </summary>
  public enum EventConfigStatus {
      [EnumMember(Value = "ENABLED")]
      Enabled,
      [EnumMember(Value = "DISABLED")]
      Disabled
  }
}
