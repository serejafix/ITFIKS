using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DZ_CodeFirstMapping_ChessChapmionships
{
    class Program
    {
        public static EntityChess db;

        static void Main(string[] args)
        {
            db = new EntityChess();
            PrintMenu();
        }
        static void PrintMenu()
        {
            while (true)
            {
                Console.WriteLine("Сделайте выбор");
                Console.WriteLine("1 Меню запросов");
                Console.WriteLine("2 Меня добавления");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PrintQueryMenu();
                        break;
                    case 2:
                        PrintAddMenu();
                        break;

                }
            }
        }
        static void Query1()
        {
            var query1 = from t in db.Tournaments
                         where t.StartDate > DateTime.Now
                         select t;
            if (query1 == null)
            {
                Console.WriteLine("Таких соревований нет");
            }
            else
            {
                foreach (var t in query1)
                {
                    Console.WriteLine(t);
                }
            }

        }
        static void Query2()
        {
            var query2 = from r in db.Results
                         where r.Place == 1
                         select new
                         {
                             Место = r.Place,
                             Чемпион = r.Member.FIO,
                             Турнир = r.Tournament.Name
                         };
            if (query2 == null)
            {
                Console.WriteLine("Чемпионов нет");
            }
            foreach (var t in query2)
            {
                Console.WriteLine(t);
            }
        }
        static void Query3()
        {
            var query1 = from t in db.Tournaments
                         where t.StartDate > DateTime.Now && t.EndDate < DateTime.Now
                         select t;
            if (query1 == null)
            {
                Console.WriteLine("Таких соревований нет");
            }
            else
            {
                foreach (var t in query1)
                {
                    Console.WriteLine(t);
                }
            }
        }
        static void Query4()
        {
            Console.WriteLine("Выберите id турнира");

            foreach (var item in db.Tournaments)
            {
                Console.WriteLine($"({item.Id}),{item.Name}");
            }

            Console.WriteLine("Введите id: ");
            int tourn = int.Parse(Console.ReadLine());

            var query4 = from r in db.Results
                         from t in db.Tournaments
                         from m in db.Members
                         where r.Place == 1 && t.Id == tourn && r.TournamentId == t.Id && r.MemberId == m.Id
                         select new
                         {
                             Чемпион = r.Member.FIO,
                             Турнир = r.Tournament.Name
                         };

            foreach (var t in query4)
            {
                Console.WriteLine(t);
            }
        }
        static void Query5()
        {
            var resultt = db.Results.GroupBy(d => d.TournamentId).
                                   OrderByDescending(g => g.Count()).FirstOrDefault().Key;

            var max = db.Tournaments.FirstOrDefault(t => t.Id == resultt);
            Console.WriteLine(max.Name);
        }
        static void PrintQueryMenu()
        {
            while (true)
            {

                Console.WriteLine("Сделайте выбор");
                Console.WriteLine("1 Вывести список предстоящих турниров");
                Console.WriteLine("2 Показать чемпионов");
                Console.WriteLine("3 Показать незавершенные соревнования");
                Console.WriteLine("4 Вывести победителей в указаном турнире");
                Console.WriteLine("5 Вывести турнир с наибольшим количеством участников");
                Console.WriteLine("5 Назад");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Query1();
                        break;
                    case 2:
                        Query2();
                        break;
                    case 3:
                        Query3();
                        break;
                    case 4:
                        Query4();
                        break;
                    case 5:
                        Query5();
                        break;
                    case 6:
                        Console.Clear();
                        return;

                }
            }
        }
        static void PrintAddMenu()
        {
            while (true)
            {

                Console.WriteLine("Сделайте выбор");
                Console.WriteLine("1 Добавить нового участника");
                Console.WriteLine("2 Добавить новое соревнование");
                Console.WriteLine("3 Добавить новый результат соревнований");
                Console.WriteLine("3 Назад");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddNewMember();
                        break;
                    case 2:
                        AddNewTournament();
                        break;
                    case 3:
                        AddNewResults();
                        break;
                    case 4:
                        Console.Clear();
                        return;
                }
            }
        }
        private static void AddNewTournament()
        {
            Console.WriteLine("Создание нового соревнования: ");

            Console.WriteLine("Введите Название");
            string name = Console.ReadLine();
            if (name == null)
            {
                return;
            }

            Console.WriteLine("Введите Место проведения");
            string venue = Console.ReadLine();
            if (venue == null)
            {
                return;
            }

            Console.WriteLine("Введите Старт Дату в формате dd/MM/yyyy ");
            string line = Console.ReadLine();
            DateTime startdt;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out startdt))
            {
                Console.WriteLine("Неправильный ввод, введите ещё раз");
                line = Console.ReadLine();
            }
            Console.WriteLine("Введите Конечную Дату в формате dd/MM/yyyy ");

            string line2 = Console.ReadLine();
            DateTime enddt;
            while (!DateTime.TryParseExact(line2, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out enddt))
            {
                Console.WriteLine("Неправильный ввод, введите ещё раз");
                line = Console.ReadLine();
            }
            Tournament t = new Tournament()
            {
                Name = name,
                Venue = venue,
                StartDate = startdt,
                EndDate = enddt
            };

            db.Tournaments.Add(t);
            db.SaveChanges();
            if (t != null)
                Console.WriteLine("Соревнование добавлено");
        }
        private static void AddNewMember()
        {
            Console.WriteLine("Добавление нового Участника: ");

            Console.WriteLine("Введите Имя");
            string fio = Console.ReadLine();
            if (fio == null)
            {
                return;
            }
            Console.WriteLine("Введите День рождение в формате dd/MM/yyyy ");
            string line = Console.ReadLine();
            DateTime dt;
            while (!DateTime.TryParseExact(line, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dt))
            {
                Console.WriteLine("Неправильный ввод, введите ещё раз");
                line = Console.ReadLine();
            }
            Console.WriteLine("Введите Страну");
            string country = Console.ReadLine();
            if (fio == null)
            {
                return;
            }
            Console.WriteLine("Выберите разряд");
            int a = 1;
            foreach (var item in db.Levels)
            {
                Console.WriteLine($"({a}),{item.CategoryLevel}");
                a++;
            }
            Console.WriteLine("Введите номер разряда");
            int lvlid = int.Parse(Console.ReadLine());
            Member m = new Member()
            {
                FIO = fio,
                Birthday = dt,
                Country = country,
                LevelId = lvlid,
            };
            db.Members.Add(m);
            db.SaveChanges();
            if (m != null)
            {
                Console.WriteLine("Участник добавлен");
            }

        }
        private static void AddNewResults()
        {
            Console.WriteLine("Создание Результаты соревнования: ");
            int place;
            while (true)
            {
                Console.WriteLine("Введите место от 1-3");
                place = int.Parse(Console.ReadLine());
                if (place < 1 || place > 3)
                {
                    Console.WriteLine("неправильный ввод, введите ещё раз");
                }

                else
                {
                    Console.WriteLine("Выберите участника");
                    int a = 1;
                    foreach (var item in db.Members)
                    {
                        Console.WriteLine($"({a}),{item.FIO}");
                        a++;
                    }
                    int memberId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите Турнир");
                    int b = 1;
                    foreach (var item in db.Tournaments)
                    {
                        Console.WriteLine($"({b}),{item.Name}");
                        b++;
                    }
                    int tournamentId = int.Parse(Console.ReadLine());
                    Result r = new Result()
                    {
                        MemberId = memberId,
                        Place = place,
                        TournamentId = tournamentId
                    };
                    db.Results.Add(r);
                    db.SaveChanges();
                    if (r != null)
                    {
                        Console.WriteLine("Результат соревнований добавлен");
                    }
                    return;
                }
            }

        }

        //Метод добавляет разряды -  без пользователя!
        private static void AddLevel()
        {

            Level l = new Level()
            {
                CategoryLevel = "Первый Разряд"
            };
            Level l2 = new Level()
            {
                CategoryLevel = "Второй Разряд"
            };
            Level l3 = new Level()
            {
                CategoryLevel = "Третий Разряд"
            };
            Level l4 = new Level()
            {
                CategoryLevel = "Четвёртый Разряд"
            };
            Level l5 = new Level()
            {
                CategoryLevel = "Кандидат в мастера"
            };
            db.Levels.Add(l);
            db.Levels.Add(l2);
            db.Levels.Add(l3);
            db.Levels.Add(l4);
            db.Levels.Add(l5);
            db.SaveChanges();
            Console.WriteLine("Разряды добавлены!");
        }

    }
}

