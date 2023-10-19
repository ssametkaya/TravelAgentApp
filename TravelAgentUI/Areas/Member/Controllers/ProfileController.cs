using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TravelAgentUI.Areas.Member.Models;

namespace TravelAgentUI.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values= await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel viewModel = new UserEditViewModel();
            viewModel.Name = values.Name;
            viewModel.Surname = values.Surname;
            viewModel.Mail = values.Email;
            viewModel.PhoneNumber = values.PhoneNumber;

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEdit)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (userEdit.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension=Path.GetExtension(userEdit.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation,FileMode.Create);
                await userEdit.Image.CopyToAsync(stream);
                user.ImageUrl = "/UserImages/" + imagename;
            }

            user.Name = userEdit.Name;
            user.Surname = userEdit.Surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, userEdit.Password);
            var result= await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }

            return View();
        }
    }
}
