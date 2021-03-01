using Autofac.Extensions.DependencyInjection;
using MarioMendonca.SpeechPlanning.Presentation.Util;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace MarioMendonca.SpeechPlanning.Presentation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Log.Logger = Logger.FactoryLogger();

            Log.Information("Application: {0}", "Starting up");

            IHost host = CreateHostBuilder(args).Build();

            ExecuteMigrations.Execute(host);

            host.Run();        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(((context, builder) =>
                {
                    builder.AddEnvironmentVariables("APP_CONFIG_");
                }))
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
