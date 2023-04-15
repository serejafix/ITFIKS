using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CountyCities.Shared.DTO
{
    public class CityDetailsDTO :CityDTO
    {
        // [Required]
        [Display(Name = "Country Name")]
        [JsonPropertyOrder(10)]
        public string? CountryName { get; set; } = default!;

        // [Required]
        // [Range(1, 999)]
        [Display(Name = "Country Code")]
        [JsonPropertyOrder(20)]
        public int? CountryCode { get; set; }

    }
}
