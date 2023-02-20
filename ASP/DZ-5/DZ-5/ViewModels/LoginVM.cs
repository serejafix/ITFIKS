using System.ComponentModel.DataAnnotations;
using Xunit.Abstractions;

namespace DZ_5.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Error Email")]
        public string Email { get; set; } = default!;
        [Required(ErrorMessage = "Error Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;
    }
}
