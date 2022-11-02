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
        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();
            if (isHost)
            {
                server = new TcpListener(IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();              
              
                timer1.Enabled = true;
            }
            else
            {
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessaageReceiver.RunWorkerAsync();
                    timer2.Enabled = true;
                    timer2.Interval = 1;
                    timer1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }            
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            rocket.Top = playground.Bottom - (playground.Bottom / 10);
            rocket2.Top = playground.Bottom - (playground.Bottom);
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
            byte[] XY = { (byte)ball.Location.X, (byte)ball.Location.Y };
            sock.Send(XY);
            byte[] buffer = new byte[20];
            sock.Receive(buffer);
            rocket2.Location = new Point(buffer[0], buffer[1]);
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
        private void timer2_Tick(object sender, EventArgs e)
        {
            rocket2.Left = Cursor.Position.X - (rocket.Width / 2);
            byte[] buffer = new byte[20];
            sock.Receive(buffer);
            ball.Location = new Point(buffer[0], buffer[1]);
            byte[] XY = { (byte)rocket2.Location.X, (byte)rocket2.Location.Y};
            sock.Send(XY);
            if (ball.Bottom >= rocket2.Top && ball.Bottom <= rocket2.Bottom && ball.Left >= rocket2.Left && ball.Right <= rocket2.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
            }
            //if (ball.Left <= playground.Left)
            //{
            //    speed_left = -speed_left;
            //}
            //if (ball.Right >= playground.Right)
            //{
            //    speed_left = -speed_left;
            //}
            //if (ball.Top <= playground.Top)
            //{
            //    speed_top = -speed_top;
            //}
            //if (ball.Top >= playground.Top)
            //{
            //    timer1.Enabled = false;
            //}
        }
    }
}
