using bookshop.Entities;
using bookshop.servies;
using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class ManageCategoryController : Controller
    {
        private readonly ICategoryServies categoryServies;

        public ManageCategoryController()
        {
            categoryServies = new CategoryServies();
        }
        public ActionResult Index()
        {
            var category = categoryServies.GetCategories();
            return View(category);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {

            categoryServies.Create(category);

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var category = categoryServies.GetById(id);
            return View(category);

        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryServies.Update(category);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            categoryServies.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
