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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChoiceMultiplayer multiplayerMenu = new ChoiceMultiplayer();
            multiplayerMenu.ShowDialog();
            this.Close();
        }
        private void Button_SinglePlayer_Click(object sender, EventArgs e)
        {
            SinglPlayer newGame = new SinglPlayer();
            Visible = false;
            if (!newGame.IsDisposed)
                newGame.ShowDialog();
            Visible = true;
        }
    }
}
