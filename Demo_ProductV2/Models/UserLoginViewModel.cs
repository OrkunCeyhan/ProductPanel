using System.ComponentModel.DataAnnotations;

namespace Demo_ProductV2.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adını giriniz")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Lütfen şifreyi giriniz")]
        public string Password { get; set; }
    }
}
