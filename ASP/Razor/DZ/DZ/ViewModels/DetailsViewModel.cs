using DZ.Models.RazorPagesApp.Models;

namespace DZ.ViewModels
{
    public class DetailsViewModel
    {
        public List<News> News { get; set; } = default!;
        public List<Comment> Comments { get; set; } = default!;
    }
}
