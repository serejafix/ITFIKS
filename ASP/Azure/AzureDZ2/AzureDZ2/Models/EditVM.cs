namespace AzureDZ2.Models
{
    public class EditVM
    {
        public IFormFile? Image { get; set; }

        public Blob Blob { get; set; } = default!;
    }
}
