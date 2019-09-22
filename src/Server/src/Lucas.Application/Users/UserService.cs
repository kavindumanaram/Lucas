using Lucas.Domain.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lucas.Application.Users
{
    public class UserService : IUserService
    {
        /// <summary>
        /// Reference to the item repository.
        /// </summary>
        private IUserRepository _userRepository;

        public UserService(
            IUserRepository userRepository
            )
        {
            _userRepository = userRepository;
        }
        /// <summary>
        /// Retrieves item using item id.
        /// </summary>
        /// <param name="id">The item id.</param>
        /// <returns>An instance of <see cref="Item"/>.</returns>
        public User RetrieveById(int id)
        {
            return _userRepository.RetrieveByKey(id);
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _userRepository.FindAll<User>();
        }
    }
}
