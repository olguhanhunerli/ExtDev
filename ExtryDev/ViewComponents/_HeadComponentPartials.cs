using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class _HeadComponentPartials: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
