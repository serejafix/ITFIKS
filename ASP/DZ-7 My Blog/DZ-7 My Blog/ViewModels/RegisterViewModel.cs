using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels
{
    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; } = default!;
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = default!;

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string ConfirmPassword { get; set; } = default!;

    }
}
