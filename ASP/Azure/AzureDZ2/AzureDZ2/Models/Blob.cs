namespace AzureDZ2.Models
{
    public class Blob
    {
        public int Id { get; set; }
        public string FileName { get; set; } = default!;
        public string Uri { get; set; } = default!;
    }
}
