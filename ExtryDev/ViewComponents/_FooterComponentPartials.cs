using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class _FooterComponentPartials: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
