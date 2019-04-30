using Microsoft.AspNetCore.Builder;

namespace OldStyleConsoleApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<SampleMiddleware>();
        }
    }
}
