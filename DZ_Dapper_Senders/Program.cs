using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DZ_Dapper_Senders
{
    class Program
    {
        private const string connectionStr = @"Data Source=DESKTOP-639J3PH;Initial Catalog=SenderList;Integrated Security=True";
        private static SqlConnection connection = new SqlConnection(connectionStr);
        static string sql = string.Empty;
        static string sqlQuery = string.Empty;
        static City city;
        static Country Country;
        static ProductType ProductType;
        static Discont Discont;
        static Client Client;
        static void Main(string[] args)
        {
            //PrintMenu();

            query1();
            //query2();
            //query3();

        }
        static void query1()
        {
            using (connection)
            {
                connection.Open();
                Console.WriteLine("Введите Country");
                string country = Console.ReadLine();
                string sql = $@"select
                                       Cities.CityName
                                from  
                                Clients
                                join Cities on Cities.Id = Clients.CityId
                                join Countries on Clients.CountryId = Countries.Id
                                where Countries.CountryName = '{country}'";
                var res = connection.Query(sql).ToList();
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            };
        }
        static void query2()
        {
            using (connection)
            {
                connection.Open();
                Console.WriteLine("Введите Client.FIO");
                string FIO = Console.ReadLine();
                string sql = $@"select
                                       ProductTypes.TypeName
                                from  Clients join ProductTypes on Clients.Id = ProductTypes.Id
                                where Clients.FIO = '{FIO}'";
                var res = connection.Query(sql).ToList();
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            };
        }
        static void query3()
        {
            using (connection)
            {
                connection.Open();
                Console.WriteLine("Введите TypeName");
                string TypeName = Console.ReadLine();
                string sql = $@"select
                                      *
                                from  Discounts join ProductTypes on Discounts.ProductTypeId = ProductTypes.Id
                                where ProductTypes.TypeName = '{TypeName}'";
                var res = connection.Query(sql).ToList();
                foreach (var item in res)
                {
                    Console.WriteLine(item);
                }
            };
        }
        private static void PrintMenu()
        {
            Console.WriteLine("Сделайте выбор");
            Console.WriteLine("1 Меню Удаления");
            Console.WriteLine("2 Меня Обновления");
            Console.WriteLine("3 Меня Добавления");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Delete();                  
                    break;
                case 2:
                    Update();
                    break;
                case 3:
                    Insert();
                    break;
            }
        }
        private static void Delete()
        {
            connection.Open();
            Console.WriteLine("Сделайте выбор таблицы");
            Console.WriteLine("1 Cities");
            Console.WriteLine("2 Countries");
            Console.WriteLine("3 Clients");
            Console.WriteLine("4 Disconts");
            Console.WriteLine("5 ProductTypes");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    sql = "select * from Cities";
                    sqlQuery = "delete from Cities where [Id] = @id";
                    break;
                case 2:
                    sql = "select * from Countries";
                    sqlQuery = "delete from Countries where [Id] = @id";
                    break;
                case 3:
                    sql = "select * from Clients";
                    sqlQuery = "delete from Clients where [Id] = @id";
                    break;
                case 4:
                    sql = "select * from Discounts";
                    sqlQuery = "delete from Discounts where [Id] = @id";
                    break;
                case 5:
                    sql = "select * from ProductTypes";
                    sqlQuery = "delete from ProductTypes where [Id] = @id";
                    break;
            }
            var result = connection.Query(sql);

            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Enter Id: ");

                int id = int.Parse(Console.ReadLine());
                var rows = connection.Execute(sqlQuery, new { Id = id });
                Console.WriteLine("Affectred rows:" + rows.ToString());
                connection.Close();
                PrintMenu();           
        }
        private static void Insert()
        {
            connection.Open();
            Console.WriteLine("Сделайте выбор таблицы");
            Console.WriteLine("1 Cities");
            Console.WriteLine("2 Countries");
            Console.WriteLine("3 Clients");
            Console.WriteLine("4 Disconts");
            Console.WriteLine("5 ProductTypes");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    sql = "select * from Cities";
                    sqlQuery = "insert into Cities([CityName]) " +
                    "values(@Cityname)";
                    Console.WriteLine("Enter City");
                    string cityName = Console.ReadLine();
                    city = new City()
                    {
                        CityName = cityName
                    };
                    var rows = connection.Execute(sqlQuery, city);
                    Console.WriteLine("Affectred rows:" + rows.ToString());
                    break;
                case 2:
                    sql = "select * from Countries";
                    sqlQuery = "insert into Countries([CountryName]) " +
                     "values(@Countryname)";
                    Console.WriteLine("Enter CountryName");
                    string CountryName = Console.ReadLine();
                    Country = new Country()
                    {
                        CountryName = CountryName
                    };
                    var rows1 = connection.Execute(sqlQuery, Country);
                    Console.WriteLine("Affectred rows:" + rows1.ToString());
                    break;
                case 3:
                    sql = "select * from Clients";
                    sqlQuery = "insert into Clients([FIO],[Birthday],[Email],[CountryId],[GenderId],[ProductTypeId],[DiscontId],[CityId]) " +
                     "values(@Fio,@Email,@CountryId,@GenderId,@ProductTypeId,@DiscontId,@CityId)";
                    Console.WriteLine("Enter FIO");
                    string FIO = Console.ReadLine();
                    Console.WriteLine("Enter Date");
                    string date = Console.ReadLine();
                    DateTime dt = Convert.ToDateTime(date);
                    Console.WriteLine("Enter Email");
                    string Email = Console.ReadLine();
                    Console.WriteLine("Enter GenderId");
                    int GenderIdClient = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter CountryId");
                    int countryIdClient = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ProductTypeId");
                    int ProductTypeIdClient = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter CityId");
                    int CityIdСClient = int.Parse(Console.ReadLine());
                    Client = new Client()
                    {
                        FIO = FIO,
                        Birthday = dt,
                        Email = Email,
                        GenderId = GenderIdClient,
                        CountryId = countryIdClient,
                        ProductTypeId = ProductTypeIdClient,
                        CityId = CityIdСClient
                    };
                    var rows2= connection.Execute(sqlQuery, Discont);
                    
                    Console.WriteLine("Affectred rows:" + rows2.ToString());
                    break;
                case 4:
                    sql = "select * from Discounts";
                    sqlQuery = "insert into Discounts([Product],[CountryId],[ProductTypeId],[CityId]) " +
                     "values(@Product,@CountryId,@ProductTypeId,@CityId)";
                    Console.WriteLine("Enter TypeName");
                    string Product = Console.ReadLine();
                    Console.WriteLine("Enter CountryId");
                    int countryId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter ProductTypeId");
                    int ProductTypeId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter CityId");
                    int CityId = int.Parse(Console.ReadLine());
                    Discont = new Discont()
                    {
                        Product = Product,
                        CountryId = countryId,
                        ProductTypeId = ProductTypeId,
                        CityId = CityId
                    };
                    var rows5 = connection.Execute(sqlQuery, Discont);
                    Console.WriteLine("Affectred rows:" + rows5.ToString());
                    break;
                case 5:
                    sql = "select * from ProductTypes";
                    sqlQuery = "insert into ProductTypes([TypeName]) " +
                     "values(@TypeName)";
                    Console.WriteLine("Enter TypeName");
                    string TypeName = Console.ReadLine();
                    ProductType = new ProductType()
                    {
                        TypeName = TypeName
                    };
                    var rows3 =  connection.Execute(sqlQuery, Country);
                    Console.WriteLine("Affectred rows:" + rows3.ToString());
                    break;
            }
            
            var result = connection.Query(sql);
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }
            connection.Close();
            PrintMenu();
        }
        private static void Update()
        {
            connection.Open();
            Console.WriteLine("Сделайте выбор таблицы");
            Console.WriteLine("1 Cities");
            Console.WriteLine("2 Countries");
            Console.WriteLine("3 Clients");
            Console.WriteLine("4 Disconts");
            Console.WriteLine("5 ProductTypes");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    sql = "select * from Cities";
                    sqlQuery = "update Cities set CityName = @CityName where Id = @Id";
                    var result = connection.Query(sql);
                    foreach (var item in result)
                    {
                        Console.WriteLine($"{item}");
                    }
                    Console.WriteLine("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter City");
                    string cityName = Console.ReadLine();
                    city = new City()
                    {    
                        Id = id,
                        CityName = cityName
                    };
                    connection.Execute(sqlQuery, city);
                    break;
                case 2:
                    sql = "select * from Countries";
                    sqlQuery = "update Countries set CountryName = @CountryName where Id = @Id";
                    var resultCountry = connection.Query(sql);
                    foreach (var item in resultCountry)
                    {
                        Console.WriteLine($"{item}");
                    }
                    Console.WriteLine("Enter Id: ");
                    int idCountry = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Country");
                    string CountryName = Console.ReadLine();
                    Country = new Country()
                    {
                        Id = idCountry,
                        CountryName = CountryName
                    };
                    connection.Execute(sqlQuery, Country);
                    break;
                case 3:
                    {
                        sql = "select * from Clients";

                        //sqlQuery = "insert into Clients([FIO],[Birthday],[Email],[CountryId],[GenderId],[ProductTypeId],[DiscontId],[CityId]) " +
                        // "values(@Fio,@Email,@CountryId,@GenderId,@ProductTypeId,@DiscontId,@CityId)";
                        var resultClient = connection.Query(sql);
                        foreach (var item in resultClient)
                        {
                            Console.WriteLine($"{item}");
                        }

                        Console.WriteLine("Enter Id: ");
                        int IdClientUpdate = int.Parse(Console.ReadLine());

                        Console.WriteLine("Сделайте выбор поля");
                        Console.WriteLine("1 FIO");
                        Console.WriteLine("2 Birthday");
                        Console.WriteLine("3 Email");
                        Console.WriteLine("4 CountryId");
                        Console.WriteLine("6 ProductTypeId");
                        Console.WriteLine("7 DiscontId");
                        Console.WriteLine("9 CityId");

                        int choiceUp = int.Parse(Console.ReadLine());

                        switch (choiceUp)
                        {
                            case 1:
                                sqlQuery = "update Clients set FIO = @FIO where Id = @Id";
                                Console.WriteLine("Enter FIO");
                                string FIO = Console.ReadLine();
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    FIO = FIO
                                };
                                break;
                            case 2:
                                sqlQuery = "update Clients set Birthday = @Birthday where Id = @Id";
                                Console.WriteLine("Enter Birthday");
                                string Birthday = Console.ReadLine();
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    Birthday = Convert.ToDateTime(Birthday)
                                };
                                break;
                            case 3:
                                sqlQuery = "update Clients set Email = @Email where Id = @Id";
                                Console.WriteLine("Enter Email");
                                string Email = Console.ReadLine();
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    Email = Email
                                };
                                break;
                            case 4:
                                sqlQuery = "update Clients set CountryId = @CountryId where Id = @Id";
                                sql = "select * from Country";
                                var resultC = connection.Query(sql);
                                foreach (var item in resultC)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                Console.WriteLine("Enter CountryId");
                                int CountryIdClient = int.Parse(Console.ReadLine());
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    CountryId = CountryIdClient
                                };
                                break;
                            case 5:
                                sqlQuery = "update Clients set ProductTypeId = @ProductTypeId where Id = @Id";
                                sql = "select * from ProductTypes";
                                var pt = connection.Query(sql);
                                foreach (var item in pt)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                Console.WriteLine("Enter ProductTypeId");
                                int PTIdClient = int.Parse(Console.ReadLine());
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    ProductTypeId = PTIdClient
                                };
                                break;
                            case 6:
                                sqlQuery = "update Clients set DiscontId = @DiscontId where Id = @Id";
                                sql = "select * from Discounts";
                                var discontId = connection.Query(sql);
                                foreach (var item in discontId)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                Console.WriteLine("Enter DiscontId");
                                int DId = int.Parse(Console.ReadLine());
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    DiscontId = DId
                                };
                                break;
                            case 7:
                                sqlQuery = "update Clients set CityId = @CityId where Id = @Id";
                                sql = "select * from Cities";
                                var CitId = connection.Query(sql);
                                foreach (var item in CitId)
                                {
                                    Console.WriteLine($"{item}");
                                }
                                Console.WriteLine("Enter CityId");
                                int CId = int.Parse(Console.ReadLine());
                                Client = new Client()
                                {
                                    Id = IdClientUpdate,
                                    CityId = CId
                                };
                                break;
                            default:
                                break;
                        }
                    }
                    var a = connection.Execute(sqlQuery, Client);
                    Console.WriteLine("Affectred rows:" + a.ToString());
                    break;
                case 4:

                    sql = "select * from Discounts";                    
                    var resultDiscounts = connection.Query(sql);
                    foreach (var item in resultDiscounts)
                    {
                        Console.WriteLine($"{item}");
                    }

                    Console.WriteLine("Enter Id: ");
                    int IdDiscountsUpdate = int.Parse(Console.ReadLine());

                    Console.WriteLine("Сделайте выбор поля");
                    Console.WriteLine("1 Product");
                    Console.WriteLine("4 CountryId");
                    Console.WriteLine("6 ProductTypeId");
                    Console.WriteLine("9 CityId");

                    int choiceDisc = int.Parse(Console.ReadLine());

                    switch (choiceDisc)
                    {
                        case 1:
                            sqlQuery = "update Discounts set Product = @Product where Id = @Id";
                            Console.WriteLine("Enter Product");
                            string Prod = Console.ReadLine();
                            Discont = new Discont()
                            {
                                Id = IdDiscountsUpdate,
                                Product = Prod
                            };
                            break;
                        case 2:
                            sqlQuery = "update Discounts set CountryId = @CountryId where Id = @Id";
                            sql = "select * from Country";
                            var resultC = connection.Query(sql);
                            foreach (var item in resultC)
                            {
                                Console.WriteLine($"{item}");
                            }
                            Console.WriteLine("Enter CountryId");
                            int CountryIdDisc = int.Parse(Console.ReadLine());
                            Discont = new Discont()
                            {
                                Id = IdDiscountsUpdate,
                                CountryId = CountryIdDisc
                            };
                            break;
                        case 3:
                            sqlQuery = "update Discounts set ProductTypeId = @ProductTypeId where Id = @Id";
                            sql = "select * from ProductTypes";
                            var pt = connection.Query(sql);
                            foreach (var item in pt)
                            {
                                Console.WriteLine($"{item}");
                            }
                            Console.WriteLine("Enter ProductTypeId");
                            int PTIdDisc = int.Parse(Console.ReadLine());
                            Client = new Client()
                            {
                                Id = IdDiscountsUpdate,
                                ProductTypeId = PTIdDisc
                            };
                            break;
                        case 4:
                            sqlQuery = "update Discounts set CityId = @CityId where Id = @Id";
                            sql = "select * from Cities";
                            var CitId = connection.Query(sql);
                            foreach (var item in CitId)
                            {
                                Console.WriteLine($"{item}");
                            }
                            Console.WriteLine("Enter CityId");
                            int CId = int.Parse(Console.ReadLine());
                            Discont = new Discont()
                            {
                                Id = IdDiscountsUpdate,
                                CityId = CId
                            };
                            break;
                    }
                    connection.Execute(sqlQuery, Discont);
                    break;
                case 5:
                    sql = "select * from ProductTypes";
                    sqlQuery = "update ProductTypes set TypeName = @TypeName where Id = @Id";
                    var resultProductTypes = connection.Query(sql);
                    foreach (var item in resultProductTypes)
                    {
                        Console.WriteLine($"{item}");
                    }
                    Console.WriteLine("Enter Id: ");
                    int idProductTypes = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter TypeName");
                    string TypeName = Console.ReadLine();
                    ProductType = new ProductType()
                    {
                        Id = idProductTypes,
                        TypeName = TypeName
                    };
                    connection.Execute(sqlQuery, ProductType);
                    break;
            }
            connection.Close();
            PrintMenu();
        }
    }
}
