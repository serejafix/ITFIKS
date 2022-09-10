using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
 using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DZ_CodeFirst_dbSender
{
    public partial class Form1 : Form
    {
        SenderlistDb db;
        public Form1()
        {
            InitializeComponent();

            db = new SenderlistDb();            
        }

        private void btn_allClients_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = db.Clients.ToList();
        }

        private void btn_AllEmail_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = (from c in db.Clients
                                  select new { Email = c.Email }).ToList();
        }

        private void btn_ByCity_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = (from c in db.Clients
                                   where c.City == txb_SearchByCity.Text
                                   select new { FIO = c.FIO, City = c.City }).ToList();
        }

        private void btn_ByCountry_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = (from client in db.Clients
                                   join c in db.Countries on client.CountryId equals c.Id
                                   where (c.CountryName == txb_SearchByCountry.Text)
                                   select new { FIO = client.FIO, Country = c.CountryName }).ToList();
        }

        private void btn_AllDiscont_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = db.Discounts.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvTable.DataSource = null;
            dgvTable.DataSource = (from d in db.Discounts
                                   join c in db.Countries on d.CountryId equals c.Id
                                   where (c.CountryName == txb_SearchDiscontByCountry.Text)
                                   select new { ProductName = d.Pruduct, Country = c.CountryName }).ToList();
        }
    }
}
