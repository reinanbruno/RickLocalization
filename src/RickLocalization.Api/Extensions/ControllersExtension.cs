using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;

namespace RickLocalization.Api.Extensions
{
    public static class ControllersExtension
    {
        public static void AddControllersExtensions(this IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson(options => {
                options.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
        }
    }
}
