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


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies a trigger schedule. Timing information for when to initiate automated syncs.
    /// </summary>
    public class TriggerSchedule 
    {
                ///
        /// <value>
        /// Different types of trigger schedule:
        /// None - No automated synchronization schedule.
        /// Default - Trigger schedule is every 30 minutes.
        /// Custom - Custom triggering schedule.
        /// 
        /// </value>
        ///
        public enum ScheduleTypeEnum {
            [EnumMember(Value = "NONE")]
            None,
            [EnumMember(Value = "DEFAULT")]
            Default,
            [EnumMember(Value = "CUSTOM")]
            Custom
        };

        /// <value>
        /// Different types of trigger schedule:
        /// None - No automated synchronization schedule.
        /// Default - Trigger schedule is every 30 minutes.
        /// Custom - Custom triggering schedule.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ScheduleType is required.")]
        [JsonProperty(PropertyName = "scheduleType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScheduleTypeEnum> ScheduleType { get; set; }
        
        /// <value>
        /// Valid if type is CUSTOM. Following RFC 5545 recurrence rules, we can specify starting time, occurrence frequency, and interval size.
        /// Example for frequency could be DAILY/WEEKLY/HOURLY or any RFC 5545 supported frequency, which is followed by start time of this window. 
        /// You can control the start time with BYHOUR, BYMINUTE and BYSECONDS. It is followed by the interval size.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "customSchedule")]
        public string CustomSchedule { get; set; }
        
    }
}
