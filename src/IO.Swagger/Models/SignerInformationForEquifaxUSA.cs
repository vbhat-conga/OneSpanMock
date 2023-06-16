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
    public partial class SignerInformationForEquifaxUSA : IEquatable<SignerInformationForEquifaxUSA>
    { 
        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [Required]

        [DataMember(Name="state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>

        [DataMember(Name="valid")]
        public bool? Valid { get; set; }

        /// <summary>
        /// StreetAddress
        /// </summary>
        /// <value>StreetAddress</value>
        [Required]

        [DataMember(Name="streetAddress")]
        public string StreetAddress { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [Required]

        [DataMember(Name="city")]
        public string City { get; set; }

        /// <summary>
        /// Zip
        /// </summary>
        /// <value>Zip</value>
        [Required]

        [DataMember(Name="zip")]
        public string Zip { get; set; }

        /// <summary>
        /// TimeAtAddress
        /// </summary>
        /// <value>TimeAtAddress</value>

        [DataMember(Name="timeAtAddress")]
        public int? TimeAtAddress { get; set; }

        /// <summary>
        /// SocialSecurityNumber
        /// </summary>
        /// <value>SocialSecurityNumber</value>

        [DataMember(Name="socialSecurityNumber")]
        public string SocialSecurityNumber { get; set; }

        /// <summary>
        /// HomePhoneNumber
        /// </summary>
        /// <value>HomePhoneNumber</value>

        [DataMember(Name="homePhoneNumber")]
        public string HomePhoneNumber { get; set; }

        /// <summary>
        /// DriversLicenseNumber
        /// </summary>
        /// <value>DriversLicenseNumber</value>

        [DataMember(Name="driversLicenseNumber")]
        public string DriversLicenseNumber { get; set; }

        /// <summary>
        /// DateOfBirth
        /// </summary>
        /// <value>DateOfBirth</value>

        [DataMember(Name="dateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// FirstName
        /// </summary>
        /// <value>FirstName</value>
        [Required]

        [DataMember(Name="firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// LastName
        /// </summary>
        /// <value>LastName</value>
        [Required]

        [DataMember(Name="lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignerInformationForEquifaxUSA {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Zip: ").Append(Zip).Append("\n");
            sb.Append("  TimeAtAddress: ").Append(TimeAtAddress).Append("\n");
            sb.Append("  SocialSecurityNumber: ").Append(SocialSecurityNumber).Append("\n");
            sb.Append("  HomePhoneNumber: ").Append(HomePhoneNumber).Append("\n");
            sb.Append("  DriversLicenseNumber: ").Append(DriversLicenseNumber).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
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
            return obj.GetType() == GetType() && Equals((SignerInformationForEquifaxUSA)obj);
        }

        /// <summary>
        /// Returns true if SignerInformationForEquifaxUSA instances are equal
        /// </summary>
        /// <param name="other">Instance of SignerInformationForEquifaxUSA to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerInformationForEquifaxUSA other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    State == other.State ||
                    State != null &&
                    State.Equals(other.State)
                ) && 
                (
                    Valid == other.Valid ||
                    Valid != null &&
                    Valid.Equals(other.Valid)
                ) && 
                (
                    StreetAddress == other.StreetAddress ||
                    StreetAddress != null &&
                    StreetAddress.Equals(other.StreetAddress)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                ) && 
                (
                    Zip == other.Zip ||
                    Zip != null &&
                    Zip.Equals(other.Zip)
                ) && 
                (
                    TimeAtAddress == other.TimeAtAddress ||
                    TimeAtAddress != null &&
                    TimeAtAddress.Equals(other.TimeAtAddress)
                ) && 
                (
                    SocialSecurityNumber == other.SocialSecurityNumber ||
                    SocialSecurityNumber != null &&
                    SocialSecurityNumber.Equals(other.SocialSecurityNumber)
                ) && 
                (
                    HomePhoneNumber == other.HomePhoneNumber ||
                    HomePhoneNumber != null &&
                    HomePhoneNumber.Equals(other.HomePhoneNumber)
                ) && 
                (
                    DriversLicenseNumber == other.DriversLicenseNumber ||
                    DriversLicenseNumber != null &&
                    DriversLicenseNumber.Equals(other.DriversLicenseNumber)
                ) && 
                (
                    DateOfBirth == other.DateOfBirth ||
                    DateOfBirth != null &&
                    DateOfBirth.Equals(other.DateOfBirth)
                ) && 
                (
                    FirstName == other.FirstName ||
                    FirstName != null &&
                    FirstName.Equals(other.FirstName)
                ) && 
                (
                    LastName == other.LastName ||
                    LastName != null &&
                    LastName.Equals(other.LastName)
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
                    if (State != null)
                    hashCode = hashCode * 59 + State.GetHashCode();
                    if (Valid != null)
                    hashCode = hashCode * 59 + Valid.GetHashCode();
                    if (StreetAddress != null)
                    hashCode = hashCode * 59 + StreetAddress.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                    if (Zip != null)
                    hashCode = hashCode * 59 + Zip.GetHashCode();
                    if (TimeAtAddress != null)
                    hashCode = hashCode * 59 + TimeAtAddress.GetHashCode();
                    if (SocialSecurityNumber != null)
                    hashCode = hashCode * 59 + SocialSecurityNumber.GetHashCode();
                    if (HomePhoneNumber != null)
                    hashCode = hashCode * 59 + HomePhoneNumber.GetHashCode();
                    if (DriversLicenseNumber != null)
                    hashCode = hashCode * 59 + DriversLicenseNumber.GetHashCode();
                    if (DateOfBirth != null)
                    hashCode = hashCode * 59 + DateOfBirth.GetHashCode();
                    if (FirstName != null)
                    hashCode = hashCode * 59 + FirstName.GetHashCode();
                    if (LastName != null)
                    hashCode = hashCode * 59 + LastName.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(SignerInformationForEquifaxUSA left, SignerInformationForEquifaxUSA right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SignerInformationForEquifaxUSA left, SignerInformationForEquifaxUSA right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}