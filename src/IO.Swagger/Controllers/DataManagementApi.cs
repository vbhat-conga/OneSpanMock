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
    public class DataManagementApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieves the data management policy for the account.
        /// </summary>
        /// <remarks>Retrieves the data management policy for the account.</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">The specified resource was not found</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/dataRetentionSettings/dataManagementPolicy")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiDataManagementPolicyGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(DataManagementPolicy), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiDataManagementPolicyGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(DataManagementPolicy));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"transactionRetention\" : {\n    \"optedOut\" : 90,\n    \"archived\" : 90,\n    \"declined\" : 90,\n    \"expired\" : 90,\n    \"draft\" : 90,\n    \"completed\" : 90,\n    \"sent\" : 90\n  }\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<DataManagementPolicy>(exampleJson)
                        : default(DataManagementPolicy);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates data management policy for the account.
        /// </summary>
        /// <remarks>Updates data management policy for the account.</remarks>
        /// <param name="body">The sample payload.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/dataRetentionSettings/dataManagementPolicy")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiDataManagementPolicyPut")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiDataManagementPolicyPut([FromBody]DataManagementPolicy body)
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
        /// Retrieves the expiry configurations defined for the account.
        /// </summary>
        /// <remarks>Retrieves the expiry configurations defined for the account.</remarks>
        /// <response code="200">OK</response>
        /// <response code="400">The specified resource was not found</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/dataRetentionSettings/expiryTimeConfiguration")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiExpiryTimeConfigurationGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(ExpiryTimeConfiguration), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiExpiryTimeConfigurationGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ExpiryTimeConfiguration));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"maximumRemainingDays\" : 90,\n  \"remainingDays\" : 60\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ExpiryTimeConfiguration>(exampleJson)
                        : default(ExpiryTimeConfiguration);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates the expiry configurations defined for the account.
        /// </summary>
        /// <remarks>Updates the expiry configurations defined for the account.</remarks>
        /// <param name="body">The sample payload.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/dataRetentionSettings/expiryTimeConfiguration")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiExpiryTimeConfigurationPut")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiExpiryTimeConfigurationPut([FromBody]ExpiryTimeConfiguration body)
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