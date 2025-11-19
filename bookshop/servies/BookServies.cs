using bookshop.Entities;
using bookshop.Infrastructure.Repository;

namespace bookshop.servies
{
    public class BookServies : IBookServies
    {
        private readonly IBookRepository _bookRepository;

        public BookServies()
        {
            _bookRepository = new BookRepository();
        }

        public void Create(book book)
        {
            _bookRepository.Create(book);

        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<book> GetBooks()
        {
           return _bookRepository.GetBooks();
        }

        public book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Update(book book)
        {
            _bookRepository.Update(book);
        }
    }
}
