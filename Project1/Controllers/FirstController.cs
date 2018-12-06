using Microsoft.AspNetCore.Mvc;
using Project1.Models;

namespace Project1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Logged(LoginModel loginModel)
        {
            return View(loginModel);
        }
    }
}