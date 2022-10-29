using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKZ_System_1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        private static Mutex mutexOneAppOpen; // эдинственный экземпляр приложения
        private const string appName = "AppForSearch"; 
        [STAThread]
        static void Main()
        {
            bool tryCreateNewApp;
            mutexOneAppOpen = new Mutex(true, appName,
                    out tryCreateNewApp);
            if (tryCreateNewApp)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                return;
            }
           
        }
    }
}
