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
    public partial class UserAccountRole : IEquatable<UserAccountRole>
    { 
        /// <summary>
        /// account Id
        /// </summary>
        /// <value>account Id</value>
        [Required]

        [DataMember(Name="accountId")]
        public string AccountId { get; set; }

        /// <summary>
        /// user Id
        /// </summary>
        /// <value>user Id</value>

        [DataMember(Name="userId")]
        public string UserId { get; set; }

        /// <summary>
        /// accountrole list
        /// </summary>
        /// <value>accountrole list</value>
        [Required]

        [DataMember(Name="accountRoles")]
        public List<AccountRole> AccountRoles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccountRole {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccountRoles: ").Append(AccountRoles).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserAccountRole)obj);
        }

        /// <summary>
        /// Returns true if UserAccountRole instances are equal
        /// </summary>
        /// <param name="other">Instance of UserAccountRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAccountRole other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccountId == other.AccountId ||
                    AccountId != null &&
                    AccountId.Equals(other.AccountId)
                ) && 
                (
                    UserId == other.UserId ||
                    UserId != null &&
                    UserId.Equals(other.UserId)
                ) && 
                (
                    AccountRoles == other.AccountRoles ||
                    AccountRoles != null &&
                    AccountRoles.SequenceEqual(other.AccountRoles)
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
                    if (AccountId != null)
                    hashCode = hashCode * 59 + AccountId.GetHashCode();
                    if (UserId != null)
                    hashCode = hashCode * 59 + UserId.GetHashCode();
                    if (AccountRoles != null)
                    hashCode = hashCode * 59 + AccountRoles.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(UserAccountRole left, UserAccountRole right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserAccountRole left, UserAccountRole right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
