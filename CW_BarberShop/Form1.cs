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

namespace CW_BarberShop
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public DataTable dt;
        public SqlCommand command;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-639J3PH;Initial Catalog=BarberShop;Integrated Security=True;Pooling=False");
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                labelConnection.Text = "Вы уже подключены!";
            }
            else
            {    
                connection.Open();
                labelConnection.Text = "Подключение установлено";
            }

        }

        private void btn_disconect_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                dataGridView1.DataSource = null;
                labelConnection.Text = "Подключение закрыто";
            }
            else
            {
                labelConnection.Text = "Вы не подключены!";
            }
        }

        private void btn_AllBarbers_Click(object sender, EventArgs e)
        {
            string sqlAllBarbers = "exec AllBarberProcedure";

            command = new SqlCommand(sqlAllBarbers, connection);
            command.CommandType = CommandType.StoredProcedure;
            var dataAdapter = new SqlDataAdapter(sqlAllBarbers, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;

        }
    }
}
