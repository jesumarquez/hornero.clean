using ErrorOr;
using Hornero.Clean.Application.Authentication.Common;
using MediatR;

namespace Hornero.Clean.Application.Authentication.Queries.Login
{
    public record LoginQuery(
        string Email,
        string Password
    ) : IRequest<ErrorOr<AuthenticationResult>>;
}