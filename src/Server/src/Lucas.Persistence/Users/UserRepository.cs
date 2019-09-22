using Lucas.Domain.Users;
using Lucas.Persistence.Common;
using System;

namespace Lucas.Persistence.Users
{
    public class UserRepository : Repository<LucasContext>, IUserRepository
    {
        public UserRepository(LucasContext context) : base(context)
        {

        }

        public User RetrieveByKey(int id)
        {
            throw new NotImplementedException();
        }
    }
}
