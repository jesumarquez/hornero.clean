using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using Hornero.Clean.Infrastrucutre.Authentication;

namespace Hornero.Clean.Infrastrucutre
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            
            return services;
        }
    }
}