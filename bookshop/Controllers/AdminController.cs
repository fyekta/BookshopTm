using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
