using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Api_1
{
    class Program
    {
        static void Main(string[] args)
        {
            task2();
        }
        private static void task1()
        {
            ApiFunc.MessageBox(IntPtr.Zero, "Hello", "1", 0);
            ApiFunc.MessageBox(IntPtr.Zero, "I am ", "2", 0);
            ApiFunc.MessageBox(IntPtr.Zero, "Fiks Sergey", "3", 0);
        }

        private static void task2()
        {

            string title = "Часы";
            IntPtr hwnd = ApiFunc.FindWindowByCaption(IntPtr.Zero, title);
            if ((hwnd == IntPtr.Zero) || (hwnd == null))
            {
                Console.WriteLine("Window not found");
            }
            else
            {
                ApiFunc.SendMessage(hwnd, 0, IntPtr.Zero, IntPtr.Zero);
            }
        }
    }
}
