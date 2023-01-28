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

// ИГРА ПИНГ ПОНГ, разработанна специально для экзаменационного проекта.
namespace App_Lan_PingPong_UA
{
    public partial class Game : Form
    {
        // часть для игровой логики -> 
        public int speed_top = 1; // скорость мяча
        public int speed_left = 1; // скорость мяча

        public int point = 0; // количество ударов ракеткой
        public int pointFirst = 0; // очки первого игрока
        public int pointSecond = 0; // очки второго игрока

        static Label lblBonus = new Label();
        //static DialogResult dialogResult; // по забитию трех голов 
        static Server server;
        static Client client;
        static List<Exception> exceptions = new List<Exception>(); // поле если нужно проверить о
        public Game(bool isHost, string ip = null)
        {
            InitializeComponent();

            if (isHost)
            {
                try
                {
                    server = new Server();
                    server.StartLisnter();
                    this.Location = new Point(500, 500);
                    rocket.Visible = true;
                    rocket2.Visible = true;              
                    _ = StartAsync2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }   
            }
            else
            {
                try
                {
                    client = new Client();
                    client.Start(ip);
                    this.Location = new Point(0, 0);
                    rocket.Visible = true;
                    rocket2.Visible = true;
                    _ = StartAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
              
            }
            Cursor.Hide();
            this.TopMost = true; // поверх остальных окон
            this.StartPosition = FormStartPosition.CenterScreen; // старт позиция
            this.FormBorderStyle = FormBorderStyle.FixedDialog; // неизменность окна

            label_scorefirst.Text = pointFirst.ToString(); // очки 
            label_scoreSec.Text = pointSecond.ToString(); // очки
            //timer_AddBonus.Enabled = true; // бонус 
            //timer_AddBonus.Interval = 20000;// интервал появления бонуса
            //rocket.Top = playground.Bottom; // позиция ракетки   1

            rocket.Top = playground.Bottom - (playground.Bottom/10);

            rocket2.Top = playground.Bottom - (playground.Bottom); // позиция ракетки  2
            this.KeyPreview = true;
        }

        private async Task StartAsync() => await Task.Run(Player1); // запуск в асинхроне логики первого игрока
        private async Task StartAsync2() => await Task.Run(Player2); // запуск в асинхроне логики первого 2 игрока
        private void RocketGoingAboard(PictureBox rockets)
        {
            Action act= () =>
            {
                // зарпет выхода за границы экрана
                if (rockets.Location.X > 593)
                {
                    rockets.Location = new Point(593, 531);
                }
                if (rockets.Location.X < 3)
                {
                    rockets.Location = new Point(3, 531);
                }
            };
            if (InvokeRequired)
                Invoke(act);
            else
                act();
        }
        private void Player1()
        {
            Thread.Sleep(100);
            while (true)
            {
                
                Action act1 = () =>
                {
                    // привязка курсора к центру ракетки
                    rocket.Left = Cursor.Position.X - (rocket.Width / 2);
                };
                if (InvokeRequired)
                    Invoke(act1);
                else
                    act1();
                //RocketGoingAboard(rocket); // запрет выхода за границу
                try
                {
                    //отправка позиции ракетки и мячика игрока 1
                    string ballPosition = $"{ball.Location.X} {ball.Location.Y} {rocket.Location.X} {rocket.Location.Y}";
                    byte[] ballPos = UTF8Encoding.UTF8.GetBytes(ballPosition);
                    client.udpclient.Send(ballPos, ballPos.Length);
                }
                catch (Exception)
                {
                }
                try 
                {
                    // попробовать данную проверку
                    if (client.udpclient.Available > 0) // Only read if we have some data  !!!!!!!!!!!!!!!
                    {                           // queued in the network buffer. 
                        var receivedData1 = client.udpclient.Receive(ref client.remoteEP); 
                    }
                    //принятие позиции ракетки второго игрока
                    //var receivedData = client.udpclient.Receive(ref client.remoteEP);                   
                    var receivedData = client.udpclient.ReceiveAsync();                   
                    string rocket2Pos = Encoding.UTF8.GetString(receivedData.Result.Buffer);
                    string[] bufferBall = rocket2Pos.Split(' ');
                    Action act = () =>
                    {
                        rocket2.Location = new Point(Convert.ToInt32(bufferBall[0]), Convert.ToInt32(bufferBall[1]));
                    };
                    if (InvokeRequired)
                        Invoke(act);
                    else
                        act();
                    
                }
                catch (Exception)
                {

                }

                ball.Left += speed_left;
                ball.Top += speed_top;

                if (ball.Top <= rocket2.Bottom && ball.Left >= rocket2.Left && ball.Right <= rocket2.Right)
                {
                    //speed_top += 1;
                    //speed_left += 1;
                    speed_top = -speed_top;
                    point += 1;
                    label_point.Text = point.ToString();
                }

                //CheckPoints(); // проверка на забитие гола

                //CheckGetBonusRocket(rocket); // проверка на взятие бонуса
                //CheckGetBonusRocket(rocket2); // проверка на взятие бонуса

                if (ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
                {
                    //speed_top += 1;
                    //speed_left += 1;
                    speed_top = -speed_top;
                    point += 1;
                    label_point.Text = point.ToString();
                }

                if (ball.Right >= playground.Right)
                {
                    speed_left = -speed_left;
                }

                if (ball.Left <= playground.Left)
                {
                    speed_left = -speed_left;
                }
                //if (pointFirst == 3)
                //{
                //    player1.Enabled = false;
                //    dialogResult = MessageBox.Show("Start again?", "YOU WON!", MessageBoxButtons.YesNo);
                //    StartAgain(dialogResult);
                //}
                //if (pointSecond == 3)
                //{
                //    player1.Enabled = false;
                //    dialogResult = MessageBox.Show("Start again?", "YOU LOSE!", MessageBoxButtons.YesNo);
                //    StartAgain(dialogResult);
                //}
            }
        }
        private void CheckPoints()
        {
            if (ball.Top <= playground.Top)
            {
                pointFirst += 1;
                label_scorefirst.Text = pointFirst.ToString();
            }

            if (ball.Bottom >= playground.Bottom)
            {
                speed_top = -speed_top;
                player1.Enabled = false;
                ball.Location = new Point(392, 155);
                pointSecond += 1;
                label_scorefirst.Text = pointSecond.ToString();
                player1.Enabled = true;
            }
        }
        private void AddBonus()
        {
            Random random = new Random();
            lblBonus.Location = new Point(random.Next(10, 500), random.Next(10, 300));
            lblBonus.ForeColor = Color.Red;
            this.Controls.Add(lblBonus);
        }
        private void CheckGetBonusRocket(PictureBox rockets)
        {
            if (ball.Top == lblBonus.Bottom && ball.Bottom == lblBonus.Top)
            {
                rockets.Width = 784;
                RocketGoingAboard(rockets);
                this.Controls.Remove(lblBonus);
            }

            if (rocket.Width == 784 && ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
            {
                rockets.Width = 189;
            }
        }
        private void StartAgain(DialogResult won)
        {
            var receivedData = client.udpclient.Receive(ref client.remoteEP);
            string rocket2Pos = Encoding.UTF8.GetString(receivedData);
            string[] bufferBall = rocket2Pos.Split(' ');
            if (won == DialogResult.Yes)
            {
                if (bufferBall[0] == "YES")
                {
                    player1.Enabled = true;
                    label_scorefirst.Text = "";
                    label_scoreSec.Text = "";
                }
                else
                {
                    this.Close();
                    client.udpclient.Close();
                }
            }
            else if (won == DialogResult.No)
            {
                string ballPosition = $"NO";
                byte[] ballPos = UTF8Encoding.UTF8.GetBytes(ballPosition);
                client.udpclient.SendAsync(ballPos, ballPos.Length);
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close();}
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        private void Player2()
        {
            Thread.Sleep(100);
            while (true)
            {
                
                Action act1 = () =>
                {
                    rocket2.Left = Cursor.Position.X - (rocket2.Width / 2);
                };
                    if (InvokeRequired)
                    Invoke(act1);
                else
                    act1();
                // привязка курсора к центру ракетки


                //RocketGoingAboard(rocket2); // запрет выхода за границу

                //CheckPoints(); // проверка на забитие гола

                //CheckGetBonusRocket(rocket); // проверка на взятие бонуса

                //CheckGetBonusRocket(rocket2); // проверка на взятие бонуса
                try
                {
                    
                    Action act = () =>
                    {
                        //прием позиции мяча и рокетки->
                        //var ballPos = server.udpServer.Receive(ref server.remoteEP);
                        var ballPos = server.udpServer.ReceiveAsync();
                        string ballPosResult = Encoding.UTF8.GetString(ballPos.Result.Buffer);

                        string[] bufferBall = ballPosResult.Split(' ');
                        ball.Location = new Point(Convert.ToInt32(bufferBall[0]), Convert.ToInt32(bufferBall[1]));
                        rocket.Location = new Point(Convert.ToInt32(bufferBall[2]), Convert.ToInt32(bufferBall[3]));
                    };
                    if (InvokeRequired)
                        Invoke(act);
                    else
                        act();
                }
                catch (Exception)
                {
                }
                try
                {
                    //отправка позиции ракетки игрока 2
                    string rocket2Position = $"{rocket2.Location.X} {rocket2.Location.Y}";
                    byte[] rocket2Pos = UTF8Encoding.UTF8.GetBytes(rocket2Position);
                    server.udpServer.Send(rocket2Pos, rocket2Pos.Length, server.remoteEP);
                }
                catch (Exception)
                {
                }
                //if (ball.Top == playground.Top)
                //{
                //    //speed_top = -speed_top;
                //    pointFirst++;
                //}
                //if (ball.Bottom == playground.Bottom)
                //{
                //    pointSecond++;
                //}
                //if (pointFirst == 3)
                //{
                    
                //    dialogResult = MessageBox.Show("Start again?", "YOU WON!", MessageBoxButtons.YesNo);
                //    StartAgainEnemy(dialogResult);
                //    break;
                //}
                //if (pointSecond == 3)
                //{
                    
                //    dialogResult = MessageBox.Show("Start again?", "YOU LOSE!", MessageBoxButtons.YesNo);
                //    StartAgainEnemy(dialogResult);
                //    break;
                //}
            }    
        }
        private void StartAgainEnemy(DialogResult won)
        {           
            var StartAgainBuff = server.udpServer.Receive(ref server.remoteEP);
            string StartAgainBuffResult = Encoding.UTF8.GetString(StartAgainBuff);
            string[] bufferStart = StartAgainBuffResult.Split(' ');
            if (won == DialogResult.Yes)
            {
                string StartagainYES = $"YES";
                byte[] YES = UTF8Encoding.UTF8.GetBytes(StartagainYES);
                server.udpServer.SendAsync(YES, YES.Length, server.remoteEP);
                if (bufferStart[0] == "YES")
                {
                    label_scorefirst.Text = "";
                    label_scoreSec.Text = "";
                    player2.Enabled = true;

                }
                else
                {
                    MessageBox.Show("SERVER DISCONECT!");
                    this.Close();
                    server.udpServer.Close();
                }
            }
            else if (won == DialogResult.No)
            {
                string StartagainNO = $"NO";
                byte[] NO = UTF8Encoding.UTF8.GetBytes(StartagainNO);
                server.udpServer.SendAsync(NO, NO.Length, server.remoteEP);
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            AddBonus();
        }
    }
}
