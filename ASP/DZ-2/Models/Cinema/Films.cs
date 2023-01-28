using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_2.Models.Cinema
{
    public class Films
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string AboutFilm { get; set; }

        public Guid SessionId { get; set; }

        public Sessions Session { get; set; }
    }
}
