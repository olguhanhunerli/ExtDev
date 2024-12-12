using ExtryDev.DAL.Context;
using ExtryDev.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExtryDev.Controllers
{
	public class HomeController : Controller
	{
		ExtDevContext _context = new ExtDevContext();
		public IActionResult Index()
		{
			ViewBag.Reference = _context.References.Count();
            return View();
		}

	
	}
}
