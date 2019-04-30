using Microsoft.AspNetCore.Http;
using System.Text;
using System.Threading.Tasks;

namespace OldStyleConsoleApp
{
    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            bool thisRequestIsForMe = true;

            if (thisRequestIsForMe)
            {
                var helloWorld = Encoding.UTF8.GetBytes("Hello world!");

                context.Response.Headers["Content-Type"] = "text/plain";
                await context.Response.Body.WriteAsync(helloWorld, 0, helloWorld.Length);
            }
            else
            {
                await _next(context);
            }
        }
    }
}
