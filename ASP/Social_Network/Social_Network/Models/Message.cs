namespace Social_Network.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public Guid InUserId { get; set; }
        public Guid OutUserId { get; set; }
        public User User { get; set; }
        public string MessageText { get; set; }
        public DateTime SendingTime { get; set; }

    }
}
