namespace DZ.Models.RazorPagesApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; } = default!;
        public int NewsId { get; set; }
        public News News { get; set; } = default!;
    }
}