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
    public partial class AccountPackageSettings : IEquatable<AccountPackageSettings>
    { 
        /// <summary>
        /// EnforceCaptureSignature
        /// </summary>
        /// <value>EnforceCaptureSignature</value>
        [Required]

        [DataMember(Name="enforceCaptureSignature")]
        public bool? EnforceCaptureSignature { get; set; }

        /// <summary>
        /// InPerson
        /// </summary>
        /// <value>InPerson</value>
        [Required]

        [DataMember(Name="inPerson")]
        public bool? InPerson { get; set; }

        /// <summary>
        /// DeclineButton
        /// </summary>
        /// <value>DeclineButton</value>
        [Required]

        [DataMember(Name="declineButton")]
        public bool? DeclineButton { get; set; }

        /// <summary>
        /// DisableDeclineOther
        /// </summary>
        /// <value>DisableDeclineOther</value>
        [Required]

        [DataMember(Name="disableDeclineOther")]
        public bool? DisableDeclineOther { get; set; }

        /// <summary>
        /// DisableDownloadForUncompletedPackage
        /// </summary>
        /// <value>DisableDownloadForUncompletedPackage</value>
        [Required]

        [DataMember(Name="disableDownloadForUncompletedPackage")]
        public bool? DisableDownloadForUncompletedPackage { get; set; }

        /// <summary>
        /// DisableFirstInPersonAffidavit
        /// </summary>
        /// <value>DisableFirstInPersonAffidavit</value>
        [Required]

        [DataMember(Name="disableFirstInPersonAffidavit")]
        public bool? DisableFirstInPersonAffidavit { get; set; }

        /// <summary>
        /// DisableInPersonAffidavit
        /// </summary>
        /// <value>DisableInPersonAffidavit</value>
        [Required]

        [DataMember(Name="disableInPersonAffidavit")]
        public bool? DisableInPersonAffidavit { get; set; }

        /// <summary>
        /// DisableSecondInPersonAffidavit
        /// </summary>
        /// <value>DisableSecondInPersonAffidavit</value>
        [Required]

        [DataMember(Name="disableSecondInPersonAffidavit")]
        public bool? DisableSecondInPersonAffidavit { get; set; }

        /// <summary>
        /// HideCaptureText
        /// </summary>
        /// <value>HideCaptureText</value>
        [Required]

        [DataMember(Name="hideCaptureText")]
        public bool? HideCaptureText { get; set; }

        /// <summary>
        /// HideLanguageDropdown
        /// </summary>
        /// <value>HideLanguageDropdown</value>
        [Required]

        [DataMember(Name="hideLanguageDropdown")]
        public bool? HideLanguageDropdown { get; set; }

        /// <summary>
        /// HidePackageOwnerInPerson
        /// </summary>
        /// <value>HidePackageOwnerInPerson</value>
        [Required]

        [DataMember(Name="hidePackageOwnerInPerson")]
        public bool? HidePackageOwnerInPerson { get; set; }

        /// <summary>
        /// HideWatermark
        /// </summary>
        /// <value>HideWatermark</value>
        [Required]

        [DataMember(Name="hideWatermark")]
        public bool? HideWatermark { get; set; }

        /// <summary>
        /// ExtractAcroFields
        /// </summary>
        /// <value>ExtractAcroFields</value>
        [Required]

        [DataMember(Name="extractAcroFields")]
        public bool? ExtractAcroFields { get; set; }

        /// <summary>
        /// ExtractTextTags
        /// </summary>
        /// <value>ExtractTextTags</value>
        [Required]

        [DataMember(Name="extractTextTags")]
        public bool? ExtractTextTags { get; set; }

        /// <summary>
        /// Ada
        /// </summary>
        /// <value>Ada</value>
        [Required]

        [DataMember(Name="ada")]
        public bool? Ada { get; set; }

        /// <summary>
        /// LeftMenuExpand
        /// </summary>
        /// <value>LeftMenuExpand</value>
        [Required]

        [DataMember(Name="leftMenuExpand")]
        public bool? LeftMenuExpand { get; set; }

        /// <summary>
        /// OptionalNavigation
        /// </summary>
        /// <value>OptionalNavigation</value>
        [Required]

        [DataMember(Name="optionalNavigation")]
        public bool? OptionalNavigation { get; set; }

        /// <summary>
        /// ShowNseHelp
        /// </summary>
        /// <value>ShowNseHelp</value>
        [Required]

        [DataMember(Name="showNseHelp")]
        public bool? ShowNseHelp { get; set; }

        /// <summary>
        /// ShowNseLogoInIframe
        /// </summary>
        /// <value>ShowNseLogoInIframe</value>
        [Required]

        [DataMember(Name="showNseLogoInIframe")]
        public bool? ShowNseLogoInIframe { get; set; }

        /// <summary>
        /// ShowNseOverview
        /// </summary>
        /// <value>ShowNseOverview</value>
        [Required]

        [DataMember(Name="showNseOverview")]
        public bool? ShowNseOverview { get; set; }

        /// <summary>
        /// DefaultTimeBasedExpiry
        /// </summary>
        /// <value>DefaultTimeBasedExpiry</value>
        [Required]

        [DataMember(Name="defaultTimeBasedExpiry")]
        public bool? DefaultTimeBasedExpiry { get; set; }

        /// <summary>
        /// GlobalActionsConfirm
        /// </summary>
        /// <value>GlobalActionsConfirm</value>
        [Required]

        [DataMember(Name="globalActionsConfirm")]
        public bool? GlobalActionsConfirm { get; set; }

        /// <summary>
        /// GlobalActionsDownload
        /// </summary>
        /// <value>GlobalActionsDownload</value>
        [Required]

        [DataMember(Name="globalActionsDownload")]
        public bool? GlobalActionsDownload { get; set; }

        /// <summary>
        /// GlobalActionsHideEvidenceSummary
        /// </summary>
        /// <value>GlobalActionsHideEvidenceSummary</value>
        [Required]

        [DataMember(Name="globalActionsHideEvidenceSummary")]
        public bool? GlobalActionsHideEvidenceSummary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountPackageSettings {\n");
            sb.Append("  EnforceCaptureSignature: ").Append(EnforceCaptureSignature).Append("\n");
            sb.Append("  InPerson: ").Append(InPerson).Append("\n");
            sb.Append("  DeclineButton: ").Append(DeclineButton).Append("\n");
            sb.Append("  DisableDeclineOther: ").Append(DisableDeclineOther).Append("\n");
            sb.Append("  DisableDownloadForUncompletedPackage: ").Append(DisableDownloadForUncompletedPackage).Append("\n");
            sb.Append("  DisableFirstInPersonAffidavit: ").Append(DisableFirstInPersonAffidavit).Append("\n");
            sb.Append("  DisableInPersonAffidavit: ").Append(DisableInPersonAffidavit).Append("\n");
            sb.Append("  DisableSecondInPersonAffidavit: ").Append(DisableSecondInPersonAffidavit).Append("\n");
            sb.Append("  HideCaptureText: ").Append(HideCaptureText).Append("\n");
            sb.Append("  HideLanguageDropdown: ").Append(HideLanguageDropdown).Append("\n");
            sb.Append("  HidePackageOwnerInPerson: ").Append(HidePackageOwnerInPerson).Append("\n");
            sb.Append("  HideWatermark: ").Append(HideWatermark).Append("\n");
            sb.Append("  ExtractAcroFields: ").Append(ExtractAcroFields).Append("\n");
            sb.Append("  ExtractTextTags: ").Append(ExtractTextTags).Append("\n");
            sb.Append("  Ada: ").Append(Ada).Append("\n");
            sb.Append("  LeftMenuExpand: ").Append(LeftMenuExpand).Append("\n");
            sb.Append("  OptionalNavigation: ").Append(OptionalNavigation).Append("\n");
            sb.Append("  ShowNseHelp: ").Append(ShowNseHelp).Append("\n");
            sb.Append("  ShowNseLogoInIframe: ").Append(ShowNseLogoInIframe).Append("\n");
            sb.Append("  ShowNseOverview: ").Append(ShowNseOverview).Append("\n");
            sb.Append("  DefaultTimeBasedExpiry: ").Append(DefaultTimeBasedExpiry).Append("\n");
            sb.Append("  GlobalActionsConfirm: ").Append(GlobalActionsConfirm).Append("\n");
            sb.Append("  GlobalActionsDownload: ").Append(GlobalActionsDownload).Append("\n");
            sb.Append("  GlobalActionsHideEvidenceSummary: ").Append(GlobalActionsHideEvidenceSummary).Append("\n");
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
            return obj.GetType() == GetType() && Equals((AccountPackageSettings)obj);
        }

        /// <summary>
        /// Returns true if AccountPackageSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountPackageSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountPackageSettings other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    EnforceCaptureSignature == other.EnforceCaptureSignature ||
                    EnforceCaptureSignature != null &&
                    EnforceCaptureSignature.Equals(other.EnforceCaptureSignature)
                ) && 
                (
                    InPerson == other.InPerson ||
                    InPerson != null &&
                    InPerson.Equals(other.InPerson)
                ) && 
                (
                    DeclineButton == other.DeclineButton ||
                    DeclineButton != null &&
                    DeclineButton.Equals(other.DeclineButton)
                ) && 
                (
                    DisableDeclineOther == other.DisableDeclineOther ||
                    DisableDeclineOther != null &&
                    DisableDeclineOther.Equals(other.DisableDeclineOther)
                ) && 
                (
                    DisableDownloadForUncompletedPackage == other.DisableDownloadForUncompletedPackage ||
                    DisableDownloadForUncompletedPackage != null &&
                    DisableDownloadForUncompletedPackage.Equals(other.DisableDownloadForUncompletedPackage)
                ) && 
                (
                    DisableFirstInPersonAffidavit == other.DisableFirstInPersonAffidavit ||
                    DisableFirstInPersonAffidavit != null &&
                    DisableFirstInPersonAffidavit.Equals(other.DisableFirstInPersonAffidavit)
                ) && 
                (
                    DisableInPersonAffidavit == other.DisableInPersonAffidavit ||
                    DisableInPersonAffidavit != null &&
                    DisableInPersonAffidavit.Equals(other.DisableInPersonAffidavit)
                ) && 
                (
                    DisableSecondInPersonAffidavit == other.DisableSecondInPersonAffidavit ||
                    DisableSecondInPersonAffidavit != null &&
                    DisableSecondInPersonAffidavit.Equals(other.DisableSecondInPersonAffidavit)
                ) && 
                (
                    HideCaptureText == other.HideCaptureText ||
                    HideCaptureText != null &&
                    HideCaptureText.Equals(other.HideCaptureText)
                ) && 
                (
                    HideLanguageDropdown == other.HideLanguageDropdown ||
                    HideLanguageDropdown != null &&
                    HideLanguageDropdown.Equals(other.HideLanguageDropdown)
                ) && 
                (
                    HidePackageOwnerInPerson == other.HidePackageOwnerInPerson ||
                    HidePackageOwnerInPerson != null &&
                    HidePackageOwnerInPerson.Equals(other.HidePackageOwnerInPerson)
                ) && 
                (
                    HideWatermark == other.HideWatermark ||
                    HideWatermark != null &&
                    HideWatermark.Equals(other.HideWatermark)
                ) && 
                (
                    ExtractAcroFields == other.ExtractAcroFields ||
                    ExtractAcroFields != null &&
                    ExtractAcroFields.Equals(other.ExtractAcroFields)
                ) && 
                (
                    ExtractTextTags == other.ExtractTextTags ||
                    ExtractTextTags != null &&
                    ExtractTextTags.Equals(other.ExtractTextTags)
                ) && 
                (
                    Ada == other.Ada ||
                    Ada != null &&
                    Ada.Equals(other.Ada)
                ) && 
                (
                    LeftMenuExpand == other.LeftMenuExpand ||
                    LeftMenuExpand != null &&
                    LeftMenuExpand.Equals(other.LeftMenuExpand)
                ) && 
                (
                    OptionalNavigation == other.OptionalNavigation ||
                    OptionalNavigation != null &&
                    OptionalNavigation.Equals(other.OptionalNavigation)
                ) && 
                (
                    ShowNseHelp == other.ShowNseHelp ||
                    ShowNseHelp != null &&
                    ShowNseHelp.Equals(other.ShowNseHelp)
                ) && 
                (
                    ShowNseLogoInIframe == other.ShowNseLogoInIframe ||
                    ShowNseLogoInIframe != null &&
                    ShowNseLogoInIframe.Equals(other.ShowNseLogoInIframe)
                ) && 
                (
                    ShowNseOverview == other.ShowNseOverview ||
                    ShowNseOverview != null &&
                    ShowNseOverview.Equals(other.ShowNseOverview)
                ) && 
                (
                    DefaultTimeBasedExpiry == other.DefaultTimeBasedExpiry ||
                    DefaultTimeBasedExpiry != null &&
                    DefaultTimeBasedExpiry.Equals(other.DefaultTimeBasedExpiry)
                ) && 
                (
                    GlobalActionsConfirm == other.GlobalActionsConfirm ||
                    GlobalActionsConfirm != null &&
                    GlobalActionsConfirm.Equals(other.GlobalActionsConfirm)
                ) && 
                (
                    GlobalActionsDownload == other.GlobalActionsDownload ||
                    GlobalActionsDownload != null &&
                    GlobalActionsDownload.Equals(other.GlobalActionsDownload)
                ) && 
                (
                    GlobalActionsHideEvidenceSummary == other.GlobalActionsHideEvidenceSummary ||
                    GlobalActionsHideEvidenceSummary != null &&
                    GlobalActionsHideEvidenceSummary.Equals(other.GlobalActionsHideEvidenceSummary)
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
                    if (EnforceCaptureSignature != null)
                    hashCode = hashCode * 59 + EnforceCaptureSignature.GetHashCode();
                    if (InPerson != null)
                    hashCode = hashCode * 59 + InPerson.GetHashCode();
                    if (DeclineButton != null)
                    hashCode = hashCode * 59 + DeclineButton.GetHashCode();
                    if (DisableDeclineOther != null)
                    hashCode = hashCode * 59 + DisableDeclineOther.GetHashCode();
                    if (DisableDownloadForUncompletedPackage != null)
                    hashCode = hashCode * 59 + DisableDownloadForUncompletedPackage.GetHashCode();
                    if (DisableFirstInPersonAffidavit != null)
                    hashCode = hashCode * 59 + DisableFirstInPersonAffidavit.GetHashCode();
                    if (DisableInPersonAffidavit != null)
                    hashCode = hashCode * 59 + DisableInPersonAffidavit.GetHashCode();
                    if (DisableSecondInPersonAffidavit != null)
                    hashCode = hashCode * 59 + DisableSecondInPersonAffidavit.GetHashCode();
                    if (HideCaptureText != null)
                    hashCode = hashCode * 59 + HideCaptureText.GetHashCode();
                    if (HideLanguageDropdown != null)
                    hashCode = hashCode * 59 + HideLanguageDropdown.GetHashCode();
                    if (HidePackageOwnerInPerson != null)
                    hashCode = hashCode * 59 + HidePackageOwnerInPerson.GetHashCode();
                    if (HideWatermark != null)
                    hashCode = hashCode * 59 + HideWatermark.GetHashCode();
                    if (ExtractAcroFields != null)
                    hashCode = hashCode * 59 + ExtractAcroFields.GetHashCode();
                    if (ExtractTextTags != null)
                    hashCode = hashCode * 59 + ExtractTextTags.GetHashCode();
                    if (Ada != null)
                    hashCode = hashCode * 59 + Ada.GetHashCode();
                    if (LeftMenuExpand != null)
                    hashCode = hashCode * 59 + LeftMenuExpand.GetHashCode();
                    if (OptionalNavigation != null)
                    hashCode = hashCode * 59 + OptionalNavigation.GetHashCode();
                    if (ShowNseHelp != null)
                    hashCode = hashCode * 59 + ShowNseHelp.GetHashCode();
                    if (ShowNseLogoInIframe != null)
                    hashCode = hashCode * 59 + ShowNseLogoInIframe.GetHashCode();
                    if (ShowNseOverview != null)
                    hashCode = hashCode * 59 + ShowNseOverview.GetHashCode();
                    if (DefaultTimeBasedExpiry != null)
                    hashCode = hashCode * 59 + DefaultTimeBasedExpiry.GetHashCode();
                    if (GlobalActionsConfirm != null)
                    hashCode = hashCode * 59 + GlobalActionsConfirm.GetHashCode();
                    if (GlobalActionsDownload != null)
                    hashCode = hashCode * 59 + GlobalActionsDownload.GetHashCode();
                    if (GlobalActionsHideEvidenceSummary != null)
                    hashCode = hashCode * 59 + GlobalActionsHideEvidenceSummary.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(AccountPackageSettings left, AccountPackageSettings right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(AccountPackageSettings left, AccountPackageSettings right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}