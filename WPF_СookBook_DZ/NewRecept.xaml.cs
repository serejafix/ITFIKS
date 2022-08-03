using Microsoft.Win32;
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
using System.Windows.Forms;

namespace WPF_СookBook_DZ
{
    /// <summary>
    /// Логика взаимодействия для NewRecept.xaml
    /// </summary>
    public partial class NewRecept : Window
    {

        private Recepts receptsNew;
        private ObservableCollection<Recepts> recepts1;
        public NewRecept(ObservableCollection<Recepts> recepts)
        {
            this.receptsNew = new Recepts();
            this.recepts1 = recepts;
            InitializeComponent();
            LstIngr.ItemsSource = receptsNew.lstIngr;
            LstIngr.DisplayMemberPath = "Name";
            lstIngrStep.ItemsSource = receptsNew.lstIngredientsSteps;
            lstIngrStep.DisplayMemberPath = "";
            btnSaveAll.IsEnabled = false;
    
        }

        private bool SaveChek()
        {
            if (receptsNew.lstIngr.Count != 0 && receptsNew.lstIngredientsSteps.Count != 0 && edName.Text != "" && edCookingTime.Text != "" &&edServingsCount.Text != "")
            {
                btnSaveAll.IsEnabled = true;
            }
            return true;
        }
        private void loadPicture()
        {

            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();

            openFileDialog.Title = "Добавление фото";
            openFileDialog.Filter = "Изображения JPEG(*.jpeg)|*.jpeg|Изображения BMP(*.bmp)|*.bmp|Изображения PNG(*.png)|*.png||";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string picturePath = openFileDialog.FileName;
                receptsNew.PicturePath = picturePath;
            }
            SaveChek();
        }

            
        private void btnAddNewIngr_Click(object sender, RoutedEventArgs e)
        {

            receptsNew.lstIngr.Add(new Ingredients() { Name = edNameIngr.Text, Units = edUnits.Text, Count = Convert.ToInt32(edCount.Text)});
            SaveChek();
        }
        private void btnAddNewStep_Click(object sender, RoutedEventArgs e)
        {
            receptsNew.lstIngredientsSteps.Add(tbxStepsIngr.Text);
            SaveChek();
        }
        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
                receptsNew.Name = edName.Text;
                receptsNew.CookingTime = edCookingTime.Text;
                receptsNew.ServingsCount = Convert.ToInt32(edServingsCount.Text);
                recepts1.Add(receptsNew);
                receptsNew = null;

                this.Close();
        }

        private void btnLoadImage_Click(object sender, RoutedEventArgs e)
        {
            loadPicture();
        }

        private void btnDeleteNewIngrStep_Click(object sender, RoutedEventArgs e)
        {
            if (lstIngrStep.SelectedItem is string)
            {
                receptsNew.lstIngredientsSteps.Remove(lstIngrStep.SelectedItem as string);
                tbxStepsIngr.Text = "";
            }           
        }

        private void btnDeleteNewIngr_Click(object sender, RoutedEventArgs e)
        {
            if (LstIngr.SelectedItem is Ingredients)
            {
                receptsNew.lstIngr.Remove(LstIngr.SelectedItem as Ingredients);
                edNameIngr.Text = "";
                edUnits.Text = "";
                edCount.Text = "";
            }           
        }
    }
}
