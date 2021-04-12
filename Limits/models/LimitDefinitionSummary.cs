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


namespace Oci.LimitsService.Models
{
    /// <summary>
    /// The metadata specific to a resource limit definition.
    /// </summary>
    public class LimitDefinitionSummary 
    {
        
        /// <value>
        /// The resource limit name. To be used for writing policies (in case of quotas) or other programmatic calls.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// The service name of the limit.
        /// </value>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }
        
        /// <value>
        /// The limit description.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
                ///
        /// <value>
        /// Reflects the scope of the resource limit: which can be Global (across all regions), regional or ad specific.
        /// 
        /// </value>
        ///
        public enum ScopeTypeEnum {
            [EnumMember(Value = "GLOBAL")]
            Global,
            [EnumMember(Value = "REGION")]
            Region,
            [EnumMember(Value = "AD")]
            Ad
        };

        /// <value>
        /// Reflects the scope of the resource limit: which can be Global (across all regions), regional or ad specific.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "scopeType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ScopeTypeEnum> ScopeType { get; set; }
        
        /// <value>
        /// If true, quota policies can be created on top of this resource limit.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "areQuotasSupported")]
        public System.Nullable<bool> AreQuotasSupported { get; set; }
        
        /// <value>
        /// Reflects if the GetResourceAvailability API is supported for this limit or not.
        /// If not, the API will return an empty JSON response.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isResourceAvailabilitySupported")]
        public System.Nullable<bool> IsResourceAvailabilitySupported { get; set; }
        
        /// <value>
        /// Indicates if the limit has been deprecated.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDeprecated")]
        public System.Nullable<bool> IsDeprecated { get; set; }
        
        /// <value>
        /// Indicates if the customer can request a limit increase for this resource.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isEligibleForLimitIncrease")]
        public System.Nullable<bool> IsEligibleForLimitIncrease { get; set; }
        
    }
}
