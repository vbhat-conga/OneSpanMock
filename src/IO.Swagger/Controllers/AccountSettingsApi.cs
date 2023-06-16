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
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class AccountSettingsApiController : ControllerBase
    { 
        /// <summary>
        /// Updates your Backoffice Account settings with any or all changes. This call can be used to implement either some of the settings that you wish to change, or to implement all of your changes.
        /// </summary>
        /// <remarks>Update your Backoffice Account settings with your new settings.</remarks>
        /// <param name="body">The sample Account Settings payload.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpPatch]
        [Route("/api/account/admin/accountSettings")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAccountSettingsPut")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAccountSettingsPut([FromBody]AccountConfiguration body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes and resets any customized Backoffice Account settings.
        /// </summary>
        /// <remarks>Deletes any Backoffice Account settings that you may have changed. Your Backoffice settings will be returned to their default values.</remarks>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/admin/accountSettings")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAdminAccountSettingsDelete")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAdminAccountSettingsDelete()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a list of all your current Backoffice Account settings.
        /// </summary>
        /// <remarks>Retrieves your Backoffice Account settings.</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">The specified resource was not found</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/admin/accountSettings")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAdminAccountSettingsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountConfiguration), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAdminAccountSettingsGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountConfiguration));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"accountFeatureSettings\" : {\n    \"attachments\" : true,\n    \"forceLogin\" : true,\n    \"customFields\" : true,\n    \"disableFooter\" : true,\n    \"deliverDocumentsByEmail\" : true,\n    \"evidenceSummary\" : true,\n    \"uploadSignatureImage\" : true,\n    \"inAppReports\" : true,\n    \"sendToMobile\" : true,\n    \"forceTransactionOwnerLogin\" : true,\n    \"emailDocumentsAndEvidenceSummary\" : true,\n    \"passwordManagement\" : true,\n    \"allowInPersonForAccountSenders\" : true,\n    \"mobileCapture\" : true,\n    \"conditionalFields\" : true,\n    \"preventConsentRemoval\" : true,\n    \"allowCheckboxConsentApproval\" : true,\n    \"flattenSignerDocuments\" : true,\n    \"qnaAuth\" : true,\n    \"groups\" : true,\n    \"optionalSignature\" : true,\n    \"maskResponse\" : true,\n    \"disableInPersonActivationEmail\" : true,\n    \"delegation\" : true,\n    \"enforceAuth\" : true,\n    \"documentVisibility\" : true\n  },\n  \"accountPackageSettings\" : {\n    \"showNseLogoInIframe\" : true,\n    \"hideWatermark\" : true,\n    \"disableDownloadForUncompletedPackage\" : true,\n    \"disableInPersonAffidavit\" : true,\n    \"hidePackageOwnerInPerson\" : true,\n    \"declineButton\" : true,\n    \"enforceCaptureSignature\" : true,\n    \"leftMenuExpand\" : true,\n    \"inPerson\" : true,\n    \"hideCaptureText\" : true,\n    \"globalActionsDownload\" : true,\n    \"showNseOverview\" : true,\n    \"globalActionsConfirm\" : true,\n    \"disableFirstInPersonAffidavit\" : true,\n    \"extractAcroFields\" : true,\n    \"optionalNavigation\" : true,\n    \"disableDeclineOther\" : true,\n    \"disableSecondInPersonAffidavit\" : true,\n    \"defaultTimeBasedExpiry\" : true,\n    \"globalActionsHideEvidenceSummary\" : true,\n    \"showNseHelp\" : true,\n    \"extractTextTags\" : true,\n    \"hideLanguageDropdown\" : true,\n    \"ada\" : true\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AccountConfiguration>(exampleJson)
                        : default(AccountConfiguration);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}