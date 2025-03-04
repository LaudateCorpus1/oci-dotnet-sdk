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


namespace Oci.DatabasemigrationService.Models
{
    /// <summary>
    /// Parameters for GoldenGate Replicat processes.
    /// 
    /// </summary>
    public class CreateReplicat 
    {
        
        /// <value>
        /// Number of threads used to read trail files (valid for Parallel Replicat)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "mapParallelism")]
        public System.Nullable<int> MapParallelism { get; set; }
        
        /// <value>
        /// Defines the range in which the Replicat automatically adjusts its apply parallelism (valid for Parallel Replicat)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "minApplyParallelism")]
        public System.Nullable<int> MinApplyParallelism { get; set; }
        
        /// <value>
        /// Defines the range in which the Replicat automatically adjusts its apply parallelism (valid for Parallel Replicat)
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxApplyParallelism")]
        public System.Nullable<int> MaxApplyParallelism { get; set; }
        
    }
}
