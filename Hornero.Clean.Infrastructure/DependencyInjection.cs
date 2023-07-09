using Microsoft.Extensions.DependencyInjection;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Infrastrucutre.Authentication;
using Hornero.Clean.Application.Common.Interfaces.Services;
using Hornero.Clean.Application.Services;
using Microsoft.Extensions.Configuration;
using Hornero.Clean.Application.Common.Persistence;
using Hornero.Clean.Infrastrucutre.Persistence;

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
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}