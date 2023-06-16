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
    public partial class CompletionReport : IEquatable<CompletionReport>
    { 
        /// <summary>
        /// Gets or Sets From
        /// </summary>

        [DataMember(Name="from")]
        public DateTime? From { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>

        [DataMember(Name="to")]
        public DateTime? To { get; set; }

        /// <summary>
        /// The usage list
        /// </summary>
        /// <value>The usage list</value>

        [DataMember(Name="senders")]
        public List<Sender> Senders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompletionReport {\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Senders: ").Append(Senders).Append("\n");
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
            return obj.GetType() == GetType() && Equals((CompletionReport)obj);
        }

        /// <summary>
        /// Returns true if CompletionReport instances are equal
        /// </summary>
        /// <param name="other">Instance of CompletionReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompletionReport other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    From == other.From ||
                    From != null &&
                    From.Equals(other.From)
                ) && 
                (
                    To == other.To ||
                    To != null &&
                    To.Equals(other.To)
                ) && 
                (
                    Senders == other.Senders ||
                    Senders != null &&
                    Senders.SequenceEqual(other.Senders)
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
                    if (From != null)
                    hashCode = hashCode * 59 + From.GetHashCode();
                    if (To != null)
                    hashCode = hashCode * 59 + To.GetHashCode();
                    if (Senders != null)
                    hashCode = hashCode * 59 + Senders.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(CompletionReport left, CompletionReport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CompletionReport left, CompletionReport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
