using ExtryDev.DAL.Context;
using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.Controllers
{
    public class ContactController : Controller
    {
        ExtDevContext _context = new ExtDevContext();
        public IActionResult Contact()
        {
            return View();
        }
    }
}
