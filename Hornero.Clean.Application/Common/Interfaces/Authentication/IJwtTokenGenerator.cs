using System;
using Hornero.Clean.Domain.Entities;

namespace Hornero.Clean.Application.Common.Interfaces.Authentication
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(User user);
    }
}