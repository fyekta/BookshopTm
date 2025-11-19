using bookshop.Controllers;
using bookshop.Entities;
using bookshop.Infrastructure.Repository;
using bookshop.Models;
using bookshop.servies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace bookshop.Controllers
{
    public class ManageBookController : Controller
    {
        private readonly IBookServies bookServies;
        private readonly ICategoryServies categoryServies;

        public ManageBookController()
        {
            bookServies = new BookServies();
            categoryServies = new CategoryServies();
        }
        public IActionResult Index()
        {
            //var Model = new ListViewModel
            //{
            //    books = bookServies.GetBooks(),
            //    categories = categoryServies.GetCategories()
            //};
            var book = bookServies.GetBooks();

            return View(book);
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = new EditBookViewModel()
            {
                book = bookServies.GetById(id),
                categories = categoryServies.GetCategories()
            };
            //var book = bookServies.GetById(id);
            return View(model);

        }
        [HttpPost]
        public ActionResult Edit(book book)
        {
            bookServies.Update(book);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            bookServies.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
           
            var model = new CreateBookViewModel()
            {
                categories = categoryServies.GetCategories(),
                book = null,

            };
            return View (model);
        }

            [HttpPost]
            
            public IActionResult Create(CreateBookViewModel model)
            {

               
                bookServies.Create(model.book);
              
              return RedirectToAction("Index");
            }

        

    }
}


    