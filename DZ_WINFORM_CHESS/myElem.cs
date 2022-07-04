using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WINFORM_CHESS
{
    public partial class myElem : UserControl
    {
        public Color c;

        public myElem()
        {
            InitializeComponent();

        }
        public void setColor(Color color)
        {
            c = color;
        }
        private void myElem_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(c);           
        }
        private void myElem_MouseEnter(object sender, EventArgs e)
        {
            ForeColor = Color.Aquamarine;
        }

        private void myElem_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = Color.White;
            BackColor = Color.AntiqueWhite;
        }

        private void myElem_Load(object sender, EventArgs e)
        {

        }
    }
}
