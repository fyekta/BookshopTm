using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public interface IBookRepository
    {
        public List<book> GetBooks();
        public void Create(book book);
        public void Delete(int id);
        public void Update(book book);
        public book GetById(int id);
    }
}
