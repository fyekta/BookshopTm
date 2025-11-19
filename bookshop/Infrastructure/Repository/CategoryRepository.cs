using bookshop.Entities;
using System;

namespace bookshop.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository()
        {
            _context = new AppDbContext();
        }

        public void Create(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == id);
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public Category GetById(int id)
        {
            return _context.Categories.Where(s => s.Id == id).FirstOrDefault();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public void Update(Category category)
        {
            var existingcategory = _context.Categories.Where(s => s.Id == category.Id).FirstOrDefault();

            if (existingcategory != null)
            {
                existingcategory.Name = category.Name;
                

            }
            _context.SaveChanges();
        }
    }

}