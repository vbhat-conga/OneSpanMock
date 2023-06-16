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
    public partial class PackageLayout : IEquatable<PackageLayout>
    { 
        /// <summary>
        /// Name of the layout
        /// </summary>
        /// <value>Name of the layout</value>
        [Required]

        [DataMember(Name="name")]
        public string Name { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [Required]

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>

        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum LAYOUTEnum for LAYOUT
            /// </summary>
            [EnumMember(Value = "LAYOUT")]
            LAYOUTEnum = 0        }

        /// <summary>
        /// Type
        /// </summary>
        /// <value>Type</value>
        [Required]

        [DataMember(Name="type")]
        public TypeEnum? Type { get; set; }

        /// <summary>
        /// Visibility
        /// </summary>
        /// <value>Visibility</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum VisibilityEnum
        {
            /// <summary>
            /// Enum ACCOUNTEnum for ACCOUNT
            /// </summary>
            [EnumMember(Value = "ACCOUNT")]
            ACCOUNTEnum = 0,
            /// <summary>
            /// Enum SENDEREnum for SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDEREnum = 1        }

        /// <summary>
        /// Visibility
        /// </summary>
        /// <value>Visibility</value>
        [Required]

        [DataMember(Name="visibility")]
        public VisibilityEnum? Visibility { get; set; }

        /// <summary>
        /// Document id. It MUST contains only one document id.
        /// </summary>
        /// <value>Document id. It MUST contains only one document id.</value>
        [Required]

        [DataMember(Name="documents")]
        public List<PackageLayoutDocuments> Documents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageLayout {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Documents: ").Append(Documents).Append("\n");
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
            return obj.GetType() == GetType() && Equals((PackageLayout)obj);
        }

        /// <summary>
        /// Returns true if PackageLayout instances are equal
        /// </summary>
        /// <param name="other">Instance of PackageLayout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageLayout other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) && 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Type == other.Type ||
                    Type != null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Visibility == other.Visibility ||
                    Visibility != null &&
                    Visibility.Equals(other.Visibility)
                ) && 
                (
                    Documents == other.Documents ||
                    Documents != null &&
                    Documents.SequenceEqual(other.Documents)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Type != null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Visibility != null)
                    hashCode = hashCode * 59 + Visibility.GetHashCode();
                    if (Documents != null)
                    hashCode = hashCode * 59 + Documents.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(PackageLayout left, PackageLayout right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(PackageLayout left, PackageLayout right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
