using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Server_Client_
{
    class Currency
    {
        Dictionary<string, double> dictCureency = new Dictionary<string, double>();

        public void addCurrency()
        {
            dictCureency.Add("USD", 36.06);
            dictCureency.Add("EUR", 36.00);
            dictCureency.Add("PLN", 7.66);
        }
        public double GetCurrency(string firstCur, string secondCur)
        {
            if (dictCureency.ContainsKey(firstCur) && dictCureency.ContainsKey(secondCur))
            {
                return dictCureency[firstCur] / dictCureency[secondCur];
            }
            return 0;
        }
    }
}
