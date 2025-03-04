/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DatalabelingService.Models
{
  /// <summary>
  /// Possible types of actions.
  /// </summary>
  public enum ActionType {
      [EnumMember(Value = "CREATED")]
      Created,
      [EnumMember(Value = "UPDATED")]
      Updated,
      [EnumMember(Value = "DELETED")]
      Deleted,
      [EnumMember(Value = "IN_PROGRESS")]
      InProgress,
      [EnumMember(Value = "WRITTEN")]
      Written,
      [EnumMember(Value = "RELATED")]
      Related
  }
}
