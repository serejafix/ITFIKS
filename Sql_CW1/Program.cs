using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using System.Data.Common;

namespace Sql_CW1
{
 
        class Program
        {
            static void Main(string[] args)
            {
                SqlConnection connection =
                    new SqlConnection(@"Data Source=DESKTOP-639J3PH;Initial Catalog=MusicCollection;Integrated Security=True");
                connection.Open();
                Console.WriteLine("ServerVersion: " + connection.ServerVersion);
                //ReadFromDb(connection, "select * from Authors; select * from Publisher; select * from Format;");
                //PrintBooksCount(connection);
                ReadFromDb(connection, "select * from themes");
                InsertTheme(connection);
                ReadFromDb(connection, "select * from themes");
                UpdateTheme(connection);
                ReadFromDb(connection, "select * from themes");
                DeleteTheme(connection);
                ReadFromDb(connection, "select * from themes");

                connection.Close();
                Console.ReadKey();
            }

            static void ReadFromDb(SqlConnection connection, string sql)
            {
                //string sql = "select * from Authors; select * from Publisher; select * from Format;";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                bool first = true;
                do
                {
                    while (reader.Read())
                    {
                        if (first)
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.Write(reader.GetName(i) + "\t");
                            }
                            first = false;
                            Console.WriteLine();
                        }
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write(reader.GetValue(i) + "\t");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    first = true;
                } while (reader.NextResult());
                reader.Close();
            }

            static void PrintBooksCount(SqlConnection connection)
            {
                SqlCommand command = new SqlCommand("select count(*) from books", connection);
                int count = (int)command.ExecuteScalar();
                Console.WriteLine($"\nBooks count: {count}");
            }

            static void InsertTheme(SqlConnection connection)
            {
                Console.Write("Enter theme: ");
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                    return;

                string sql = $"insert into Themes values('{str}')";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine($"{result} record affected");
            }
            static void DeleteTheme(SqlConnection connection)
            {
                Console.Write("Enter delete theme id: ");
                string str = Console.ReadLine();
                int id;
                if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                    return;

                string sql = $"delete from Themes where (Id = {id})";
                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine($"{result} record affected");
            }
            static void UpdateTheme(SqlConnection connection)
            {
                Console.Write("Enter update theme id: ");
                string strId = Console.ReadLine();

                Console.Write("Enter new theme name: ");
                string strName = Console.ReadLine();

                int id;
                if (string.IsNullOrEmpty(strId)
                    || !int.TryParse(strId, out id)
                    || string.IsNullOrEmpty(strName))
                    return;

                string sql = $"update Themes set [Name] = '{strName}' where (Id = {id})";

                SqlCommand command = new SqlCommand(sql, connection);
                int result = command.ExecuteNonQuery();
                Console.WriteLine($"{result} record affected");
            }
        }
    }
