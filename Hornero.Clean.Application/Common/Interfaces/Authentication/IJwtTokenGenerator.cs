using System;

namespace Hornero.Clean.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(Guid userId, string firsrName, string lastName);
    }
}