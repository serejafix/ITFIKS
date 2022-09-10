using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace DZ_CodeFirst_Db_Sender.DataBase
{
    public class SenderlistDb : DbContext
    {
        public SenderlistDb() : base("DbConnection") { }
        public SenderlistDb(string connectionString) : base(connectionString) { }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Client> Clients { get; set; }
    }

    public class Gender
    {
        public Gender()
        {
            Clients = new HashSet<Client>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string SEX { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FIO { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string Country { get; set; }
        [Required]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        public int GendersId { get; set; }
    }


}
