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
    public class AccountRolesApiController : ControllerBase
    { 
        /// <summary>
        /// Deletes an account role.
        /// </summary>
        /// <remarks>Deletes an account role using the specified ID. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="accountRoleId">The unique role id.</param>
        /// <response code="200">OK</response>
        /// <response code="304">Not modified error</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/roles/{accountRoleId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesAccountRoleIdDelete")]
        [SwaggerResponse(statusCode: 304, type: typeof(DefaultError), description: "Not modified error")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesAccountRoleIdDelete([FromRoute][Required]string accountRoleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 304 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(304, default(DefaultError));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves an account role.
        /// </summary>
        /// <remarks>Retrieves an account role by using the specified ID. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="accountRoleId">The unique role id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/roles/{accountRoleId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesAccountRoleIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRole), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesAccountRoleIdGet([FromRoute][Required]string accountRoleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountRole));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"permissions\" : [ \"permissions\", \"permissions\" ],\n  \"inherited\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"id\",\n  \"enabled\" : false,\n  \"predefined\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AccountRole>(exampleJson)
                        : default(AccountRole);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates an existing account role.
        /// </summary>
        /// <remarks>Updates an account role. For example, to change permission settings, or role name. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="body">The account role data to be updated.</param>
        /// <param name="accountRoleId">The unique role id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/account/roles/{accountRoleId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesAccountRoleIdPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(AccountRole), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesAccountRoleIdPut([FromBody]AccountRoleWithoutId body, [FromRoute][Required]string accountRoleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AccountRole));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"permissions\" : [ \"permissions\", \"permissions\" ],\n  \"inherited\" : true,\n  \"name\" : \"name\",\n  \"description\" : \"description\",\n  \"id\" : \"id\",\n  \"enabled\" : false,\n  \"predefined\" : true\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AccountRole>(exampleJson)
                        : default(AccountRole);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Retrieves the list of user IDs assigned to a given role.
        /// </summary>
        /// <remarks>Retrieves the list of user IDs assigned to a given role. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="accountRoleId">The unique role id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/roles/{accountRoleId}/users")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesAccountRoleIdUsersGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<string>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesAccountRoleIdUsersGet([FromRoute][Required]string accountRoleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<string>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "\"[\"45a7e197f2d54b2797cc40787976e1b135353b920c58407d\",\"b76c5c403dabb4e120a95ddfb385930a57c2586490784d98\"]\"";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<string>>(exampleJson)
                        : default(List<string>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Retrieves account role information for the current system account.
        /// </summary>
        /// <remarks>Retrieves account role information, such as name and permissions, for the current system account. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/roles")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse2004), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse2004));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"count\" : 0,\n  \"results\" : [ {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  }, {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse2004>(exampleJson)
                        : default(InlineResponse2004);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates a new account role for an account. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.
        /// </summary>
        /// <remarks>Adds an account role to an account. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="body">The account role payload.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/api/account/roles")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountRolesPost")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountRolesPost([FromBody]AccountRoleWithoutId body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
           //return StatusCode(200);

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
        /// Retrieves the account roles assigned to the specified user.
        /// </summary>
        /// <remarks>Retrieves the account roles assigned to the specified user. If the Subaccount feature is enabled, The API retrieves all user assigned subaccounts roles or specified subaccount roles if the accountUid is provided. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative.</remarks>
        /// <param name="senderId">The unique sender id.</param>
        /// <param name="accountId">This parameter is used when subaccount feature enabled to get specified subaccount roles, if it&#x27;s undefined, all user assigned subaccounts roles will be responsed.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/senders/{senderId}/roles")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdRolesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserAccountRole>), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdRolesGet([FromRoute][Required]string senderId, [FromQuery]string accountId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<UserAccountRole>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"accountId\" : \"accountId\",\n  \"accountRoles\" : [ {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  }, {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  } ],\n  \"userId\" : \"userId\"\n}, {\n  \"accountId\" : \"accountId\",\n  \"accountRoles\" : [ {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  }, {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  } ],\n  \"userId\" : \"userId\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<UserAccountRole>>(exampleJson)
                        : default(List<UserAccountRole>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Assigns account roles to a user in specified account.
        /// </summary>
        /// <remarks>Assigns account roles to a user. To use this call you must have Roles and Permissions enabled on your account. To enable Roles and Permissions contact your OneSpan Sales Representative. If your OSS Account has the Sub Accounts feature enabled, specify accountId in the post body, accountId is mandatory.</remarks>
        /// <param name="body">AccountId with Account Roles to be assigned to the user, AccountId and Role&#x27;s id are mandatory.</param>
        /// <param name="senderId">The unique sender id.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/api/account/senders/{senderId}/roles")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdRolesPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<UserAccountRole>), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdRolesPost([FromBody]UserAccountRole body, [FromRoute][Required]string senderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<UserAccountRole>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(DefaultError));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "[ {\n  \"accountId\" : \"accountId\",\n  \"accountRoles\" : [ {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  }, {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  } ],\n  \"userId\" : \"userId\"\n}, {\n  \"accountId\" : \"accountId\",\n  \"accountRoles\" : [ {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  }, {\n    \"permissions\" : [ \"permissions\", \"permissions\" ],\n    \"inherited\" : true,\n    \"name\" : \"name\",\n    \"description\" : \"description\",\n    \"id\" : \"id\",\n    \"enabled\" : false,\n    \"predefined\" : true\n  } ],\n  \"userId\" : \"userId\"\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<UserAccountRole>>(exampleJson)
                        : default(List<UserAccountRole>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
