using JWTRefreshToken.DTO;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace JWTRefreshToken.Exceptions
{
    public class GlobalExceptions : IExceptionHandler
    {
        private readonly ILogger<GlobalExceptions> _logger;

        public GlobalExceptions(ILogger<GlobalExceptions> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            _logger.LogError(exception, exception.Message);
            var response = new ErrorResponse
            {
                Message = exception.Message,
            };

            switch (exception)
            {
                case BadHttpRequestException:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    response.Title = exception.GetType().Name;
                    break;

                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    response.Title = "Internal Server Error";
                    break;
            }

            httpContext.Response.StatusCode = response.StatusCode;
            await httpContext.Response.WriteAsJsonAsync(response, cancellationToken);

            return true;
        }
    }
}
