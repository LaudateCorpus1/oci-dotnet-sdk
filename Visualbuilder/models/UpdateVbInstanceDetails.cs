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


namespace Oci.VisualbuilderService.Models
{
    /// <summary>
    /// Information about updating a VbInstance.
    /// </summary>
    public class UpdateVbInstanceDetails 
    {
        
        /// <value>
        /// Vb Instance Identifier.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name,
        /// type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Usage of predefined tag keys. These predefined keys are scoped to
        /// namespaces.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// Encrypted IDCS Open ID token. This is required for pre-UCPIS cloud accounts, but not UCPIS, hence not a required parameter
        /// </value>
        [JsonProperty(PropertyName = "idcsOpenId")]
        public string IdcsOpenId { get; set; }
        
        /// <value>
        /// The number of Nodes
        /// </value>
        [JsonProperty(PropertyName = "nodeCount")]
        public System.Nullable<int> NodeCount { get; set; }
        
        /// <value>
        /// Enable Visual Builder. If Visual Builder is enabled alredy, then it cannot be disabled.
        /// </value>
        [JsonProperty(PropertyName = "isVisualBuilderEnabled")]
        public System.Nullable<bool> IsVisualBuilderEnabled { get; set; }
        
        [JsonProperty(PropertyName = "customEndpoint")]
        public UpdateCustomEndpointDetails CustomEndpoint { get; set; }
        
        /// <value>
        /// A list of alternate custom endpoints to be used for the vb instance URL
        /// (contact Oracle for alternateCustomEndpoints availability for a specific instance).
        /// 
        /// </value>
        [JsonProperty(PropertyName = "alternateCustomEndpoints")]
        public System.Collections.Generic.List<UpdateCustomEndpointDetails> AlternateCustomEndpoints { get; set; }
        
    }
}
