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

        public void Create(Category category)
        {
           _categoryRepository.Create(category);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }

    }
}
