using bookshop.Entities;

namespace bookshop.servies
{
    public interface ICategoryServies
    {
        public List<Category> GetCategories();
        public void Create(Category category);
        public void Delete(int id);
        public void Update(Category category);
        public Category GetById(int id);
    }
}
