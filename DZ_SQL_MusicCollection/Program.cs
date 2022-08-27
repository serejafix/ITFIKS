using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DZ_SQL_MusicCollection
{
    class Program
    {
        static string sql;
        static SqlConnection connection;

        static void Main(string[] args)
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-639J3PH;Initial Catalog=MusicCollection;Integrated Security=True");
            sql = "select * from Artist; select * from MusicDisk; select * from Publisher;select * from Songs;select * from Styles;";
            OpenConnect(connection);
            Menu(connection);
        }

        static void OpenConnect(SqlConnection connection)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine($" Вы подключены к {connection.Database}");
            }
            else
            {
                Console.WriteLine("Ошибка подключения");
            }
        }

        static void ReadFromDb(SqlConnection connection, string sql)
        {
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
                        Console.WriteLine("-----------------------------");
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

        static void Menu(SqlConnection connection)
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вывод на экран");
                Console.WriteLine("2.Вставить");
                Console.WriteLine("3.Удалить");
                Console.WriteLine("4.Обновить");
                Console.WriteLine("5.Закрыть подключение");
                Console.WriteLine("6.Очистить консоль");
                Console.WriteLine("7.Выход");

                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        ReadFromDb(connection, sql);
                        break;
                    case 2:
                        TableMenu();
                        Console.WriteLine("Выбор таблицы для добавления");
                        break;
                    case 3:
                        DeleteArtist(connection);
                        break;
                    case 4:
                        UpdateArtist(connection);
                        break;
                    case 5:
                        connection.Close();
                        break;
                    case 6:
                        Console.Clear();
                        break;
                    case 7:
                        connection.Close();
                        break;
                    default:
                        break;
                }
            }

        }
        static void TableMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Artist");
                Console.WriteLine("2.MusicDisk");
                Console.WriteLine("3.Publisher");
                Console.WriteLine("4.Songs");
                Console.WriteLine("5.Styles");
                Console.WriteLine("6.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        ArtistMenu();
                        break;
                    case 2:
                        MusicDiskMenu();
                        break;
                    case 3:
                        PublisherMenu();
                        break;
                    case 4:
                        SongsMenu();
                        break;
                    case 5:
                        StylesMenu();
                        break;
                    case 6:
                        return;
                    default:
                        break;
                }
            }
        }

        static void StylesMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вставить");
                Console.WriteLine("2.Удалить");
                Console.WriteLine("3.Обновить");
                Console.WriteLine("4.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        InsertStyles(connection);
                        break;
                    case 2:
                        DeleteStyles(connection);
                        break;
                    case 3:
                        UpdateStyles(connection);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        static void ArtistMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вставить");
                Console.WriteLine("2.Удалить");
                Console.WriteLine("3.Обновить");
                Console.WriteLine("4.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        InsertArtist(connection);
                        break;
                    case 2:
                        DeleteArtist(connection);
                        break;
                    case 3:
                        UpdateArtist(connection);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        static void PublisherMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вставить");
                Console.WriteLine("2.Удалить");
                Console.WriteLine("3.Обновить");
                Console.WriteLine("4.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        InsertPublisher(connection);
                        break;
                    case 2:
                        DeletePublisher(connection);
                        break;
                    case 3:
                        UpdatePublisher(connection);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        static void SongsMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вставить");
                Console.WriteLine("2.Удалить");
                Console.WriteLine("3.Обновить");
                Console.WriteLine("4.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        InsertSongs(connection);
                        break;
                    case 2:
                        DeleteSongs(connection);
                        break;
                    case 3:
                        UpdateSongs(connection);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }
        static void MusicDiskMenu()
        {
            while (connection.State == System.Data.ConnectionState.Open)
            {
                Console.Clear();
                ReadFromDb(connection, sql);
                Console.WriteLine("1.Вставить");
                Console.WriteLine("2.Удалить");
                Console.WriteLine("3.Обновить");
                Console.WriteLine("4.Назад");
                Console.WriteLine("Ввод:");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        InsertMusicDisk(connection);
                        break;
                    case 2:
                        DeleteMusicDisk(connection);
                        break;
                    case 3:
                        UpdateMusicDisk(connection);
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            }
        }

        static void InsertStyles(SqlConnection connection)
        {
            Console.Write("Enter Styles name: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return;

            string sql = $"insert into Styles values('{str}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeleteStyles(SqlConnection connection)
        {
            Console.Write("Enter delete Styles id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from Styles where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void UpdateStyles(SqlConnection connection)
        {
            Console.Write("Enter update Styles id: ");
            string strId = Console.ReadLine();

            Console.Write("Enter new Styles name: ");
            string strName = Console.ReadLine();

            int id;
            if (string.IsNullOrEmpty(strId)
                || !int.TryParse(strId, out id)
                || string.IsNullOrEmpty(strName))
                return;

            string sql = $"update Styles set [Name] = '{strName}' where (Id = {id})";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }

        static void InsertPublisher(SqlConnection connection)
        {
            Console.Write("Enter Publisher name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                return;

            Console.Write("Enter Publisher Country: ");
            string country = Console.ReadLine();
            if (string.IsNullOrEmpty(country))
                return;

            string sql = $"insert into Publisher values('{name}','{country}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeletePublisher(SqlConnection connection)
        {
            Console.Write("Enter delete Publisher id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from Publisher where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void UpdatePublisher(SqlConnection connection)
        {
            Console.Write("Enter update Publisher id: ");
            string strId = Console.ReadLine();

            Console.Write("Enter new Publisher name: ");
            string strName = Console.ReadLine();

            Console.Write("Enter new Publisher Country: ");
            string country = Console.ReadLine();

            int id;
            if (string.IsNullOrEmpty(strId)
                || !int.TryParse(strId, out id)
                || string.IsNullOrEmpty(strName)
                || string.IsNullOrEmpty(country));
                return;

            string sql = $"update Publisher set [Name] = '{strName}', '{country}' where (Id = {id})";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }

        static void InsertArtist(SqlConnection connection)
        {
            Console.Write("Enter Artist name: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return;

            string sql = $"insert into Artist values('{str}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeleteArtist(SqlConnection connection)
        {
            Console.Write("Enter delete Artist id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from Artist where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void UpdateArtist(SqlConnection connection)
        {
            Console.Write("Enter update Artist id: ");
            string strId = Console.ReadLine();

            Console.Write("Enter new artist name: ");
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

        static void InsertMusicDisk(SqlConnection connection)
        {
            Console.WriteLine("Enter MusicDisk Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            return;

            Console.WriteLine("Enter Date Format 2000-01-01");
            string date = Console.ReadLine();
            if (string.IsNullOrEmpty(date)) 
            return;

            Console.Write("Enter  PublisherId: ");
            string Pid = Console.ReadLine();
            int pid;
            if (string.IsNullOrEmpty(Pid) || !int.TryParse(Pid, out pid))
                return;

            Console.Write("Enter StylesId: ");
            string Sid = Console.ReadLine();
            int sid;
            if (string.IsNullOrEmpty(Sid) || !int.TryParse(Sid, out sid))
                return;

            Console.Write("Enter  StylesId: ");
            string Aid = Console.ReadLine();
            int aid;
            if (string.IsNullOrEmpty(Aid) || !int.TryParse(Aid, out aid))
                return;

            string sql = $"insert into MusicDisk values('{name}','{date}','{pid}','{sid}','{aid}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeleteMusicDisk(SqlConnection connection)
        {
            Console.Write("Enter delete MusicDisk id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from MusicDisk where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");

        }
        static void UpdateMusicDisk(SqlConnection connection)
        {
            Console.Write("Enter update MusicDisk id: ");
            string strId = Console.ReadLine();
            int MDiD;
            if (string.IsNullOrEmpty(strId) || !int.TryParse(strId, out MDiD))
                return;

            Console.WriteLine("Enter MusicDisk Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                return;

            Console.WriteLine("Enter date Format 2000-01-01");
            string date = Console.ReadLine();
            if (string.IsNullOrEmpty(date))
                return;

            Console.Write("Enter  PublisherId: ");
            string Pid = Console.ReadLine();
            int pid;
            if (string.IsNullOrEmpty(Pid) || !int.TryParse(Pid, out pid))
                return;

            Console.Write("Enter StylesId: ");
            string Sid = Console.ReadLine();
            int sid;
            if (string.IsNullOrEmpty(Sid) || !int.TryParse(Sid, out sid))
                return;

            Console.Write("Enter  ArtistId: ");
            string Aid = Console.ReadLine();
            int aid;
            if (string.IsNullOrEmpty(Aid) || !int.TryParse(Aid, out aid))
                return;      
            string sql = $"update MusicDisk set [Name] = '{name}','{date}','{pid}','{sid}','{aid}' where (Id = {MDiD})";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }

        static void InsertSongs(SqlConnection connection)
        {
            Console.WriteLine("Enter Songs Name:");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                return;

            Console.WriteLine("Enter SongsTime:");
            string time = Console.ReadLine();
            if (string.IsNullOrEmpty(time))
                return;

            Console.Write("Enter  MusicDiskId: ");
            string Pid = Console.ReadLine();
            int pid;
            if (string.IsNullOrEmpty(Pid) || !int.TryParse(Pid, out pid))
                return;

            Console.Write("Enter StylesId: ");
            string Sid = Console.ReadLine();
            int sid;
            if (string.IsNullOrEmpty(Sid) || !int.TryParse(Sid, out sid))
                return;

            Console.Write("Enter  ArtistId: ");
            string Aid = Console.ReadLine();
            int aid;
            if (string.IsNullOrEmpty(Aid) || !int.TryParse(Aid, out aid))
                return;

            string sql = $"insert into Songs values('{name}','{time}','{pid}','{sid}','{aid}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeleteSongs(SqlConnection connection)
        {
            Console.Write("Enter delete Songs id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from Songs where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");

        }
        static void UpdateSongs(SqlConnection connection)
        {
            Console.Write("Enter update Songs id: ");
            string strId = Console.ReadLine();
            int SiD;
            if (string.IsNullOrEmpty(strId) || !int.TryParse(strId, out SiD))
                return;

            Console.WriteLine("Enter Songs Name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                return;

            Console.WriteLine("Enter SongsTime:");
            string time = Console.ReadLine();
            if (string.IsNullOrEmpty(time))
                return;

            Console.Write("Enter  MusicDiskId: ");
            string Pid = Console.ReadLine();
            int pid;
            if (string.IsNullOrEmpty(Pid) || !int.TryParse(Pid, out pid))
                return;

            Console.Write("Enter StylesId: ");
            string Sid = Console.ReadLine();
            int sid;
            if (string.IsNullOrEmpty(Sid) || !int.TryParse(Sid, out sid))
                return;

            Console.Write("Enter  ArtistId: ");
            string Aid = Console.ReadLine();
            int aid;
            if (string.IsNullOrEmpty(Aid) || !int.TryParse(Aid, out aid))
                return;
            string sql = $"update MusicDisk set [Name] = '{name}','{time}','{pid}','{sid}','{aid}' where (Id = {SiD})";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }

    }
}

