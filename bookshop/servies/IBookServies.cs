using bookshop.Entities;

namespace bookshop.servies
{
    public interface IBookServies
    {
        public List<book> GetBooks();
        public void Create(book book);
        public void Delete(int id);
        public void Update(book book);
        public book GetById(int id);
    }
}
