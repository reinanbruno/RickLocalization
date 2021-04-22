using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace RickLocalization.Infrastructure.Context
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<RickLocalizationDbContext>
    {
        public RickLocalizationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                    .SetBasePath(Directory.GetCurrentDirectory())
                                                    .AddJsonFile("appsettings.json")
                                                    .Build();

            string connectionString = configuration.GetConnectionString(nameof(RickLocalizationDbContext));
            return new RickLocalizationDbContext(new DbContextOptionsBuilder<RickLocalizationDbContext>().UseSqlite(connectionString).Options);
        }
    }
}
