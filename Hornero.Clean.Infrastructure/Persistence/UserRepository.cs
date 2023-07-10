using System.Collections.Generic;
using Hornero.Clean.Domain.Entities;
using System.Linq;
using Hornero.Clean.Application.Common.Interfaces.Persistence;

namespace Hornero.Clean.Infrastrucutre.Persistence
{
    public class UserRepository : IUserRepository
    {
        private static readonly List<User> _users = new();
        public void Add(User user)
        {
            _users.Add(user);
        }

        public User? GetUserByEmail(string email)
        {
            return _users.SingleOrDefault(u => u.Email == email);
        }
    }
}