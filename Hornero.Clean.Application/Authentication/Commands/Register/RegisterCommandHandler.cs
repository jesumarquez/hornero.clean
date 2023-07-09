using System.Threading;
using System.Threading.Tasks;
using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Application.Common.Interfaces.Authentication;
using MediatR;

namespace Hornero.Clean.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult>
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public RegisterCommandHandler(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthenticationResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var token = _jwtTokenGenerator.GenerateToken(request.User.Id, request.User.FirstName, request.User.LastName);
            
            return new AuthenticationResult(
                User: request.User,
                Token: token
            );
        }
    }
}