using bookshop.Entities;
using bookshop.Infrastructure.Repository;

namespace bookshop.servies
{
    public class BookServies : IBookServies
    {
        private readonly IBookRepository _userRepository;

        public BookServies()
        {
            _userRepository = new BookRepository();
        }

        public List<book> GetBooks()
        {
           return _userRepository.GetBooks();
        }
    }
}
