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

        private void ChoiceMultiplayer_Load(object sender, EventArgs e)
        {

        }

        private void button_BacktoMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            Visible = false;
            if (!menu.IsDisposed)
                menu.ShowDialog();
            Visible = true;
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
    }
}
