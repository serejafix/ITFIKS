using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKZ_System_1
{
    public partial class Form1 : Form
    {
        
        static FileSearch fileSearch;
        string[] args = Environment.GetCommandLineArgs();
        public Form1()
        {            
            InitializeComponent();
            if (args.Length > 1)
            {
                string[] words = { };
                args = args.Skip(1).ToArray();
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                fileSearch = new FileSearch(args);
                if (fileSearch == null)
                    return;
                fileSearch.Run();
                fileSearch.EventPath += h;
                fileSearch.EventDR += b;
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        public void h(string b)
        {
            Action act = () =>
            {
                for (int i = 0; i < 100; i++)
                {
                    progressBar.Value = i + 1;
                    lbl_path.Text = b;
                }
            };
            if (this.InvokeRequired)
                this.Invoke(act);
            else act();
        }
        public void b(DialogResult result) 
        {
            if (result == DialogResult.OK)
            {
                btn_Start.Enabled = true;
                txb_EnterWords.ReadOnly = false;
                progressBar.Value = 0;
                txb_EnterWords.Text = "";
                lbl_path.Text = "";   
            }
            FormCompleted completed = new FormCompleted();
            completed.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] words = txb_EnterWords.Text.Split(new char[] { ' ', ',', '!', '.', ')', '(', '_', '?' },
                                                        StringSplitOptions.RemoveEmptyEntries); // запрещенные слова из формы в конструктор класса ->

            if(string.IsNullOrWhiteSpace(txb_EnterWords.Text))
            { MessageBox.Show("Enter Words"); return;}

            fileSearch = new FileSearch(words);

            if (fileSearch == null) // проверка на экземпляр класса
                return;
            
            fileSearch.Run(); // запуск в асинхронном режиме через метод в классе

            btn_Start.Enabled = false; // выкл кнопки пока идет выполнение программы
            txb_EnterWords.ReadOnly = true;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            fileSearch.EventPath += h;
            fileSearch.EventDR += b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txb_EnterWords.ReadOnly = false;
        }
    }
}
