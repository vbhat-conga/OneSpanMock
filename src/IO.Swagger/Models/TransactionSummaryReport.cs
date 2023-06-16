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
    public partial class TransactionSummaryReport : IEquatable<TransactionSummaryReport>
    { 
        /// <summary>
        /// The transaction list
        /// </summary>
        /// <value>The transaction list</value>

        [DataMember(Name="content")]
        public List<Package> Content { get; set; }

        /// <summary>
        /// Tocal records count, used for pagination
        /// </summary>
        /// <value>Tocal records count, used for pagination</value>

        [DataMember(Name="totalElements")]
        public int? TotalElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionSummaryReport {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
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
            return obj.GetType() == GetType() && Equals((TransactionSummaryReport)obj);
        }

        /// <summary>
        /// Returns true if TransactionSummaryReport instances are equal
        /// </summary>
        /// <param name="other">Instance of TransactionSummaryReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionSummaryReport other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Content == other.Content ||
                    Content != null &&
                    Content.SequenceEqual(other.Content)
                ) && 
                (
                    TotalElements == other.TotalElements ||
                    TotalElements != null &&
                    TotalElements.Equals(other.TotalElements)
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
                    if (Content != null)
                    hashCode = hashCode * 59 + Content.GetHashCode();
                    if (TotalElements != null)
                    hashCode = hashCode * 59 + TotalElements.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TransactionSummaryReport left, TransactionSummaryReport right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TransactionSummaryReport left, TransactionSummaryReport right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}