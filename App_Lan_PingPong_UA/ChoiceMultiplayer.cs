using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void button_BacktoMainMenu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainMenu menu = new MainMenu();
            menu.ShowDialog();
            this.Close();
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            Game newGame = new Game(true);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }

        private void button__Click(object sender, EventArgs e)
        {
            Game newGame = new Game(false, textBox_EnterIP.Text);
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
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
            if (string.IsNullOrEmpty(textBox_EnterName.Text))
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
