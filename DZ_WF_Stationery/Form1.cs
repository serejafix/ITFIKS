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
using System.Data.Common;

namespace DZ_WF_Stationery
{
    public partial class Form1 : Form
    {
        public SqlConnection connection;

        string sql = string.Empty;
        public SqlCommand command;
        public DataTable dt;
        public Form1()
        {    
            connection = new SqlConnection
            (@"Data Source=DESKTOP-639J3PH;Initial Catalog=Stationery;Integrated Security=True");
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
          
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {  
                l_connect.Text = "Вы уже подключены!";
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                connection.Open();
                l_connect.Text = "Подключение установлено";
            }

        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                dataGridView1.DataSource = null;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                l_connect.Text = "Подключение закрыто";
            }
            else
            {
                l_connect.Text = "Вы не подключены!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlAllInfo = "exec ProductsAllInfo";
            command = new SqlCommand(sqlAllInfo, connection);

            var dataAdapter = new SqlDataAdapter(sqlAllInfo, connection);
            
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "exec AllType";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "exec AllManager";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "exec MaxCount";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string sql = "exec MinConstPrice";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string sql = "exec MinCount";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string sql = "exec MaxCostPrice";
            command = new SqlCommand(sql, connection);

            var dataAdapter = new SqlDataAdapter(sql, connection);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button8_Click_1(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            command = new SqlCommand("ProductsForType", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Type", SqlDbType.NVarChar, (50)).Value = s;
            var dataAdapter = new SqlDataAdapter(command);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {

            string s = textBox1.Text;
            command = new SqlCommand("SaleForManager", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Manager", SqlDbType.NVarChar, (50)).Value = s;
            var dataAdapter = new SqlDataAdapter(command);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            command = new SqlCommand("BuyForBuyer", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Buyer", SqlDbType.NVarChar, (50)).Value = s;
            var dataAdapter = new SqlDataAdapter(command);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            command = new SqlCommand("AvgforType", connection);
            command.CommandType = CommandType.StoredProcedure;
            var dataAdapter = new SqlDataAdapter(command);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }

        private void button12_Click(object sender, EventArgs e)
        {
          
            command = new SqlCommand("LastSale", connection);
            command.CommandType = CommandType.StoredProcedure;
            var dataAdapter = new SqlDataAdapter(command);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);

            dt = new DataTable();

            dataAdapter.Fill(dt);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = dt;
        }
    }
}
