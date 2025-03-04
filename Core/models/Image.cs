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


namespace Oci.CoreService.Models
{
    /// <summary>
    /// A boot disk image for launching an instance. For more information, see
    /// [Overview of the Compute Service](https://docs.cloud.oracle.com/iaas/Content/Compute/Concepts/computeoverview.htm).
    /// <br/>
    /// To use any of the API operations, you must be authorized in an IAM policy. If you're not authorized,
    /// talk to an administrator. If you're an administrator who needs to write policies to give users access, see
    /// [Getting Started with Policies](https://docs.cloud.oracle.com/iaas/Content/Identity/Concepts/policygetstarted.htm).
    /// <br/>
    /// **Warning:** Oracle recommends that you avoid using any confidential information when you
    /// supply string values using the API.
    /// 
    /// </summary>
    public class Image 
    {
        
        /// <value>
        /// The OCID of the image originally used to launch the instance.
        /// </value>
        [JsonProperty(PropertyName = "baseImageId")]
        public string BaseImageId { get; set; }
        
        /// <value>
        /// The OCID of the compartment containing the instance you want to use as the basis for the image.
        /// 
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CompartmentId is required.")]
        [JsonProperty(PropertyName = "compartmentId")]
        public string CompartmentId { get; set; }
        
        /// <value>
        /// Whether instances launched with this image can be used to create new images.
        /// For example, you cannot create an image of an Oracle Database instance.
        /// <br/>
        /// Example: true
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CreateImageAllowed is required.")]
        [JsonProperty(PropertyName = "createImageAllowed")]
        public System.Nullable<bool> CreateImageAllowed { get; set; }
        
        /// <value>
        /// Defined tags for this resource. Each key is predefined and scoped to a
        /// namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Operations&quot;: {&quot;CostCenter&quot;: &quot;42&quot;}}
        /// </value>
        [JsonProperty(PropertyName = "definedTags")]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.Dictionary<string, System.Object>> DefinedTags { get; set; }
        
        /// <value>
        /// A user-friendly name for the image. It does not have to be unique, and it's changeable.
        /// Avoid entering confidential information.
        /// <br/>
        /// You cannot use a platform image name as a custom image name.
        /// <br/>
        /// Example: My custom Oracle Linux image
        /// </value>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }
        
        /// <value>
        /// Free-form tags for this resource. Each tag is a simple key-value pair with no
        /// predefined name, type, or namespace. For more information, see [Resource Tags](https://docs.cloud.oracle.com/iaas/Content/General/Concepts/resourcetags.htm).
        /// <br/>
        /// Example: {&quot;Department&quot;: &quot;Finance&quot;}
        /// </value>
        [JsonProperty(PropertyName = "freeformTags")]
        public System.Collections.Generic.Dictionary<string, string> FreeformTags { get; set; }
        
        /// <value>
        /// The OCID of the image.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "Id is required.")]
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
                ///
        /// <value>
        /// Specifies the configuration mode for launching virtual machine (VM) instances. The configuration modes are:
        /// * `NATIVE` - VM instances launch with iSCSI boot and VFIO devices. The default value for platform images.
        /// * `EMULATED` - VM instances launch with emulated devices, such as the E1000 network driver and emulated SCSI disk controller.
        /// * `PARAVIRTUALIZED` - VM instances launch with paravirtualized devices using VirtIO drivers.
        /// * `CUSTOM` - VM instances launch with custom configuration settings specified in the `LaunchOptions` parameter.
        /// 
        /// </value>
        ///
        public enum LaunchModeEnum {
            [EnumMember(Value = "NATIVE")]
            Native,
            [EnumMember(Value = "EMULATED")]
            Emulated,
            [EnumMember(Value = "PARAVIRTUALIZED")]
            Paravirtualized,
            [EnumMember(Value = "CUSTOM")]
            Custom
        };

        /// <value>
        /// Specifies the configuration mode for launching virtual machine (VM) instances. The configuration modes are:
        /// * `NATIVE` - VM instances launch with iSCSI boot and VFIO devices. The default value for platform images.
        /// * `EMULATED` - VM instances launch with emulated devices, such as the E1000 network driver and emulated SCSI disk controller.
        /// * `PARAVIRTUALIZED` - VM instances launch with paravirtualized devices using VirtIO drivers.
        /// * `CUSTOM` - VM instances launch with custom configuration settings specified in the `LaunchOptions` parameter.
        /// 
        /// </value>
        [JsonProperty(PropertyName = "launchMode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LaunchModeEnum> LaunchMode { get; set; }
        
        [JsonProperty(PropertyName = "launchOptions")]
        public LaunchOptions LaunchOptions { get; set; }
                ///
        ///
        public enum LifecycleStateEnum {
            [EnumMember(Value = "PROVISIONING")]
            Provisioning,
            [EnumMember(Value = "IMPORTING")]
            Importing,
            [EnumMember(Value = "AVAILABLE")]
            Available,
            [EnumMember(Value = "EXPORTING")]
            Exporting,
            [EnumMember(Value = "DISABLED")]
            Disabled,
            [EnumMember(Value = "DELETED")]
            Deleted
        };

        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "LifecycleState is required.")]
        [JsonProperty(PropertyName = "lifecycleState")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<LifecycleStateEnum> LifecycleState { get; set; }
        
        /// <value>
        /// The image's operating system.
        /// <br/>
        /// Example: Oracle Linux
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatingSystem is required.")]
        [JsonProperty(PropertyName = "operatingSystem")]
        public string OperatingSystem { get; set; }
        
        /// <value>
        /// The image's operating system version.
        /// <br/>
        /// Example: 7.2
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OperatingSystemVersion is required.")]
        [JsonProperty(PropertyName = "operatingSystemVersion")]
        public string OperatingSystemVersion { get; set; }
        
        [JsonProperty(PropertyName = "agentFeatures")]
        public InstanceAgentFeatures AgentFeatures { get; set; }
                ///
        /// <value>
        /// The listing type of the image. The default value is \"NONE\".
        /// </value>
        ///
        public enum ListingTypeEnum {
            [EnumMember(Value = "COMMUNITY")]
            Community,
            [EnumMember(Value = "NONE")]
            None
        };

        /// <value>
        /// The listing type of the image. The default value is \"NONE\".
        /// </value>
        [JsonProperty(PropertyName = "listingType")]
        [JsonConverter(typeof(StringEnumConverter))]
        public System.Nullable<ListingTypeEnum> ListingType { get; set; }
        
        /// <value>
        /// The boot volume size for an instance launched from this image (1 MB = 1,048,576 bytes).
        /// Note this is not the same as the size of the image when it was exported or the actual size of the image.
        /// <br/>
        /// Example: 47694
        /// </value>
        [JsonProperty(PropertyName = "sizeInMBs")]
        public System.Nullable<long> SizeInMBs { get; set; }
        
        /// <value>
        /// The size of the internal storage for this image that is subject to billing (1 GB = 1,073,741,824 bytes).
        /// <br/>
        /// Example: 100
        /// </value>
        [JsonProperty(PropertyName = "billableSizeInGBs")]
        public System.Nullable<long> BillableSizeInGBs { get; set; }
        
        /// <value>
        /// The date and time the image was created, in the format defined by [RFC3339](https://tools.ietf.org/html/rfc3339).
        /// <br/>
        /// Example: 2016-08-25T21:10:29.600Z
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "TimeCreated is required.")]
        [JsonProperty(PropertyName = "timeCreated")]
        public System.Nullable<System.DateTime> TimeCreated { get; set; }
        
    }
}
