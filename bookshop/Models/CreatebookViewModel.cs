using bookshop.Entities;

namespace bookshop.Models
{
    public class CreateBookViewModel
    {
        public book book { get; set; }
        public List<Category> categories { get; set; }
    }
   
}
