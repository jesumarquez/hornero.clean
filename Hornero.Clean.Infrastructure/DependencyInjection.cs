using Microsoft.Extensions.DependencyInjection;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Infrastrucutre.Authentication;
using Hornero.Clean.Application.Common.Interfaces.Services;
using Hornero.Clean.Application.Services;
using Microsoft.Extensions.Configuration;

namespace Hornero.Clean.Infrastrucutre
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, 
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}