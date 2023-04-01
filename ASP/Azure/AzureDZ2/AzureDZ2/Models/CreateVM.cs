using System.ComponentModel.DataAnnotations;

namespace AzureDZ2.Models
{
    public class CreateVM
    {
        [Required]
        public IFormFile Image { get; set; } = default!;
    }
}
