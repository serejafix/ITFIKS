using System.ComponentModel.DataAnnotations;
namespace DZ_5.ViewModels
{
    public class RegisterVM
    { 

        [Required(ErrorMessage = "Error Email")]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Error Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;
        [Required(ErrorMessage = "Error Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = default!;
    }
}
