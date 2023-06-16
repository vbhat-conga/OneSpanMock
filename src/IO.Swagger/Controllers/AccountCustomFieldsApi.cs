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
    public class AccountCustomFieldsApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieves an account specified custom field.
        /// </summary>
        /// <remarks>Retrieves an account custom field by using the specified ID.</remarks>
        /// <param name="customFieldId">ID of the Custom Field.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Invalid field Id</response>
        [HttpGet]
        [Route("/api/account/customfields/{customFieldId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountCustomFieldsCustomFieldIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CustomField), description: "OK")]
        public virtual IActionResult ApiAccountCustomFieldsCustomFieldIdGet([FromRoute][Required]string customFieldId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CustomField));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"translations\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  } ],\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"value\" : \"value\",\n  \"required\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CustomField>(exampleJson)
                        : default(CustomField);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes an account custom field by its ID.
        /// </summary>
        /// <remarks>Deletes a custom field using the specified ID.</remarks>
        /// <param name="customFieldId">ID of the Custom Field.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/customfields/{customFieldId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountCustomFieldsDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountCustomFieldsDelete([FromRoute][Required]string customFieldId)
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
        /// Retrieves all custom fields in an account.
        /// </summary>
        /// <remarks>Retrieves all custom fields in an account. Custom fields can be sorted using pagination.</remarks>
        /// <param name="from">The first record that will be returned. Useful for pagination.</param>
        /// <param name="to">The last record that will be returned. Useful for pagination.</param>
        /// <param name="dir">The direction according to which the data will be sorted. &#x27;asc&#x27; for ascending and &#x27;desc&#x27; for descending.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/customfields")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountCustomFieldsGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(CustomField), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountCustomFieldsGet([FromQuery]int? from, [FromQuery]int? to, [FromQuery]string dir)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CustomField));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"translations\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  } ],\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"value\" : \"value\",\n  \"required\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CustomField>(exampleJson)
                        : default(CustomField);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Adds a custom field to an account.
        /// </summary>
        /// <remarks>Adds a custom field to an account.</remarks>
        /// <param name="body">The custom field to be created.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/api/account/customfields")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountCustomFieldsPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(CustomField), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountCustomFieldsPost([FromBody]CustomField body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CustomField));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"translations\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  } ],\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"value\" : \"value\",\n  \"required\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CustomField>(exampleJson)
                        : default(CustomField);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates an account custom field.
        /// </summary>
        /// <remarks>Updates an account custom field with information specified in the parameters.</remarks>
        /// <param name="body">The custom field to be updated.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/account/customfields")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountCustomFieldsPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(CustomField), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountCustomFieldsPut([FromBody]CustomField body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CustomField));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"translations\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"language\" : \"language\",\n    \"id\" : \"id\"\n  } ],\n  \"name\" : \"name\",\n  \"id\" : \"id\",\n  \"value\" : \"value\",\n  \"required\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<CustomField>(exampleJson)
                        : default(CustomField);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
