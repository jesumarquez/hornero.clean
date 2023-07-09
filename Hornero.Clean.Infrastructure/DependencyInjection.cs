using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Infrastrucutre.Authentication;
using Hornero.Clean.Application.Common.Interfaces.Services;
using Hornero.Clean.Application.Services;

namespace Hornero.Clean.Infrastrucutre
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();

            return services;
        }
    }
}