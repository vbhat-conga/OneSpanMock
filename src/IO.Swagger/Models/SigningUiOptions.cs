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
    /// Signing UI Options
    /// </summary>
    [DataContract]
    public partial class SigningUiOptions : IEquatable<SigningUiOptions>
    { 
        /// <summary>
        /// Gets or Sets CompleteSummaryOptions
        /// </summary>

        [DataMember(Name="completeSummaryOptions")]
        public CompleteSummaryOptions CompleteSummaryOptions { get; set; }

        /// <summary>
        /// Gets or Sets InpersonWelcomeOptions
        /// </summary>

        [DataMember(Name="inpersonWelcomeOptions")]
        public InpersonWelcomeOptions InpersonWelcomeOptions { get; set; }

        /// <summary>
        /// Gets or Sets InpersonHostThankYouOptions
        /// </summary>

        [DataMember(Name="inpersonHostThankYouOptions")]
        public InpersonHostThankYouOptions InpersonHostThankYouOptions { get; set; }

        /// <summary>
        /// Gets or Sets NotaryWelcomeOptions
        /// </summary>

        [DataMember(Name="notaryWelcomeOptions")]
        public NotaryWelcomeOptions NotaryWelcomeOptions { get; set; }

        /// <summary>
        /// Gets or Sets NotaryHostThankYouOptions
        /// </summary>

        [DataMember(Name="notaryHostThankYouOptions")]
        public NotaryHostThankYouOptions NotaryHostThankYouOptions { get; set; }

        /// <summary>
        /// Gets or Sets OverviewOptions
        /// </summary>

        [DataMember(Name="overviewOptions")]
        public OverviewOptions OverviewOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningUiOptions {\n");
            sb.Append("  CompleteSummaryOptions: ").Append(CompleteSummaryOptions).Append("\n");
            sb.Append("  InpersonWelcomeOptions: ").Append(InpersonWelcomeOptions).Append("\n");
            sb.Append("  InpersonHostThankYouOptions: ").Append(InpersonHostThankYouOptions).Append("\n");
            sb.Append("  NotaryWelcomeOptions: ").Append(NotaryWelcomeOptions).Append("\n");
            sb.Append("  NotaryHostThankYouOptions: ").Append(NotaryHostThankYouOptions).Append("\n");
            sb.Append("  OverviewOptions: ").Append(OverviewOptions).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SigningUiOptions)obj);
        }

        /// <summary>
        /// Returns true if SigningUiOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of SigningUiOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningUiOptions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CompleteSummaryOptions == other.CompleteSummaryOptions ||
                    CompleteSummaryOptions != null &&
                    CompleteSummaryOptions.Equals(other.CompleteSummaryOptions)
                ) && 
                (
                    InpersonWelcomeOptions == other.InpersonWelcomeOptions ||
                    InpersonWelcomeOptions != null &&
                    InpersonWelcomeOptions.Equals(other.InpersonWelcomeOptions)
                ) && 
                (
                    InpersonHostThankYouOptions == other.InpersonHostThankYouOptions ||
                    InpersonHostThankYouOptions != null &&
                    InpersonHostThankYouOptions.Equals(other.InpersonHostThankYouOptions)
                ) && 
                (
                    NotaryWelcomeOptions == other.NotaryWelcomeOptions ||
                    NotaryWelcomeOptions != null &&
                    NotaryWelcomeOptions.Equals(other.NotaryWelcomeOptions)
                ) && 
                (
                    NotaryHostThankYouOptions == other.NotaryHostThankYouOptions ||
                    NotaryHostThankYouOptions != null &&
                    NotaryHostThankYouOptions.Equals(other.NotaryHostThankYouOptions)
                ) && 
                (
                    OverviewOptions == other.OverviewOptions ||
                    OverviewOptions != null &&
                    OverviewOptions.Equals(other.OverviewOptions)
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
                    if (CompleteSummaryOptions != null)
                    hashCode = hashCode * 59 + CompleteSummaryOptions.GetHashCode();
                    if (InpersonWelcomeOptions != null)
                    hashCode = hashCode * 59 + InpersonWelcomeOptions.GetHashCode();
                    if (InpersonHostThankYouOptions != null)
                    hashCode = hashCode * 59 + InpersonHostThankYouOptions.GetHashCode();
                    if (NotaryWelcomeOptions != null)
                    hashCode = hashCode * 59 + NotaryWelcomeOptions.GetHashCode();
                    if (NotaryHostThankYouOptions != null)
                    hashCode = hashCode * 59 + NotaryHostThankYouOptions.GetHashCode();
                    if (OverviewOptions != null)
                    hashCode = hashCode * 59 + OverviewOptions.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SigningUiOptions left, SigningUiOptions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SigningUiOptions left, SigningUiOptions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}