using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class NavbarComponentPartials: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
