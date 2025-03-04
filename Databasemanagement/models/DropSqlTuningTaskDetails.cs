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


namespace Oci.DatabasemanagementService.Models
{
    /// <summary>
    /// The request to drop a SQL tuning task.
    /// </summary>
    public class DropSqlTuningTaskDetails 
    {
        
        /// <value>
        /// The identifier of the SQL tuning task being dropped. This is not the [OCID](https://docs.cloud.oracle.com/Content/General/Concepts/identifiers.htm).
        /// It can be retrieved from the following endpoint
        /// {@link #listSqlTuningAdvisorTasks(ListSqlTuningAdvisorTasksRequest) listSqlTuningAdvisorTasks}.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TaskId is required.")]
        [JsonProperty(PropertyName = "taskId")]
        public System.Nullable<long> TaskId { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CredentialDetails is required.")]
        [JsonProperty(PropertyName = "credentialDetails")]
        public SqlTuningTaskCredentialDetails CredentialDetails { get; set; }
        
    }
}
