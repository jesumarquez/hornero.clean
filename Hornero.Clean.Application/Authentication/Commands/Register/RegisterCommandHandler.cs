using System.Threading;
using System.Threading.Tasks;
using Hornero.Clean.Application.Authentication.Common;
using MediatR;

namespace Hornero.Clean.Application.Authentication.Commands.Register
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResult>
    {
        public async Task<AuthenticationResult> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;
            
            return new AuthenticationResult(
                User: request.User,
                Token: "token"
            );
        }
    }
}