using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AltoHttp; // использовал интересный Nuget!
namespace Http_DownloadFile
{
    public partial class Form1 : Form
    {
        HttpDownloader httpDownloader;// использовал интересный Nuget!
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label_exeption.Enabled = false;
            label_exeption.Visible = false;
        }

        private void textBox_InputUrl_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_InputUrl.Text))
            {
                button_Download.Enabled = false;
            }
            else
            {
                button_Download.Enabled = true;
            }
        }

        private void button_pause_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Pause();
        }

        private void button_Download_Click(object sender, EventArgs e)
        {
            label_status.Text = "";
            label_exeption.Enabled = false;
            label_exeption.Visible = false;
            try
            {
                httpDownloader = new HttpDownloader(textBox_InputUrl.Text, $"{Application.StartupPath}\\{Path.GetFileName(textBox_InputUrl.Text)}"); // скачивание в папку проекта
                httpDownloader.DownloadCompleted += HttpDownloader_DownloadCompleted;
                httpDownloader.Start();
            }
            catch (Exception ex)
            {
                label_exeption.Enabled = true;
                label_exeption.Visible = true;
                label_exeption.Text = ex.Message;
            }    
        }

        private void HttpDownloader_DownloadCompleted(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                label_status.Text = "Finish!";                
            });
        }

        private void button_resume_Click(object sender, EventArgs e)
        {
            if (httpDownloader != null)
                httpDownloader.Resume();
        }
    }
}
