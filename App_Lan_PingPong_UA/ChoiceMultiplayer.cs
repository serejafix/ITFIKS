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
    public partial class ChoiceMultiplayer : Form
    {
        public ChoiceMultiplayer()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // не изменность окна->
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            GetIP(); // получаем IP чтобы было удобнее сказать его другому игроку)
        }
        private void GetIP() // получение ип
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    label_youripv4.Text = ip.ToString(); // присваиваем к label на форме
                }
            }
        }
        private void button_BacktoMainMenu_Click(object sender, EventArgs e) // кнопка назад в главное меню
        {
            this.Visible = false;
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            button_Admin.ForeColor = Color.Aquamarine;
            Game newGame = new Game(true);
            Visible = false;
            if (newGame != null)
            {
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
                 
        }

        private void button__Click(object sender, EventArgs e)
        {
            Game newGame = new Game(false, textBox_EnterIP.Text);
            Visible = false;
            if (newGame != null)
            {
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                Visible = true;
            }
           
        }

        private void textBox_EnterName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_EnterName.Text))
            {
                button_enterName.Enabled = false;
                button_enterName.BackColor = Color.Aquamarine;
                button_Admin.Enabled = false;
                button_enterName.BackColor = Color.Aquamarine;
            }
            else
            {
                button_enterName.Enabled = true;
                button_enterName.BackColor = Color.CornflowerBlue;
                button_Admin.Enabled = true;
                button_enterName.BackColor = Color.CornflowerBlue;
            }
        }

        private void textBox_EnterIP_TextChanged(object sender, EventArgs e)
       {
            if (string.IsNullOrEmpty(textBox_EnterIP.Text))
            {
                button_EnterIP.Enabled = false;
                button_EnterIP.BackColor = Color.Aquamarine;
            }
            else
            {
                button_EnterIP.Enabled = true;
                button_EnterIP.BackColor = Color.CornflowerBlue;
            }
        }
    }
}
