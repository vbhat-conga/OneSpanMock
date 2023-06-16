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
    public class AccountSigningUIOptionsApiController : ControllerBase
    { 
        /// <summary>
        /// Deletes customized New Signer Experience settings.
        /// </summary>
        /// <remarks>Deletes customized New Signer Experience settings. Note that if there are no customized settings for the New Signer Experience then the default settings for the New Signer Experience will be returned.</remarks>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/admin/signingUiOptions")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAdminSigningUiIptionsDelete")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAdminSigningUiIptionsDelete()
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
        /// Retrieves customized New Signer Experience settings.
        /// </summary>
        /// <remarks>Retrieves customized New Signer Experience settings. Note that if there are no customized settings for the New Signer Experience then the default settings for the New Signer Experience will be returned.</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">The specified resource was not found</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/admin/signingUiOptions")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAdminSigningUiOptionsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SigningUiOptions), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAdminSigningUiOptionsGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SigningUiOptions));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"notaryWelcomeOptions\" : {\n    \"recipientRole\" : true,\n    \"notaryTag\" : true,\n    \"recipientName\" : true,\n    \"recipientStatus\" : true,\n    \"title\" : true,\n    \"body\" : true,\n    \"recipientActionRequired\" : true,\n    \"recipientEmail\" : true\n  },\n  \"notaryHostThankYouOptions\" : {\n    \"recipientRole\" : true,\n    \"downloadButton\" : true,\n    \"notaryTag\" : true,\n    \"reviewDocumentsButton\" : true,\n    \"recipientName\" : true,\n    \"recipientStatus\" : true,\n    \"title\" : true,\n    \"body\" : true,\n    \"recipientEmail\" : true\n  },\n  \"inpersonHostThankYouOptions\" : {\n    \"recipientRole\" : true,\n    \"downloadButton\" : true,\n    \"reviewDocumentsButton\" : true,\n    \"recipientName\" : true,\n    \"recipientStatus\" : true,\n    \"title\" : true,\n    \"body\" : true,\n    \"recipientEmail\" : true\n  },\n  \"overviewOptions\" : {\n    \"documentSection\" : true,\n    \"title\" : true,\n    \"body\" : true,\n    \"uploadSection\" : true\n  },\n  \"inpersonWelcomeOptions\" : {\n    \"recipientRole\" : true,\n    \"recipientName\" : true,\n    \"recipientStatus\" : true,\n    \"title\" : true,\n    \"body\" : true,\n    \"recipientActionRequired\" : true,\n    \"recipientEmail\" : true\n  },\n  \"completeSummaryOptions\" : {\n    \"download\" : true,\n    \"review\" : true,\n    \"continue\" : true,\n    \"documentSection\" : true,\n    \"title\" : true,\n    \"message\" : true,\n    \"uploadSection\" : true\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SigningUiOptions>(exampleJson)
                        : default(SigningUiOptions);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Patch the customized Signing UI Option.
        /// </summary>
        /// <remarks>Retrieves the customized Signing UI Options.</remarks>
        /// <param name="body">The sample Signing UI Options payload.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpPatch]
        [Route("/api/account/admin/signingUiOptions")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSigningUiOptionsPut")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSigningUiOptionsPut([FromBody]SigningUiOptions body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }
    }
}
