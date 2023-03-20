namespace DZ.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? TextComment { get; set; }
        public int NewsId { get; set; }
        public News? News { get; set; }
    }
}
