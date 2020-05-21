using Arena.Domain.Entities;
using Arena.Domain.Repositories;

namespace Arena.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool Save(User user)
        {
            return true;
        }
    }
}
