using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DZ_Api_3
{
    public partial class Form1 : Form
    {
        static Thread thread1;
        static Thread thread;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Tusk1_Click(object sender, EventArgs e)
        {
            thread = new Thread(() =>
            {
                Action action = () =>
                {
                    if (num_rndStart.Value == 0)
                    {
                        int a = 2;
                        for (int i = 0; i < 20; i++)
                        {
                            int b = random.Next(2, (int)num_rnd_End.Value);
                            lst_rnd_Tusk1.Items.Add(b);
                            Thread.Sleep(700);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 20; i++)
                        {

                            int b = random.Next((int)num_rndStart.Value, (int)num_rnd_End.Value);
                            lst_rnd_Tusk1.Items.Add(b);
                            Thread.Sleep(700);

                        }
                    }
                };
                action();
            });            
            thread.Start();

            thread1 = new Thread(() =>
                    {
                        Action action1 = () =>
                        {
                            int end = (int)num_EndFibo.Value;
                            int j = 1;
                            for (int i = 1; i <= end; i += j)
                            {
                                j = i - j;
                                lst_fibonachi.Items.Add(j);
                                Thread.Sleep(700);
                            }
                        };
                        action1();
                    });
            thread1.Start();
            }

        private void btn_Thread1Abort_Click(object sender, EventArgs e)
        {

            if (thread == null)
                return;
            thread.Abort();
        }

        private void btn_Thread2Abort_Click(object sender, EventArgs e)
        {

            if (thread1 == null)
                return;
            thread1.Abort();
        }

        private void btn_Pause1_Click(object sender, EventArgs e)
        {
            if (thread == null)
                return;
            thread.Suspend();
        }

        private void btn_Resume1_Click(object sender, EventArgs e)
        {
            if (thread == null)
                return;
            thread.Resume();
        }

        private void btn_pause2_Click(object sender, EventArgs e)
        {
            if (thread1 == null)
                return;
            thread1.Suspend();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (thread1 == null)
                return;
            thread1.Resume();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            if (thread1 == null && thread == null)
                return;
            thread.Abort();
            thread1.Abort();
            thread = null;
            thread1 = null;
            num_rndStart = null;
            num_rnd_End = null;
            num_EndFibo = null;
            lst_rnd_Tusk1.Items.Clear();
            lst_fibonachi.Items.Clear();
        }
    }
}
