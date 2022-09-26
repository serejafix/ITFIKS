using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Для задания 1
            //object value = new DataTable().Compute(args[0], null);
            //string res = value.ToString();
            //Console.WriteLine(res);
            //Для задания 2
            List<string> lst = new List<string>();
            foreach (string item in System.IO.File.ReadLines(args[0]))
            {
                lst.Add(item);
            }
            foreach (var item in lst.Distinct())
            {
                Console.WriteLine(item + " " + lst.Where(x => x == item).Count() + " раз");
            }
            
            Console.ReadLine();
        }
        static void Sum(int a,int b)
        {
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
