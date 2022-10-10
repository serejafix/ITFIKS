using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace WF_Semaphore
{
    public partial class Form1 : Form
    {
        static int count = 0; // количество мест в семафоре
        static int c = 1;   // для инкрементации id потока
        //private static ManualResetEvent mre = new ManualResetEvent(false);
        private static AutoResetEvent waitHandler = new AutoResetEvent(true);  // объект-событие
        static Semaphore semaphore;
        static bool isRun; // для проверки пропустил ли поток семафор
        static Dictionary<Thread, int> dictionary = new Dictionary<Thread, int>(); // попытка
        public Form1()
        {
            InitializeComponent();
        }


        private void num_Count_ValueChanged(object sender, EventArgs e)
        {
            count = (int)num_count.Value; // нумерик с формы = количество мест в семафоре            
            waitHandler.Set(); // пропускает поток из ожидающих в работащий, потому что семафор не видит запущенего потока в ожидание после смены семафора 
        }

        private void lst_CreateThread_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // двойное нажатие перемещает из созданых потоков в оижадющие и запускает       
            var b = lst_CreateThread.SelectedItem as Thread;
            if (b == null)
                return;
            lst_waitingThread.Items.Add(b);
            lst_CreateThread.Items.Remove(b);
            lst_waitingThread.DisplayMember = "Name";
            b.Start();
        }

        void DoSomething(object obj)
        {
            semaphore = new Semaphore(1, count);
            //var dict = from a in dictionary select new { Поток = a.Key.Name, Работа = a.Value }; // linq для отображение в datagridview
            waitHandler.WaitOne();
            semaphore.WaitOne(); // ждемс
            isRun = false; // меняем если семафор пропустил
            if (!isRun)
            {
                // если пропустил, тогда этот поток идет в работающие 
                var r = Thread.CurrentThread; // ловим поток и добавляем через action ->
                Action action = () =>
                {
                    dictionary.Add(r, 0);
                    lst_waitingThread.Items.Remove(r);
                    dataGridView1.DataSource = dictionary.ToList();
                };
                if (this.InvokeRequired)
                    this.Invoke(action);
                else
                    action();
                isRun = true; // делаем обратно тру, чтобы видить новые потоки которые пропустили

                while (true) // делаем илюзию работы потока увеличивая по ключу значение ->
                {
                    Thread.Sleep(1000);
                    if (dictionary.ContainsKey(r) == true)
                    {
                        dictionary[r]++;
                    }
                    Action act = () =>
                    {
                        dataGridView1.DataSource = dictionary.ToList();
                        //dataGridView1.AutoGenerateColumns = false;
                    };

                    if (this.InvokeRequired)
                        this.Invoke(act);
                    else
                        act();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var thread = (KeyValuePair<Thread, int>)dataGridView1.CurrentRow.DataBoundItem;// забираю пару ключ
            // я куча способов перепробовал, но я сдаю так у меня нет сил:)
            //string nameThread  = thread.ToString();
            //string aa;
            //string[] strs = nameThread.Split(new[] { '=', ',' }, StringSplitOptions.RemoveEmptyEntries);
            //aa = strs[1];
            thread.Key.Abort(); // из пары ключ беру ключ(поток) и выключаю его
            semaphore.Release(); // пропускаю в семафоре
            waitHandler.Set(); // пропускаю в waithandle
            dictionary.Remove(thread.Key); // удаляю с дикт
            Action act = () => dataGridView1.DataSource = dictionary.ToList(); // обновляю грид в реальном времени
            if (this.InvokeRequired)
                this.Invoke(act);
            else
                act();
        }

        private void btn_creatThread_Click(object sender, EventArgs e)
        {
            Thread tr1 = new Thread(DoSomething);
            tr1.IsBackground = true;
            tr1.Name = $"Поток {c}";
            c++; // для инкрементации имени потока
            Thread.Sleep(1000);
            lst_CreateThread.Items.Add(tr1);
            lst_CreateThread.DisplayMember = "Name";
        }
    }
}
