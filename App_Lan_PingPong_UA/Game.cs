using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Lan_PingPong_UA
{
    public partial class Game : Form
    {
        public int speed_top = 4;
        public int speed_left = 4; // скорость мяча
        public int point = 0;

        //public int ballX;
        //public int ballY;

        //TcpListener tcpListener;

        //static int port = 5000; // порт для приема
        //DialogResult dialogResult =  MessageBox.Show("Host?", "who?",MessageBoxButtons.YesNo);

        //if (dialogResult == DialogResult.Yes)
        //{
        //    IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

        //    // создаем сокет
        //    Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //    try
        //    {
        //        // связываем сокет с локальной точкой, по которой будем принимать данные
        //        listenSocket.Bind(ipPoint);

        //        // начинаем прослушивание
        //        listenSocket.Listen(1);
        //        while (true)
        //        {
        //            Socket handler = listenSocket.Accept();
        //            // получаем сообщение
        //            StringBuilder builder = new StringBuilder();
        //            int bytes = 0; // количество полученных байтов
        //            byte[] data = new byte[256]; // буфер для получаемых данных

        //            do
        //            {
        //                bytes = handler.Receive(data);
        //                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
        //            }
        //            while (handler.Available > 0);

        //            //Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

        //            //// отправляем ответ
        //            //string message = "ваше сообщение доставлено";
        //            //data = Encoding.Unicode.GetBytes(message);
        //            //handler.Send(data);
        //            //// закрываем сокет
        //            //handler.Shutdown(SocketShutdown.Both);
        //            //handler.Close();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //Console.WriteLine(ex.Message);
        //    }
        //}
        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();
            if (isHost)
            {
                server = new TcpListener(IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessaageReceiver.RunWorkerAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;

            this.Bounds = Screen.PrimaryScreen.Bounds;
            rocket.Top = playground.Bottom - (playground.Bottom / 10);
        }
        private Socket sock;
        private BackgroundWorker MessaageReceiver = new BackgroundWorker();
        private TcpClient client;
        private TcpListener server = null;
        private void timer1_Tick(object sender, EventArgs e)
        {

            rocket.Left = Cursor.Position.X - (rocket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;


            if (ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false; 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessaageReceiver.WorkerSupportsCancellation = true;
            MessaageReceiver.CancelAsync();
            if (server != null)
                server.Stop();
        }
    }
}
