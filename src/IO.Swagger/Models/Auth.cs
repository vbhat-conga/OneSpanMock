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
    public partial class Auth : IEquatable<Auth>
    { 
        /// <summary>
        /// Scheme
        /// </summary>
        /// <value>Scheme</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SchemeEnum
        {
            /// <summary>
            /// Enum NONEEnum for NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONEEnum = 0,
            /// <summary>
            /// Enum PROVIDEREnum for PROVIDER
            /// </summary>
            [EnumMember(Value = "PROVIDER")]
            PROVIDEREnum = 1,
            /// <summary>
            /// Enum CHALLENGEEnum for CHALLENGE
            /// </summary>
            [EnumMember(Value = "CHALLENGE")]
            CHALLENGEEnum = 2,
            /// <summary>
            /// Enum SMSEnum for SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMSEnum = 3,
            /// <summary>
            /// Enum SSOEnum for SSO
            /// </summary>
            [EnumMember(Value = "SSO")]
            SSOEnum = 4,
            /// <summary>
            /// Enum KBAEnum for KBA
            /// </summary>
            [EnumMember(Value = "KBA")]
            KBAEnum = 5,
            /// <summary>
            /// Enum SAAEnum for SAA
            /// </summary>
            [EnumMember(Value = "SAA")]
            SAAEnum = 6        }

        /// <summary>
        /// Scheme
        /// </summary>
        /// <value>Scheme</value>
        [Required]

        [DataMember(Name="scheme")]
        public SchemeEnum? Scheme { get; set; }

        /// <summary>
        /// Challenges
        /// </summary>
        /// <value>Challenges</value>
        [Required]

        [DataMember(Name="challenges")]
        public List<AuthChallenge> Challenges { get; set; }

        /// <summary>
        /// Idv Workflow configuration
        /// </summary>
        /// <value>Idv Workflow configuration</value>

        [DataMember(Name="idvWorkflow")]
        public List<IdvWorkflow> IdvWorkflow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Auth {\n");
            sb.Append("  Scheme: ").Append(Scheme).Append("\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
            sb.Append("  IdvWorkflow: ").Append(IdvWorkflow).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Auth)obj);
        }

        /// <summary>
        /// Returns true if Auth instances are equal
        /// </summary>
        /// <param name="other">Instance of Auth to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Auth other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Scheme == other.Scheme ||
                    Scheme != null &&
                    Scheme.Equals(other.Scheme)
                ) && 
                (
                    Challenges == other.Challenges ||
                    Challenges != null &&
                    Challenges.SequenceEqual(other.Challenges)
                ) && 
                (
                    IdvWorkflow == other.IdvWorkflow ||
                    IdvWorkflow != null &&
                    IdvWorkflow.SequenceEqual(other.IdvWorkflow)
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
                    if (Scheme != null)
                    hashCode = hashCode * 59 + Scheme.GetHashCode();
                    if (Challenges != null)
                    hashCode = hashCode * 59 + Challenges.GetHashCode();
                    if (IdvWorkflow != null)
                    hashCode = hashCode * 59 + IdvWorkflow.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Auth left, Auth right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Auth left, Auth right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
