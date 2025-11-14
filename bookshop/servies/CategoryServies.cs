using bookshop.Entities;
using bookshop.Infrastructure.Repository;

namespace bookshop.servies
{
    public class CategoryServies : ICategoryServies
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryServies()
        {
            _categoryRepository = new CategoryRepository();
        }

       

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
