using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using System;

namespace TestAppConfig
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    var settings = config.Build();

                    config.AddAzureAppConfiguration(options =>
                        //options.ConnectWithManagedIdentity(settings["AppConfig:Endpoint"]
                        options.ConnectWithManagedIdentity("https://exampleconfiguration.azconfig.io")
                            .Use("TestApp:Settings:*")
                            .WatchAndReloadAll("TestApp:Settings:Sentinal", TimeSpan.FromSeconds(5)));
                })
                .UseStartup<Startup>();


    }
}
