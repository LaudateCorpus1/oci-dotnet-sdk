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


namespace Oci.AppmgmtcontrolService.Models
{
    /// <summary>
    /// Summary of the monitored instance.
    /// </summary>
    public class MonitoredInstanceSummary 
    {
        
        /// <value>
        /// The [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) of monitored instance.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "InstanceId is required.")]
        [JsonProperty(PropertyName = "instanceId")]
        public string InstanceId { get; set; }
        
        /// <value>
        /// Compartment Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm)
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// A user-friendly name of the monitored instance. It is binded to [Compute Instance](https://docs.cloud.oracle.com/Content/Compute/Concepts/computeoverview.htm).
        /// DisplayName is fetched from [Core Service API](https://docs.cloud.oracle.com/api/#/en/iaas/20160918/Instance/).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Management Agent Identifier [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// </value>
        [JsonProperty(PropertyName = "managementAgentId")]
        public string ManagementAgentId { get; set; }
        
        /// <value>
        /// The current state of the monitored instance.
        /// </value>
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonitoredInstance.LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// Monitoring status. Can be either enabled or disabled.
        /// </value>
        [JsonProperty(PropertyName = "monitoringState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<MonitoredInstance.MonitoringStateEnum> MonitoringState { get; set; }
        
    }
}
