using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository()
        {
            _context = new AppDbContext();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }

}