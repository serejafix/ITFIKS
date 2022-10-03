using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DZ_Mutex
{
    class Program
    {
        static Mutex mut = new Mutex();
        static string filePath1 = "File1.txt";
        static string filePath2 = "File2.txt";
        static string filePath3 = "File3.txt";
        static string filePathAllInfo = "File4AllInfo.txt";
        static int justnumbers;
        static string lastnumbers;
        static int counter;
        static Random random = new Random();
        static void Main(string[] args)
        {
            using (FileStream fs = File.Create(filePath1)) { }
            using (FileStream fs1 = File.Create(filePath2)) { }
            using (FileStream fs2 = File.Create(filePath3)) { }
            using (FileStream fs2 = File.Create(filePathAllInfo)) { }

            Thread[] threads = new Thread[4];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(First);
                threads[i].Start();
            }
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
            Console.WriteLine("Нажмите любую клавишу");
            Console.ReadKey();
        }
        static public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void First()
        {
            mut.WaitOne();           
            var fi = new FileInfo(filePath1);
            var f1 = new FileInfo(filePath2);
            var f2 = new FileInfo(filePath3);

            Console.WriteLine($"Начало потока  #{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
            if (fi.Length == 0)
            {
                Console.WriteLine("Запись в первый файл рандомных чисел");
                using (StreamWriter writer = new StreamWriter(filePath1, true))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        int a = random.Next(1, 100);
                        writer.WriteLine(a) ;
                    }
                }
                Thread.Sleep(2000);
            }
            else if (f1.Length != 0 && fi.Length != 0 && f2.Length != 0)
            {
                Console.WriteLine("Запись информации о всех файлах");
                var info = new FileInfo(filePath1);
                long size = info.Length;
                    //первый файл

                    foreach (string line in File.ReadLines(filePath1))
                    {
                        counter++;
                    }

                    using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                    {
                        writer.WriteLine($"Первый файл(Рандомные числа) - количество чисел: {counter} - Размер файла: {size}");
                    }
               
                    foreach (string line in File.ReadLines(filePath1))
                    {                                       
                        using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                        {                                       
                            writer.WriteLine(line);
                        }
                    }
                    counter = 0;
                    //второй файл
                    foreach (string line in File.ReadLines(filePath2))
                    {
                        counter++;
                    }

                    using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                    {
                        writer.WriteLine($"Второй файл(Простые числа) - количество чисел: {counter} - Размер файла: {size}");
                    }

                    foreach (string line in File.ReadLines(filePath2))
                    {
                        using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                        {
                            writer.WriteLine(line);
                        }
                    }
                     counter = 0;
                    //Третий файл
                    foreach (string line in File.ReadLines(filePath2))
                    {
                        counter++;
                    }

                    using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                    {
                        writer.WriteLine($"Второй файл(Простые числа) - количество чисел: {counter} - Размер файла: {size}");
                    }

                    foreach (string line in File.ReadLines(filePath3))
                    {
                        using (StreamWriter writer = new StreamWriter(filePathAllInfo, true))
                        {
                            writer.WriteLine(line);
                        }
                    }
                counter = 0;
                Thread.Sleep(2000);
            }
            else if (f1.Length != 0)
            {
                Console.WriteLine("Числа в конце 7: ");
                foreach (string line in System.IO.File.ReadLines(filePath2))
                {
                    lastnumbers = line.Substring(line.Length - 1);
                    justnumbers = Convert.ToInt32(lastnumbers);
                    if (justnumbers == 7)
                    {
                        using (StreamWriter writer = new StreamWriter(filePath3, true))
                        {
                            writer.WriteLine(line);
                        }
                        Console.WriteLine($"Число простое в конце 7 {line}");
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    string info = "Нет чисел с 7 в конце";
                    using (StreamWriter writer = new StreamWriter(filePath3, true))
                    {
                        
                        Console.WriteLine(info);
                        writer.WriteLine(info);
                    }
                }
                counter = 0;
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Запись во второй файл простых чисел");
                foreach (string line in System.IO.File.ReadLines(filePath1))
                {
                    justnumbers = Convert.ToInt32(line);
                    if (IsPrime(justnumbers))
                    {
                        using (StreamWriter writer = new StreamWriter(filePath2, true))
                        {
                            writer.WriteLine(justnumbers);
                        }
                        Console.WriteLine($"Число простое {justnumbers}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Конец потока #{Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine();
            Thread.Sleep(2000);            
            mut.ReleaseMutex();
        }
    }
}
