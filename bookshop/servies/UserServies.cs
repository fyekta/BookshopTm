using bookshop.Entities;
using bookshop.Infrastructure.Repository;

namespace bookshop.servies
{
    public class UserServies : IUserServies
    {
        private readonly IUserRepository _userRepository;

        public UserServies()
        {
            _userRepository = new UserRepository();
        }

        public User GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }

        public void Register(User user)
        {
            
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);
            _userRepository.AddUser(user);
        }

        public bool ValidatePassword(User user, string password)
        {
            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }
    }
}
