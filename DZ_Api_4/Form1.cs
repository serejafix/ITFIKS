using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace DZ_Api_4
{
    public partial class Form1 : Form
    {
        static Random random = new Random();
        static int countBar;

        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";    
        }
        #region Задание 1
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (countBars.Value == 0)
                return;
            countBar = countBars.Value;

            Thread thread = new Thread(Tusk1);
            thread.Start();
        }
        void Tusk1()
        {
            int locationX = 110;

            Action action = () =>
            {
                ProgressBar a = new ProgressBar();
                a.Value = random.Next(5, 100);
                a.SetState(random.Next(1, 4));
                a.Location = new Point(5, locationX);
                Controls.Add(a);
                locationX = locationX + 25;

            };

            for (int i = 0; i < countBar; i++)
            {
                if (this.InvokeRequired)
                    this.Invoke(action);
                else
                    action();
                Thread.Sleep(1000);
            }
        }
        #endregion
        #region  Задание 2
        private void btn_startHorse_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Tusk2);
            thread.Start();
        }
        void Tusk2()
        {
            listBox1.Items.Clear();
            int locationX = 110;
            int locationY = 100;
            int horseSpped;
            int count = 1;
            Action action1 = () =>
            {
                for (int i = 0; i < 5; i++)
                {
                    ProgressBar a = new ProgressBar();
                    a.Value = 100;
                    a.Location = new Point(locationY, locationX);
                    Controls.Add(a);
                    locationX = locationX + 25;
                    horseSpped = random.Next(20, 50);
                    listBox1.Items.Add(count.ToString() + ".".ToString() + horseSpped.ToString());
                    count++;
                }
            };

            if (this.InvokeRequired)
                this.Invoke(action1);
            else
                action1();
            Thread.Sleep(1000);
        }
        #endregion
        #region Задание 3
        private void btn_startFib_Click(object sender, EventArgs e)
        {
            Action<object> action = Fibonachi;

            action.BeginInvoke(random.Next(4, 10), null, null);

        }
        void Fibonachi(object obj)
        {
            int end = (int)num_EndFib.Value;
            int j = 1;
            for (int i = 1; i <= end; i += j)
            {
                j = i - j;
                lst_Fibo.Items.Add(j);
                Thread.Sleep(500);
            }
        }
        #endregion
        #region Задание 4
        void CountWord(object obj)
        {
            String[] words = fileText.Split(new char[] { ' ', ',', '\n', '\r' });

            int counter = 0;

            foreach (var word in words)
            {
                if (txb_Word.Text == word.ToLower())
                    counter++;
            }
            lbl_CountWords.Text = counter.ToString();
        }

        static string fileText;
        private void btn_OpenFIle_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            fileText = System.IO.File.ReadAllText(filename);
        }

        private void txb_Word_TextChanged(object sender, EventArgs e)
        {
            if (txb_Word.Text == null)
            {
                btn_OpenFIle.Enabled = false;
            }
            else
            {
                btn_OpenFIle.Enabled = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_OpenFIle.Enabled = false;
        }

        private void btn_startCounterWords_Click(object sender, EventArgs e)
        {
            Action<object> action = CountWord;

            action.BeginInvoke(random.Next(4, 10), null, null);
        }
        #endregion
        #region Задание 5
        
        static private string folderName;
        static private string wordName;
        static private string allText;
        private void btn_Tusk5_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                lbl_showPath.Text = folderName;
            }
    }
        private void txb_wordsForeSearch_TextChanged(object sender, EventArgs e)
        {
            wordName = txb_wordsForeSearch.Text;           
        }
        static Dictionary<string, int> DiscFileLine = new Dictionary<string, int>();
       
        void CountWordsInAllFile(object obj)
        {
            foreach (var file in Directory.GetFiles(folderName, "*.txt"))
            {
                allText = System.IO.File.ReadAllText(file);
                String[] words = allText.Split(new char[] { ' ', ',', '\n', '\r' });
                int counter = 0;
                foreach (var word in words)
                {
                    if (wordName == word.ToLower())
                        counter++;
                }
                string fileN = Path.GetFileName(file);
                DiscFileLine.Add(fileN, counter);
            }
            var discFileWord = from d in DiscFileLine select new { CountWords = d.Value, FileName = d.Key };
            dataGridView1.DataSource = discFileWord.ToArray();
        }
        private void btn_Tusk5Start_Click(object sender, EventArgs e)
        {
            if (wordName == null && folderName == null)
                return;

            Action<object> action1 = CountWordsInAllFile;

            action1.BeginInvoke(random.Next(4, 10), null, null);          
        }
        #endregion
    }

    // Задать цвет ProgressBar
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
