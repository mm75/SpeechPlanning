using MarioMendonca.SpeechPlanning.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace MarioMendonca.SpeechPlanning.Presentation.Util
{
    public class ExecuteMigrations
    {
        public static void Execute(IHost host)
        {
            Log.Information("Migrations: {0}", "Performing migrations");

            using IServiceScope scope = host.Services.CreateScope();

            SqlContext databaseContext =
                scope.ServiceProvider.GetRequiredService<SqlContext>();

            databaseContext.Database.Migrate();
        }
    }
}