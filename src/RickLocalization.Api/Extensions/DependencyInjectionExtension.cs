using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Interfaces.UoW;
using RickLocalization.Infrastructure.Repositories;

namespace RickLocalization.Api.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddDependencyInjectionExtension(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IDimensionTravelledRepository, DimensionTravelledRepository>();

            services.AddScoped<IRickRepository, RickRepository>();

            services.AddScoped<IDimensionRepository, DimensionRepository>();
        }
    }
}
