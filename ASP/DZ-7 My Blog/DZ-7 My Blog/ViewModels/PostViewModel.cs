using DZ_7_My_Blog.Models;

namespace DZ_7_My_Blog.ViewModels
{
    public class PostViewModel
    {
        public IEnumerable<Post> Posts { get; set; } = default!;
        public IEnumerable<Category> Categories { get; set; } = default!;
        public int CategoryId { get; set; }
    }
}
