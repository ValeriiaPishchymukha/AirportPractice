using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Net;
using Newtonsoft.Json;


namespace WebApplicationAirport.Middleware
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                // Pass the request to the next middleware
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            return context.Response.WriteAsync(JsonConvert.SerializeObject(new ResponseBase<object>(
                context.Response.StatusCode,
                ex.Message,
                VarHelper.ResponseStatus.ERROR.ToString())));
        }
    }
}
