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


namespace Oci.ApigatewayService.Models
{
    /// <summary>
    /// List of additional applicable parameters for any given target language.
    /// </summary>
    public class SdkLanguageOptionalParameters 
    {
        
        /// <value>
        /// Name of the parameter.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ParamName is required.")]
        [JsonProperty(PropertyName = "paramName")]
        public string ParamName { get; set; }
        
        /// <value>
        /// Display name of the parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Description for the parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        
        /// <value>
        /// Information on whether the parameter is required or not.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isRequired")]
        public System.Nullable<bool> IsRequired { get; set; }
        
        /// <value>
        /// Maximum size as input value for this parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "maxSize")]
        public System.Nullable<decimal> MaxSize { get; set; }
                ///
        /// <value>
        /// The input type for this param.
        /// - Input type is ENUM when only specific list of input strings are allowed.
        /// - Input type is EMAIL when input type is an email ID.
        /// - Input type is URI when input type is an URI.
        /// - Input type is STRING in all other cases.
        /// 
        /// </value>
        ///
        public enum InputTypeEnum {
            [EnumMember(Value = "ENUM")]
            Enum,
            [EnumMember(Value = "EMAIL")]
            Email,
            [EnumMember(Value = "URI")]
            Uri,
            [EnumMember(Value = "STRING")]
            String
        };

        /// <value>
        /// The input type for this param.
        /// - Input type is ENUM when only specific list of input strings are allowed.
        /// - Input type is EMAIL when input type is an email ID.
        /// - Input type is URI when input type is an URI.
        /// - Input type is STRING in all other cases.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "inputType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<InputTypeEnum> InputType { get; set; }
        
        /// <value>
        /// List of allowed input values.
        /// Example: [{&quot;name&quot;: &quot;name1&quot;, &quot;description&quot;: &quot;description1&quot;}, ...]
        /// </value>
        [JsonProperty(PropertyName = "allowedValues")]
        public System.Collections.Generic.List<SdkLanguageOptionalParametersAllowedValue> AllowedValues { get; set; }
        
    }
}
