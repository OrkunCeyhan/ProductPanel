using System.ComponentModel.DataAnnotations;

namespace Demo_ProductV2.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim  giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyİsim  giriniz")]
        public string SurName { get; set; }

       

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet  giriniz")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen şifre  giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen şifrelerin eşleştiginden emin olun")]
        public string ConfirmPassword { get; set; }
    }
}
