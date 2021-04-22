using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Api.Extensions;
using RickLocalization.Infrastructure.Context;
using System;
using System.Reflection;

namespace RickLocalization.Api
{
    public class Startup
    {
        public IConfiguration _configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            Assembly assembly = AppDomain.CurrentDomain.Load("RickLocalization.Application");
            services.AddDependencyInjectionExtension();
            services.AddMediatR(assembly);
            services.AddResponseCompressionExtension();
            services.AddCorsExtension();
            services.AddMvcExtension(assembly);
            services.AddControllersExtensions();
            services.AddSwaggerExtension();
            services.AddDataBaseExtension(_configuration);
            services.AddAutoMapper(assembly);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RickLocalizationDbContext context)
        {
            app.UseRouting();
            app.UseResponseCompressionExtension();
            app.UseCorsExtension();
            app.UseEndPointsExtension();
            app.UseSwaggerExtension(env);
            app.UseDataBaseExtension(context);
        }
    }
}
