using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EKZ_System_1
{
    public partial class FormCompleted : Form
    {
        public FormCompleted()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // no resize формы
            listBox1.Items.AddRange(File.ReadAllLines(@"C:\EkzTempFiles\ошибки.txt", Encoding.UTF8)); 
            listBox2.Items.AddRange(File.ReadAllLines(@"C:\EkzTempFiles\отчет.txt", Encoding.UTF8));
        }

        private void lbl_pathToFolder_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"C:\EkzTempFiles"); // открытие папки с репортом
        }
    }
}
