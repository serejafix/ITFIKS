using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CodeFirstMapping_ChessChapmionships
{
    public class EntityChess:DbContext
    {
        public EntityChess() : base("DbConnection") { }
        public EntityChess(string connectionString) : base(connectionString) { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new LevelMap());
            modelBuilder.Configurations.Add(new TournamentMap());
            modelBuilder.Configurations.Add(new ResultMap());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Member> Members { get; set; } 
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Result> Results { get; set; }

    }


    public class Member
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public string Country { get; set; }
        public int LevelId { get; set; }
        public virtual Level Level { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
    public class Level
    {
        public int Id { get; set; }
        public string CategoryLevel { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
    public class Tournament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Venue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }

    public class Result
    {
        public int Id { get; set; }
        public int Place { get; set; }
        public int MemberId { get; set; }
        public int TournamentId { get; set; }
        public virtual Member Member { get; set; }
        public virtual Tournament Tournament { get; set; }
    }

}
