using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace App_Meditation
{
    public static class ValidatorExtensions
    {
        public static bool IsValidEmailAddress(this string s)
        {
            Regex RegexEmail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return RegexEmail.IsMatch(s);
        }
        public static bool IsValidNUmber(this string s)
        {
            Regex RegexNumber = new Regex("^\\+?[1-9][0-9]{11,14}$");
            return RegexNumber.IsMatch(s);
        }
        public static bool IsValidLogin(this string s)
        {
            Regex RegexNumber = new Regex(@"^[a-zA-Z0-9]+$");
            return RegexNumber.IsMatch(s);
        }

    }
    public partial class MainWindow : Window
    {
        string fileName = ".txt" ;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, RoutedEventArgs e)
        {
            string strUserLogin = "";
            string strUserPassword = "";
            string strUserPhone = "";

            if (!File.Exists(txbLogLogin.Text + fileName))
            {
                MessageBox.Show("неправильный пароль или логин!");
            }
            else
            {
                StreamReader sr = new StreamReader(txbLogLogin.Text + fileName);

                while (!sr.EndOfStream)
                {
                    strUserLogin = sr.ReadLine();
                    strUserPassword = sr.ReadLine();
                    strUserPhone = sr.ReadLine();
                }
                sr.Close();
                if (strUserLogin == txbLogLogin.Text && strUserPassword == txbLogPass.Password)
                {
                    MainMeditation main = new MainMeditation();

                    main.Show();
                    this.Close();
                }
            }
        }
        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            
            if (!(txbRegLogin.Text == ""  && txbRegPhone.Text == ""))
            {
                if (File.Exists(txbRegLogin.Text + fileName))
                {
                    MessageBox.Show("логин занят!");
                }
                StreamWriter sw = new StreamWriter(txbRegLogin.Text+fileName);
                sw.WriteLine(txbRegLogin.Text);
                sw.WriteLine(txbRegPass.Password);
                sw.WriteLine(txbRegPhone.Text);
                sw.Close();
                MessageBox.Show("Вы Зарегистрировались!");
                tbcMain.SelectedValue = tbcLogin;
            }
            else
            {
                
            }
        }

        private void txbRegPhone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidatorExtensions.IsValidNUmber(txbRegPhone.Text))
            {
                ValidRegPhone.Text = "";
            }
            else
            {
                ValidRegPhone.Text = "Введите номер по шаблону +380932332323 !";
            }
        }

        private void txbLogLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (txbLogLogin.Text == "")
            {
                ValidLogLogin.Text = "Поле не может быть пустым!";
            }
            else
            {
                ValidLogLogin.Text = "";
            }
        }

        private void txbRegPass_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbRegPass.Password == "")
            {
                ValidRegPass.Text = "Поле не может быть пустым!";
            }
            else
            {
                ValidRegPass.Text = "";
            }
        }

        private void txbRegLogin_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (ValidatorExtensions.IsValidLogin(txbRegLogin.Text))
            {
                ValidRegLogin.Text = "";
            }
            else
            {
                ValidRegLogin.Text = "Только цифры и буквы и не может быть пустым";
            }
        }
    }
}
