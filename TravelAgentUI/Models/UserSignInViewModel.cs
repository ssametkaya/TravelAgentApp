using System.ComponentModel.DataAnnotations;

namespace TravelAgentUI.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Lütfen şifrenizi giriniz.")]
        public string Password { get; set; }
    }
}
