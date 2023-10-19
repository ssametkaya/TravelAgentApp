using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.Areas.Member.Controllers
{
    [Area("Member")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
