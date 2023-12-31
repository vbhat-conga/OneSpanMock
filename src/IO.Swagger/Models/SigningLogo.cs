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
    public partial class SigningLogo : IEquatable<SigningLogo>
    { 
        /// <summary>
        /// Language key
        /// </summary>
        /// <value>Language key</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum LanguageEnum
        {
            /// <summary>
            /// Enum EnEnum for en
            /// </summary>
            [EnumMember(Value = "en")]
            EnEnum = 0,
            /// <summary>
            /// Enum FrEnum for fr
            /// </summary>
            [EnumMember(Value = "fr")]
            FrEnum = 1,
            /// <summary>
            /// Enum ItEnum for it
            /// </summary>
            [EnumMember(Value = "it")]
            ItEnum = 2,
            /// <summary>
            /// Enum RuEnum for ru
            /// </summary>
            [EnumMember(Value = "ru")]
            RuEnum = 3,
            /// <summary>
            /// Enum EsEnum for es
            /// </summary>
            [EnumMember(Value = "es")]
            EsEnum = 4,
            /// <summary>
            /// Enum PtEnum for pt
            /// </summary>
            [EnumMember(Value = "pt")]
            PtEnum = 5,
            /// <summary>
            /// Enum DeEnum for de
            /// </summary>
            [EnumMember(Value = "de")]
            DeEnum = 6,
            /// <summary>
            /// Enum NlEnum for nl
            /// </summary>
            [EnumMember(Value = "nl")]
            NlEnum = 7,
            /// <summary>
            /// Enum DaEnum for da
            /// </summary>
            [EnumMember(Value = "da")]
            DaEnum = 8,
            /// <summary>
            /// Enum ElEnum for el
            /// </summary>
            [EnumMember(Value = "el")]
            ElEnum = 9,
            /// <summary>
            /// Enum ZhCNEnum for zh-CN
            /// </summary>
            [EnumMember(Value = "zh-CN")]
            ZhCNEnum = 10,
            /// <summary>
            /// Enum ZhTWEnum for zh-TW
            /// </summary>
            [EnumMember(Value = "zh-TW")]
            ZhTWEnum = 11,
            /// <summary>
            /// Enum JaEnum for ja
            /// </summary>
            [EnumMember(Value = "ja")]
            JaEnum = 12,
            /// <summary>
            /// Enum KoEnum for ko
            /// </summary>
            [EnumMember(Value = "ko")]
            KoEnum = 13        }

        /// <summary>
        /// Language key
        /// </summary>
        /// <value>Language key</value>
        [Required]

        [DataMember(Name="language")]
        public LanguageEnum? Language { get; set; }

        /// <summary>
        /// Base64 encoded image
        /// </summary>
        /// <value>Base64 encoded image</value>
        [Required]

        [DataMember(Name="image")]
        public byte[] Image { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SigningLogo {\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SigningLogo)obj);
        }

        /// <summary>
        /// Returns true if SigningLogo instances are equal
        /// </summary>
        /// <param name="other">Instance of SigningLogo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SigningLogo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Language == other.Language ||
                    Language != null &&
                    Language.Equals(other.Language)
                ) && 
                (
                    Image == other.Image ||
                    Image != null &&
                    Image.Equals(other.Image)
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
                    if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                    if (Image != null)
                    hashCode = hashCode * 59 + Image.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SigningLogo left, SigningLogo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SigningLogo left, SigningLogo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
