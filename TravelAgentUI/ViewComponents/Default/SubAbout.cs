using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelAgentUI.ViewComponents.Default
{
    public class SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager=new SubAboutManager(new EfSubAboutDAL());
        public IViewComponentResult Invoke()
        {
            
            return View(subAboutManager.TGetList());
        }
    }
}
