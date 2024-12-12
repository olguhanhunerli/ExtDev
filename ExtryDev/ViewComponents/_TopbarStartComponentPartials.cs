using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class _TopbarStartComponentPartials: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
