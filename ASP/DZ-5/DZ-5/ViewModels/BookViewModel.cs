using MessagePack;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DZ_5.ViewModels
{
    public class BookViewModel
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Id { get; set; } = "";
        public string Name { get; set; }
        public string Fio { get; set; }
        public string Style { get; set; }
        [NotMapped]
        public IFormFile? Poster { get; set; }
        public DateTime PublishYear { get; set; }

        public string[] Tags { get; set; } = default!;

    }
}
