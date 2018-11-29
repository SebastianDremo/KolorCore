using Microsoft.AspNetCore.Mvc;

namespace Project1.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}