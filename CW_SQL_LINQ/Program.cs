using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_SQL_LINQ
{
    class Program
    {
        static List<User> lstUser = new List<User>();

        static void Main(string[] args)
        {
            //List<string> lst = new List<string>();
            //lst.AddRange(new string[] { "Niko", "Odessa", "Kyev" });
            //PrintCollection("Не Сотрированный лист", lst);

            //var varO = from strC in lst
            //           where strC.StartsWith("N")
            //           //orderby strC
            //           select strC;
            //PrintCollection("Сотрированный лист", varO);
            lstUser.AddRange(new User[] { new User {Id = 1, FirstName="F3",SecondName= "L3",Birthday=DateTime.Now }, });
            lstUser.AddRange(new User[] { new User {Id = 2, FirstName="F2",SecondName= "L2",Birthday=DateTime.Now }, });
            lstUser.AddRange(new User[] { new User {Id = 3, FirstName="F4",SecondName= "L4",Birthday=DateTime.Now }, });
            lstUser.AddRange(new User[] { new User {Id = 4, FirstName="F1",SecondName= "L1",Birthday=DateTime.Now }, });
            //var namesOnly = lstUser.OrderBy(a => a.FirstName).Select(b => new { b.FirstName, b.SecondName});

            //var varN = from strU in lstUser
            //           orderby strU.FirstName
            //           select new { strU.FirstName, strU.SecondName };

            //var n = lstUser.OrderBy(u => u.FirstName).Select(u => $"{u.FirstName} {u.SecondName}");

            //Console.WriteLine("\nOnly Names");
            //foreach (var item in n)
            //{
            //    Console.WriteLine(item);
            //}

            Console.ReadKey();
        }
        private static void PrintCollection(string message, IEnumerable<object> collection)
        {
            Console.WriteLine(message);
            foreach (string item in collection)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
