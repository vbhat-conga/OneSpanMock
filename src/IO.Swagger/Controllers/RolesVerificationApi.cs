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
    public class RolesVerificationApiController : ControllerBase
    { 
        /// <summary>
        /// Retrieves advanced verification types.
        /// </summary>
        /// <remarks>Retrieves a list of verification types that are available in the account.</remarks>
        /// <param name="accountId">The unique account id.</param>
        /// <response code="200">OK</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/account/{accountId}/verificationTypes")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiAccountAccountIdVerificationTypesGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(InlineResponse200), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiAccountAccountIdVerificationTypesGet([FromRoute][Required]string accountId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(InlineResponse200));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"count\" : 0,\n  \"results\" : [ {\n    \"lastName\" : \"lastName\",\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"signature\" : {\n      \"handdrawn\" : \"handdrawn\",\n      \"textual\" : {\n        \"color\" : \"color\",\n        \"font\" : \"font\"\n      }\n    },\n    \"specialTypes\" : [ \"NOTARY\", \"NOTARY\" ],\n    \"language\" : \"language\",\n    \"type\" : \"REGULAR\",\n    \"title\" : \"title\",\n    \"memberships\" : [ {\n      \"groupName\" : \"groupName\",\n      \"groupId\" : \"groupId\",\n      \"memberType\" : \"REGULAR\"\n    }, {\n      \"groupName\" : \"groupName\",\n      \"groupId\" : \"groupId\",\n      \"memberType\" : \"REGULAR\"\n    } ],\n    \"professionalIdentityFields\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ null, null ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"type\" : \"type\",\n      \"category\" : \"category\",\n      \"value\" : \"value\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ null, null ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"type\" : \"type\",\n      \"category\" : \"category\",\n      \"value\" : \"value\"\n    } ],\n    \"userCustomFields\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\"\n    } ],\n    \"company\" : \"company\",\n    \"id\" : \"id\",\n    \"locked\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"email\" : \"email\",\n    \"address\" : {\n      \"zipcode\" : \"zipcode\",\n      \"country\" : \"country\",\n      \"city\" : \"city\",\n      \"address2\" : \"address2\",\n      \"address1\" : \"address1\",\n      \"state\" : \"state\"\n    },\n    \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"firstName\" : \"firstName\",\n    \"external\" : {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"provider\" : \"provider\",\n      \"id\" : \"id\",\n      \"providerName\" : \"providerName\"\n    },\n    \"phone\" : \"phone\",\n    \"name\" : \"name\",\n    \"timezoneId\" : \"timezoneId\",\n    \"hasDelegates\" : true,\n    \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"account\" : {\n      \"owner\" : \"owner\",\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"customFields\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"translations\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        } ],\n        \"name\" : \"name\",\n        \"id\" : \"id\",\n        \"value\" : \"value\",\n        \"required\" : true\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"translations\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        } ],\n        \"name\" : \"name\",\n        \"id\" : \"id\",\n        \"value\" : \"value\",\n        \"required\" : true\n      } ],\n      \"logoUrl\" : \"logoUrl\",\n      \"licenses\" : [ {\n        \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"transactions\" : [ {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        }, {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        } ],\n        \"plan\" : {\n          \"features\" : {\n            \"key\" : { }\n          },\n          \"quotas\" : [ {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          }, {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          } ],\n          \"original\" : \"original\",\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"contract\" : \"DAY\",\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"id\" : \"id\",\n          \"freeCycles\" : {\n            \"count\" : 5,\n            \"cycle\" : \"DAY\"\n          },\n          \"cycle\" : \"DAY\",\n          \"group\" : \"group\"\n        },\n        \"status\" : \"ACTIVE\"\n      }, {\n        \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"transactions\" : [ {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        }, {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        } ],\n        \"plan\" : {\n          \"features\" : {\n            \"key\" : { }\n          },\n          \"quotas\" : [ {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          }, {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          } ],\n          \"original\" : \"original\",\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"contract\" : \"DAY\",\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"id\" : \"id\",\n          \"freeCycles\" : {\n            \"count\" : 5,\n            \"cycle\" : \"DAY\"\n          },\n          \"cycle\" : \"DAY\",\n          \"group\" : \"group\"\n        },\n        \"status\" : \"ACTIVE\"\n      } ],\n      \"logoAltTextKey\" : \"logoAltTextKey\",\n      \"name\" : \"name\",\n      \"timezoneId\" : \"timezoneId\",\n      \"company\" : {\n        \"address\" : {\n          \"zipcode\" : \"zipcode\",\n          \"country\" : \"country\",\n          \"city\" : \"city\",\n          \"address2\" : \"address2\",\n          \"address1\" : \"address1\",\n          \"state\" : \"state\"\n        },\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"id\" : \"id\"\n      },\n      \"id\" : \"id\",\n      \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"providers\" : {\n        \"documents\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"provides\" : \"provides\",\n          \"name\" : \"name\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"provides\" : \"provides\",\n          \"name\" : \"name\",\n          \"id\" : \"id\"\n        } ],\n        \"users\" : [ null, null ]\n      }\n    },\n    \"status\" : \"INVITED\",\n    \"activated\" : \"2000-01-23T04:56:07.000+00:00\"\n  }, {\n    \"lastName\" : \"lastName\",\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"signature\" : {\n      \"handdrawn\" : \"handdrawn\",\n      \"textual\" : {\n        \"color\" : \"color\",\n        \"font\" : \"font\"\n      }\n    },\n    \"specialTypes\" : [ \"NOTARY\", \"NOTARY\" ],\n    \"language\" : \"language\",\n    \"type\" : \"REGULAR\",\n    \"title\" : \"title\",\n    \"memberships\" : [ {\n      \"groupName\" : \"groupName\",\n      \"groupId\" : \"groupId\",\n      \"memberType\" : \"REGULAR\"\n    }, {\n      \"groupName\" : \"groupName\",\n      \"groupId\" : \"groupId\",\n      \"memberType\" : \"REGULAR\"\n    } ],\n    \"professionalIdentityFields\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ null, null ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"type\" : \"type\",\n      \"category\" : \"category\",\n      \"value\" : \"value\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ null, null ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"type\" : \"type\",\n      \"category\" : \"category\",\n      \"value\" : \"value\"\n    } ],\n    \"userCustomFields\" : [ {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\"\n    }, {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"translations\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"description\" : \"description\",\n        \"language\" : \"language\",\n        \"id\" : \"id\"\n      } ],\n      \"name\" : \"name\",\n      \"id\" : \"id\",\n      \"value\" : \"value\"\n    } ],\n    \"company\" : \"company\",\n    \"id\" : \"id\",\n    \"locked\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"email\" : \"email\",\n    \"address\" : {\n      \"zipcode\" : \"zipcode\",\n      \"country\" : \"country\",\n      \"city\" : \"city\",\n      \"address2\" : \"address2\",\n      \"address1\" : \"address1\",\n      \"state\" : \"state\"\n    },\n    \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"firstName\" : \"firstName\",\n    \"external\" : {\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"provider\" : \"provider\",\n      \"id\" : \"id\",\n      \"providerName\" : \"providerName\"\n    },\n    \"phone\" : \"phone\",\n    \"name\" : \"name\",\n    \"timezoneId\" : \"timezoneId\",\n    \"hasDelegates\" : true,\n    \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"account\" : {\n      \"owner\" : \"owner\",\n      \"data\" : {\n        \"key\" : { }\n      },\n      \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"customFields\" : [ {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"translations\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        } ],\n        \"name\" : \"name\",\n        \"id\" : \"id\",\n        \"value\" : \"value\",\n        \"required\" : true\n      }, {\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"translations\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"language\" : \"language\",\n          \"id\" : \"id\"\n        } ],\n        \"name\" : \"name\",\n        \"id\" : \"id\",\n        \"value\" : \"value\",\n        \"required\" : true\n      } ],\n      \"logoUrl\" : \"logoUrl\",\n      \"licenses\" : [ {\n        \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"transactions\" : [ {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        }, {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        } ],\n        \"plan\" : {\n          \"features\" : {\n            \"key\" : { }\n          },\n          \"quotas\" : [ {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          }, {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          } ],\n          \"original\" : \"original\",\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"contract\" : \"DAY\",\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"id\" : \"id\",\n          \"freeCycles\" : {\n            \"count\" : 5,\n            \"cycle\" : \"DAY\"\n          },\n          \"cycle\" : \"DAY\",\n          \"group\" : \"group\"\n        },\n        \"status\" : \"ACTIVE\"\n      }, {\n        \"paidUntil\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n        \"transactions\" : [ {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        }, {\n          \"created\" : \"2000-01-23T04:56:07.000+00:00\",\n          \"price\" : {\n            \"amount\" : 0,\n            \"currency\" : {\n              \"data\" : {\n                \"key\" : { }\n              },\n              \"name\" : \"name\",\n              \"id\" : \"id\"\n            }\n          },\n          \"creditCard\" : {\n            \"number\" : \"number\",\n            \"cvv\" : \"cvv\",\n            \"name\" : \"name\",\n            \"expiration\" : {\n              \"month\" : 1,\n              \"year\" : 6\n            },\n            \"type\" : \"type\"\n          }\n        } ],\n        \"plan\" : {\n          \"features\" : {\n            \"key\" : { }\n          },\n          \"quotas\" : [ {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          }, {\n            \"scope\" : \"SENDER\",\n            \"limit\" : 5,\n            \"cycle\" : \"DAY\",\n            \"target\" : \"SIGNER\"\n          } ],\n          \"original\" : \"original\",\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"contract\" : \"DAY\",\n          \"name\" : \"name\",\n          \"description\" : \"description\",\n          \"id\" : \"id\",\n          \"freeCycles\" : {\n            \"count\" : 5,\n            \"cycle\" : \"DAY\"\n          },\n          \"cycle\" : \"DAY\",\n          \"group\" : \"group\"\n        },\n        \"status\" : \"ACTIVE\"\n      } ],\n      \"logoAltTextKey\" : \"logoAltTextKey\",\n      \"name\" : \"name\",\n      \"timezoneId\" : \"timezoneId\",\n      \"company\" : {\n        \"address\" : {\n          \"zipcode\" : \"zipcode\",\n          \"country\" : \"country\",\n          \"city\" : \"city\",\n          \"address2\" : \"address2\",\n          \"address1\" : \"address1\",\n          \"state\" : \"state\"\n        },\n        \"data\" : {\n          \"key\" : { }\n        },\n        \"name\" : \"name\",\n        \"id\" : \"id\"\n      },\n      \"id\" : \"id\",\n      \"updated\" : \"2000-01-23T04:56:07.000+00:00\",\n      \"providers\" : {\n        \"documents\" : [ {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"provides\" : \"provides\",\n          \"name\" : \"name\",\n          \"id\" : \"id\"\n        }, {\n          \"data\" : {\n            \"key\" : { }\n          },\n          \"provides\" : \"provides\",\n          \"name\" : \"name\",\n          \"id\" : \"id\"\n        } ],\n        \"users\" : [ null, null ]\n      }\n    },\n    \"status\" : \"INVITED\",\n    \"activated\" : \"2000-01-23T04:56:07.000+00:00\"\n  } ]\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<InlineResponse200>(exampleJson)
                        : default(InlineResponse200);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Deletes an advanced verification method, for a specified role.
        /// </summary>
        /// <remarks>If an advanced form of verification is used, such as an external verification method, then this call deletes that verification method, for the specified role.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/api/packages/{packageId}/roles/{roleId}/verification")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdRolesRoleIdVerificationDelete")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdRolesRoleIdVerificationDelete([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

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

            throw new NotImplementedException();
        }

        /// <summary>
        /// Retrieves information on the type of verification being used.
        /// </summary>
        /// <remarks>If an advanced form of verification is used, such as an external verification method, then this call retrieves information about that verification method, for the specified role.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <response code="200">OK</response>
        /// <response code="204">OK. No verification is assigned to the role.</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpGet]
        [Route("/api/packages/{packageId}/roles/{roleId}/verification")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdRolesRoleIdVerificationGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Verification), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdRolesRoleIdVerificationGet([FromRoute][Required]string packageId, [FromRoute][Required]string roleId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Verification));

            //TODO: Uncomment the next line to return response 204 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(204);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(DefaultError));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(DefaultError));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(DefaultError));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(DefaultError));
            string exampleJson = null;
            exampleJson = "{\n  \"payload\" : \"payload\",\n  \"typeId\" : \"typeId\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Verification>(exampleJson)
                        : default(Verification);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Creates an advanced form of verification.
        /// </summary>
        /// <remarks>Creates an advanced form of verification for a role, such as an external verification method role.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpPost]
        [Route("/api/packages/{packageId}/roles/{roleId}/verification")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdRolesRoleIdVerificationPost")]
        [SwaggerResponse(statusCode: 200, type: typeof(Verification), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdRolesRoleIdVerificationPost([FromRoute][Required]string packageId, [FromRoute][Required]string roleId, [FromBody]Verification body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Verification));

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
            exampleJson = "{\n  \"payload\" : \"payload\",\n  \"typeId\" : \"typeId\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Verification>(exampleJson)
                        : default(Verification);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Updates an advanced verification method.
        /// </summary>
        /// <remarks>Updates an existing advanced form of verification, such as an external verification method, for the specified role.</remarks>
        /// <param name="packageId">The unique package id.</param>
        /// <param name="roleId">The unique role id within the package.</param>
        /// <param name="body"></param>
        /// <response code="200">OK</response>
        /// <response code="400">Validation error</response>
        /// <response code="401">Not Authorized</response>
        /// <response code="403">Access Denied error</response>
        /// <response code="404">The specified resource was not found</response>
        /// <response code="0">Unexpected error</response>
        [HttpPut]
        [Route("/api/packages/{packageId}/roles/{roleId}/verification")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("ApiPackagesPackageIdRolesRoleIdVerificationPut")]
        [SwaggerResponse(statusCode: 200, type: typeof(Verification), description: "OK")]
        [SwaggerResponse(statusCode: 400, type: typeof(DefaultError), description: "Validation error")]
        [SwaggerResponse(statusCode: 401, type: typeof(DefaultError), description: "Not Authorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(DefaultError), description: "Access Denied error")]
        [SwaggerResponse(statusCode: 404, type: typeof(DefaultError), description: "The specified resource was not found")]
        [SwaggerResponse(statusCode: 0, type: typeof(DefaultError), description: "Unexpected error")]
        public virtual IActionResult ApiPackagesPackageIdRolesRoleIdVerificationPut([FromRoute][Required]string packageId, [FromRoute][Required]string roleId, [FromBody]Verification body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Verification));

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
            exampleJson = "{\n  \"payload\" : \"payload\",\n  \"typeId\" : \"typeId\"\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Verification>(exampleJson)
                        : default(Verification);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
