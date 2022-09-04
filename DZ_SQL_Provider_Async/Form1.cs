using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;
using System.Configuration;
using System.Diagnostics;
using System.Data.OleDb;
namespace DZ_SQL_Provider_Async
{
    public partial class Form1 : Form
    {
        Stopwatch clock;
        //SqlConnection sqlconnection = null;
        DbProviderFactory factory = null;
        DbConnection connection = null;
        //SqlConnectionStringBuilder builderString;
        //DbConnectionStringBuilder DbstringBuilder;
        string providerStr = string.Empty;
        string connectionStr = string.Empty;
       
        public Form1()
        {
            InitializeComponent();
            clock = new Stopwatch();
        }

        private void btn_getFactory_Click(object sender, EventArgs e)
        {
            DataTable table = DbProviderFactories.GetFactoryClasses();
            cmb_provider.DataSource = table;
            cmb_provider.DisplayMember = "InvariantName";
            cmb_provider.ValueMember = "InvariantName";
        }

        private void cmb_provider_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            providerStr = cmb_provider.SelectedValue.ToString();

            if (string.IsNullOrEmpty(providerStr))
                return;

            connectionStr = string.Empty;
            foreach (ConnectionStringSettings item in ConfigurationManager.ConnectionStrings)
            {
                if (item.ProviderName.Equals(providerStr))
                {
                    connectionStr = item.ConnectionString;
                    break;
                }
            }

            if (string.IsNullOrEmpty(connectionStr))
                return;

            factory = DbProviderFactories.GetFactory(providerStr);

            connection = factory.CreateConnection();
            connection.ConnectionString = connectionStr;
            btnSync.Enabled = true;
        }

        private  void Connect_Click(object sender, EventArgs e)
        {
            if (Connect.Text.Equals("Connect"))
            {
                if (connection == null)
                    return;
                connection.ConnectionString = connectionStr;

                if (AsyncEnable.Checked == true)
                {
                    //string concat = connectionStr;
                    //string concatAsync = "; Asynchronous Processing=True";
                    //string AsyncTrue = concat + concatAsync;
                    //connection.ConnectionString = AsyncTrue;
                    //using (connection)
                    //{
                    //    await connection.OpenAsync();
                    //}
                }
                else
                {
                    using (connection)
                    {
                        connection.ConnectionString = connectionStr;
                        connection.Open();  
                    }
                }


                AsyncEnable.Enabled = false;
                Connect.Text = "Disconnect";

            }
            else
            {
                connection.Close();
                connection = null;
                AsyncEnable.Enabled = true;
                btnAsync.Enabled = false;
                btnSync.Enabled = false;
                Connect.Text = "Connect";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            //sync method
            clock.Start();

            DbCommand comm = connection.CreateCommand();

            comm.CommandText += textBox1.Text.ToString();
            DbDataReader reader = comm.ExecuteReader();
            bool first = true;
            DataTable table = new DataTable();

            while (reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn column = new DataColumn(reader.GetName(i));
                        table.Columns.Add(column);
                    }
                    first = false;
                }

                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            reader.Close();
            dataGridView.DataSource = table;
            btnAsync.Enabled = true;
            clock.Stop();
            lbl_Clock.Text = clock.Elapsed.TotalSeconds.ToString() + " Секунд";
            clock.Reset();
        }

        private void btnAsync_Click(object sender, EventArgs e)
        {
            clock.Start();

            btnAsync.Enabled = false;
            //SqlCommand command = new SqlCommand(textBox1.Text, sqlconnection);
            AsyncCallback callback = new AsyncCallback(GetData);
            //command.BeginExecuteReader(callback, command);
            clock.Stop();
            lbl_Clock.Text = clock.Elapsed.TotalSeconds.ToString() + " Секунд";
            clock.Reset();
        }
        private void GetData(IAsyncResult Asyncresult)
        {
            SqlCommand command = Asyncresult.AsyncState as SqlCommand;
            if (command == null)
                return;

            SqlDataReader reader = command.EndExecuteReader(Asyncresult);

            bool first = true;

            DataTable table = new DataTable();

            while (reader.Read())
            {
                if (first)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        DataColumn column = new DataColumn(reader.GetName(i));
                        table.Columns.Add(column);
                    }
                    first = false;
                }

                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader[i];
                }
                table.Rows.Add(row);
            }
            reader.Close();

            Action a = () =>
            {
                dataGridView.DataSource = table;
                btnAsync.Enabled = true;
            };
            if (this.InvokeRequired)
            {
                this.Invoke(a);
            }
            else
            {
                a();
            }
        }

        private void btn_updateSync_Click(object sender, EventArgs e)
        {
            //string sql = $"update Veg_and_Fruits set [Name] = '{txb_nameUpdate.Text}',[Type] = '{checkBox1.Checked}',[Color] = '{txb_UpdateColor.Text}',[calories] = '{txb_UpdateColories.Text}' where (Id = {num_WhereId.Value})";

            ////SqlCommand command = new SqlCommand(sql, sqlconnection);
            //int result = command.ExecuteNonQuery();
            //lbl_result.Text = $"{result} record affected";
        }

        private void btn_UpdateAsync_Click(object sender, EventArgs e)
        {
            //btnAsync.Enabled = false;
            //SqlCommand command = new SqlCommand(textBox1.Text, sqlconnection);
            //AsyncCallback callback = new AsyncCallback(getDataUpdate);
            //command.BeginExecuteReader(callback, command);
        }
        private void getDataUpdate(IAsyncResult resultUpdate)
        {
            //SqlCommand command = resultUpdate.AsyncState as SqlCommand;
            //if (command == null)
            //    return;
            //SqlDataReader reader = command.EndExecuteReader(resultUpdate);

            //string sql = $"update Veg_and_Fruits set [Name] = '{txb_nameUpdate.Text}',[Type] = '{checkBox1.Checked}',[Color] = '{txb_UpdateColor.Text}',[calories] = '{txb_UpdateColories.Text}' where (Id = {num_WhereId.Value})";
            //int result = command.ExecuteNonQuery();
            //lbl_result.Text = $"{result} record affected";
        }
    }
}
