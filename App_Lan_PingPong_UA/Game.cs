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
        public int pointFirst = 0;
        public int pointSecond = 0;
        static Socket sck;
        static UdpClient udpServer;
        static UdpClient udpclient;
        static IPEndPoint remoteEP;
        static IPEndPoint ep;
        static TcpClient client;
        static DialogResult dialogResult;
        static TcpListener listener;
        public Game(bool isClient, string ip = null)
        {
            InitializeComponent();

            if (!isClient)
            {
                remoteEP = new IPEndPoint(IPAddress.Any, 0);
                client = new TcpClient();
                client.Connect(ip, 25655);

                udpclient = new UdpClient();
                ep = new IPEndPoint(IPAddress.Parse(ip), 1100);
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

                    listener = new TcpListener(IPAddress.Any, 25655);
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
            if (isClient && ip == null)
            {
                rocket.Top = playground.Bottom - (playground.Bottom / 10);
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = true;
                rocket2.Visible = false;
            }
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            label_scorefirst.Text = pointFirst.ToString();
            label_scoreSec.Text = pointSecond.ToString();
            //this.Bounds = Screen.PrimaryScreen.Bounds;
            //rocket.Top = playground.Bottom;
            //rocket2.Top = playground.Bottom - (playground.Bottom);
            //ball.BackColor = Color.Transparent;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // привязка курсора к центру ракетки
            rocket.Left = Cursor.Position.X - (rocket.Width / 2);

            // зарпет выхода за границы
            if (rocket.Location.X > 593)
            {
                rocket.Location = new Point(593, 531);
            }
            if (rocket.Location.X < 3)
            {
                rocket.Location = new Point(3, 531);
            }

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
                label_point.Text = point.ToString();
            }
            if (ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            //if (ball.Top <= playground.Top)
            //{
            //    speed_top = -speed_top;
            //}

            if (ball.Bottom >= playground.Bottom)
            {
                speed_top = -speed_top;
                timer1.Enabled = false;
                ball.Location = new Point(392, 155);
                pointSecond += 1;
                label_scorefirst.Text = pointSecond.ToString();
                timer1.Enabled = true;
            }

            if (ball.Top <= playground.Top)
            {
                pointFirst += 1;
                label_scorefirst.Text = pointFirst.ToString();
            }
            if (pointFirst == 3)
            {
                timer1.Enabled = false;
                dialogResult = MessageBox.Show("Start again?", "YOU WON!", MessageBoxButtons.YesNo);
                StartAgain(dialogResult);
            }
            if (pointSecond == 3)
            {
                timer1.Enabled = false;
                dialogResult = MessageBox.Show("Start again?", "YOU LOSE!", MessageBoxButtons.YesNo);
                StartAgain(dialogResult);
            }
        }
        private void AddBonus()
        {
            Random random = new Random();        
            Label lblBonus = new Label();
            lblBonus.Text = "BONUS";
            lblBonus.Location = new Point(random.Next(10, 500), random.Next(10, 300));
            this.Controls.Add(lblBonus);
        }

        private void StartAgain(DialogResult won)
        {
            var receivedData = udpclient.Receive(ref remoteEP);
            string rocket2Pos = Encoding.UTF8.GetString(receivedData);
            string[] bufferBall = rocket2Pos.Split(' ');
            if (won == DialogResult.Yes)
            {
                if (bufferBall[0] == "YES")
                {
                    timer1.Enabled = true;
                    label_scorefirst.Text = "";
                    label_scoreSec.Text = "";
                }
                else
                {
                    this.Close();
                    udpclient.Close();
                }
            }
            else if (won == DialogResult.No)
            {
                string ballPosition = $"NO";
                byte[] ballPos = UTF8Encoding.UTF8.GetBytes(ballPosition);
                udpclient.Send(ballPos, ballPos.Length);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close();}
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            // привязка курсора к центру ракетки
            rocket2.Left = Cursor.Position.X - (rocket2.Width / 2);

            // зарпет выхода за границы
            if (rocket.Location.X > 593)
            {
                rocket.Location = new Point(593, 12);
            }
            if (rocket.Location.X < 3)
            {
                rocket.Location = new Point(3, 12);
            }

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
                label_point.Text = point.ToString();
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
                pointFirst =+ 1;
                label_scorefirst.Text = pointFirst.ToString();
            }
            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
                timer2.Enabled = false;
                ball.Location = new Point(392, 155);
                pointSecond += 1;
                label_scoreSec.Text = pointSecond.ToString();
                timer2.Enabled = true;
            }
            if (pointSecond == 3)
            {
                timer2.Enabled = false;
                dialogResult = MessageBox.Show("Start again?", "YOU WON!", MessageBoxButtons.YesNo);
                StartAgainEnemy(dialogResult);
            }
            if (pointFirst == 3)
            {
                timer2.Enabled = false;
                dialogResult = MessageBox.Show("Start again?", "YOU LOSE!", MessageBoxButtons.YesNo);
                StartAgainEnemy(dialogResult);
            }
        }
        private void StartAgainEnemy(DialogResult won)
        {           
            var StartAgainBuff = udpServer.Receive(ref remoteEP);
            string StartAgainBuffResult = Encoding.UTF8.GetString(StartAgainBuff);
            string[] bufferStart = StartAgainBuffResult.Split(' ');
            if (won == DialogResult.Yes)
            {
                string StartagainYES = $"YES";
                byte[] YES = UTF8Encoding.UTF8.GetBytes(StartagainYES);
                udpServer.Send(YES, YES.Length, remoteEP);
                if (bufferStart[0] == "YES")
                {
                    label_scorefirst.Text = "";
                    label_scoreSec.Text = "";
                    timer2.Enabled = true;

                }
                else
                {
                    MessageBox.Show("SERVER DISCONECT!");
                    this.Close();
                    udpServer.Close();
                }
            }
            else if (won == DialogResult.No)
            {
                string StartagainNO = $"NO";
                byte[] NO = UTF8Encoding.UTF8.GetBytes(StartagainNO);
                udpServer.Send(NO, NO.Length, remoteEP);
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            // привязка курсора к центру ракетки
            rocket.Left = Cursor.Position.X - (rocket2.Width / 2);

            // зарпет выхода за границы
            if (rocket.Location.X > 593)
            {
                rocket.Location = new Point(593,531);
            }
            if (rocket.Location.X < 3)
            {
                rocket.Location = new Point(3, 531);
            }
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
                speed_top = -speed_top;
                timer3.Enabled = false;
                ball.Location = new Point(392, 155);
                timer3.Enabled = true;
            }
        }
    }
}
