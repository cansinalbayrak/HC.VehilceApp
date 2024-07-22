using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;

namespace HC.VehilceApp.WebApi.Extensions
{
    public static class ValidationExtensions
    {
        public static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services
            .AddFluentValidationAutoValidation(config => config.DisableDataAnnotationsValidation = true) 
            .AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
