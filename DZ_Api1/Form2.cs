using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Api1
{
    public partial class Form2 : Form
    {
        private static Form f;

        public Form2(Form form)
        {
            InitializeComponent();
            f = form;
        }

        private void btn_colorChange_Click(object sender, EventArgs e)
        {
            f.BackColor = Color.Blue;
        }
    }
}
