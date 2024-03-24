using Infrastructures.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Api.Configurations
{
    public static class DbContextConfiguration
    {
        private const string ConnectionString = "Server={0};Database={1};User Id={2};Password={3};TrustServerCertificate=true;";

        public static void SetApplicationDbContext(
            IServiceCollection collection,
            ConfigurationManager configuration)
        {
            var host = configuration["SQL:Host"];
            var userName = configuration["SQL:UserName"];
            var databaseName = configuration["SQL:DatabaseName"];
            var password = configuration["SQL:Password"];
            var connectionString = string.Format(ConnectionString, host, databaseName, userName, password);

            collection.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
        }
    }
}