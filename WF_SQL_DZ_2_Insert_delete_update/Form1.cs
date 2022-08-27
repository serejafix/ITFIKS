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

namespace WF_SQL_DZ_2_Insert_delete_update
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection
            (@"Data Source = DESKTOP-639J3PH;Initial Catalog=VegetablesAndFruits;Integrated Security=True");
        }
        static void CheckConnect(SqlConnection connection)
        {
            connection.Open();
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("Подключение установлено");
                connection.Close();
            }
            else
            {
                Console.WriteLine("Ошибка подключения");
            }
            connection.Close();
        }

        static void InsertTheme(SqlConnection connection)
        {
            Console.Write("Enter theme: ");
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
                return;

            string sql = $"insert into Themes values('{str}')";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void DeleteTheme(SqlConnection connection)
        {
            Console.Write("Enter delete theme id: ");
            string str = Console.ReadLine();
            int id;
            if (string.IsNullOrEmpty(str) || !int.TryParse(str, out id))
                return;

            string sql = $"delete from Themes where (Id = {id})";
            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        static void UpdateTheme(SqlConnection connection)
        {
            Console.Write("Enter update theme id: ");
            string strId = Console.ReadLine();

            Console.Write("Enter new theme name: ");
            string strName = Console.ReadLine();

            int id;
            if (string.IsNullOrEmpty(strId)
                || !int.TryParse(strId, out id)
                || string.IsNullOrEmpty(strName))
                return;

            string sql = $"update Themes set [Name] = '{strName}' where (Id = {id})";

            SqlCommand command = new SqlCommand(sql, connection);
            int result = command.ExecuteNonQuery();
            Console.WriteLine($"{result} record affected");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                label_CheckCoonect.Text = "Вы уже подключены!";
            }
            else
            {
                connection.Open();
                label_CheckCoonect.Text = "Подключение установлено";
            }  
        }

        private void btn_Close_con_Click(object sender, EventArgs e)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                label_CheckCoonect.Text = "Подключение закрыто";
            }
            else
            {
                label_CheckCoonect.Text = "Вы не подключены!";
            }
        }
    }
}
