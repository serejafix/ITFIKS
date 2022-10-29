using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dll;
using Check;

namespace CW_DllTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            double a1 = Dlltrs.triangle(4, 13, 12);
            Console.WriteLine(a1);
            double b1 = Dlltrs.rectangle(13, 12);
            Console.WriteLine(b1);
            double c1 = Dlltrs.square(12);
            Console.WriteLine(c1);
            // Задание 2
            bool a = Checks.FIOCheck("FiksSergey");
            Console.WriteLine(a);
            bool b = Checks.AgeCheck("27");
            Console.WriteLine(b);
            bool c = Checks.PhoneNumberCheck("+380 (67)-995-33-65");
            Console.WriteLine(c);
            bool d = Checks.EmailCheck("serejafix@gmail.com");
            Console.WriteLine(d);
        }
    }
}
