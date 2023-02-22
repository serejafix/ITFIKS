using System.ComponentModel.DataAnnotations;

namespace DZ_7_My_Blog.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = default!;

        [Display(Name = "Remeber?")]
        public bool RememberMe { get; set; }
        public string?ReturnUrl { get; set; }

    }
}
