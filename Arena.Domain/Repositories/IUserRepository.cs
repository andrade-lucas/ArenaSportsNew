using Arena.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arena.Domain.Repositories
{
    public interface IUserRepository
    {
        bool Save(User user);
    }
}
