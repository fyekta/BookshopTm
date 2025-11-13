using bookshop.Entities;
using bookshop.servies;
using Microsoft.AspNetCore.Mvc;

namespace bookshop.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserServies _userServies;
        
        public AuthController()
        {
            _userServies = new UserServies();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        { 
          _userServies.Register(user);
         return RedirectToAction("login");

        }
        [HttpGet]
        public IActionResult Login() 
        { 
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username , string PasswordHash)
        {
            var user = _userServies.GetUserByUsername(username);
            if (user != null && _userServies.ValidatePassword(user, PasswordHash)== true)
            {
                return RedirectToAction("Index" , "Book");
            }

            return View();
        }

    }
}
