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
    public partial class IdvWorkflow : IEquatable<IdvWorkflow>
    { 
        /// <summary>
        /// 00000000-0000-0001-0000-200000000055
        /// </summary>
        /// <value>00000000-0000-0001-0000-200000000055</value>

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// DV
        /// </summary>
        /// <value>DV</value>

        [DataMember(Name="type")]
        public string Type { get; set; }

        /// <summary>
        /// oss
        /// </summary>
        /// <value>oss</value>

        [DataMember(Name="tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// This is Mitek Document verification only Mock workflow.
        /// </summary>
        /// <value>This is Mitek Document verification only Mock workflow.</value>

        [DataMember(Name="desc")]
        public string Desc { get; set; }

        /// <summary>
        /// Gets or Sets SkipWhenAccessingSignedDocuments
        /// </summary>

        [DataMember(Name="skipWhenAccessingSignedDocuments")]
        public bool? SkipWhenAccessingSignedDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdvWorkflow {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  SkipWhenAccessingSignedDocuments: ").Append(SkipWhenAccessingSignedDocuments).Append("\n");
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
            return obj.GetType() == GetType() && Equals((IdvWorkflow)obj);
        }

        /// <summary>
        /// Returns true if IdvWorkflow instances are equal
        /// </summary>
        /// <param name="other">Instance of IdvWorkflow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdvWorkflow other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Tenant == other.Tenant ||
                    Tenant != null &&
                    Tenant.Equals(other.Tenant)
                ) && 
                (
                    Desc == other.Desc ||
                    Desc != null &&
                    Desc.Equals(other.Desc)
                ) && 
                (
                    SkipWhenAccessingSignedDocuments == other.SkipWhenAccessingSignedDocuments ||
                    SkipWhenAccessingSignedDocuments != null &&
                    SkipWhenAccessingSignedDocuments.Equals(other.SkipWhenAccessingSignedDocuments)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Tenant != null)
                    hashCode = hashCode * 59 + Tenant.GetHashCode();
                    if (Desc != null)
                    hashCode = hashCode * 59 + Desc.GetHashCode();
                    if (SkipWhenAccessingSignedDocuments != null)
                    hashCode = hashCode * 59 + SkipWhenAccessingSignedDocuments.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(IdvWorkflow left, IdvWorkflow right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(IdvWorkflow left, IdvWorkflow right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
