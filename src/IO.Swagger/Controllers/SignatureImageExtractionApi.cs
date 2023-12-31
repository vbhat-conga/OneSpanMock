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
    public class SignatureImageExtractionApiController : ControllerBase
    { 
        /// <summary>
        /// Extracts a Signer’s Captured Signature from a Package.
        /// </summary>
        /// <remarks>Extracts the image of a specific signer’s captured signature from a package.&lt;/br&gt; An Account Manager can extract signature images from any package, and Package Owners can extract signature images from the packages they own.&lt;/br&gt; The default image size is 350 x 100 pixels.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/roles/{roleId}/signatureImage")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagePackageIdRolesRoleIdSignatureImageGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagePackageIdRolesRoleIdSignatureImageGet([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
