using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Dapper_Senders
{
    class Client
    {
        public int Id { get; set; }
        public string FIO { get; set; }  
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public int GenderId { get; set; }
        public int ProductTypeId { get; set; }
        public int DiscontId { get; set; }        
        public int CityId { get; set; }
        public override string ToString()
        {
            return $"{FIO} {Birthday.ToShortDateString()}{Email} ";
        }
    }
}
