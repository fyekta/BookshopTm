using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository()
        {
            _context = new AppDbContext();
        }

        public User GetUserByUsername(string username)
        {
            return _context.users.FirstOrDefault(u => u.Username == username);
        }

        public void AddUser(User user)
        {
            _context.users.Add(user);
            _context.SaveChanges();
        }
    }
}
