using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CountriesCities.API.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Code { get; set; }

        [Display(Name = "Deleted Status")]
        public bool IsDeleted { get; set; }

        public ICollection<City>? Cities { get; set; }

    }
}
