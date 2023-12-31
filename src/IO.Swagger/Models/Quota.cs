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
    public partial class Quota : IEquatable<Quota>
    { 
        /// <summary>
        /// Target
        /// </summary>
        /// <value>Target</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TargetEnum
        {
            /// <summary>
            /// Enum SIGNEREnum for SIGNER
            /// </summary>
            [EnumMember(Value = "SIGNER")]
            SIGNEREnum = 0,
            /// <summary>
            /// Enum SENDEREnum for SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDEREnum = 1,
            /// <summary>
            /// Enum DOCUMENTEnum for DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENTEnum = 2,
            /// <summary>
            /// Enum PACKAGEEnum for PACKAGE
            /// </summary>
            [EnumMember(Value = "PACKAGE")]
            PACKAGEEnum = 3,
            /// <summary>
            /// Enum STORAGEEnum for STORAGE
            /// </summary>
            [EnumMember(Value = "STORAGE")]
            STORAGEEnum = 4        }

        /// <summary>
        /// Target
        /// </summary>
        /// <value>Target</value>
        [Required]

        [DataMember(Name="target")]
        public TargetEnum? Target { get; set; }

        /// <summary>
        /// Cycle
        /// </summary>
        /// <value>Cycle</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CycleEnum
        {
            /// <summary>
            /// Enum DAYEnum for DAY
            /// </summary>
            [EnumMember(Value = "DAY")]
            DAYEnum = 0,
            /// <summary>
            /// Enum MONTHEnum for MONTH
            /// </summary>
            [EnumMember(Value = "MONTH")]
            MONTHEnum = 1,
            /// <summary>
            /// Enum YEAREnum for YEAR
            /// </summary>
            [EnumMember(Value = "YEAR")]
            YEAREnum = 2        }

        /// <summary>
        /// Cycle
        /// </summary>
        /// <value>Cycle</value>

        [DataMember(Name="cycle")]
        public CycleEnum? Cycle { get; set; }

        /// <summary>
        /// Scope
        /// </summary>
        /// <value>Scope</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Enum SENDEREnum for SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDEREnum = 0,
            /// <summary>
            /// Enum DOCUMENTEnum for DOCUMENT
            /// </summary>
            [EnumMember(Value = "DOCUMENT")]
            DOCUMENTEnum = 1,
            /// <summary>
            /// Enum PACKAGEEnum for PACKAGE
            /// </summary>
            [EnumMember(Value = "PACKAGE")]
            PACKAGEEnum = 2,
            /// <summary>
            /// Enum ACCOUNTEnum for ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNTEnum = 3        }

        /// <summary>
        /// Scope
        /// </summary>
        /// <value>Scope</value>

        [DataMember(Name="scope")]
        public ScopeEnum? Scope { get; set; }

        /// <summary>
        /// Limit
        /// </summary>
        /// <value>Limit</value>
        [Required]

        [DataMember(Name="limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quota {\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Cycle: ").Append(Cycle).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Quota)obj);
        }

        /// <summary>
        /// Returns true if Quota instances are equal
        /// </summary>
        /// <param name="other">Instance of Quota to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quota other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Target == other.Target ||
                    Target != null &&
                    Target.Equals(other.Target)
                ) && 
                (
                    Cycle == other.Cycle ||
                    Cycle != null &&
                    Cycle.Equals(other.Cycle)
                ) && 
                (
                    Scope == other.Scope ||
                    Scope != null &&
                    Scope.Equals(other.Scope)
                ) && 
                (
                    Limit == other.Limit ||
                    Limit != null &&
                    Limit.Equals(other.Limit)
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
                    if (Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();
                    if (Cycle != null)
                    hashCode = hashCode * 59 + Cycle.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                    if (Limit != null)
                    hashCode = hashCode * 59 + Limit.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Quota left, Quota right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Quota left, Quota right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
