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


namespace Oci.DatasafeService.Models
{
    /// <summary>
    /// Details to mask data.
    /// </summary>
    public class MaskDataDetails 
    {
        
        /// <value>
        /// The OCID of the target database to be masked. If it's not provided, the value of the 
        /// targetId attribute in the MaskingPolicy resource is used. The OCID of the target 
        /// database to be masked. If it's not provided, the value of the targetId attribute in 
        /// the MaskingPolicy resource is used. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "targetId")]
        public string TargetId { get; set; }
        
        /// <value>
        /// Indicates if the masking request is to decrypt the data values previously encrypted using Deterministic Encryption. Note that, to
        /// correctly decrypt the encrypted data values, it requires the same seed value that was provided to encrypt those data values. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isDecrypt")]
        public System.Nullable<bool> IsDecrypt { get; set; }
        
        /// <value>
        /// Indicates if the masking request is to rerun the previously failed masking steps. If a masking request is submitted with the
        /// isIgnoreErrorsEnabled attribute set to true, the masking process tracks the failed masking steps. Another masking request can be
        /// submitted with the isRun attribute set to true to rerun those failed masking steps. It helps save time by executing only the failed
        /// masking steps and not doing the whole masking again. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRerun")]
        public System.Nullable<bool> IsRerun { get; set; }
        
        /// <value>
        /// The tablespace that should be used to create the mapping tables, DMASK objects, and other temporary tables for data masking.
        /// If no tablespace is provided, the DEFAULT tablespace is used. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "tablespace")]
        public string Tablespace { get; set; }
        
        /// <value>
        /// Indicates if the masking process should continue on hitting an error. It provides fault tolerance support and is enabled by
        /// default. In fault-tolerant mode, the masking process saves the failed step and continues. You can then submit another masking
        /// request (with isRerun attribute set to true) to execute only the failed steps. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isIgnoreErrorsEnabled")]
        public System.Nullable<bool> IsIgnoreErrorsEnabled { get; set; }
        
        /// <value>
        /// The seed value to be used in case of Deterministic Encryption and Deterministic Substitution masking formats.
        /// </value>
        [JsonProperty(PropertyName = "seed")]
        public string Seed { get; set; }
        
        /// <value>
        /// Indicates if the interim DMASK tables should be moved to the user-specified tablespace. As interim tables can be large in size,
        /// set it to false if moving them causes performance overhead during masking. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMoveInterimTablesEnabled")]
        public System.Nullable<bool> IsMoveInterimTablesEnabled { get; set; }
        
        /// <value>
        /// Indicates if data masking should be performed using a saved masking script. Setting this attribute to true skips masking script
        /// generation and executes the masking script stored in the Data Safe repository. It helps save time if there are no changes in
        /// the database tables and their dependencies. 
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isExecuteSavedScriptEnabled")]
        public System.Nullable<bool> IsExecuteSavedScriptEnabled { get; set; }
        
    }
}
