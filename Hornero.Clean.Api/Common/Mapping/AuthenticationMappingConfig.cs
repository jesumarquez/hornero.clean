using Hornero.Clean.Application.Authentication.Commands.Register;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Application.Authentication.Queries.Login;
using Hornero.Clean.Contract.Authentication;
using Mapster;

namespace Hornero.Clean.Api.Common.Mapping
{
    public class AuthenticationMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<RegisterRequest, RegisterCommand>()
                .Map(dest => dest.User, src => src);

            config.NewConfig<LoginRequest, LoginQuery>();

            config.NewConfig<AuthenticationResult, AuthenticationResponse>()
                .Map(dest => dest, src => src.User);
        }
    }
}