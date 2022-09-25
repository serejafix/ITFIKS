using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Dapper_Sender_2
{
    class Program
    {
        private const string connectionStr = @"Data Source=DESKTOP-639J3PH;Initial Catalog=SenderList;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionStr);

        static void Main(string[] args)
        {
            connection.Open();
            #region Задание 1

            //Задание 1

            //У додаток «Список розсилки» додайте тести для перевірки
            //функціональності роботи із СКБД.
            //testDb();
            #endregion
            #region Задание 2
            ////************************************
            ////Задание 2

            ////Показати Топ-3 найпопулярніших розділів розсилки.
            //var top3 = $@"select top 3 ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            group by ProductTypes.TypeName order by count(*) DESC";
            //var res = connection.Query(top3).ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            ////Показати найпопулярніший розділ розсилки.
            //var top = $@"select top 3 ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            group by ProductTypes.TypeName order by count(*) DESC";
            //var res2 = connection.Query(top).ToList();
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}
            ////Показати Топ-3 найнепопулярніших розділів розсилки.
            //var top3no = $@"select top 3 ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            group by ProductTypes.TypeName order by count(*)";
            //var resno = connection.Query(top3).ToList();
            //foreach (var item in resno)
            //{
            //    Console.WriteLine(item);
            //}
            ////Показати найнепопулярніший розділ розсилки.
            //var topno = $@"select top 3 ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            group by ProductTypes.TypeName order by count(*)";
            //var reno = connection.Query(top3).ToList();
            //foreach (var item in reno)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Задание 3

            ////Показати Топ-3 розділів розсилки за кількістю акційних
            ////товарів.
            //var to3Prod = $@"select top 3 Discounts.Pruduct from Clients
            //                                            join Discounts on Clients.DiscontId = Discounts.id
            //                                            group by Discounts.Pruduct order by count(*) DESC";
            //var to3ProdQuery = connection.Query(to3Prod).ToList();
            //foreach (var item in to3ProdQuery)
            //{
            //    Console.WriteLine(item);
            //}
            ////Показати розділ розсилки з найбільшою кількістю акційних
            ////товарів.    
            //var topProd = $@"select top 1 Discounts.Pruduct from Clients
            //                                            join Discounts on Clients.DiscontId = Discounts.id
            //                                            group by Discounts.Pruduct order by count(*) DESC";
            //var topProdQuery = connection.Query(topProd).ToList();
            //foreach (var item in topProdQuery)
            //{
            //    Console.WriteLine(item);
            //}

            ////Показати Топ-3 розділів розсилки з найменшою кількістю
            ////акційних товарів.
            //var count3min = $@"select top 3 Discounts.Pruduct from Clients
            //                                            join Discounts on Clients.DiscontId = Discounts.id
            //                                            group by Discounts.Pruduct order by count(*)";
            //var to3ProdQuer = connection.Query(count3min).ToList();
            //foreach (var item in to3ProdQuer)
            //{
            //    Console.WriteLine(item);
            //}
            ////Показати розділ розсилки з найменшою кількістю акційних
            ////товарів.
            //var top1 = $@"select top 1 Discounts.Pruduct from Clients
            //                                            join Discounts on Clients.DiscontId = Discounts.id
            //                                            group by Discounts.Pruduct order by count(*) DESC";
            //var topProdQuer = connection.Query(top1).ToList();
            //foreach (var item in topProdQuer)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Задание 4
            // Відобразіть усі акційні товари, які мають три дні до кінця
            //акції.
            //var discDate = $@"select Discounts.Pruduct from Discounts                                                      
            //                                            where DAY(GETDATE()+3) = DAY(Discounts.EndDiscont)";
            //var discDateQuery = connection.Query(discDate).ToList();
            //foreach (var item in discDateQuery)
            //{
            //    Console.WriteLine(item);
            //}

            //Відобразіть усі акційні товари, в яких закінчився термін дії
            //акції.
            //var discstop = $@"select Discounts.Pruduct from Discounts                                                      
            //                                            where GETDATE() > Discounts.EndDiscont";
            //var ddiscstopQuery = connection.Query(discstop).ToList();
            //foreach (var item in ddiscstopQuery)
            //{
            //    Console.WriteLine(item);
            //}
            //Перенесіть усі товари, в яких закінчився термін дії акції, до
            //таблиці під назвою «Архів акцій».

            //Создал вот такой триггер, после удаления товар попадает в таблицу архивов

            //CREATE TRIGGER Products_DELETE
            //ON Discounts
            //AFTER DELETE
            //AS
            //INSERT INTO Archive(ProductId, Operation)
            //SELECT Id, 'Закончилась акция : товар ' + Pruduct
            //FROM DELETED

            //Відобразіть середній вік покупців по кожному розділу.
            //join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            /*  group by Clients.Birthday,Clients.ProductTypeId*/
            //var avg = $@"select ProductTypes.TypeName,DATEDIFF(hour, Clients.Birthday, GETDATE())/ 8766 as Age
            //                        from Clients
            //                          join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                            group by ProductTypes.TypeName,Clients.Birthday";

            //var avgbyDate = connection.Query(avg).ToList();

            //foreach (var item in avgbyDate)
            //{
            //    Console.WriteLine(item);
            //}
            //Відобразіть середній вік покупця по кожному місту.
            //var avg1 = $@"select Cities.CityName,DATEDIFF(hour, Clients.Birthday, GETDATE())/ 8766 as Age
            //                        from Clients
            //                          join Cities on Clients.CityId = Cities.id
            //                            group by Cities.CityName,Clients.Birthday";

            //var avgbyDate1 = connection.Query(avg1).ToList();

            //foreach (var item in avgbyDate1)
            //{
            //    Console.WriteLine(item);
            //}
            //Відобразіть середній вік покупця по кожній країні.
            //var avg2 = $@"select Countries.CountryName,DATEDIFF(hour, Clients.Birthday, GETDATE())/ 8766 as Age
            //                        from Clients
            //                          join Countries on Clients.CountryId = Countries.id
            //                            group by Countries.CountryName,Clients.Birthday";
            //var avgbyDat2 = connection.Query(avg2).ToList();

            //foreach (var item in avgbyDat2)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Задание 5
            //Відобразіть найпопулярніший розділ для кожної статі.

            //var gender = $@"select Genders.SEX,ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            join Genders on Clients.GenderId = Genders.id

            //                                            group by ProductTypes.TypeName,Genders.SEX order by count(*) DESC";
            //var gendervar = connection.Query(gender).ToList();
            //foreach (var item in gendervar)
            //{
            //    Console.WriteLine(item);
            //}
            //Відобразіть Топ-3 розділи для кожної статі.
            //var gend3 = $@"select top 3 Genders.SEX,ProductTypes.TypeName from Clients
            //                                            join ProductTypes on Clients.ProductTypeId = ProductTypes.id
            //                                            join Genders on Clients.GenderId = Genders.id

            //                                            group by ProductTypes.TypeName,Genders.SEX order by count(*) DESC";
          

            //var genderv3 = connection.Query(gend3).ToList();
            //foreach (var item in genderv3)
            //{
            //    Console.WriteLine(item);
            //}

            //Відобразіть кількість покупців кожної статі.

            //var gendcount = $@"select Genders.SEX, count(Clients.GenderId)from Clients
            //                                            join Genders on Clients.GenderId = Genders.id
            //                                            group by Genders.SEX order by count(*) DESC";


            //var genderv3count = connection.Query(gendcount).ToList();
            //foreach (var item in genderv3count)
            //{
            //    Console.WriteLine(item);
            //}
            //Відобразіть кількість покупців кожної статі з кожної країни.

            //var gendcountcountry = $@"select Countries.CountryName,Genders.SEX, count(Clients.GenderId)from Clients
            //                                            join Genders on Clients.GenderId = Genders.id
            //                                            join Countries on Clients.CountryId = Countries.id
            //                                            group by Genders.SEX,Countries.CountryName order by count(*) DESC";


            //var genderv3countcountry = connection.Query(gendcountcountry).ToList();
            //foreach (var item in genderv3countcountry)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
        }

        static void CheckConnect(SqlConnection connection)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Подключение установлено");
                connection.Close();

            }
            else
            {
                Console.WriteLine("Ошибка подключения");

            }
            connection.Close();
        }
        static void testDb()
        {
           CheckConnect(connection);

            for (int i = 0; i < 500; i++)
            {
                string sql = $@"select *from  Clients";
                                
                var res = connection.Query(sql).ToList();
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            }
            //using (connection)
            //{
            //    connection.Open();
            //    Console.WriteLine("Введите Country");
            //    string country = Console.ReadLine();
            //    string sql = $@"select
            //                           Cities.CityName
            //                    from  
            //                    Clients
            //                    join Cities on Cities.Id = Clients.CityId
            //                    join Countries on Clients.CountryId = Countries.Id
            //                    where Countries.CountryName = '{country}'";
            //    var res = connection.Query(sql).ToList();
            //    foreach (var item in res)
            //    {
            //        Console.WriteLine(item);
            //    }
            //};
        }
    }
}
