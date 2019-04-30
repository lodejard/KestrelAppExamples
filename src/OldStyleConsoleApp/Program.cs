using Microsoft.AspNetCore.Hosting;

namespace OldStyleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:9191")
                .UseStartup<Startup>()
                .Build();

            webHost.Run();
        }
    }
}
