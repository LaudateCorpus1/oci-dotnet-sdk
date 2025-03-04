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
    /// Specifies Trigger Deployment Pipleline stage specific run details.
    /// </summary>
    public class TriggerDeploymentPipelineStageRunProgress : BuildPipelineStageRunProgress
    {
        
        [JsonProperty(PropertyName = "exportedVariables")]
        public ExportedVariableCollection ExportedVariables { get; set; }
        
        [JsonProperty(PropertyName = "artifactOverrideParameters")]
        public DeployArtifactOverrideArgumentCollection ArtifactOverrideParameters { get; set; }
        
        /// <value>
        /// Identifier of the deployment triggered.
        /// </value>
        [JsonProperty(PropertyName = "deploymentId")]
        public string DeploymentId { get; set; }
        
        [JsonProperty(PropertyName = "buildPipelineStageType")]
        private readonly string buildPipelineStageType = "TRIGGER_DEPLOYMENT_PIPELINE";
    }
}
