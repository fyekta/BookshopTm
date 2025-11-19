using bookshop.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace bookshop.Infrastructure.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly AppDbContext _context;

        public BookRepository()
        {
            _context = new AppDbContext();
        }

        public void Create(book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var books = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(books);
            _context.SaveChanges();
        }

        public List<book> GetBooks()
        {
            return _context.Books.Include(x => x.Category).ToList();
        }

        public book GetById(int id)
        {
            //return _context.Books.Where(s => s.Id == id).FirstOrDefault();
           
        
            return _context.Books.Include(b => b.Category).FirstOrDefault(b => b.Id == id);
        
        }

        public void Update(book book)
        {

            var existingbook = _context.Books.Where(s => s.Id == book.Id).FirstOrDefault();

            if (existingbook != null)
            {
                existingbook.Title = book.Title;
                existingbook.Author = book.Author;
                existingbook.pagecount = book.pagecount;
                existingbook.Category = book.Category;

            }
            _context.SaveChanges();
        }
    }
}
