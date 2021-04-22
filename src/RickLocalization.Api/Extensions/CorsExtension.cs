using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickLocalization.Api.Extensions
{
    public static class CorsExtension
    {
        public static void AddCorsExtension(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", build =>
            {
                string[] domainsAlloweds = new string[] {
                    "https://localhost:4200",
                    "http://localhost:4200"
                };

                build.WithOrigins(domainsAlloweds)
                     .AllowAnyMethod()
                     .AllowAnyHeader()
                    .AllowCredentials();
            }));
        }

        public static void UseCorsExtension(this IApplicationBuilder app)
        {
            app.UseCors("ApiCorsPolicy");
        }
    }
}
