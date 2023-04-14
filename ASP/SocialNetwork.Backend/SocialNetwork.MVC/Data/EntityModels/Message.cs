using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.MVC.Data.EntityModels
{
    public class Message
    {
        public Guid Id { get; set; }

        public int UserReceived { get; set; }

        public int UserSend { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(250)]
        public string Text { get; set; }

        public DateTime SendTime { get; set; }
    }
}
