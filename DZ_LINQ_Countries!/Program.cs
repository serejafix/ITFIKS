using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DZ_LINQ_Countries_
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstionStr = @"Data Source=DESKTOP-639J3PH;Initial Catalog=Country;Integrated Security=True";
            DataContext db = new DataContext(connstionStr);
            
            Table<Country> countries = db.GetTable<Country>();
            Table<Part> parts = db.GetTable<Part>();
            Table<BigCity> bigCities = db.GetTable<BigCity>();


            //Відобразити всю інформацію про країни.
            Console.WriteLine("Все страны");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }
            //Відобразити назву країн.
            Console.WriteLine("Название стран");
            foreach (var item in countries)
            {
                Console.WriteLine(item.Name);
            }
            //Відобразити назву столиц.
            Console.WriteLine("Название Столиц");
            foreach (var item in countries)
            {
                Console.WriteLine(item.NameCapital);
            }

            //Відобразити назву великих міст певної країни.
            //Console.WriteLine("Название Больших городов по стране");
            //string CountryName = Console.ReadLine();
            //var Names = from c in countries
            //            join bc in bigCities on c.NameAndCountBigCitiesId equals bc.Id
            //            where c.Name == CountryName
            //            select bc.Name;
            //            foreach (var item in Names)
            //            {
            //                Console.WriteLine(item);
            //            }

            //Відобразити назву столиць з кількістю жителів понад п'ять
            //мільйонів.
            Console.WriteLine("Название столиц с количество жителей больше 5лямов");
            

            var CapNameCount = from c in countries
                               where (c.PeopleInCapital > 5000000)
                               select c;
            if (CapNameCount == null)
            {
                foreach (var item in CapNameCount)
                {
                    Console.WriteLine(item.NameCapital);
                }
            }
            else
            {
                Console.WriteLine("Таких сталиц нетув базе");
            }
           

            //Відобразити назву усіх європейських країн.
            Console.WriteLine("Все страны европы");
            var EuropeCountry = from c in countries
                        join p in parts on c.PartOfTheWorldId equals p.Id
                        where p.Id == 1
                        select c;
            foreach (var item in EuropeCountry)
            {
                Console.WriteLine(item.Name);
            }

            //Відобразити назву країн з площею, більшою від певного
            //числа.

            //Console.WriteLine("Площадь страны по заданному числу");
            //double Area = Convert.ToDouble(Console.ReadLine());
            //var AreaCountry = from c in countries    
            //                  where c.Area > Area
            //                    select c;
                
            //foreach (var item in AreaCountry)
            //{
            //    if (item.Name.Length <= 1)
            //    {
            //        Console.WriteLine("Таких нет");
            //    }
            //    else { Console.WriteLine(item.Name); }
            //}

            //Відобразити усі столиці, в назвах яких є літери 'a' та 'p'.

            Console.WriteLine("Названия столиц с буквой А и Р");
            foreach (var item in countries)
            {
                if (item.NameCapital.Contains("а") && item.NameCapital.Contains("р"))
                {
                    Console.WriteLine(item.NameCapital);
                }
                else
                {
                    Console.WriteLine("Таких нет");
                }
            }

            //Відобразити усі столиці, в яких назва починається з літери
            //'k'.
            Console.WriteLine("Столицы которые начинаются с буквы К");
            var CapStartK = from c in countries
                            where c.NameCapital.StartsWith("K")
                            select c;
            foreach (var item in CapStartK)
            {
                Console.WriteLine(item.NameCapital);
            }

            //Відобразити назву країн, площа яких зазначена у вказаному
            //діапазоні.

            //Console.WriteLine("Площадь страны по заданному диапазону");
            //Console.WriteLine("Введите диапазон начало: ");
            //double AreaStart = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите диапазон конец:");
            //double AreaEnd = Convert.ToDouble(Console.ReadLine());
            //var AreaCountry = from c in countries
            //                  where (c.Area > AreaStart && c.Area < AreaEnd)
            //                  select c;
            //foreach (var item in AreaCountry)
            //{
            //    if (item.Name.Length <= 1)
            //    {
            //        Console.WriteLine("Таких нет");
            //    }
            //    else { Console.WriteLine(item.Name); }
            //}

            ////Відобразити назву країн, в яких кількість жителів більша за
            ////зазначену кількість.
            //Console.WriteLine("Название страны где количество больше заданого");
            //Console.WriteLine("Введите Количество");
            //double countPeople = Convert.ToDouble(Console.ReadLine());
            //var countInput = from c in countries
            //                 where (c.People > countPeople)
            //                 select c;

            //foreach (var item in countInput)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //Показати Топ-5 країни за площею.
            Console.WriteLine("Топ 5 Стран по площади");
            var top5AreaCountries = from c in countries
                                    orderby c.Area
                                    select c;

            var top = top5AreaCountries.Take(5);

            foreach (var item in top)
            {
                Console.WriteLine(item.Name);
            }

            //Показати Топ-5 столиці за кількістю жителів.
            Console.WriteLine("Топ 5 Столиц по количество жителей");
            var top5CountPeopleInCapital = from c in countries
                                    orderby c.PeopleInCapital
                                    select c;

            var topcapital = top5CountPeopleInCapital.Take(5);

            foreach (var item in topcapital)
            {
                Console.WriteLine(item.NameCapital);
            }
           

            //Показати країну з найбільшою площею.

            Console.WriteLine("Страна с большей площадью");

            var AreaMax = from c in countries
                          orderby c.Area
                          select c;
            var areaMax = AreaMax.Take(1);
              
            foreach (var item in areaMax)
            {
                Console.WriteLine(item.Name);
            }

            //Показати столицю з найбільшою кількістю жителів.

            Console.WriteLine("Старана с большей количеством жителей");
            var result1 = countries.OrderByDescending(x => x.People).First();
            Console.WriteLine(result1.Name);

            //Показати країну з найменшою площею в Європі.

            Console.WriteLine("Страна с меньшей площадью");
            var CountryEuropeMinArea = from c in countries
                                       join p in parts on c.PartOfTheWorldId equals p.Id
                                       where p.Id == 1
                                       orderby c.Area descending
                                       select c;
            var res = CountryEuropeMinArea.Take(1);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }

            //Показати середню площу країн в Європі.
            Console.WriteLine("Средняя площадь стран Европы");
            var CountryEuropeAVGArea = from c in countries
                                       join p in parts on c.PartOfTheWorldId equals p.Id
                                       where p.Id == 1
                                       select c.Area;

            var res1 = CountryEuropeAVGArea.Average();
            Console.WriteLine(res1);


            //Показати Топ-3 міст за кількістю мешканців для певної
            //країни.
            Console.WriteLine("Топ 3 города по количеству жителей");



            //Показати загальну кількість країн.
            Console.WriteLine("Количество стран");
            var countCountries = from c in countries
                                 select c.Name;
            var res2 = countCountries.Count();
            Console.WriteLine(res2);

            //Показати частину світу з максимальною кількістю країн.
            Console.WriteLine("Части света с максимальным количеством стран");

            var resultt = countries.GroupBy(d => d.PartOfTheWorldId).
                                    OrderByDescending(g => g.Count()).FirstOrDefault().Key;

            var max = parts.FirstOrDefault(t => t.Id == resultt);
            Console.WriteLine(max);

            //Показати кількість країн у кожній частині світу
            Console.WriteLine("Количество стран в каждом континенте");

            var rescount = countries.GroupBy(c => new { c.Name, c.PartOfTheWorldId })
                                      .Select(g => new { Country =  g.Key.Name, CountIncontinent =  g.Key.PartOfTheWorldId });
            foreach (var item in rescount)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
