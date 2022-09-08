using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_Barber_DatebaseFirst
{
    public partial class Form1 : Form
    {
        BarberShopEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new BarberShopEntities();           
        }

        private void button_AllBarber_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = db.Barbers.ToList();
        }

        private void btn_FioOnly_Click(object sender, EventArgs e)
        {
            dgv_Query.DataSource = db.Barbers.Select(b => new {Fio = b.FIO }).ToList();
        }

    }
}
