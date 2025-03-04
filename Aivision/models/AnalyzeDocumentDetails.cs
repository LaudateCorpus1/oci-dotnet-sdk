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


namespace Oci.AivisionService.Models
{
    /// <summary>
    /// Details about how to analyze a document.
    /// </summary>
    public class AnalyzeDocumentDetails 
    {
        
        /// <value>
        /// Types of document analysis requested.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Features is required.")]
        [JsonProperty(PropertyName = "features")]
        public System.Collections.Generic.List<DocumentFeature> Features { get; set; }
        
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Document is required.")]
        [JsonProperty(PropertyName = "document")]
        public DocumentDetails Document { get; set; }
        
        /// <value>
        /// The OCID of the compartment that calls the API.
        /// </value>
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        [JsonProperty(PropertyName = "outputLocation")]
        public OutputLocation OutputLocation { get; set; }
        
        /// <value>
        /// Language of the document, abbreviated according to ISO 639-2.
        /// </value>
        [JsonProperty(PropertyName = "language")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DocumentLanguage> Language { get; set; }
        
        /// <value>
        /// The type of document.
        /// </value>
        [JsonProperty(PropertyName = "documentType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<DocumentType> DocumentType { get; set; }
        
    }
}
