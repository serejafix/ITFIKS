using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Forms;
namespace DZ_WPF_TextEditor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_save_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button)
            {
                System.Windows.Forms.SaveFileDialog saveFile = new System.Windows.Forms.SaveFileDialog();
                saveFile.Title = "Сохранение файла";
                saveFile.Filter = "TextFiles (*.txt)|*.txt||*";

                if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamWriter stream = new StreamWriter(File.Create(saveFile.FileName));
                    stream.Write(MainTextBox.Text);
                    stream.Dispose();
                }

            }
        }

        public string filename = "";

        private void Button_open_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.Button)
            {
                System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();
                fileDialog.DefaultExt = ".txt";
                fileDialog.Title = "Открытие файла";
                fileDialog.Filter = "TextFiles (*.txt)|*.txt||*";
                if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    StreamReader stream = File.OpenText(fileDialog.FileName);
                    MainTextBox.Text = stream.ReadToEnd();
                    stream.Close();
                }
            }

        }

        private void Button_Copy_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Copy();
        }

        private void Button_Cut_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Cut();
        }

        private void Button_insert_Click(object sender, RoutedEventArgs e)
        { 
            MainTextBox.Paste();
        }
    }
}
