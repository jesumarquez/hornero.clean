using Hornero.Clean.Api.Common.Mapping;
using Hornero.Clean.Api.Errors;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Hornero.Clean.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, HorneroCleanProblemDetailsFactory>();
            services.AddMappings();

            return services;
        }
    }
}