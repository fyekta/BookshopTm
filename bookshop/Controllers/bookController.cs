using bookshop.Entities;
using bookshop.servies;
using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class bookController : Controller
    {
        private readonly BookServies _bookServies;

        public bookController() 
        {
            _bookServies = new BookServies();
        }
        public IActionResult Index()
        {
            var books =_bookServies.GetBooks();
            return View(books);
        }
    }
}
