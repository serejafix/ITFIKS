using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WPF_ClassWork
{
    /// <summary>
    /// Логика взаимодействия для WindowNewContact.xaml
    /// </summary>
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
        
    }
    public partial class WindowNewContact : Window
    {
        private bool result = true;
        private ObservableCollection<Contact> contact;
        private const string fileName = "Contacts.xml";
        public WindowNewContact(ObservableCollection<Contact> contacts)
        {

            this.contact = contacts;
            
            InitializeComponent();
            edFirstNameNew.Focus();
        }

        private void btAddNew_Click(object sender, RoutedEventArgs e)
        {
            
            if (edFirstNameNew.Text == "" )
            {

            }
            else
            {
                contact.Add(new Contact() { FirstName = edFirstNameNew.Text, LastName = edLastNameNew.Text, Company = edCompanyNew.Text, Email = edEmailNew.Text, Number = edNumberNew.Text });
                //SaveList();
            }

        }
        private void btcencelNew_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void edFirstNameNew_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void edLastNameNew_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void edCompanyNew_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void edEmailNew_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(ValidatorExtensions.IsValidEmailAddress(edEmailNew.Text))         
            {
                btAddNew.IsEnabled = true;
            }
            else
            {
                btAddNew.IsEnabled = false;
            }
        }

        private void edNumberNew_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ValidatorExtensions.IsValidNUmber(edNumberNew.Text))
            {
                btAddNew.IsEnabled = true;
            }
            else
            {
                btAddNew.IsEnabled = false;
            }
        }
    }
}
