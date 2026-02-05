using Microsoft.AspNetCore.Mvc;

namespace TrekSavvy.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}