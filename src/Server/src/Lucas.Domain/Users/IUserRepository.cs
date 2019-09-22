using Lucas.Domain.Users;

namespace Lucas.Domain.Users
{
    public interface IUserRepository : IRepository
    {
        User RetrieveByKey(int id);
    }
}
