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
    public partial class Role : IEquatable<Role>
    { 
        /// <summary>
        /// Signers
        /// </summary>
        /// <value>Signers</value>
        [Required]

        [DataMember(Name="signers")]
        public List<Signer> Signers { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [Required]

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SIGNEREnum for SIGNER
            /// </summary>
            [EnumMember(Value = "SIGNER")]
            SIGNEREnum = 0,
            /// <summary>
            /// Enum SENDEREnum for SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDEREnum = 1        }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [Required]

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Index
        /// </summary>
        /// <value>Index</value>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [Required]

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        /// <value>Data</value>

        [DataMember(Name="data")]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Gets or Sets EmailMessage
        /// </summary>

        [DataMember(Name="emailMessage")]
        public BaseMessage EmailMessage { get; set; }

        /// <summary>
        /// Reassign
        /// </summary>
        /// <value>Reassign</value>

        [DataMember(Name="reassign")]
        public bool? Reassign { get; set; }

        /// <summary>
        /// AttachmentRequirements
        /// </summary>
        /// <value>AttachmentRequirements</value>
        [Required]

        [DataMember(Name="attachmentRequirements")]
        public List<AttachmentRequirement> AttachmentRequirements { get; set; }

        /// <summary>
        /// Gets or Sets SpecialTypes
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SpecialTypesEnum
        {
            /// <summary>
            /// Enum NOTARYEnum for NOTARY
            /// </summary>
            [EnumMember(Value = "NOTARY")]
            NOTARYEnum = 0        }

        /// <summary>
        /// Special Signer Types
        /// </summary>
        /// <value>Special Signer Types</value>

        [DataMember(Name="specialTypes")]
        public List<SpecialTypesEnum> SpecialTypes { get; set; }

        /// <summary>
        /// Locked
        /// </summary>
        /// <value>Locked</value>

        [DataMember(Name="locked")]
        public bool? Locked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Role {\n");
            sb.Append("  Signers: ").Append(Signers).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  EmailMessage: ").Append(EmailMessage).Append("\n");
            sb.Append("  Reassign: ").Append(Reassign).Append("\n");
            sb.Append("  AttachmentRequirements: ").Append(AttachmentRequirements).Append("\n");
            sb.Append("  SpecialTypes: ").Append(SpecialTypes).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Role)obj);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="other">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Signers == other.Signers ||
                    Signers != null &&
                    Signers.SequenceEqual(other.Signers)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Index == other.Index ||
                    Index != null &&
                    Index.Equals(other.Index)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Data == other.Data ||
                    Data != null &&
                    Data.SequenceEqual(other.Data)
                ) && 
                (
                    EmailMessage == other.EmailMessage ||
                    EmailMessage != null &&
                    EmailMessage.Equals(other.EmailMessage)
                ) && 
                (
                    Reassign == other.Reassign ||
                    Reassign != null &&
                    Reassign.Equals(other.Reassign)
                ) && 
                (
                    AttachmentRequirements == other.AttachmentRequirements ||
                    AttachmentRequirements != null &&
                    AttachmentRequirements.SequenceEqual(other.AttachmentRequirements)
                ) && 
                (
                    SpecialTypes == other.SpecialTypes ||
                    SpecialTypes != null &&
                    SpecialTypes.SequenceEqual(other.SpecialTypes)
                ) && 
                (
                    Locked == other.Locked ||
                    Locked != null &&
                    Locked.Equals(other.Locked)
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
                    if (Signers != null)
                    hashCode = hashCode * 59 + Signers.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Index != null)
                    hashCode = hashCode * 59 + Index.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Data != null)
                    hashCode = hashCode * 59 + Data.GetHashCode();
                    if (EmailMessage != null)
                    hashCode = hashCode * 59 + EmailMessage.GetHashCode();
                    if (Reassign != null)
                    hashCode = hashCode * 59 + Reassign.GetHashCode();
                    if (AttachmentRequirements != null)
                    hashCode = hashCode * 59 + AttachmentRequirements.GetHashCode();
                    if (SpecialTypes != null)
                    hashCode = hashCode * 59 + SpecialTypes.GetHashCode();
                    if (Locked != null)
                    hashCode = hashCode * 59 + Locked.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Role left, Role right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Role left, Role right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}