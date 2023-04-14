using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.MVC.Data.EntityModels
{
    public class Comment
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Комментарий")]
        public string TextComment { get; set; }

        public int UserId { get; set; }

        public int PostId { get; set; }

        public Post Post { get; set; }
    }
}
