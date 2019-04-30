using Microsoft.AspNetCore.Hosting;

namespace NewStyleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:9090")
                .UseStartup<Startup>()
                .Build();

            webHost.Run();
        }
    }
}
