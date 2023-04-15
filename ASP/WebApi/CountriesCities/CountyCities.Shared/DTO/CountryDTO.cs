using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CountyCities.Shared.DTO
{
    public class CountryDTO
    {

        public int Id { get; set; }

        [Required]
        [Display(Name = "Country Name")]
        public string Name { get; set; } = default!;


        [Required]
        [Range(1, 999)]
        public int Code { get; set; }

    }
}
