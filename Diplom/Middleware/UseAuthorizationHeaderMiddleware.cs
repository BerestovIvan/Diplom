using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Diplom.Middleware
{
    public class UseAuthorizationHeaderMiddleware
    {
        readonly RequestDelegate next;

        public UseAuthorizationHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var token = context.Session.GetString("token");
            if (!string.IsNullOrEmpty(token))
            {
                context.Request.Headers.Add("Authorization", "Bearer " + token);
            }
            await next(context);
        }
    }
}
