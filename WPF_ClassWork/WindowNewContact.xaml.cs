using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPF_ClassWork
{
    /// <summary>
    /// Логика взаимодействия для WindowNewContact.xaml
    /// </summary>
    public partial class WindowNewContact : Window
    {
        private ObservableCollection<Contact> contact;

        public WindowNewContact(ObservableCollection<Contact> contacts)
        {

            this.contact = contacts;

            InitializeComponent();
            edFirstName1.Focus();
        }

        private void btAddNew_Click(object sender, RoutedEventArgs e)
        {

            if (edFirstName1.Text == "" )
            {

            }
            else
            {
                contact.Add(new Contact() { FirstName = edFirstName1.Text, LastName = edLastName1.Text, Company = edCompany1.Text, Email = edEmail1.Text, Number = edNumber1.Text });
            }
        }

        private void btcencelNew_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
