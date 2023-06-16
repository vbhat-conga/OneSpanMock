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
    public partial class Page : IEquatable<Page>
    { 
        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [Required]

        [DataMember(Name="id")]
        public string Id { get; set; }

        /// <summary>
        /// Index
        /// </summary>
        /// <value>Index</value>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        /// <value>Version</value>
        [Required]

        [DataMember(Name="version")]
        public int? Version { get; set; }

        /// <summary>
        /// Left
        /// </summary>
        /// <value>Left</value>

        [DataMember(Name="left")]
        public double? Left { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        /// <value>Width</value>

        [DataMember(Name="width")]
        public double? Width { get; set; }

        /// <summary>
        /// Top
        /// </summary>
        /// <value>Top</value>

        [DataMember(Name="top")]
        public double? Top { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        /// <value>Height</value>

        [DataMember(Name="height")]
        public double? Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Page {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Page)obj);
        }

        /// <summary>
        /// Returns true if Page instances are equal
        /// </summary>
        /// <param name="other">Instance of Page to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Page other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Id == other.Id ||
                    Id != null &&
                    Id.Equals(other.Id)
                ) && 
                (
                    Index == other.Index ||
                    Index != null &&
                    Index.Equals(other.Index)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.Equals(other.Version)
                ) && 
                (
                    Left == other.Left ||
                    Left != null &&
                    Left.Equals(other.Left)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Top == other.Top ||
                    Top != null &&
                    Top.Equals(other.Top)
                ) && 
                (
                    Height == other.Height ||
                    Height != null &&
                    Height.Equals(other.Height)
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
                    if (Id != null)
                    hashCode = hashCode * 59 + Id.GetHashCode();
                    if (Index != null)
                    hashCode = hashCode * 59 + Index.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (Left != null)
                    hashCode = hashCode * 59 + Left.GetHashCode();
                    if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                    if (Top != null)
                    hashCode = hashCode * 59 + Top.GetHashCode();
                    if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Page left, Page right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Page left, Page right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}