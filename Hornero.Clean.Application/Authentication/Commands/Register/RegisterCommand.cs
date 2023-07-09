using Hornero.Clean.Application.Authentication.Common;
using Hornero.Clean.Domain.Entities;
using MediatR;

namespace Hornero.Clean.Application.Authentication.Commands.Register
{
    public record RegisterCommand(
        User User
    ) : IRequest<AuthenticationResult>;
}