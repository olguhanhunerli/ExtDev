using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class _SpinnerComponentPartials: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
