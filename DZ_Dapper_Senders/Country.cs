﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Dapper_Senders
{
    class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

        public override string ToString()
        {
            return $"{CountryName}";
        }
    }
}
