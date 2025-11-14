using bookshop.Entities;

namespace bookshop.Infrastructure.Repository
{
    public interface ICategoryRepository
    {
        public List<Category> GetCategories();
    }
}
