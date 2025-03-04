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
using Newtonsoft.Json.Linq;

namespace Oci.CoreService.Models
{
    /// <summary>
    /// The platform configuration for the instance.
    /// 
    /// </summary>
    [JsonConverter(typeof(PlatformConfigModelConverter))]
    public class PlatformConfig 
    {
                ///
        /// <value>
        /// The type of platform being configured.
        /// 
        /// </value>
        ///
        public enum TypeEnum {
            [EnumMember(Value = "AMD_MILAN_BM")]
            AmdMilanBm,
            [EnumMember(Value = "AMD_ROME_BM")]
            AmdRomeBm,
            [EnumMember(Value = "INTEL_SKYLAKE_BM")]
            IntelSkylakeBm,
            [EnumMember(Value = "AMD_VM")]
            AmdVm,
            [EnumMember(Value = "INTEL_VM")]
            IntelVm
        };

        
        /// <value>
        /// Whether Secure Boot is enabled on the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isSecureBootEnabled")]
        public System.Nullable<bool> IsSecureBootEnabled { get; set; }
        
        /// <value>
        /// Whether the Trusted Platform Module (TPM) is enabled on the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isTrustedPlatformModuleEnabled")]
        public System.Nullable<bool> IsTrustedPlatformModuleEnabled { get; set; }
        
        /// <value>
        /// Whether the Measured Boot feature is enabled on the instance.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "isMeasuredBootEnabled")]
        public System.Nullable<bool> IsMeasuredBootEnabled { get; set; }
        
    }

    public class PlatformConfigModelConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;
        public override bool CanConvert(System.Type type)
        {
            return type == typeof(PlatformConfig);
        }
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.InvalidOperationException("Use default serialization.");
        }

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObject = JObject.Load(reader);
            var obj = default(PlatformConfig);
            var discriminator = jsonObject["type"].Value<string>();
            switch (discriminator)
            {
                case "AMD_MILAN_BM":
                    obj = new AmdMilanBmPlatformConfig();
                    break;
                case "AMD_ROME_BM":
                    obj = new AmdRomeBmPlatformConfig();
                    break;
                case "INTEL_SKYLAKE_BM":
                    obj = new IntelSkylakeBmPlatformConfig();
                    break;
                case "AMD_VM":
                    obj = new AmdVmPlatformConfig();
                    break;
                case "INTEL_VM":
                    obj = new IntelVmPlatformConfig();
                    break;
            }
            serializer.Populate(jsonObject.CreateReader(), obj);
            return obj;
        }
    }
}
