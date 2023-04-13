using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace TravelAgentUI.ViewComponents.Default
{
    public class Testimonial:ViewComponent
    {
        TestimonialManager testimonialManager=new TestimonialManager(new EfTestimonialDAL());
       public IViewComponentResult Invoke()
        {
            return View(testimonialManager.TGetList());
        }
    }
}
