using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace Client_Currency
{
    public partial class Form1 : Form
    {
        static TcpClient client;
        static int count = 1;
        public Form1()
        {
            client = null;
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
           
            if (buttonConnect.Text == "Connect")
            {
                client = new TcpClient();
                if (client != null)
                client.Connect(new IPEndPoint(IPAddress.Parse(textBox_Ip.Text), Convert.ToInt32(textBox_Port.Text)));
                if (textBox_login.Text != "" && textBox_pasw.Text != "")
                {
                    NetworkStream ns = client.GetStream();
                    byte[] buffer = Encoding.UTF8.GetBytes(textBox_login.Text + " " + textBox_pasw.Text);
                    ns.Write(buffer, 0, buffer.Length);
                }

                buttonConnect.Text = "Disconect";
                label_Cure.Text = "";
                Task.Run(ReadMessage);
            }
            else
            {
                client.Close();
                buttonConnect.Text = "Connect";
            }                   
        }
        private void ReadMessage()
        {
            if (!client.Connected || client == null)
                return;
            NetworkStream ns = client.GetStream();
            int bytes = 0;
            byte[] buffer = new byte[256];
            StringBuilder sb = new StringBuilder();
            do
            {
                bytes = ns.Read(buffer, 0, buffer.Length);
                sb.Append(Encoding.UTF8.GetString(buffer, 0, bytes));
            } while (ns.DataAvailable);
            if (sb.ToString() == "limit" || sb.ToString() == "wrong input")
            {
                client.Close();
                Action action = () => { label_Cure.Text = sb.ToString(); buttonConnect.Text = "Connect"; };
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();               
                sb.Clear();
            }
            else
            {
                Action act = () => { label_Cure.Text = sb.ToString(); };
                if (InvokeRequired)
                    Invoke(act);
                else
                    act();
            }
        }
        private async void Countdown()
        {
            if (count == 3)
            {
                button_Send.Enabled = false;
                var start = DateTime.UtcNow;
                var end = start.AddSeconds(60);
                var diff = TimeSpan.FromSeconds(60);

                while ((DateTime.UtcNow - start) < diff)
                {
                    label_Stopwatch.Text = (diff - (DateTime.UtcNow - start)).ToString();
                   await Task.Delay(1000);
                }
                button_Send.Enabled = true;
            }
            else
            {
                return;
            }
        }
        private void button_Send_Click(object sender, EventArgs e)
        {
                if (client == null ||  !client.Connected )
                return;
                Countdown();
                NetworkStream ns = client.GetStream();
                if (comboBoxFirst.SelectedItem.ToString() == comboBoxSecond.SelectedItem.ToString())
                {
                    label_Cure.Text = "Input true currency";
                }
                else
                {
                    if (comboBoxFirst.SelectedItem.ToString() != "" && comboBoxSecond.SelectedItem.ToString() != "")
                    {
                        byte[] buffer = Encoding.UTF8.GetBytes(comboBoxFirst.SelectedItem.ToString() + " " + comboBoxSecond.SelectedItem.ToString());
                        ns.Write(buffer, 0, buffer.Length);
                    }
                    count++;                   
                }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(client != null)
            client.Close();
            buttonConnect.Text = "Connect";
        }
    }
}
