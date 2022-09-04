using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Provider_Async
{
    public partial class Form1 : Form
    {
        DbConnection conn = null;
        DbProviderFactory fact = null;
        string connectionString = "";
        string providerStr = string.Empty;
        Stopwatch clock = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            cmbProviders.DisplayMember = "InvariantName";
            cmbProviders.ValueMember = "InvariantName";
        }
        void textBox1_TextChanged(object sender,EventArgs e)
        {
            if (textBox1.Text.Length > 3)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //"waitfor delay '00:00:01';"
            clock.Start();
            conn.ConnectionString = connectionString;
            await conn.OpenAsync();
            DbCommand comm = conn.CreateCommand();
            comm.CommandText +=textBox1.Text.ToString();
            DataTable table = new DataTable();
            using (DbDataReader reader = await comm.
            ExecuteReaderAsync())
            {
                int line = 0;
                do
                {
                    while (await reader.ReadAsync())
                    {
                        if (line == 0)
                        {
                            for (int i = 0; i <
                           reader.FieldCount; i++)
                            {
                                table.Columns.Add(reader.
                               GetName(i));
                            }
                            line++;
                        }
                        DataRow row = table.NewRow();
                        for (int i = 0; i < reader.
                       FieldCount; i++)
                        {
                            row[i] = await reader.
                           GetFieldValueAsync<Object>(i);
                        }
                        table.Rows.Add(row);
                    }
                } while (reader.NextResult());
            }
            clock.Stop();
            lblTime.Text = $"Time: {clock.Elapsed.TotalSeconds.ToString()} секунд";
            clock.Reset();
           
            dvg_data.DataSource = null;
            dvg_data.DataSource = table;
            conn.Close();
        }

        private void btnGetProvider_Click(object sender, EventArgs e)
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            cmbProviders.DataSource = table;
            cmbProviders.DisplayMember = "InvariantName";
            cmbProviders.ValueMember = "InvariantName";
        }

        private void cmbProviders_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;

            providerStr = cmbProviders.SelectedValue.ToString();
            if (string.IsNullOrEmpty(providerStr))
                return;
            connectionString = string.Empty;
            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.ProviderName.Equals(providerStr))
                {
                    connectionString = item.ConnectionString;
                    break;
                }
            }
            if (string.IsNullOrEmpty(connectionString))
                return;

            fact = DbProviderFactories.GetFactory(providerStr);
            conn = fact.CreateConnection();
            if (providerStr == "System.Data.SqlClient")
            {
                connectionString = connectionString + ";Asynchronous Processing=true";
            }

            conn.ConnectionString = connectionString;
            button1.Enabled = true;
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            clock.Start();
            conn.ConnectionString = connectionString;

            await conn.OpenAsync();
            
            string command = $"waitfor delay '00:00:03'; update FruitsAndVegetables set [Name] = '{textBoxName.Text}'" +
                                $",[Type] = '{checkBoxVegOrFruits.Checked}'" +
                                $",[Color] = '{textBoxColor.Text}'" +
                                $",[calories] = '{Convert.ToInt32(textBoxCalories.Text)}'" +
                                $" where (Id = {(int)numericUpDown1.Value})";
            DbCommand comm = conn.CreateCommand();
            comm.CommandText += command;
            await comm.ExecuteNonQueryAsync();
            conn.Close();

            clock.Stop();
            lblTime.Text = $"Time: {clock.Elapsed.TotalSeconds.ToString()} секунд";
            clock.Reset();

        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            clock.Start();
            conn.ConnectionString = connectionString;

            await conn.OpenAsync();

            string command = $"waitfor delay '00:00:03';" +
                        $" delete from FruitsAndVegetables where (Id = {(int)numericUpDownDelete.Value})";
            DbCommand comm = conn.CreateCommand();
            comm.CommandText += command;
            await comm.ExecuteNonQueryAsync();
            conn.Close();
            clock.Stop();
            lblTime.Text = $"Time: {clock.Elapsed.TotalSeconds.ToString()} секунд";
            clock.Reset();
        }
    }
}

