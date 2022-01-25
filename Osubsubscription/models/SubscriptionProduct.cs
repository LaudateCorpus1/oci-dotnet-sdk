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


namespace Oci.OsubsubscriptionService.Models
{
    /// <summary>
    /// Product description
    /// 
    /// </summary>
    public class SubscriptionProduct 
    {
        
        /// <value>
        /// Product part numner
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "PartNumber is required.")]
        [JsonProperty(PropertyName = "partNumber")]
        public string PartNumber { get; set; }
        
        /// <value>
        /// Product name
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Name is required.")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
        
        /// <value>
        /// Unit of measure
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "UnitOfMeasure is required.")]
        [JsonProperty(PropertyName = "unitOfMeasure")]
        public string UnitOfMeasure { get; set; }
        
        /// <value>
        /// Product provisioning group
        /// 
        /// </value>
        [JsonProperty(PropertyName = "provisioningGroup")]
        public string ProvisioningGroup { get; set; }
        
    }
}
