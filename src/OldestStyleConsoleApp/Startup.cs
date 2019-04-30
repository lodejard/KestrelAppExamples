using Microsoft.AspNetCore.Builder;

namespace OldestStyleConsoleApp
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMiddleware<SampleMiddleware>();
        }
    }
}
