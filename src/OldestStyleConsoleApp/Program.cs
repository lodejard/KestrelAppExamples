using Microsoft.AspNetCore.Hosting;

namespace OldestStyleConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var webHost = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:9292")
                .UseStartup<Startup>()
                .Build();

            webHost.Run();
        }
    }
}
