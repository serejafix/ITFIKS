using System.ComponentModel.DataAnnotations.Schema;

namespace DZ_7_My_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Message { get; set; } = default!;
        public DateTime Created { get; set; }

        public int PostId { get; set; }
        public string UserId { get; set; } = default!;
        public Post? Post { get; set; }
        public User? User { get; set; }
        public int? ParentCommentId { get; set; }
        [ForeignKey(nameof(ParentCommentId))]
        public Comment? ParentComment { get; set; }
        public ICollection<Comment> ChildComments { get; set; } = default!;
    }
}