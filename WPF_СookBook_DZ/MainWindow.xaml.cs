using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace WPF_СookBook_DZ
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public ObservableCollection<Recepts> recepts;

        private const string fileName = "Recepts.xml";

        public MainWindow()
        {
          
            InitializeComponent();
            recepts = new ObservableCollection<Recepts>();
            this.LstRecept.ItemsSource = recepts;
            LoadList();
        }
        private void SaveList()
        {
            List<Recepts> saveList = new List<Recepts>();

            foreach (var rec in recepts)
            {
                saveList.Add(rec);
            }

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Recepts>));
                xmlSerializer.Serialize(stream, saveList);
            }

        }
        private bool LoadList()
        {
            if (!File.Exists(fileName))
                return false;
            try
            {
                XmlSerializer x = new XmlSerializer(typeof(List<Recepts>), new Type[] { typeof(Recepts) });
                TextReader reader = new StreamReader(fileName);
                List<Recepts> rList = x.Deserialize(reader) as List<Recepts>;
                foreach (Recepts recept in rList)
                {
                    recepts.Add(recept);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void btAddNew_Click(object sender, RoutedEventArgs e)
        {
            NewRecept newRecept = new NewRecept(recepts);
            newRecept.Show();
        }
        private void bttDelete_Click(object sender, RoutedEventArgs e)
        {
            if (LstRecept.SelectedItem is Recepts)
            {
                recepts.Remove(LstRecept.SelectedItem as Recepts);
            }
        }

        private void btAddSaveAndExit_Click(object sender, RoutedEventArgs e)
        {
            SaveList();
        }
    }
}
