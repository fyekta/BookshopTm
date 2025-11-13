using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public interface IBookRepository
    {
        public List<book> GetBooks();
    }
}
