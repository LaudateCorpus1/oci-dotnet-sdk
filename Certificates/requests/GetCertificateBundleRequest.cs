/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Oci.CertificatesService.Models;

namespace Oci.CertificatesService.Requests
{
    /// <example>
    /// Click <a href="https://docs.cloud.oracle.com/en-us/iaas/tools/dot-net-examples/latest/certificates/GetCertificateBundle.cs.html">here</a> to see an example of how to use GetCertificateBundle request.
    /// </example>
    public class GetCertificateBundleRequest : Oci.Common.IOciRequest
    {
        
        /// <value>
        /// The OCID of the certificate.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "CertificateId is required.")]
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Path, "certificateId")]
        public string CertificateId { get; set; }
        
        /// <value>
        /// Unique Oracle-assigned identifier for the request. If you need to contact Oracle about a particular request,
        /// please provide the request ID.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Header, "opc-request-id")]
        public string OpcRequestId { get; set; }
        
        /// <value>
        /// The version number of the certificate. The default value is 0, which means that this query parameter is ignored.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "versionNumber")]
        public System.Nullable<long> VersionNumber { get; set; }
        
        /// <value>
        /// The name of the certificate. (This might be referred to as the name of the certificate version, as every certificate consists of at least one version.) Names are unique across versions of a given certificate.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "certificateVersionName")]
        public string CertificateVersionName { get; set; }
        
        ///
        /// <value>
        /// The rotation state of the certificate version.
        /// </value>
        ///
        public enum StageEnum {
            [EnumMember(Value = "CURRENT")]
            Current,
            [EnumMember(Value = "PENDING")]
            Pending,
            [EnumMember(Value = "LATEST")]
            Latest,
            [EnumMember(Value = "PREVIOUS")]
            Previous,
            [EnumMember(Value = "DEPRECATED")]
            Deprecated
        };

        /// <value>
        /// The rotation state of the certificate version.
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "stage")]
        public System.Nullable<StageEnum> Stage { get; set; }
        
        ///
        /// <value>
        /// The type of certificate bundle. By default, the private key fields are not returned. When querying for certificate bundles, to return results with certificate contents, the private key in PEM format, and the private key passphrase, specify the value of this parameter as `CERTIFICATE_CONTENT_WITH_PRIVATE_KEY`.
        /// 
        /// </value>
        ///
        public enum CertificateBundleTypeEnum {
            [EnumMember(Value = "CERTIFICATE_CONTENT_PUBLIC_ONLY")]
            CertificateContentPublicOnly,
            [EnumMember(Value = "CERTIFICATE_CONTENT_WITH_PRIVATE_KEY")]
            CertificateContentWithPrivateKey
        };

        /// <value>
        /// The type of certificate bundle. By default, the private key fields are not returned. When querying for certificate bundles, to return results with certificate contents, the private key in PEM format, and the private key passphrase, specify the value of this parameter as `CERTIFICATE_CONTENT_WITH_PRIVATE_KEY`.
        /// 
        /// </value>
        [Oci.Common.Http.HttpConverter(Oci.Common.Http.TargetEnum.Query, "certificateBundleType")]
        public System.Nullable<CertificateBundleTypeEnum> CertificateBundleType { get; set; }
    }
}
