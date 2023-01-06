using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Http;

namespace WebApi.Middleware
{
    public class Middleware
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<Middleware> _logger;

        public Middleware(RequestDelegate next, ILogger<Middleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public Task Invoke(HttpContext httpContext)
        {
            _logger.LogInformation("log in middleware");
            return _next(httpContext);
        }
    }
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<Middleware>();
        }
    }
}
