using System;
using System.Windows;
using WPF_ClassWork;
using System.ComponentModel;
using System.Collections.ObjectModel;
using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WpfTutorialSamples.DataBinding
{
    public partial class DataContextSample : Window
    {
        private ObservableCollection<Contact> contacts;

        public bool bEditchange = true;

        private const string fileName = "Contacts.xml";

        public DataContextSample()
        {
            InitializeComponent();

            contacts = new ObservableCollection<Contact>();

            LstContacts.ItemsSource = contacts;

            LstContacts.DisplayMemberPath = "FirstName";

            LoadList();

        }
        private void SaveList()
        {
            List<Contact> cList = new List<Contact>(contacts);
            XmlSerializer x = new XmlSerializer(typeof(List<Contact>), new Type[] { typeof(Contact) });
            TextWriter writer = new StreamWriter(fileName);
            x.Serialize(writer, cList);
            cList.Clear();
        }
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewContact newContact = new WindowNewContact(contacts);
            newContact.Show();          
        }
        private bool LoadList()
        {
            if (!File.Exists(fileName))
                return false;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Contact>), new Type[] { typeof(Contact) });
                TextReader reader = new StreamReader(fileName);
                List<Contact> pList = x.Deserialize(reader) as List<Contact>;
                foreach (Contact contact in pList)
                {
                    contacts.Add(contact);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btEdit_Click(object sender, RoutedEventArgs e)
        {
           
            if (bEditchange)
            {
                edFirstName.IsReadOnly = false;
                edLastName.IsReadOnly = false;
                edCompany.IsReadOnly = false;
                edEmail.IsReadOnly = false;
                edNumber.IsReadOnly = false;
                bEditchange = false;
            }
            else
            {
                edFirstName.IsReadOnly = true;
                edLastName.IsReadOnly = true;
                edCompany.IsReadOnly = true;
                edEmail.IsReadOnly = true;
                edNumber.IsReadOnly = true;
                bEditchange = true;
            }
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LstContacts.SelectedItem is Contact)
            {
                contacts.Remove(LstContacts.SelectedItem as Contact);
            }
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            SaveList();
        }
    }
}