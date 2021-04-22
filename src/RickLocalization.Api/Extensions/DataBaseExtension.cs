using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Infrastructure.Context;

namespace RickLocalization.Api.Extensions
{
    public static class DataBaseExtension
    {
        public static void AddDataBaseExtension(this IServiceCollection services, IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString(nameof(RickLocalizationDbContext));
            services.AddDbContext<RickLocalizationDbContext>(options => options.UseSqlite(connectionString));
        }

        public static void UseDataBaseExtension(this IApplicationBuilder app, RickLocalizationDbContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
