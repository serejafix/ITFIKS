using System.Data.Entity;
using TZ_Parsing.DB;

namespace TZ_Parsing
{
    public class ParserDbContext :DbContext
    {
       public ParserDbContext() : base("ParserConnection") { } // подключение к базе данных, через поле в  app.config

        public DbSet<Main> Mains { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<AtmMtm> AtmMtms { get; set; }
        public DbSet<DriverPosition> DriverPositions { get; set; }
    }
}
