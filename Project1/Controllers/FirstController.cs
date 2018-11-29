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
        public IActionResult Logged(string Login)
        {
            LoginModel loginModel = new LoginModel();
            loginModel.Login = Login;

            return View();
        }
    }
}