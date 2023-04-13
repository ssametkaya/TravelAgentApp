using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.ViewComponents.Default
{
    public class PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager=new DestinationManager(new EfDestinationDAL());


        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
