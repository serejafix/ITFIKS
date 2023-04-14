using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SocialNetwork.MVC.Data.EntityModels
{
    public class Post
    {
        public Guid Id { get; set; }
        [Required]
        public int UserId { get; set; }
        [StringLength(300)]
        [Display(Name = "Текст")]
        public string Description { get; set; }
        public byte[] PostImage { get; set; }

        public ICollection<Like> Likes { get; set; }
        public ICollection<Comment> Comments { get; set; }

    }
}
