using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DZ_LINQ_Countries_
{
    [Table(Name = "Countries")]
    class Country
    {
        [Column(IsDbGenerated =true, IsPrimaryKey =true)]
        public int Id { get; set; }
        [Column(DbType ="nvarchar(100)")]
        public string Name { get; set; }
        [Column(DbType = "nvarchar(100)")]
        public string NameCapital { get; set; }
        [Column(DbType = "int")]
        public int People { get; set; }
        [Column(DbType = "int")]
        public int PeopleInCapital { get; set; }
        [Column(DbType = "numeric(18,0)")]
        public float Area { get; set; }
        [Column(DbType = "int")]
        public float PartOfTheWorldId { get; set; }
        [Column(DbType = "int")]
        public int NameAndCountBigCitiesId { get; set; }

        public override string ToString()
        {
            return $"({Id}) {Name} {NameCapital}," +
                   $" {People} {PeopleInCapital} " +
                   $"{Area} {PartOfTheWorldId} {NameAndCountBigCitiesId}";
        }
    }

    [Table(Name = "BigCities")]
    class BigCity
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(DbType = "nvarchar(100)")]
        public string Name { get; set; }
        [Column(DbType = "int")]
        public int CountPeople { get; set; }

        public override string ToString()
        {
            return $"({Id}) {Name} {CountPeople},";                 
        }
    }

    [Table(Name = "Parts")]
    class Part
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int Id { get; set; }
        [Column(DbType = "nvarchar(100)")]
        public string PartsOfTheWorld { get; set; }

        public override string ToString()
        {
            return $"({Id}) {PartsOfTheWorld} ";
        }
    }
}
