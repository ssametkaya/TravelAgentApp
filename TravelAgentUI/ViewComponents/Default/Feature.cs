using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.ViewComponents.Default
{
    public class Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDAL());
        public IViewComponentResult Invoke()
        {
            //ViewBag.image1=featureManager.
            return View();
        }
    }
}
