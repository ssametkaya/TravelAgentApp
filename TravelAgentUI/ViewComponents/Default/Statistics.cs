using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelAgentUI.ViewComponents.Default
{
    public class Statistics :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new TraversalDbContext();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
