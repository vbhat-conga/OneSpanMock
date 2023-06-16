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
    public partial class AuditEvent : IEquatable<AuditEvent>
    { 
        /// <summary>
        /// The target type.
        /// </summary>
        /// <value>The target type.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TargetTypeEnum
        {
            /// <summary>
            /// Enum DocumentEnum for Document
            /// </summary>
            [EnumMember(Value = "Document")]
            DocumentEnum = 0,
            /// <summary>
            /// Enum PackageEnum for Package
            /// </summary>
            [EnumMember(Value = "Package")]
            PackageEnum = 1,
            /// <summary>
            /// Enum AuthMethodEnum for AuthMethod
            /// </summary>
            [EnumMember(Value = "AuthMethod")]
            AuthMethodEnum = 2,
            /// <summary>
            /// Enum AccountEnum for Account
            /// </summary>
            [EnumMember(Value = "Account")]
            AccountEnum = 3,
            /// <summary>
            /// Enum CHALLENGEEnum for CHALLENGE
            /// </summary>
            [EnumMember(Value = "CHALLENGE")]
            CHALLENGEEnum = 4,
            /// <summary>
            /// Enum SMSEnum for SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMSEnum = 5,
            /// <summary>
            /// Enum SSOEnum for SSO
            /// </summary>
            [EnumMember(Value = "SSO")]
            SSOEnum = 6,
            /// <summary>
            /// Enum EMAILLINKEnum for EMAIL_LINK
            /// </summary>
            [EnumMember(Value = "EMAIL_LINK")]
            EMAILLINKEnum = 7,
            /// <summary>
            /// Enum KnowledgeBasedAuthenticationEnum for Knowledge Based Authentication
            /// </summary>
            [EnumMember(Value = "Knowledge Based Authentication")]
            KnowledgeBasedAuthenticationEnum = 8        }

        /// <summary>
        /// The target type.
        /// </summary>
        /// <value>The target type.</value>

        [DataMember(Name="target-type")]
        public TargetTypeEnum? TargetType { get; set; }

        /// <summary>
        /// The time the event happened.
        /// </summary>
        /// <value>The time the event happened.</value>

        [DataMember(Name="date-time")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The audit type.
        /// </summary>
        /// <value>The audit type.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AcceptEnum for Accept
            /// </summary>
            [EnumMember(Value = "Accept")]
            AcceptEnum = 0,
            /// <summary>
            /// Enum ClickToSignEnum for Click To Sign
            /// </summary>
            [EnumMember(Value = "Click To Sign")]
            ClickToSignEnum = 1,
            /// <summary>
            /// Enum ClickToInitialEnum for Click To Initial
            /// </summary>
            [EnumMember(Value = "Click To Initial")]
            ClickToInitialEnum = 2,
            /// <summary>
            /// Enum CaptureSignatureEnum for Capture Signature
            /// </summary>
            [EnumMember(Value = "Capture Signature")]
            CaptureSignatureEnum = 3,
            /// <summary>
            /// Enum ConfirmEnum for Confirm
            /// </summary>
            [EnumMember(Value = "Confirm")]
            ConfirmEnum = 4,
            /// <summary>
            /// Enum DownloadEnum for Download
            /// </summary>
            [EnumMember(Value = "Download")]
            DownloadEnum = 5,
            /// <summary>
            /// Enum DownloadZipEnum for Download Zip
            /// </summary>
            [EnumMember(Value = "Download Zip")]
            DownloadZipEnum = 6,
            /// <summary>
            /// Enum FormFieldEnum for Form Field
            /// </summary>
            [EnumMember(Value = "Form Field")]
            FormFieldEnum = 7,
            /// <summary>
            /// Enum LoginEnum for Login
            /// </summary>
            [EnumMember(Value = "Login")]
            LoginEnum = 8,
            /// <summary>
            /// Enum ViewEnum for View
            /// </summary>
            [EnumMember(Value = "View")]
            ViewEnum = 9,
            /// <summary>
            /// Enum OptOutEnum for Opt Out
            /// </summary>
            [EnumMember(Value = "Opt Out")]
            OptOutEnum = 10,
            /// <summary>
            /// Enum SigningSessionForRecipientEnum for Signing Session For Recipient
            /// </summary>
            [EnumMember(Value = "Signing Session For Recipient")]
            SigningSessionForRecipientEnum = 11,
            /// <summary>
            /// Enum DeclineEnum for Decline
            /// </summary>
            [EnumMember(Value = "Decline")]
            DeclineEnum = 12        }

        /// <summary>
        /// The audit type.
        /// </summary>
        /// <value>The audit type.</value>

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// The audit target.
        /// </summary>
        /// <value>The audit target.</value>

        [DataMember(Name="target")]
        public string Target { get; set; }

        /// <summary>
        /// The signer full name.
        /// </summary>
        /// <value>The signer full name.</value>

        [DataMember(Name="user")]
        public string User { get; set; }

        /// <summary>
        /// The signer email.
        /// </summary>
        /// <value>The signer email.</value>

        [DataMember(Name="user-email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// The signer ip.
        /// </summary>
        /// <value>The signer ip.</value>

        [DataMember(Name="user-ip")]
        public string UserIp { get; set; }

        /// <summary>
        /// The data signer enters.
        /// </summary>
        /// <value>The data signer enters.</value>

        [DataMember(Name="data")]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEvent {\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");
            sb.Append("  UserIp: ").Append(UserIp).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AuditEvent)obj);
        }

        /// <summary>
        /// Returns true if AuditEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of AuditEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEvent other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TargetType == other.TargetType ||
                    TargetType != null &&
                    TargetType.Equals(other.TargetType)
                ) && 
                (
                    DateTime == other.DateTime ||
                    DateTime != null &&
                    DateTime.Equals(other.DateTime)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Target == other.Target ||
                    Target != null &&
                    Target.Equals(other.Target)
                ) && 
                (
                    User == other.User ||
                    User != null &&
                    User.Equals(other.User)
                ) && 
                (
                    UserEmail == other.UserEmail ||
                    UserEmail != null &&
                    UserEmail.Equals(other.UserEmail)
                ) && 
                (
                    UserIp == other.UserIp ||
                    UserIp != null &&
                    UserIp.Equals(other.UserIp)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.Equals(other.Data)
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
                    if (TargetType != null)
                    hashCode = hashCode * 59 + TargetType.GetHashCode();
                    if (DateTime != null)
                    hashCode = hashCode * 59 + DateTime.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Target != null)
                    hashCode = hashCode * 59 + Target.GetHashCode();
                    if (User != null)
                    hashCode = hashCode * 59 + User.GetHashCode();
                    if (UserEmail != null)
                    hashCode = hashCode * 59 + UserEmail.GetHashCode();
                    if (UserIp != null)
                    hashCode = hashCode * 59 + UserIp.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AuditEvent left, AuditEvent right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AuditEvent left, AuditEvent right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}