using Hornero.Clean.Domain.Entities;

namespace Hornero.Clean.Application.Authentication.Common
{
    public record AuthenticationResult(
        User User,
        string Token
    );
}