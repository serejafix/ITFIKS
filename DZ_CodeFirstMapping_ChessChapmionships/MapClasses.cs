using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CodeFirstMapping_ChessChapmionships
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            HasKey(m => m.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.FIO)
                        .IsRequired().HasColumnName("FIO")
                         .HasColumnType("nvarchar").HasMaxLength(100);

            Property(p => p.Birthday)
                            .IsRequired().HasColumnName("Birthday")
                            .HasColumnType("date");

            Property(p => p.Country)
                            .IsRequired().HasColumnName("Country")
                            .HasColumnType("nvarchar").HasMaxLength(100);
            Property(p => p.LevelId)
                          .IsRequired().HasColumnName("LevelId")
                          .HasColumnType("int");


            ToTable("Members", "dbo");


        }
    }

    public class LevelMap : EntityTypeConfiguration<Level>
    {
        public LevelMap()
        {
            HasKey(l => l.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.CategoryLevel)
                        .IsRequired().HasColumnName("CategoryLevel")
                         .HasColumnType("nvarchar").HasMaxLength(100);

            ToTable("Levels", "dbo");
        }
    }

    public class TournamentMap : EntityTypeConfiguration<Tournament>
    {
        public TournamentMap()
        {
            HasKey(m => m.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Name)
                        .IsRequired().HasColumnName("Name")
                         .HasColumnType("nvarchar").HasMaxLength(100);

            Property(p => p.StartDate)
                            .IsRequired().HasColumnName("StartDate")
                            .HasColumnType("date");

            Property(p => p.EndDate)
                           .IsRequired().HasColumnName("EndDate")
                           .HasColumnType("date");

            Property(p => p.Venue)
                            .IsRequired().HasColumnName("Venue")
                            .HasColumnType("nvarchar").HasMaxLength(100);

            ToTable("Tournamets", "dbo");


        }
    }
    public class ResultMap : EntityTypeConfiguration<Result>
    {
        public ResultMap()
        {
            HasKey(m => m.Id);

            Property(p => p.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Place)
                        .IsRequired().HasColumnName("Place")
                         .HasColumnType("int");

            Property(p => p.MemberId)
                            .IsRequired().HasColumnName("MemberId")
                            .HasColumnType("int");

            Property(p => p.TournamentId)
                          .IsRequired().HasColumnName("TournamentId")
                          .HasColumnType("int");

            ToTable("Results", "dbo");
        }
    }
}
