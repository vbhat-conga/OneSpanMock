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
    /// Account Configuration
    /// </summary>
    [DataContract]
    public partial class AccountConfiguration : IEquatable<AccountConfiguration>
    { 
        /// <summary>
        /// Gets or Sets AccountFeatureSettings
        /// </summary>

        [DataMember(Name="accountFeatureSettings")]
        public AccountFeatureSettings AccountFeatureSettings { get; set; }

        /// <summary>
        /// Gets or Sets AccountPackageSettings
        /// </summary>

        [DataMember(Name="accountPackageSettings")]
        public AccountPackageSettings AccountPackageSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountConfiguration {\n");
            sb.Append("  AccountFeatureSettings: ").Append(AccountFeatureSettings).Append("\n");
            sb.Append("  AccountPackageSettings: ").Append(AccountPackageSettings).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountConfiguration)obj);
        }

        /// <summary>
        /// Returns true if AccountConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountConfiguration other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccountFeatureSettings == other.AccountFeatureSettings ||
                    AccountFeatureSettings != null &&
                    AccountFeatureSettings.Equals(other.AccountFeatureSettings)
                ) && 
                (
                    AccountPackageSettings == other.AccountPackageSettings ||
                    AccountPackageSettings != null &&
                    AccountPackageSettings.Equals(other.AccountPackageSettings)
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
                    if (AccountFeatureSettings != null)
                    hashCode = hashCode * 59 + AccountFeatureSettings.GetHashCode();
                    if (AccountPackageSettings != null)
                    hashCode = hashCode * 59 + AccountPackageSettings.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountConfiguration left, AccountConfiguration right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountConfiguration left, AccountConfiguration right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}