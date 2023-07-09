using System;

namespace Hornero.Clean.Contract.Authentication
{
    public record AuthenticationResponse(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
    );
}