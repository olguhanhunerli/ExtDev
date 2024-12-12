using ExtryDev.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.Controllers
{
    public class ReferencesController : Controller
    {
        ExtDevContext _context = new ExtDevContext();
        public IActionResult References()
        {
            ViewBag.v1 = _context.References.Count();
            return View();
        }
    }
}
