using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DZ_WPF_1
{
    /// <summary>
    /// Логика взаимодействия для calculator.xaml
    /// </summary>
    public partial class calculator : Window
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            LastEx.Text = example.Text;
            example.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void С_Click(object sender, RoutedEventArgs e)
        {
            example.Text = "";
            LastEx.Text = "";

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 7;
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 4;
        }

        private void tchk_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + ".";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 1;
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 8;
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 5;
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 2;
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 0;
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 3;
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 6;
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + 9;
        }

        private void multiplication_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + "*";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + "/";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + "-";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + "+";
        }

        private void more_Click(object sender, RoutedEventArgs e)
        {
            example.Text = example.Text + "<";
        }
        public static double Evaluate(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            
            example.Text = Evaluate(example.Text).ToString();
        }
    }
}
