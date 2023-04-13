using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.ViewComponents.Default
{
    public class SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
