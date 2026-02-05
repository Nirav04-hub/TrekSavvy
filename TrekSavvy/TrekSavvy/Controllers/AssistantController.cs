using Microsoft.AspNetCore.Mvc;

namespace TrekSavvy.Controllers
{
    public class AssistantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}