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


namespace Oci.DatabasetoolsService.Models
{
    /// <summary>
    /// Allow to restrict access to only requests that come from the specified public or virtual source IP addresses.
    /// 
    /// </summary>
    public class DatabaseToolsAllowedNetworkSources 
    {
        
        /// <value>
        /// A list of allowed public IPs and CIDR blocks.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "publicSourceList")]
        public System.Collections.Generic.List<string> PublicSourceList { get; set; }
        
        /// <value>
        /// A list of allowed VCN [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm) and IP ranges pairs.
        /// Example: &quot;vcnId&quot;: &quot;ocid1.vcn.oc1.iad.aaaaaaaaexampleuniqueID&quot;, &quot;ipRanges&quot;: [ &quot;129.213.39.0/24&quot; ]
        /// </value>
        [JsonProperty(PropertyName = "virtualSourceList")]
        public System.Collections.Generic.List<DatabaseToolsVirtualSource> VirtualSourceList { get; set; }
        
    }
}
