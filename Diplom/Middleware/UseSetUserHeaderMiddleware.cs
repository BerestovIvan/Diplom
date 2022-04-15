using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Diplom.Middleware
{
    public class UseSetUserHeaderMiddleware
    {

        readonly RequestDelegate next;

        public UseSetUserHeaderMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var userId = context.Session.GetString("UserId");
            if (!string.IsNullOrEmpty(userId))
            {
                context.Request.Headers.Add("UserId", userId);
            }
            await next(context);
        }
    }
}
