﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Dapper_Senders
{
    class ProductType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public override string ToString()
        {
            return $"{TypeName}";
        }
    }
}

