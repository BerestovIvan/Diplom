using Microsoft.AspNetCore.Builder;

namespace Diplom.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSetAuthorizationHeader(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UseAuthorizationHeaderMiddleware>();
        }

        public static IApplicationBuilder UseSetUserHeader(this IApplicationBuilder app)
        {
            return app.UseMiddleware<UseSetUserHeaderMiddleware>();
        }
    }
}
