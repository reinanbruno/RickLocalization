using Microsoft.Extensions.DependencyInjection;
using RickLocalization.Api.Filters;
using FluentValidation.AspNetCore;
using System.Reflection;
using System;

namespace RickLocalization.Api.Extensions
{
    public static class MvcExtension
    {
        public static void AddMvcExtension(this IServiceCollection services)
        {
            Assembly assembly = AppDomain.CurrentDomain.Load("RickLocalization.Application");
            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(ModelStateValidatorFilter));
            }).AddJsonOptions(options =>            {
                options.JsonSerializerOptions.IgnoreNullValues = true;
            }).AddFluentValidation(options =>
                options.RegisterValidatorsFromAssembly(assembly)
            );
        }
    }
}
