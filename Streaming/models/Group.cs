/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.StreamingService.Models
{
    /// <summary>
    /// Represents the current state of a consumer group, including partition reservations and committed offsets.
    /// 
    /// </summary>
    public class Group 
    {
        
        /// <value>
        /// The streamId for which the group exists.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "StreamId is required.")]
        [JsonProperty(PropertyName = "streamId")]
        public string StreamId { get; set; }
        
        /// <value>
        /// The name of the consumer group.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "GroupName is required.")]
        [JsonProperty(PropertyName = "groupName")]
        public string GroupName { get; set; }
        
        /// <value>
        /// An array of the partition reservations of a group.
        /// </value>
        [JsonProperty(PropertyName = "reservations")]
        public System.Collections.Generic.List<PartitionReservation> Reservations { get; set; }
        
    }
}
