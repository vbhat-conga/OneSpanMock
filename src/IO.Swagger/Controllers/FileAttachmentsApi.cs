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
    public class FileAttachmentsApiController : ControllerBase
    { 
        /// <summary>
        /// Checks for Signer uploads.
        /// </summary>
        /// <remarks>Verifies whether or not the specified attachment contains any uploads from the Signer.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="attachmentId">The unique attachment id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/{attachmentId}/exists")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentAttachmentIdExistsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AttachmentAvailability), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentAttachmentIdExistsGet([FromRoute][Required]string packageId, [FromRoute][Required]string attachmentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AttachmentAvailability));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"exists\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AttachmentAvailability>(exampleJson)
                        : default(AttachmentAvailability);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes attachment file
        /// </summary>
        /// <remarks>Deletes specific attachment file</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="attachmentId">The unique attachment id.</param>
        /// <param name="fileId">The unique attachment file id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/packages/{packageId}/attachment/{attachmentId}/file/{fileId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdDelete([FromRoute][Required]string packageId, [FromRoute][Required]string attachmentId, [FromRoute][Required]int? fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks for a specific attachment.
        /// </summary>
        /// <remarks>Checks whether or not the specified attachment exists in the package.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="attachmentId">The unique attachment id.</param>
        /// <param name="fileId">The unique attachment file id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/{attachmentId}/file/{fileId}/exists")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdExistsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AttachmentAvailability), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdExistsGet([FromRoute][Required]string packageId, [FromRoute][Required]string attachmentId, [FromRoute][Required]int? fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AttachmentAvailability));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"exists\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AttachmentAvailability>(exampleJson)
                        : default(AttachmentAvailability);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Downloads an attachment.
        /// </summary>
        /// <remarks>Downloads a specified attachment from a package.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="attachmentId">The unique attachment id.</param>
        /// <param name="fileId">The unique attachment file id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/{attachmentId}/file/{fileId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentAttachmentIdFileFileIdGet([FromRoute][Required]string packageId, [FromRoute][Required]string attachmentId, [FromRoute][Required]int? fileId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Downloads an attachment.
        /// </summary>
        /// <remarks>Downloads the specified attachment.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="attachmentId">The unique attachment id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="406">Not acceptable error</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/{attachmentId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentAttachmentIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 406, type: typeof(DefaultError), description: "Not acceptable error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentAttachmentIdGet([FromRoute][Required]string packageId, [FromRoute][Required]string attachmentId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }


        /// <summary>
        /// Downloads all attachments.
        /// </summary>
        /// <remarks>Compresses all attachments into a zip file, which is then downloaded.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="406">Not acceptable error</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/zip")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentZipGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 406, type: typeof(DefaultError), description: "Not acceptable error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentZipGet([FromRoute][Required]string packageId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "\"\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<byte[]>(exampleJson)
                        : default(byte[]);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Checks for attachments and uploads by a specified Role
        /// </summary>
        /// <remarks>Verifies whether or not there are any attachments for the specified role, and whether or not those attachments contain uploads from a Signer.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/zip/{roleId}/exists")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentZipRoleIdExistsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AttachmentAvailability), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentZipRoleIdExistsGet([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AttachmentAvailability));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"exists\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AttachmentAvailability>(exampleJson)
                        : default(AttachmentAvailability);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Downloads all attachments for a specified Role.
        /// </summary>
        /// <remarks>Compresses all attachments into a zip file, and then downloads it. Only attachments for the specified role are included.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="406">Not acceptable error</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/attachment/zip/{roleId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdAttachmentZipRoleIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(byte[]), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 406, type: typeof(DefaultError), description: "Not acceptable error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdAttachmentZipRoleIdGet([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(byte[]));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 406 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(406, default(DefaultError));

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
