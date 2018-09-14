using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Voidwell.Logging;

namespace DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://0.0.0.0:5000")
                .ConfigureLogging((context, builder) =>
                {
                    builder.ClearProviders();

                    builder.AddGelf(options =>
                    {
                        options.LogSource = "DemoApp";
                    });
                })
                .Build();
    }
}