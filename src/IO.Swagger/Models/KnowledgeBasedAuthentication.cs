/*
 * ONESPAN SIGN API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 11.51
 * Contact: support@onespan.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class KnowledgeBasedAuthentication : IEquatable<KnowledgeBasedAuthentication>
    { 
        /// <summary>
        /// SignerInformationForEquifaxCanada
        /// </summary>
        /// <value>SignerInformationForEquifaxCanada</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum KnowledgeBasedAuthenticationStatusEnum
        {
            /// <summary>
            /// Enum NOTYETATTEMPTEDEnum for NOT_YET_ATTEMPTED
            /// </summary>
            [EnumMember(Value = "NOT_YET_ATTEMPTED")]
            NOTYETATTEMPTEDEnum = 0,
            /// <summary>
            /// Enum PASSEDEnum for PASSED
            /// </summary>
            [EnumMember(Value = "PASSED")]
            PASSEDEnum = 1,
            /// <summary>
            /// Enum FAILEDEnum for FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILEDEnum = 2,
            /// <summary>
            /// Enum INVALIDSIGNEREnum for INVALID_SIGNER
            /// </summary>
            [EnumMember(Value = "INVALID_SIGNER")]
            INVALIDSIGNEREnum = 3,
            /// <summary>
            /// Enum UPDATEDEnum for UPDATED
            /// </summary>
            [EnumMember(Value = "UPDATED")]
            UPDATEDEnum = 4        }

        /// <summary>
        /// SignerInformationForEquifaxCanada
        /// </summary>
        /// <value>SignerInformationForEquifaxCanada</value>

        [DataMember(Name="knowledgeBasedAuthenticationStatus")]
        public KnowledgeBasedAuthenticationStatusEnum? KnowledgeBasedAuthenticationStatus { get; set; }

        /// <summary>
        /// Gets or Sets SignerInformationForEquifaxCanada
        /// </summary>

        [DataMember(Name="signerInformationForEquifaxCanada")]
        public SignerInformationForEquifaxCanada SignerInformationForEquifaxCanada { get; set; }

        /// <summary>
        /// Gets or Sets SignerInformationForEquifaxUSA
        /// </summary>

        [DataMember(Name="signerInformationForEquifaxUSA")]
        public SignerInformationForEquifaxUSA SignerInformationForEquifaxUSA { get; set; }

        /// <summary>
        /// Gets or Sets EquifaxCanada
        /// </summary>

        [DataMember(Name="equifaxCanada")]
        public bool? EquifaxCanada { get; set; }

        /// <summary>
        /// Gets or Sets EquifaxUSA
        /// </summary>

        [DataMember(Name="equifaxUSA")]
        public bool? EquifaxUSA { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeBasedAuthentication {\n");
            sb.Append("  KnowledgeBasedAuthenticationStatus: ").Append(KnowledgeBasedAuthenticationStatus).Append("\n");
            sb.Append("  SignerInformationForEquifaxCanada: ").Append(SignerInformationForEquifaxCanada).Append("\n");
            sb.Append("  SignerInformationForEquifaxUSA: ").Append(SignerInformationForEquifaxUSA).Append("\n");
            sb.Append("  EquifaxCanada: ").Append(EquifaxCanada).Append("\n");
            sb.Append("  EquifaxUSA: ").Append(EquifaxUSA).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((KnowledgeBasedAuthentication)obj);
        }

        /// <summary>
        /// Returns true if KnowledgeBasedAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of KnowledgeBasedAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KnowledgeBasedAuthentication other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    KnowledgeBasedAuthenticationStatus == other.KnowledgeBasedAuthenticationStatus ||
                    KnowledgeBasedAuthenticationStatus != null &&
                    KnowledgeBasedAuthenticationStatus.Equals(other.KnowledgeBasedAuthenticationStatus)
                ) && 
                (
                    SignerInformationForEquifaxCanada == other.SignerInformationForEquifaxCanada ||
                    SignerInformationForEquifaxCanada != null &&
                    SignerInformationForEquifaxCanada.Equals(other.SignerInformationForEquifaxCanada)
                ) && 
                (
                    SignerInformationForEquifaxUSA == other.SignerInformationForEquifaxUSA ||
                    SignerInformationForEquifaxUSA != null &&
                    SignerInformationForEquifaxUSA.Equals(other.SignerInformationForEquifaxUSA)
                ) && 
                (
                    EquifaxCanada == other.EquifaxCanada ||
                    EquifaxCanada != null &&
                    EquifaxCanada.Equals(other.EquifaxCanada)
                ) && 
                (
                    EquifaxUSA == other.EquifaxUSA ||
                    EquifaxUSA != null &&
                    EquifaxUSA.Equals(other.EquifaxUSA)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (KnowledgeBasedAuthenticationStatus != null)
                    hashCode = hashCode * 59 + KnowledgeBasedAuthenticationStatus.GetHashCode();
                    if (SignerInformationForEquifaxCanada != null)
                    hashCode = hashCode * 59 + SignerInformationForEquifaxCanada.GetHashCode();
                    if (SignerInformationForEquifaxUSA != null)
                    hashCode = hashCode * 59 + SignerInformationForEquifaxUSA.GetHashCode();
                    if (EquifaxCanada != null)
                    hashCode = hashCode * 59 + EquifaxCanada.GetHashCode();
                    if (EquifaxUSA != null)
                    hashCode = hashCode * 59 + EquifaxUSA.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(KnowledgeBasedAuthentication left, KnowledgeBasedAuthentication right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(KnowledgeBasedAuthentication left, KnowledgeBasedAuthentication right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
