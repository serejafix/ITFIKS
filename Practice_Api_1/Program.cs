using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Practice_Api_1
{
    class Program
    {
      
        static void Main(string[] args)
        {

            //Task1("Hello World", "Задание 1");
            //Task2();
            Task3();
        }
        static void Task1(string message,string title)
        {
            PracticDLL.MessageBox(IntPtr.Zero, message, title, 0);
        }
        static void Task2()
        {
            Random rnd = new Random();
            int number;
            int randomNumber;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Enter Number");
                    number = int.Parse(Console.ReadLine());
                    if (number < 0 || number > 100)
                    {
                        Console.WriteLine("Enter again range 0-100");          
                    }
                    else
                    {
                        Console.Clear();
                        randomNumber = rnd.Next(0, 100);
                        PracticDLL.MessageBox(IntPtr.Zero, $"Ваше число: {Convert.ToString(number)} - Случайное число: {randomNumber}", "Введите число от 0-100", PracticDLL.MB_OK);
                    }
                }
            }
        }
        static void Task3()
        {
            string title = "Текстовый документ (2) - Блокнот";
            IntPtr hwnd = PracticDLL.FindWindowByCaption(IntPtr.Zero, title);
            if ((hwnd == IntPtr.Zero) || (hwnd == null))
            {
                Console.WriteLine("Window not found");
            }

        }
    }
}
