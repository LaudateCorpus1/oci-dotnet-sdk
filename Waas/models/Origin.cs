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


namespace Oci.WaasService.Models
{
    /// <summary>
    /// A detailed description of your web application's origin host server. An origin must be defined to set up WAF rules.
    /// </summary>
    public class Origin 
    {
        
        /// <value>
        /// The URI of the origin. Does not support paths. Port numbers should be specified in the `httpPort` and `httpsPort` fields.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Uri is required.")]
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
        
        /// <value>
        /// The HTTP port on the origin that the web application listens on. If unspecified, defaults to `80`. If `0` is specified - the origin is not used for HTTP traffic.
        /// </value>
        [JsonProperty(PropertyName = "httpPort")]
        public System.Nullable<int> HttpPort { get; set; }
        
        /// <value>
        /// The HTTPS port on the origin that the web application listens on. If unspecified, defaults to `443`. If `0` is specified - the origin is not used for HTTPS traffic.
        /// </value>
        [JsonProperty(PropertyName = "httpsPort")]
        public System.Nullable<int> HttpsPort { get; set; }
        
        /// <value>
        /// A list of HTTP headers to forward to your origin.
        /// </value>
        [JsonProperty(PropertyName = "customHeaders")]
        public System.Collections.Generic.List<Header> CustomHeaders { get; set; }
        
    }
}
