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
    public partial class Delivery : IEquatable<Delivery>
    { 
        /// <summary>
        /// Provider
        /// </summary>
        /// <value>Provider</value>
        [Required]

        [DataMember(Name="provider")]
        public bool? Provider { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [Required]

        [DataMember(Name="email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Download
        /// </summary>
        /// <value>Download</value>
        [Required]

        [DataMember(Name="download")]
        public bool? Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Delivery {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Delivery)obj);
        }

        /// <summary>
        /// Returns true if Delivery instances are equal
        /// </summary>
        /// <param name="other">Instance of Delivery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Delivery other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Provider == other.Provider ||
                    Provider != null &&
                    Provider.Equals(other.Provider)
                ) && 
                (
                    Email == other.Email ||
                    Email != null &&
                    Email.Equals(other.Email)
                ) && 
                (
                    Download == other.Download ||
                    Download != null &&
                    Download.Equals(other.Download)
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
                    if (Provider != null)
                    hashCode = hashCode * 59 + Provider.GetHashCode();
                    if (Email != null)
                    hashCode = hashCode * 59 + Email.GetHashCode();
                    if (Download != null)
                    hashCode = hashCode * 59 + Download.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Delivery left, Delivery right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Delivery left, Delivery right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
