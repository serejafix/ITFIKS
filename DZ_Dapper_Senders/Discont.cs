using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Dapper_Senders
{
    class Discont
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int CountryId { get; set; }
        public int ProductTypeId { get; set; }
        public int CityId { get; set; }
        public override string ToString()
        {
            return $"{Product} ";
        }
    }
}
