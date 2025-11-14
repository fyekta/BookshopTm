using bookshop.Entities;
using bookshop.Models;
using bookshop.servies;
using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class bookController : Controller
    {
        private readonly BookServies _bookServies;
        private readonly CategoryServies _categoryServies;

        public bookController() 
        {
            _bookServies = new BookServies();
            _categoryServies = new CategoryServies();
        }
        public IActionResult Index()
        {
            var Model = new ListViewModel
            {
                books = _bookServies.GetBooks(),
                categories = _categoryServies.GetCategories()
            };
            
            return View(Model);
        }
    }
}
