using Lucas.Data.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lucas.Models.Persistence.Users
{
    public class UserRepository : Repository<LucasContext>, IUserRepository
    {
        public UserRepository(LucasContext context) : base(context)
        {

        }
    }
}
