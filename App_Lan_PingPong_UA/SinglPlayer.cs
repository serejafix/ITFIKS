using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Lan_PingPong_UA
{
    public partial class SinglPlayer : Form
    {
        public int speed_top = 4; // скорость мяча
        public int speed_left = 4; // скорость мяча
        public int point = 0; // количество ударов ракеткой
        Random r;
        Label lblBonus;
        public SinglPlayer()
        {
            InitializeComponent();
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            rocket.Top = playground.Bottom - (playground.Bottom / 10);
            timer_Singplayer.Enabled = false;
            timer_Singplayer.Interval = 1;
            this.KeyPreview = true;
            label_Escape.Top = playground.Top;
            label_Score.Text = "Score:" + point.ToString();
            lblBonus = new Label();

            Timer_AddBonus.Enabled = false;
            _ = StartAsync();
        }

        private void SinglPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_top = 4;
                speed_left = 4;
                point = 0;
                string buffer = label_Score.Text.Remove(label_Score.Text.Length - 1) + point.ToString();
                label_Score.Text = buffer;
                timer_Singplayer.Enabled = true;
                playground.BackColor = Color.White;
            }
        }

        private void AddBonus()
        {
            Random random = new Random();
            lblBonus.Text = "BONUS";
            lblBonus.Location = new Point(random.Next(10, 500), random.Next(10, 300));
            lblBonus.ForeColor = Color.Red;
            this.Controls.Add(lblBonus);
        }
        private async Task StartAsync() => await Task.Run(SingleGame);
        private void SingleGame()
        {
            while (true)
            {
                // привязка курсора к центру ракетки
                rocket.Left = Cursor.Position.X - (rocket.Width / 2);

                ball.Left += speed_left;
                ball.Top += speed_top;

                if (ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
                {
                    speed_top += 2;
                    speed_left += 2;
                    speed_top = -speed_top;
                    point += 1;
                    if (point >= 10)
                    {
                        string buf = label_Score.Text.Remove(label_Score.Text.Length - 2) + point.ToString();
                        label_Score.Text = buf;
                    }
                    else
                    {
                        string buffer = label_Score.Text.Remove(label_Score.Text.Length - 1) + point.ToString();
                        label_Score.Text = buffer;
                    }

                    r = new Random();
                    playground.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255)); // смена фото при косании с ракеткой
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
                    timer_Singplayer.Enabled = false;
                    ball.Location = new Point(392, 155);
                    timer_Singplayer.Enabled = true;
                }

                if (ball.Top == lblBonus.Bottom && ball.Bottom == lblBonus.Top)
                {
                    rocket.Dock = DockStyle.Bottom;
                    this.Controls.Remove(lblBonus);
                }

                if (rocket.Width == 784 && ball.Bottom >= rocket.Top && ball.Bottom <= rocket.Bottom && ball.Left >= rocket.Left && ball.Right <= rocket.Right)
                {
                    rocket.Width = 167;
                }
                Thread.Sleep(10);
            } 
        }

    
        private void Timer_AddBonus_Tick(object sender, EventArgs e)
        {
            AddBonus();
        }
    }
}
