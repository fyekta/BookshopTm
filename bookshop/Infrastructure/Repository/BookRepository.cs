using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly AppDbContext _context;

        public BookRepository()
        {
            _context = new AppDbContext();
        }

        public List<book> GetBooks()
        {
            return _context.Books.ToList();
        }
    }
}
