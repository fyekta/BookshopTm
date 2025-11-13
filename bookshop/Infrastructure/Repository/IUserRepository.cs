using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public interface IUserRepository
    {
        User GetUserByUsername(string username);
        void AddUser(User user);
    }
}
