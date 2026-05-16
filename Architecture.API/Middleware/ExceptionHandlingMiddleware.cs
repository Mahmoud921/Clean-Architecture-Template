using System.Text.Json;
using Architecture.Application.Exceptions;

namespace Architecture.API.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (BaseException ex)
            {
                context.Response.ContentType = "application/json";

                context.Response.StatusCode = ex.StatusCode;

                var response = new
                {
                    Success = false,
                    Message = ex.Message,
                    Errors = (ex is ValidationException validationException) ? validationException.Errors : null

                };

                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(response));
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";

                context.Response.StatusCode = 500;

                var response = new
                {
                    Success = false,
                    Message = "Internal Server Error",
                    Errors = (ex is ValidationException validationException)

                };

                await context.Response.WriteAsync(
                    JsonSerializer.Serialize(response));
            }
        }
    }
}