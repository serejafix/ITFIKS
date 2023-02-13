using System.ComponentModel.DataAnnotations;

namespace DZ_6.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Fio { get; set; }
        public string Style { get; set; }
        public string Poster { get; set; }
        public DateTime PublishYear { get; set; }
    }
}
