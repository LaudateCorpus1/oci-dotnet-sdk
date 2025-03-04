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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// Filter parameters from the query string as they pass through the gateway.  The gateway applies filters after other
    /// transformations, so any parameters set or renamed must also be listed here when using an ALLOW type policy.
    /// 
    /// </summary>
    public class FilterQueryParameterPolicy 
    {
                ///
        /// <value>
        /// BLOCK drops any query parameters that are in the list of items, so it acts as an exclusion list.  ALLOW
        /// permits only the parameters in the list and removes all others, so it acts as an inclusion list.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "ALLOW")]
            Allow,
            [EnumMember(Value = "BLOCK")]
            Block
        };

        /// <value>
        /// BLOCK drops any query parameters that are in the list of items, so it acts as an exclusion list.  ALLOW
        /// permits only the parameters in the list and removes all others, so it acts as an inclusion list.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Type is required.")]
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<TypeEnum> Type { get; set; }
        
        /// <value>
        /// The list of query parameters.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Items is required.")]
        [JsonProperty(PropertyName = "items")]
        public System.Collections.Generic.List<FilterQueryParameterPolicyItem> Items { get; set; }
        
    }
}
