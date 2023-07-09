using Hornero.Clean.Domain.Entities;

namespace Hornero.Clean.Application.Common.Persistence
{
    public interface IUserRepository
    {
        User? GetUserByEmail(string email);
        void Add(User user);
    }
}