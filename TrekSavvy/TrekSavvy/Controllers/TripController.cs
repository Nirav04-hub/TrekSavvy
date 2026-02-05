using Microsoft.AspNetCore.Mvc;

namespace TrekSavvy.Controllers
{
    public class TripController : Controller
    {
        public IActionResult Plan()
        {
            return View();
        }

        public IActionResult Itinerary()
        {
            return View();
        }

        public IActionResult Map()
        {
            return View();
        }
    }
}