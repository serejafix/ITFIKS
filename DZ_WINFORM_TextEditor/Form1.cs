using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WINFORM_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Color_Sintaksis(string text, Color color)
        {
            int position_save = TextBox.SelectionStart; 

            int i = 0;

            while (i <= TextBox.Text.Length - text.Length)
            {
                i = TextBox.Text.IndexOf(text, i);
                if (i < 0) break;
                TextBox.SelectionStart = i;
                TextBox.SelectionLength = text.Length;
                TextBox.SelectionColor = color;
                i += text.Length;
                TextBox.SelectionStart = position_save; 
                TextBox.SelectionColor = Color.Black;
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Color_Sintaksis("привет", Color.Red);
        }

        private void FileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string fileText = System.IO.File.ReadAllText(filename);
            TextBox.Clear();
            TextBox.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            System.IO.File.WriteAllText(filename, TextBox.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
