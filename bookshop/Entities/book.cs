using bookshop.Enum;

namespace bookshop.Entities
{
    public class book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int pagecount { get; set; }
        
        public int CategoryId  { get; set; }
        public Category Category { get; set; }

    }
}
