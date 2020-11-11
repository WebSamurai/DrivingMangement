using Microsoft.Extensions.Configuration;

namespace DriveMigrator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
          IConfiguration Configuration = new ConfigurationBuilder()
       .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
       .Build();
            Migrater.Migrate(Configuration);
        }
    }
}