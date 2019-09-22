using Lucas.Domain.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lucas.Application.Users
{
    public interface IUserService
    {
         Task<ActionResult<IEnumerable<User>>> GetUser();
    }
}
