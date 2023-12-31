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
    public class DelegatesApiController : ControllerBase
    { 
        /// <summary>
        /// Deletes a delegate from a specified Sender.
        /// </summary>
        /// <remarks>Deletes a delegate. The delegate will no longer be able to: (1) access the delegator&#x27;s inbox, drafts, layouts, and templates; (2) sign documents on behalf of the delegator.</remarks>
        /// <param name="senderId">The unique sender id.</param>
        /// <param name="delegateId">The unique delegateId id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/senders/{senderId}/delegates/{delegateId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdDelegatesDelegateIdDelete")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdDelegatesDelegateIdDelete([FromRoute][Required]string senderId, [FromRoute][Required]string delegateId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds delegates to a Sender.
        /// </summary>
        /// <remarks>A delegate can: (1) access the delegator&#x27;s inbox, drafts, layouts, and templates; (2) sign documents on behalf of the delegator.</remarks>
        /// <param name="senderId">The unique sender id.</param>
        /// <param name="delegateId">The unique delegateId id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/api/account/senders/{senderId}/delegates/{delegateId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdDelegatesDelegateIdPost")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdDelegatesDelegateIdPost([FromRoute][Required]string senderId, [FromRoute][Required]string delegateId)
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
        /// Deletes all delegates from a Sender.
        /// </summary>
        /// <remarks>Deletes all delegates that have been specified for a Sender. Delegates will no longer be able to  (1) access the delegator&#x27;s inbox, drafts, layouts, and templates; (2) sign documents on behalf of the delegator. </remarks>
        /// <param name="senderId">The unique sender id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/account/senders/{senderId}/delegates")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdDelegatesDelete")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdDelegatesDelete([FromRoute][Required]string senderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves a list of users who have been designated as delegates for a specified user.
        /// </summary>
        /// <remarks>Retrieves a list of users who have been designated as delegates for a specified user. A delegate can: (1) access the delegator&#x27;s inbox, drafts, layouts, and templates; (2) sign documents on behalf of the delegator. </remarks>
        /// <param name="senderId">The unique sender id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/senders/{senderId}/delegates")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdDelegatesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Sender), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdDelegatesGet([FromRoute][Required]string senderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Sender));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"lastName\" : \"lastName\",\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"signature\" : {\n    \"handdrawn\" : \"handdrawn\",\n    \"textual\" : {\n      \"color\" : \"color\",\n      \"font\" : \"font\"\n    }\n  },\n  \"specialTypes\" : [ \"NOTARY\", \"NOTARY\" ],\n  \"language\" : \"language\",\n  \"type\" : \"REGULAR\",\n  \"title\" : \"title\",\n  \"memberships\" : [ {\n    \"groupName\" : \"groupName\",\n    \"groupId\" : \"groupId\",\n    \"memberType\" : \"REGULAR\"\n  }, {\n    \"groupName\" : \"groupName\",\n    \"groupId\" : \"groupId\",\n    \"memberType\" : \"REGULAR\"\n  } ],\n  \"professionalIdentityFields\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"translations\" : [ null, null ],\n    \"name\" : \"name\",\n    \"id\" : \"id\",\n    \"type\" : \"type\",\n    \"category\" : \"category\",\n    \"value\" : \"value\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"translations\" : [ null, null ],\n    \"name\" : \"name\",\n    \"id\" : \"id\",\n    \"type\" : \"type\",\n    \"category\" : \"category\",\n    \"value\" : \"value\"\n  } ],\n  \"userCustomFields\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"translations\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"language\" : \"language\",\n      \"id\" : \"id\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"language\" : \"language\",\n      \"id\" : \"id\"\n    } ],\n    \"name\" : \"name\",\n    \"id\" : \"id\",\n    \"value\" : \"value\"\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"translations\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"language\" : \"language\",\n      \"id\" : \"id\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"language\" : \"language\",\n      \"id\" : \"id\"\n    } ],\n    \"name\" : \"name\",\n    \"id\" : \"id\",\n    \"value\" : \"value\"\n  } ],\n  \"company\" : \"company\",\n  \"id\" : \"id\",\n  \"locked\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"email\" : \"email\",\n  \"address\" : {\n    \"zipcode\" : \"zipcode\",\n    \"country\" : \"country\",\n    \"city\" : \"city\",\n    \"address2\" : \"address2\",\n    \"address1\" : \"address1\",\n    \"state\" : \"state\"\n  },\n  \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"firstName\" : \"firstName\",\n  \"external\" : {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"provider\" : \"provider\",\n    \"id\" : \"id\",\n    \"providerName\" : \"providerName\"\n  },\n  \"phone\" : \"phone\",\n  \"name\" : \"name\",\n  \"timezoneId\" : \"timezoneId\",\n  \"hasDelegates\" : true,\n  \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n  \"account\" : {\n    \"owner\" : \"owner\",\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"customFields\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\",\n      \"required\" : true\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\",\n      \"required\" : true\n    } ],\n    \"logoUrl\" : \"logoUrl\",\n    \"licenses\" : [ {\n      \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"transactions\" : [ {\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"price\" : {\n          \"amount\" : 0,\n          \"currency\" : {\n            \"data\" : {\n              \"key\" : { }\n            },\n            \"name\" : \"name\",\n            \"id\" : \"id\"\n          }\n        },\n        \"creditCard\" : {\n          \"number\" : \"number\",\n          \"cvv\" : \"cvv\",\n          \"name\" : \"name\",\n          \"expiration\" : {\n            \"month\" : 1,\n            \"year\" : 6\n          },\n          \"type\" : \"type\"\n        }\n      }, {\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"price\" : {\n          \"amount\" : 0,\n          \"currency\" : {\n            \"data\" : {\n              \"key\" : { }\n            },\n            \"name\" : \"name\",\n            \"id\" : \"id\"\n          }\n        },\n        \"creditCard\" : {\n          \"number\" : \"number\",\n          \"cvv\" : \"cvv\",\n          \"name\" : \"name\",\n          \"expiration\" : {\n            \"month\" : 1,\n            \"year\" : 6\n          },\n          \"type\" : \"type\"\n        }\n      } ],\n      \"plan\" : {\n        \"features\" : {\n          \"key\" : { }\n        },\n        \"quotas\" : [ {\n          \"scope\" : \"SENDER\",\n          \"limit\" : 5,\n          \"cycle\" : \"DAY\",\n          \"target\" : \"SIGNER\"\n        }, {\n          \"scope\" : \"SENDER\",\n          \"limit\" : 5,\n          \"cycle\" : \"DAY\",\n          \"target\" : \"SIGNER\"\n        } ],\n        \"original\" : \"original\",\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"contract\" : \"DAY\",\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"id\" : \"id\",\n        \"freeCycles\" : {\n          \"count\" : 5,\n          \"cycle\" : \"DAY\"\n        },\n        \"cycle\" : \"DAY\",\n        \"group\" : \"group\"\n      },\n      \"status\" : \"ACTIVE\"\n    }, {\n      \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"transactions\" : [ {\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"price\" : {\n          \"amount\" : 0,\n          \"currency\" : {\n            \"data\" : {\n              \"key\" : { }\n            },\n            \"name\" : \"name\",\n            \"id\" : \"id\"\n          }\n        },\n        \"creditCard\" : {\n          \"number\" : \"number\",\n          \"cvv\" : \"cvv\",\n          \"name\" : \"name\",\n          \"expiration\" : {\n            \"month\" : 1,\n            \"year\" : 6\n          },\n          \"type\" : \"type\"\n        }\n      }, {\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"price\" : {\n          \"amount\" : 0,\n          \"currency\" : {\n            \"data\" : {\n              \"key\" : { }\n            },\n            \"name\" : \"name\",\n            \"id\" : \"id\"\n          }\n        },\n        \"creditCard\" : {\n          \"number\" : \"number\",\n          \"cvv\" : \"cvv\",\n          \"name\" : \"name\",\n          \"expiration\" : {\n            \"month\" : 1,\n            \"year\" : 6\n          },\n          \"type\" : \"type\"\n        }\n      } ],\n      \"plan\" : {\n        \"features\" : {\n          \"key\" : { }\n        },\n        \"quotas\" : [ {\n          \"scope\" : \"SENDER\",\n          \"limit\" : 5,\n          \"cycle\" : \"DAY\",\n          \"target\" : \"SIGNER\"\n        }, {\n          \"scope\" : \"SENDER\",\n          \"limit\" : 5,\n          \"cycle\" : \"DAY\",\n          \"target\" : \"SIGNER\"\n        } ],\n        \"original\" : \"original\",\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"contract\" : \"DAY\",\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"id\" : \"id\",\n        \"freeCycles\" : {\n          \"count\" : 5,\n          \"cycle\" : \"DAY\"\n        },\n        \"cycle\" : \"DAY\",\n        \"group\" : \"group\"\n      },\n      \"status\" : \"ACTIVE\"\n    } ],\n    \"logoAltTextKey\" : \"logoAltTextKey\",\n    \"name\" : \"name\",\n    \"timezoneId\" : \"timezoneId\",\n    \"company\" : {\n      \"address\" : {\n        \"zipcode\" : \"zipcode\",\n        \"country\" : \"country\",\n        \"city\" : \"city\",\n        \"address2\" : \"address2\",\n        \"address1\" : \"address1\",\n        \"state\" : \"state\"\n      },\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"name\" : \"name\",\n      \"id\" : \"id\"\n    },\n    \"id\" : \"id\",\n    \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"providers\" : {\n      \"documents\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"provides\" : \"provides\",\n        \"name\" : \"name\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"provides\" : \"provides\",\n        \"name\" : \"name\",\n        \"id\" : \"id\"\n      } ],\n      \"users\" : [ null, null ]\n    }\n  },\n  \"status\" : \"INVITED\",\n  \"activated\" : \"2000-01-23T04:56:07.000+00:00\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Sender>(exampleJson)
                        : default(Sender);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Adds delegates to a specified user.
        /// </summary>
        /// <remarks>A delegate can&amp;#58; (1) access the delegator&#x27;s inbox, drafts, layouts, and templates; (2) sign documents on behalf of the delegator. &lt;p&gt;All currently existing delegates will be replaced with delegates provided in a request body&lt;/p&gt; &lt;p&gt;Request body can have one of two formats:&lt;/p&gt; &lt;ul&gt; &lt;li&gt;array of string&lt;/li&gt; &lt;li&gt;array of DelegationUser&lt;/li&gt; &lt;/ul&gt; &lt;p&gt;Examples:&lt;/p&gt; &lt;p&gt;* array of string&lt;/p&gt; &lt;code&gt; [ \&quot;userUid1\&quot;, \&quot;userUid2\&quot;, \&quot;userUid3\&quot; ] &lt;/code&gt; &lt;p&gt; * array of DelegationUser&lt;/p&gt; &lt;code&gt; [ { \&quot;id\&quot;&amp;#58; \&quot;userUid1\&quot;, \&quot;expiryDate\&quot;&amp;#58; \&quot;2020-05-30\&quot; }, { \&quot;id\&quot;&amp;#58; \&quot;userUid2\&quot;, \&quot;expiryDate\&quot;&amp;#58; \&quot;2020-05-20\&quot; }, \&quot;userUid3\&quot; ] &lt;/code&gt; &lt;p&gt;String with user UID only, like \&quot;userUid3\&quot; above, will be deserialized to DelegationUser.&lt;/p&gt;</remarks>
        /// <param name="body">The custom field to be updated.</param>
        /// <param name="senderId">The unique sender id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/account/senders/{senderId}/delegates")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountSendersSenderIdDelegatesPut")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountSendersSenderIdDelegatesPut([FromBody]List<DelegationUser> body, [FromRoute][Required]string senderId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));

            throw new NotImplementedException();
        }
    }
}
