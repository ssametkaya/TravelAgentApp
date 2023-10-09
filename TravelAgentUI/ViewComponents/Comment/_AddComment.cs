using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TravelAgentUI.ViewComponents.Comment
{
    public class _AddComment:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDAL());

        public IViewComponentResult Invoke()
        {
            return View();
        }
        
    }
}
