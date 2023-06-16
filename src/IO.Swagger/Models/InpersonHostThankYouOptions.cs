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
    public partial class InpersonHostThankYouOptions : IEquatable<InpersonHostThankYouOptions>
    { 
        /// <summary>
        /// title
        /// </summary>
        /// <value>title</value>
        [Required]

        [DataMember(Name="title")]
        public bool? Title { get; set; }

        /// <summary>
        /// body
        /// </summary>
        /// <value>body</value>
        [Required]

        [DataMember(Name="body")]
        public bool? Body { get; set; }

        /// <summary>
        /// recipientName
        /// </summary>
        /// <value>recipientName</value>
        [Required]

        [DataMember(Name="recipientName")]
        public bool? RecipientName { get; set; }

        /// <summary>
        /// recipientEmail
        /// </summary>
        /// <value>recipientEmail</value>
        [Required]

        [DataMember(Name="recipientEmail")]
        public bool? RecipientEmail { get; set; }

        /// <summary>
        /// recipientRole
        /// </summary>
        /// <value>recipientRole</value>
        [Required]

        [DataMember(Name="recipientRole")]
        public bool? RecipientRole { get; set; }

        /// <summary>
        /// recipientStatus
        /// </summary>
        /// <value>recipientStatus</value>
        [Required]

        [DataMember(Name="recipientStatus")]
        public bool? RecipientStatus { get; set; }

        /// <summary>
        /// downloadButton
        /// </summary>
        /// <value>downloadButton</value>
        [Required]

        [DataMember(Name="downloadButton")]
        public bool? DownloadButton { get; set; }

        /// <summary>
        /// reviewDocumentsButton
        /// </summary>
        /// <value>reviewDocumentsButton</value>
        [Required]

        [DataMember(Name="reviewDocumentsButton")]
        public bool? ReviewDocumentsButton { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InpersonHostThankYouOptions {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
            sb.Append("  RecipientEmail: ").Append(RecipientEmail).Append("\n");
            sb.Append("  RecipientRole: ").Append(RecipientRole).Append("\n");
            sb.Append("  RecipientStatus: ").Append(RecipientStatus).Append("\n");
            sb.Append("  DownloadButton: ").Append(DownloadButton).Append("\n");
            sb.Append("  ReviewDocumentsButton: ").Append(ReviewDocumentsButton).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InpersonHostThankYouOptions)obj);
        }

        /// <summary>
        /// Returns true if InpersonHostThankYouOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of InpersonHostThankYouOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InpersonHostThankYouOptions other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Title == other.Title ||
                    Title != null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Body == other.Body ||
                    Body != null &&
                    Body.Equals(other.Body)
                ) && 
                (
                    RecipientName == other.RecipientName ||
                    RecipientName != null &&
                    RecipientName.Equals(other.RecipientName)
                ) && 
                (
                    RecipientEmail == other.RecipientEmail ||
                    RecipientEmail != null &&
                    RecipientEmail.Equals(other.RecipientEmail)
                ) && 
                (
                    RecipientRole == other.RecipientRole ||
                    RecipientRole != null &&
                    RecipientRole.Equals(other.RecipientRole)
                ) && 
                (
                    RecipientStatus == other.RecipientStatus ||
                    RecipientStatus != null &&
                    RecipientStatus.Equals(other.RecipientStatus)
                ) && 
                (
                    DownloadButton == other.DownloadButton ||
                    DownloadButton != null &&
                    DownloadButton.Equals(other.DownloadButton)
                ) && 
                (
                    ReviewDocumentsButton == other.ReviewDocumentsButton ||
                    ReviewDocumentsButton != null &&
                    ReviewDocumentsButton.Equals(other.ReviewDocumentsButton)
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
                    if (Title != null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    if (Body != null)
                    hashCode = hashCode * 59 + Body.GetHashCode();
                    if (RecipientName != null)
                    hashCode = hashCode * 59 + RecipientName.GetHashCode();
                    if (RecipientEmail != null)
                    hashCode = hashCode * 59 + RecipientEmail.GetHashCode();
                    if (RecipientRole != null)
                    hashCode = hashCode * 59 + RecipientRole.GetHashCode();
                    if (RecipientStatus != null)
                    hashCode = hashCode * 59 + RecipientStatus.GetHashCode();
                    if (DownloadButton != null)
                    hashCode = hashCode * 59 + DownloadButton.GetHashCode();
                    if (ReviewDocumentsButton != null)
                    hashCode = hashCode * 59 + ReviewDocumentsButton.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InpersonHostThankYouOptions left, InpersonHostThankYouOptions right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InpersonHostThankYouOptions left, InpersonHostThankYouOptions right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
