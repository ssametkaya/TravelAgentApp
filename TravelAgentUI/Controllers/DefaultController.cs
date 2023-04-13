using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
