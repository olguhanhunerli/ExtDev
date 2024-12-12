using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {
            ViewData["ActivePage"] = "About";
            return View();
        }
    }
}
