using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Api_2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Tusk1();
            //Tusk2("Notepad.exe");
            //Tusk3();
            Tusk4("C:/Users/Fiks/source/repos/ITFiks/ITFIKS/DZ_Api_2/SumTest/bin/Debug/SumTest.exe");
        }
        static void Tusk1()
        {
            using (Process myProcess = Process.Start("NotePad.exe"))
            {
                do
                {
                    if (!myProcess.HasExited)
                    {
                        // Refresh the current process property values.
                        myProcess.Refresh();

                        Console.WriteLine();

                        // Display current process statistics.

                        Console.WriteLine($"{myProcess} -");
                        Console.WriteLine("-------------------------------------");

                        Console.WriteLine($"  Physical memory usage     : {myProcess.WorkingSet64}");
                        Console.WriteLine($"  Base priority             : {myProcess.BasePriority}");
                        Console.WriteLine($"  Priority class            : {myProcess.PriorityClass}");
                        Console.WriteLine($"  User processor time       : {myProcess.UserProcessorTime}");
                        Console.WriteLine($"  Privileged processor time : {myProcess.PrivilegedProcessorTime}");
                        Console.WriteLine($"  Total processor time      : {myProcess.TotalProcessorTime}");
                        Console.WriteLine($"  Paged system memory size  : {myProcess.PagedSystemMemorySize64}");
                        Console.WriteLine($"  Paged memory size         : {myProcess.PagedMemorySize64}");

                        if (myProcess.Responding)
                        {
                            Console.WriteLine("Status = Running");
                        }
                        else
                        {
                            Console.WriteLine("Status = Not Responding");
                        }
                    }
                }
                while (!myProcess.WaitForExit(1000));

                Console.WriteLine();
                Console.WriteLine($"  Process exit code          : {myProcess.ExitCode}");
            }
        }
        static void Tusk2(string exe )
        {          
            using (Process myProcess = Process.Start(exe))
            {
                Console.WriteLine("Хотите завершить процесс?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    myProcess.CloseMainWindow();
                    while (!myProcess.WaitForExit(1000)) ;
                    Console.WriteLine();
                    Console.WriteLine($"  Process exit code          : {myProcess.ExitCode}");
                }      
            }
        }
        static void Tusk3()
        {           
                using (Process process = Process.Start("C:/Users/Fiks/source/repos/ITFiks/ITFIKS/DZ_Api_2/SumTest/bin/Debug/SumTest.exe", "7+3"))
                {
                    Console.WriteLine("Хотите завершить процесс?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                    process.CloseMainWindow();
                        while (!process.WaitForExit(1000)) ;
                        Console.WriteLine();
                        Console.WriteLine($"  Process exit code          : {process.ExitCode}");
                    }
                }
        }

        static void Tusk4(string exe)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(exe);
            startInfo.FileName = exe;
            startInfo.Arguments = "C://Users/Fiks/source/repos/ITFiks/ITFIKS/DZ_Api_2/bicycle.txt    bicycle";
            using (Process process = Process.Start(startInfo))
            {
                Console.WriteLine("Хотите завершить процесс?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    process.CloseMainWindow();
                    while (!process.WaitForExit(1000)) ;
                    Console.WriteLine();
                    Console.WriteLine($"  Process exit code          : {process.ExitCode}");
                }
            }
        }
    }
}
