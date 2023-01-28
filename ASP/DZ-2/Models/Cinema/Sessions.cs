using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DZ_2.Models.Cinema
{
    public class Sessions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Morning { get; set; }
        public string Day { get; set; }
        public string Night { get; set; }
        public List<Films> Films { get; set; }
    }
}