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
    public class SigningURLApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieves the url that a signer can use to sign a package.
        /// </summary>
        /// <remarks>Retrieves the url that a signer can use to sign a package. This can only be done to a package which is not modifiable (e.g., a sent package). It cannot be done to a package that is in a draft state.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/roles/{roleId}/signingUrl")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagePackageIdRolesRoleIdSigningUrlGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SigningUrl), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagePackageIdRolesRoleIdSigningUrlGet([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SigningUrl));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"roleId\" : \"roleId\",\n  \"packageId\" : \"packageId\",\n  \"url\" : \"url\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SigningUrl>(exampleJson)
                        : default(SigningUrl);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
