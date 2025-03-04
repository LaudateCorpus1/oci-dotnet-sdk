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


namespace Oci.LoadbalancerService.Models
{
    
    public class UpdateLoadBalancerShapeDetails 
    {
        
        /// <value>
        /// The new shape name for the load balancer.
        /// <br/>
        /// Allowed values are :
        ///   *  10Mbps
        ///   *  100Mbps
        ///   *  400Mbps
        ///   *  8000Mbps
        ///   *  Flexible
        /// <br/>
        ///   Example: Flexible
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ShapeName is required.")]
        [JsonProperty(PropertyName = "shapeName")]
        public string ShapeName { get; set; }
        
        /// <value>
        /// The configuration details to update load balancer to a different profile.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "shapeDetails")]
        public ShapeDetails ShapeDetails { get; set; }
        
    }
}
