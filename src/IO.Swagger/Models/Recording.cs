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
    public partial class Recording : IEquatable<Recording>
    { 
        /// <summary>
        /// Uid
        /// </summary>
        /// <value>Uid</value>
        [Required]

        [DataMember(Name="uid")]
        public string Uid { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        /// <value>File name</value>
        [Required]

        [DataMember(Name="fileName")]
        public string FileName { get; set; }

        /// <summary>
        /// Creation date timestamp
        /// </summary>
        /// <value>Creation date timestamp</value>
        [Required]

        [DataMember(Name="creationDate")]
        public int? CreationDate { get; set; }

        /// <summary>
        /// Video file size
        /// </summary>
        /// <value>Video file size</value>
        [Required]

        [DataMember(Name="fileSize")]
        public string FileSize { get; set; }

        /// <summary>
        /// Video file format
        /// </summary>
        /// <value>Video file format</value>
        [Required]

        [DataMember(Name="fileFormat")]
        public string FileFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recording {\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Recording)obj);
        }

        /// <summary>
        /// Returns true if Recording instances are equal
        /// </summary>
        /// <param name="other">Instance of Recording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recording other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Uid == other.Uid ||
                    Uid != null &&
                    Uid.Equals(other.Uid)
                ) && 
                (
                    FileName == other.FileName ||
                    FileName != null &&
                    FileName.Equals(other.FileName)
                ) && 
                (
                    CreationDate == other.CreationDate ||
                    CreationDate != null &&
                    CreationDate.Equals(other.CreationDate)
                ) && 
                (
                    FileSize == other.FileSize ||
                    FileSize != null &&
                    FileSize.Equals(other.FileSize)
                ) && 
                (
                    FileFormat == other.FileFormat ||
                    FileFormat != null &&
                    FileFormat.Equals(other.FileFormat)
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
                    if (Uid != null)
                    hashCode = hashCode * 59 + Uid.GetHashCode();
                    if (FileName != null)
                    hashCode = hashCode * 59 + FileName.GetHashCode();
                    if (CreationDate != null)
                    hashCode = hashCode * 59 + CreationDate.GetHashCode();
                    if (FileSize != null)
                    hashCode = hashCode * 59 + FileSize.GetHashCode();
                    if (FileFormat != null)
                    hashCode = hashCode * 59 + FileFormat.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Recording left, Recording right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Recording left, Recording right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
