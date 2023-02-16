using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Social_Network.Models
{
    public class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string PostImage { get; set; }
        public DateTime PostTime { get; set; }
        public Guid CommentId { get; set; }
        public Comment Comment { get; set; }    
        public List<Wallet> Wallets { get; set; }
        public Guid LikeId { get; set; }
        public Like Like { get; set; }
    }
}
