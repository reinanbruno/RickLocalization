using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Core.Interfaces.Repositories;
using RickLocalization.Core.Interfaces.UoW;
using RickLocalization.Test.Repositories;
using RickLocalization.Test.UoW;

namespace RickLocalization.Test
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRickRepository, FakeRickRepository>();
            services.AddScoped<IDimensionRepository, FakeDimensionRepository>();
            services.AddScoped<IDimensionTravelledRepository, FakeDimensionTravelledRepository>();
            services.AddScoped<IUnitOfWork, FakeUnitOfWork>();
        }
    }
}
