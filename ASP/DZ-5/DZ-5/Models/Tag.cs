namespace DZ_5.Models
{
    public class Tag
    {
        public string Id { get; set; } = default!;
        public string T { get; set; } = default!;

        public string BooksId { get; set; }
        public Book? Book { get; set; }
    }
}
