using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_Task_Async
{
    class Program
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken token = cancellationTokenSource.Token;

        static void Main(string[] args)
        {
            //start1();
            //start2();
        }
        static void start1()
        {
            Task task1 = Task.Factory.StartNew(tusk1);
            task1.Wait();
        }
        static void start2()
        {
            Task task2 = Task.Factory.StartNew(tusk2);
            task2.Wait();
        }

        static void tusk1()
        {
            Console.WriteLine("Закончить");
            Console.WriteLine("1.Да");
            Console.WriteLine("2.Нет");
            int choice1 = int.Parse(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    cancellationTokenSource.Cancel();
                    Console.WriteLine("Task canceled!");
                    return;
            }

            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();
            string[] textMass;
            textMass = text.Split(' ');
            string[] question = text.Split('?');
            string[] exclaimer = text.Split('!');
            string[] allexpr = text.Split('!', '?', '.');

            Console.WriteLine("1.Записать в файл");
            Console.WriteLine("2.Вывести на экран");
            Console.WriteLine("3.Записать в файл отдельную информацию");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                    {
                        writer.WriteLineAsync("Количество слов:" + textMass.Length);
                        writer.WriteLineAsync("Количество символов:" + text.Length);
                        writer.WriteLineAsync("Количество предложений:" + allexpr.Count());
                        writer.WriteLineAsync("Количество восклицательных предложений:" + exclaimer.Count());
                        writer.WriteLineAsync("Количество вопросительных предложений:" + question.Count());
                    }
                    break;
                case 2:
                    Console.WriteLine("Количество слов:");
                    Console.WriteLine(textMass.Length);
                    Console.WriteLine("Количество символов:");
                    Console.WriteLine(text.Length);
                    Console.WriteLine("Количество предложений:");
                    Console.WriteLine(allexpr.Count() - 1);
                    Console.WriteLine("Количество восклицательных предложений:");
                    Console.WriteLine(exclaimer.Count() - 1);
                    Console.WriteLine("Количество вопросительных предложений:");
                    Console.WriteLine(question.Count() - 1);
                    break;
                case 3:
                    {

                        Console.WriteLine("1.Количество слов");
                        Console.WriteLine("2.Количество символов");
                        Console.WriteLine("3.Количество предложений");
                        Console.WriteLine("4.Количество восклицательных предложений");
                        Console.WriteLine("5.Количество вопросительных предложений");
                        int choiceOne = int.Parse(Console.ReadLine());

                        switch (choiceOne)
                        {
                            case 1:
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                                {
                                    writer.WriteLineAsync("Количество слов:" + textMass.Length);
                                }
                                break;
                            case 2:
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                                {
                                    writer.WriteLineAsync("Количество символов:" + text.Length);
                                }
                                break;
                            case 3:
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                                {
                                    writer.WriteLineAsync("Количество предложений:" + allexpr.Count());
                                }
                                break;
                            case 4:
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                                {
                                    writer.WriteLineAsync("Количество восклицательных предложений:" + exclaimer.Count()); 
                                }
                                break;
                            case 5:
                                using (StreamWriter writer = new StreamWriter(@"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\text.txt", true))
                                {  
                                    writer.WriteLineAsync("Количество вопросительных предложений:" + question.Count());
                                }
                                break;
                        }
                    }
                    break;
            }
        }
        static void tusk2()
        {
            const string pathDoubles = @"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\Double";
            const string pathOriginal = @"C:\Users\Fiks\source\repos\ITFiks\ITFIKS\DZ_Task_Async\bin\Debug\Original";
            string[] files = Directory.GetFiles(pathDoubles, "*.*", SearchOption.TopDirectoryOnly);

            IEnumerable<IGrouping<string, string>> duplicateGroups
                = files.GroupBy(file => Path.GetFileNameWithoutExtension(file))
                        .Where(group => group.Count() > 1);

            if (!Directory.Exists(pathOriginal)) // Проверяет существует ли директория для дублей
                Directory.CreateDirectory(pathOriginal); // Создаёт директорию

            foreach (IGrouping<string, string> group in duplicateGroups)
            {
                Console.WriteLine($"Files with name: {group.Key}");
                foreach (string file in group)
                {
                    Console.WriteLine($"Companion file: {file}");
                    if (string.Compare(Path.GetExtension(file), ".txt", true) != 0) // Проверка расширения файла
                        File.Move(file, pathOriginal + "\\" + Path.GetFileName(file)); // Перемещение файла
                }
            }
        }
    }
}
