using Microsoft.AspNetCore.Builder;

namespace NewStyleConsoleApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<SampleMiddleware>();
        }
    }
}
