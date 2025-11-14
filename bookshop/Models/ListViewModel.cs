using bookshop.Entities;

namespace bookshop.Models
{
    public class ListViewModel
    {
        public List<Category> categories { get; set; }
        public List<book> books { get; set; }
    }
}
