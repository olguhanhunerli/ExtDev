using Microsoft.AspNetCore.Mvc;

namespace ExtryDev.ViewComponents
{
    public class _ScriptComponentPartials: ViewComponent    
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
