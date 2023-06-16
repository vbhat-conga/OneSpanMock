using IO.Swagger.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace IO.Swagger.Middleware
{
    public class MultiFormDataMiddleware
    {
        private readonly RequestDelegate _next;
        public MultiFormDataMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var url = context.Request.GetDisplayUrl();
            var contentType = context.Request.Headers.ContentType;
            var  exampleJson = "{\n  \"data\" : {\n    \"key\" : { }\n  },\n  \"description\" : \"description\",\n  \"index\" : 6,\n  \"externalSigned\" : false,\n  \"imprintFields\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"top\" : 1.2315135367772556,\n    \"left\" : 4.145608029883936,\n    \"subtype\" : \"LABEL\",\n    \"editable\" : true,\n    \"name\" : \"name\",\n    \"width\" : 7.386281948385884,\n    \"id\" : \"id\",\n    \"page\" : 2,\n    \"type\" : \"INPUT\",\n    \"value\" : \"value\",\n    \"height\" : 1.0246457001441578\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"top\" : 1.2315135367772556,\n    \"left\" : 4.145608029883936,\n    \"subtype\" : \"LABEL\",\n    \"editable\" : true,\n    \"name\" : \"name\",\n    \"width\" : 7.386281948385884,\n    \"id\" : \"id\",\n    \"page\" : 2,\n    \"type\" : \"INPUT\",\n    \"value\" : \"value\",\n    \"height\" : 1.0246457001441578\n  } ],\n  \"extract\" : true,\n  \"pages\" : [ {\n    \"top\" : 9.965781217890562,\n    \"left\" : 4.965218492984954,\n    \"width\" : 5.025004791520295,\n    \"index\" : 7,\n    \"id\" : \"id\",\n    \"version\" : 1,\n    \"height\" : 9.369310271410669\n  }, {\n    \"top\" : 9.965781217890562,\n    \"left\" : 4.965218492984954,\n    \"width\" : 5.025004791520295,\n    \"index\" : 7,\n    \"id\" : \"id\",\n    \"version\" : 1,\n    \"height\" : 9.369310271410669\n  } ],\n  \"size\" : 1,\n  \"signerVerificationToken\" : \"signerVerificationToken\",\n  \"tagged\" : true,\n  \"approvals\" : [ {\n    \"role\" : \"role\",\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"enforceCaptureSignature\" : true,\n    \"accepted\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"signed\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"optional\" : true,\n    \"id\" : \"id\",\n    \"fields\" : [ null, null ]\n  }, {\n    \"role\" : \"role\",\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"name\" : \"name\",\n    \"enforceCaptureSignature\" : true,\n    \"accepted\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"signed\" : \"2000-01-23T04:56:07.000+00:00\",\n    \"optional\" : true,\n    \"id\" : \"id\",\n    \"fields\" : [ null, null ]\n  } ],\n  \"name\" : \"name\",\n  \"signedHash\" : \"signedHash\",\n  \"id\" : \"id\",\n  \"fields\" : [ {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"binding\" : \"binding\",\n    \"type\" : \"SIGNATURE\",\n    \"extract\" : true,\n    \"top\" : 9.301444243932576,\n    \"left\" : 2.3021358869347655,\n    \"subtype\" : \"FULLNAME\",\n    \"name\" : \"name\",\n    \"width\" : 7.061401241503109,\n    \"id\" : \"id\",\n    \"page\" : 5,\n    \"value\" : \"value\",\n    \"validation\" : {\n      \"minimumRequired\" : 5,\n      \"minLength\" : 1,\n      \"pattern\" : \"pattern\",\n      \"errorMessage\" : \"errorMessage\",\n      \"errorCode\" : 6,\n      \"maxLength\" : 0,\n      \"required\" : true,\n      \"enum\" : [ \"enum\", \"enum\" ],\n      \"group\" : \"group\"\n    },\n    \"extractAnchor\" : {\n      \"topOffset\" : 100,\n      \"anchorPoint\" : \"TOPLEFT\",\n      \"width\" : 200,\n      \"leftOffset\" : 20,\n      \"characterIndex\" : 3,\n      \"index\" : 2,\n      \"text\" : \"Signature:\",\n      \"height\" : 50\n    },\n    \"height\" : 3.616076749251911\n  }, {\n    \"data\" : {\n      \"key\" : { }\n    },\n    \"binding\" : \"binding\",\n    \"type\" : \"SIGNATURE\",\n    \"extract\" : true,\n    \"top\" : 9.301444243932576,\n    \"left\" : 2.3021358869347655,\n    \"subtype\" : \"FULLNAME\",\n    \"name\" : \"name\",\n    \"width\" : 7.061401241503109,\n    \"id\" : \"id\",\n    \"page\" : 5,\n    \"value\" : \"value\",\n    \"validation\" : {\n      \"minimumRequired\" : 5,\n      \"minLength\" : 1,\n      \"pattern\" : \"pattern\",\n      \"errorMessage\" : \"errorMessage\",\n      \"errorCode\" : 6,\n      \"maxLength\" : 0,\n      \"required\" : true,\n      \"enum\" : [ \"enum\", \"enum\" ],\n      \"group\" : \"group\"\n    },\n    \"extractAnchor\" : {\n      \"topOffset\" : 100,\n      \"anchorPoint\" : \"TOPLEFT\",\n      \"width\" : 200,\n      \"leftOffset\" : 20,\n      \"characterIndex\" : 3,\n      \"index\" : 2,\n      \"text\" : \"Signature:\",\n      \"height\" : 50\n    },\n    \"height\" : 3.616076749251911\n  } ],\n  \"extractionTypes\" : [ \"extractionTypes\", \"extractionTypes\" ],\n  \"status\" : \"status\"\n}";
            
            var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Document>(exampleJson)
                        : default(Document);            //TODO: Change the data returned
            if (url.Contains("documents") && !string.IsNullOrWhiteSpace(contentType) && contentType.ToString().StartsWith("multipart",StringComparison.OrdinalIgnoreCase))
            {
               await context.Response.WriteAsJsonAsync(new ObjectResult(example));
            }
            else  if (!string.IsNullOrWhiteSpace(contentType) && contentType.ToString().StartsWith("multipart",StringComparison.OrdinalIgnoreCase))
            {
                await context.Response.WriteAsJsonAsync(new OkResult());              
            }
            else
            {
                await _next(context);
            }
        }
    }


    public static class MultiFormDataMiddlewareExtensions
    {
        public static IApplicationBuilder UseMultiFormDataMiddleware(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MultiFormDataMiddleware>();
        }
    }
}
