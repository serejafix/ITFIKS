using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Lan_PingPong_UA
{
    public partial class Game : Form
    {
        //static TcpListener listener;
        public int speed_top = 4;
        public int speed_left = 4; // скорость мяча
        public int point = 0;
        static Socket sck;
        static UdpClient udpServer;
        static UdpClient udpclient;
        static IPEndPoint remoteEP;
        static IPEndPoint ep;
        static TcpClient client;
        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();
            if (isHost)
            {
                remoteEP = new IPEndPoint(IPAddress.Any, 0);
                client = new TcpClient();
                client.Connect("192.168.1.124", 25655);

                    udpclient = new UdpClient();
                    ep = new IPEndPoint(IPAddress.Parse("192.168.1.124"), 1100);
                    udpclient.Connect(ep);

                timer1.Enabled = true;
                timer1.Interval = 1;
                timer2.Enabled = false;
                this.Location = new Point(0, 0);
                this.Text = "1";
                rocket.Visible = true;
                rocket2.Visible = true;
            }
            else
            {
                try
                {
                    udpServer = new UdpClient(1100);
                    remoteEP = new IPEndPoint(IPAddress.Any, 1100);

                    TcpListener listener = new TcpListener(IPAddress.Any, 25655);
                    listener.Start();
                    sck = listener.AcceptTcpClient().Client;

                    timer2.Enabled = true;
                    timer2.Interval = 005;
                    timer1.Enabled = false;
                    this.Location = new Point(500, 500);
                    this.Text = "2";
                    rocket.Visible = true;
                    rocket2.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
            
            //Cursor.Hide();
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.TopMost = true;
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            rocket.Top = playground.Bottom - (playground.Bottom / 10);
            rocket2.Top = playground.Bottom - (playground.Bottom);
            //ball.BackColor = Color.Transparent;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            rocket.Left = Cursor.Position.X - (rocket.Width / 2);


            // отправка позиции ракетки и мячика игрока 1 
            string ballPosition = $"{ball.Location.X} {ball.Location.Y} {rocket.Location.X} {rocket.Location.Y}";
            byte[] ballPos = UTF8Encoding.UTF8.GetBytes(ballPosition);
            udpclient.Send(ballPos, ballPos.Length);

            // принятие позиции ракетки второго игрока
            var receivedData = udpclient.Receive(ref remoteEP);
            string rocket2Pos = Encoding.UTF8.GetString(receivedData);
            string[] bufferBall = rocket2Pos.Split(' ');
            rocket2.Location = new Point(Convert.ToInt32(bufferBall[0]), Convert.ToInt32(bufferBall[1]));

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

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            if (ball.Bottom >= playground.Bottom)
            {
                //speed_top = -speed_top;
                //timer1.Enabled = false;
            }
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            rocket2.Left = Cursor.Position.X - (rocket2.Width / 2);

            // прием позиции мяча и рокетки->
            var ballPos = udpServer.Receive(ref remoteEP);
            string ballPosResult = Encoding.UTF8.GetString(ballPos);
            string[] bufferBall = ballPosResult.Split(' ');
            ball.Location = new Point(Convert.ToInt32(bufferBall[0]), Convert.ToInt32(bufferBall[1]));
            rocket.Location = new Point(Convert.ToInt32(bufferBall[2]), Convert.ToInt32(bufferBall[3]));

            // отправка позиции ракетки игрока 2
            string rocket2Position = $"{rocket2.Location.X} {rocket2.Location.Y}";
            byte[] rocket2Pos = UTF8Encoding.UTF8.GetBytes(rocket2Position);
            udpServer.Send(rocket2Pos, rocket2Pos.Length, remoteEP);

            if (ball.Bottom >= rocket2.Top && ball.Bottom <= rocket2.Bottom && ball.Left >= rocket2.Left && ball.Right <= rocket2.Right)
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
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Top >= playground.Top)
            {
                //timer2.Enabled = false;
            }        
        }
    }
}
