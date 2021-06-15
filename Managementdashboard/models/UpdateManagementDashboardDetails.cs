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


namespace Oci.ManagementdashboardService.Models
{
    /// <summary>
    /// Properties of a dashboard.  Dashboard ID must not be provided.
    /// </summary>
    public class UpdateManagementDashboardDetails 
    {
        
        /// <value>
        /// ID of the service (for example, log-analytics) that owns the dashboard. Each service has a unique ID.
        /// </value>
        [JsonProperty(PropertyName = "providerId")]
        public string ProviderId { get; set; }
        
        /// <value>
        /// Name of the service (for example, Logging Analytics) that owns the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "providerName")]
        public string ProviderName { get; set; }
        
        /// <value>
        /// Version of the service that owns the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }
        
        /// <value>
        /// Array of dashboard tiles.
        /// </value>
        [JsonProperty(PropertyName = "tiles")]
        public System.Collections.Generic.List<ManagementDashboardTileDetails> Tiles { get; set; }
        
        /// <value>
        /// Display name of the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description of the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// OCID of the compartment in which the dashboard resides.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Determines whether the dashboard is an Out-of-the-Box (OOB) dashboard. Note that OOB dashboards are only provided by Oracle and cannot be modified.
        /// </value>
        [JsonProperty(PropertyName = "isOobDashboard")]
        public System.Nullable<bool> IsOobDashboard { get; set; }
        
        /// <value>
        /// Determines whether the dashboard will be displayed in Dashboard Home.
        /// </value>
        [JsonProperty(PropertyName = "isShowInHome")]
        public System.Nullable<bool> IsShowInHome { get; set; }
        
        /// <value>
        /// Version of the metadata.
        /// </value>
        [JsonProperty(PropertyName = "metadataVersion")]
        public string MetadataVersion { get; set; }
        
        /// <value>
        /// Determines whether the description of the dashboard is displayed.
        /// </value>
        [JsonProperty(PropertyName = "isShowDescription")]
        public System.Nullable<bool> IsShowDescription { get; set; }
        
        /// <value>
        /// Screen image of the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "screenImage")]
        public string ScreenImage { get; set; }
        
        /// <value>
        /// JSON that contains internationalization options.
        /// </value>
        [JsonProperty(PropertyName = "nls")]
        public System.Object Nls { get; set; }
        
        /// <value>
        /// JSON that contains user interface options.
        /// </value>
        [JsonProperty(PropertyName = "uiConfig")]
        public System.Object UiConfig { get; set; }
        
        /// <value>
        /// Array of JSON that contain data source options.
        /// </value>
        [JsonProperty(PropertyName = "dataConfig")]
        public System.Collections.Generic.List<System.Object> DataConfig { get; set; }
        
        /// <value>
        /// Type of dashboard. NORMAL denotes a single dashboard and SET denotes a dashboard set.
        /// </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
        
        /// <value>
        /// Determines whether the dashboard is set as favorite.
        /// </value>
        [JsonProperty(PropertyName = "isFavorite")]
        public System.Nullable<bool> IsFavorite { get; set; }
        
        /// <value>
        /// Defines parameters for the dashboard.
        /// </value>
        [JsonProperty(PropertyName = "parametersConfig")]
        public System.Collections.Generic.List<System.Object> ParametersConfig { get; set; }
        
        /// <value>
        /// Simple key-value pair that is applied without any predefined name, type or scope. Exists for cross-compatibility only.
        /// Example: {&quot;bar-key&quot;: &quot;value&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a namespace.
        /// Example: {&quot;foo-namespace&quot;: {&quot;bar-key&quot;: &quot;value&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
    }
}
