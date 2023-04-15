using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CountyCities.Shared.DTO
{
    public class CityDTO
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "City Name")]
        [StringLength(50, MinimumLength = 1)]
        public string Name { get; set; } = default!;


        [Required]
        [Range(0, 1000_000_000_0)]
        public int Population { get; set; }


        [Display(Name = "Air pollution degree")]
        [DisplayFormat(NullDisplayText = "No air pollution")]
        public AirPollutionDegree? AirPollutionDegree { get; set; }


        public int? CountryId { get; set; }
    }

    public enum AirPollutionDegree
    {
        Normal,
        Moderate,
        Middle,
        Unhealthy,
        Danger,
    }

}
}
