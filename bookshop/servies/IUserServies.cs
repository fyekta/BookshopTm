using bookshop.Entities;

namespace bookshop.servies
{
    public interface IUserServies
    {
        User GetUserByUsername(string username);
        void Register(User user);
        bool ValidatePassword(User user, string password);
    }
}
