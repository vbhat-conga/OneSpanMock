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
    public partial class AccountRole : IEquatable<AccountRole>
    { 
        /// <summary>
        /// Automatically generated guid
        /// </summary>
        /// <value>Automatically generated guid</value>
        [Required]

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Permissions
        /// </summary>
        /// <value>Permissions</value>

        [DataMember(Name="permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Descriptions
        /// </summary>
        /// <value>Descriptions</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>

        [DataMember(Name="enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// True when the role was created in a parent sub-account.
        /// </summary>
        /// <value>True when the role was created in a parent sub-account.</value>

        [DataMember(Name="inherited")]
        public bool? Inherited { get; set; }

        /// <summary>
        /// True when the role is defined by OneSpan and uneditable. False when the role is managed by your account and editable (Role Management permission required for editing a role).
        /// </summary>
        /// <value>True when the role is defined by OneSpan and uneditable. False when the role is managed by your account and editable (Role Management permission required for editing a role).</value>

        [DataMember(Name="predefined")]
        public bool? Predefined { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Inherited: ").Append(Inherited).Append("\n");
            sb.Append("  Predefined: ").Append(Predefined).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountRole)obj);
        }

        /// <summary>
        /// Returns true if AccountRole instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountRole other)
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
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Permissions == other.Permissions ||
                    Permissions != null &&
                    Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Enabled == other.Enabled ||
                    Enabled != null &&
                    Enabled.Equals(other.Enabled)
                ) && 
                (
                    Inherited == other.Inherited ||
                    Inherited != null &&
                    Inherited.Equals(other.Inherited)
                ) && 
                (
                    Predefined == other.Predefined ||
                    Predefined != null &&
                    Predefined.Equals(other.Predefined)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Permissions != null)
                    hashCode = hashCode * 59 + Permissions.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Enabled != null)
                    hashCode = hashCode * 59 + Enabled.GetHashCode();
                    if (Inherited != null)
                    hashCode = hashCode * 59 + Inherited.GetHashCode();
                    if (Predefined != null)
                    hashCode = hashCode * 59 + Predefined.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountRole left, AccountRole right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountRole left, AccountRole right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
