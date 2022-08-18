using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
namespace DZ_Sql_VegetablesAndFruit
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-639J3PH;Initial Catalog=VegetablesAndFruits;Integrated Security=True");
            connection.Open();

            //Відображення всієї інформації з таблиці овочів і фруктів.
            string PrintAll = "select * from Table_1";
            // Відображення усіх назв овочів і фруктів.
            string PrintAllName = "select T.Name from Table_1 as T";
            //Відображення усіх кольорів.

            string PrintAllColor = "select T.Color from Table_1 as T";
            //Показати максимальну калорійність.

            string PrintMaxColories = "select top 1 T.Calories  from Table_1 as T GROUP BY T.Calories order by count(*) desc";
            //Показати мінімальну калорійність
            string PrintMinColories = "select min(T.Calories) calories from Table_1 as T";
            //Показати середню калорійність
            string PrintMidleColories = "select avg(T.Calories) calories from Table_1 as T";
            //Показати кількість овочів.
            string CountVegetables1 = "select count(Type) from  Table_1 as T where Type=1";
            //Показати кількість фруктів.
            string CountVegetables0 = "select count(Type) from  Table_1 as T where Type=0";
            //Показати кількість овочів і фруктів заданого кольору
            string CountColor = "select count(T.Name) from Table_1 as T where color = 'Зеленый'";
            //Показати кількість овочів і фруктів кожного кольору
            string CountColorDesc = "select count(T.Name) from Table_1 as T Group By T.Name";
            //Показати овочі та фрукти з калорійністю нижче вказаної.
            string ColoriesAbove = "select * from Table_1 as T where T.calories > 20";
            //Показати овочі та фрукти з калорійністю вище вказаної
            string ColoriesBelow = "select * from Table_1 as T where T.calories < 20";
            //Показати овочі та фрукти з калорійністю у вказаному
            //діапазоні.
            string ColoriesRange = "select * from Table_1 as T where T.calories < 20";
            //Показати усі овочі та фрукти жовтого кольору
            string AllYellow = "select * from Table_1 as T where T.Color = 'Желтый'";
            //Показати усі овочі та фрукти червоного кольору
            string AllRed = "select * from Table_1 as T where T.Color = 'Красный'";


            //CountType1(connection,CountVegetables1);
            //CountType0(connection, CountVegetables0);
           // CountByColor(connection, CountColor);
            //CountByDesc(connection, CountColorDesc);

            //CheckConnect(connection);
            //Print(connection, CountVegetables);
            //Print(connection, PrintAllName);

            connection.Close();
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
        static void Print(SqlConnection connection,string cmd)
        {
           
            SqlCommand cmdAllTable = new SqlCommand(cmd, connection);
            SqlDataReader reader = cmdAllTable.ExecuteReader();
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
        static void CountType1(SqlConnection connection, string counts)
        {
            SqlCommand command = new SqlCommand(counts, connection);
            int count = (int)command.ExecuteScalar();
            Console.WriteLine($"\nОвощи count: {count}");
        }
        static void CountType0(SqlConnection connection, string counts)
        {
            SqlCommand command = new SqlCommand(counts, connection);
            int count = (int)command.ExecuteScalar();
            Console.WriteLine($"\nФрукты count: {count}");
        }
        static void CountByColor(SqlConnection connection, string counts)
        {
            SqlCommand command = new SqlCommand(counts, connection);
            int count = (int)command.ExecuteScalar();
            Console.WriteLine($"\n Овощей и Фруктов заданого цвета : {count}");
        }
        static void CountByDesc(SqlConnection connection, string counts)
        {
            SqlCommand command = new SqlCommand(counts, connection);
            int count = (int)command.ExecuteScalar();
            Console.WriteLine($"\n Овощей и Фруктов заданого цвета : {count}");
        }
    }
    }

