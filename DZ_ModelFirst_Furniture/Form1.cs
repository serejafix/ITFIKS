using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_ModelFirst_Furniture
{
    public partial class Form1 : Form
    {
        FurnitureDb db;
        public Form1()
        {
           
            InitializeComponent();

            db = new FurnitureDb();
           
        }
        private void txb_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txb_Fio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_InsertClients_Click(object sender, EventArgs e)
        {
            Client c = new Client()
            {
                Fio = txb_Fio.Text,
                PhoneNumber = Convert.ToDouble(txb_PhoneNumber.Text)
            };
            db.Clients.Add(c);
            db.SaveChanges();
        }

        private void btn_InsertProduct_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                Name = txb_insertName.Text,
                CostPrice = Convert.ToDouble(txb_InsertCostPrice.Text),
                Weight = Convert.ToDouble(txb_InsertWeight.Text),
                Height = Convert.ToDouble(txb_InsertHeight.Text),
                Width = Convert.ToDouble(txb_Width.Text),
                Material = txb_InsertMaterial.Text
            };
            db.Products.Add(p);
            db.SaveChanges();
        }

        private void btn_InsertProductSale_Click(object sender, EventArgs e)
        {
            ProductSale ps = new ProductSale()
            {
                Price = Convert.ToDouble(txb_InsertPrice.Text),
                DateSale = dtPicker_insertDateTime.Value,
                ClientId = (int)num_InsertClientId.Value,
                ProductId = (int)num_InsertProductId.Value
            };
            db.ProductSales.Add(ps);
            db.SaveChanges();
        }
        private void btn_Exec3_Click(object sender, EventArgs e)
        {
            var queary2 = from p in db.Products
                         from ps in db.ProductSales
                         where
                         p.Id == ps.ProductId
                         select new
                         {
                             Product = ps.Product.Name,
                             Material = ps.Product.Material
                         };
            var top5_2 = queary2.Take(3);
            dgv_Query.DataSource = null;
            dgv_Query.DataSource = top5_2.ToList();
        }

        private void btn_Exec_Click(object sender, EventArgs e)
        {
            var queary = from a in db.Clients
                         from p in db.Products
                         from ps in db.ProductSales
                         where
                         a.Id == ps.ClientId
                         && p.Id == ps.ProductId
                         orderby ps.Product.Id
                         select new
                         {
                             Client = ps.Client.Fio,
                             Product = ps.Product.Name
                         };
            var top5 = queary.Take(5);
            dgv_Query.DataSource = null;
            dgv_Query.DataSource = top5.ToList();
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {

        }
    }
}
