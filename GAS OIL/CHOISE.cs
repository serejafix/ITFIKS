using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAS_OIL
{
    public partial class CHOISE : Form
    {
        public CHOISE()
        {
            InitializeComponent();
        }

        private void CHOISE_Load(object sender, EventArgs e)
        {

        }

        private void KASSIR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 formKassir = new Form1();
            formKassir.ShowDialog();
            this.Show();

        }

        private void Director_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form1 Manager = new Form1();
            Manager.ShowDialog();

            this.Show();
        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
