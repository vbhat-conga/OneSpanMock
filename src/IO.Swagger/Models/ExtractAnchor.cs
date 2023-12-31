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
    public partial class ExtractAnchor : IEquatable<ExtractAnchor>
    { 
        /// <summary>
        /// An absolute offset applied to the final y value
        /// </summary>
        /// <value>An absolute offset applied to the final y value</value>
        [Required]

        [DataMember(Name="topOffset")]
        public int? TopOffset { get; set; }

        /// <summary>
        /// The index of the character within the Anchor Text that will be used to calculate position
        /// </summary>
        /// <value>The index of the character within the Anchor Text that will be used to calculate position</value>
        [Required]

        [DataMember(Name="characterIndex")]
        public int? CharacterIndex { get; set; }

        /// <summary>
        /// Which corner of the specified character to use as the base for calculating position
        /// </summary>
        /// <value>Which corner of the specified character to use as the base for calculating position</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AnchorPointEnum
        {
            /// <summary>
            /// Enum TOPLEFTEnum for TOPLEFT
            /// </summary>
            [EnumMember(Value = "TOPLEFT")]
            TOPLEFTEnum = 0,
            /// <summary>
            /// Enum BOTTOMLEFTEnum for BOTTOMLEFT
            /// </summary>
            [EnumMember(Value = "BOTTOMLEFT")]
            BOTTOMLEFTEnum = 1,
            /// <summary>
            /// Enum TOPRIGHTEnum for TOPRIGHT
            /// </summary>
            [EnumMember(Value = "TOPRIGHT")]
            TOPRIGHTEnum = 2,
            /// <summary>
            /// Enum BOTTOMRIGHTEnum for BOTTOMRIGHT
            /// </summary>
            [EnumMember(Value = "BOTTOMRIGHT")]
            BOTTOMRIGHTEnum = 3        }

        /// <summary>
        /// Which corner of the specified character to use as the base for calculating position
        /// </summary>
        /// <value>Which corner of the specified character to use as the base for calculating position</value>
        [Required]

        [DataMember(Name="anchorPoint")]
        public AnchorPointEnum? AnchorPoint { get; set; }

        /// <summary>
        /// The \&quot;occurrence\&quot; of the string. For example, if index &#x3D; 2, the software will skip the first two occurrences of Anchor Text, and use the third occurrence to calculate position.
        /// </summary>
        /// <value>The \&quot;occurrence\&quot; of the string. For example, if index &#x3D; 2, the software will skip the first two occurrences of Anchor Text, and use the third occurrence to calculate position.</value>
        [Required]

        [DataMember(Name="index")]
        public int? Index { get; set; }

        /// <summary>
        /// The exact string that will be searched for in the uploaded document
        /// </summary>
        /// <value>The exact string that will be searched for in the uploaded document</value>
        [Required]

        [DataMember(Name="text")]
        public string Text { get; set; }

        /// <summary>
        /// The width of the field position to be calculated
        /// </summary>
        /// <value>The width of the field position to be calculated</value>
        [Required]

        [DataMember(Name="width")]
        public int? Width { get; set; }

        /// <summary>
        /// The height of the field position to be calculated
        /// </summary>
        /// <value>The height of the field position to be calculated</value>
        [Required]

        [DataMember(Name="height")]
        public int? Height { get; set; }

        /// <summary>
        /// An absolute offset applied to the final x value
        /// </summary>
        /// <value>An absolute offset applied to the final x value</value>
        [Required]

        [DataMember(Name="leftOffset")]
        public int? LeftOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtractAnchor {\n");
            sb.Append("  TopOffset: ").Append(TopOffset).Append("\n");
            sb.Append("  CharacterIndex: ").Append(CharacterIndex).Append("\n");
            sb.Append("  AnchorPoint: ").Append(AnchorPoint).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  LeftOffset: ").Append(LeftOffset).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ExtractAnchor)obj);
        }

        /// <summary>
        /// Returns true if ExtractAnchor instances are equal
        /// </summary>
        /// <param name="other">Instance of ExtractAnchor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtractAnchor other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    TopOffset == other.TopOffset ||
                    TopOffset != null &&
                    TopOffset.Equals(other.TopOffset)
                ) && 
                (
                    CharacterIndex == other.CharacterIndex ||
                    CharacterIndex != null &&
                    CharacterIndex.Equals(other.CharacterIndex)
                ) && 
                (
                    AnchorPoint == other.AnchorPoint ||
                    AnchorPoint != null &&
                    AnchorPoint.Equals(other.AnchorPoint)
                ) && 
                (
                    Index == other.Index ||
                    Index != null &&
                    Index.Equals(other.Index)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.Equals(other.Text)
                ) && 
                (
                    Width == other.Width ||
                    Width != null &&
                    Width.Equals(other.Width)
                ) && 
                (
                    Height == other.Height ||
                    Height != null &&
                    Height.Equals(other.Height)
                ) && 
                (
                    LeftOffset == other.LeftOffset ||
                    LeftOffset != null &&
                    LeftOffset.Equals(other.LeftOffset)
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
                    if (TopOffset != null)
                    hashCode = hashCode * 59 + TopOffset.GetHashCode();
                    if (CharacterIndex != null)
                    hashCode = hashCode * 59 + CharacterIndex.GetHashCode();
                    if (AnchorPoint != null)
                    hashCode = hashCode * 59 + AnchorPoint.GetHashCode();
                    if (Index != null)
                    hashCode = hashCode * 59 + Index.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Width != null)
                    hashCode = hashCode * 59 + Width.GetHashCode();
                    if (Height != null)
                    hashCode = hashCode * 59 + Height.GetHashCode();
                    if (LeftOffset != null)
                    hashCode = hashCode * 59 + LeftOffset.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ExtractAnchor left, ExtractAnchor right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ExtractAnchor left, ExtractAnchor right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
