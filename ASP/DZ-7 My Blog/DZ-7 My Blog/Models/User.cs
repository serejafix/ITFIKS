using Microsoft.AspNetCore.Identity;

namespace Blog.Models
{
    public class User : IdentityUser
    {
        public ICollection<Post> Posts { get; set; } = default!;
        public ICollection<Comment> Comments { get; set; } = default!;

    }
}
