using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CodeFirst_dbSender
{
    public class SenderlistDb : DbContext
    {
        public SenderlistDb() : base("DbConnection") { }
        public SenderlistDb(string connectionString) : base(connectionString) { }

        public DbSet<Gender> Genders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Discount> Discounts { get; set; }    
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

    public class ProductType
    {
        public ProductType()
        {
            Clients = new HashSet<Client>();
            Discounts = new HashSet<Discount>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string TypeName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }

    }
    public class Country
    {
        public Country()
        {
            Clients = new HashSet<Client>();
            Discounts = new HashSet<Discount>();
        }
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string CountryName { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }

    }
    public class Discount
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Pruduct { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int ProductTypeId { get; set; }

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
        public string City { get; set; }
        [Required]
        public int CountryId { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public int ProductTypeId { get; set; }
        [Required]
        public int DiscontId { get; set; }

    }


}
