using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekz_System_2
{
    public partial class AllReports : Form
    {
        public AllReports(string path,string PathKey,string PathBanProgram,string BanWords,string PathStartProgram)
        {
            InitializeComponent();
            string text;
            char[] chars;
            if (File.Exists(path + PathKey))
            {
            using (StreamReader sr = new StreamReader(path+PathKey,true))
            {
                    text = sr.ReadToEnd();                       
                    chars = text.ToCharArray();
                    foreach (var item in chars)
                    {
                        listBox_Keys.Items.Add(item);
                    }
                    text = string.Empty;
            }
            }
            if (File.Exists(path + PathBanProgram))
            {
                using (StreamReader sr = new StreamReader(path + PathBanProgram, true))
                {                   
                    while ((text = sr.ReadLine()) != null)
                    {
                        listBox_BanPrograms.Items.Add(text);
                    }                    
                }
                text = string.Empty;
            }
            if (File.Exists(path + BanWords))
            {
                using (StreamReader sr = new StreamReader(path + BanWords, true))
                {
                    while ((text = sr.ReadLine()) != null)
                    {
                        listBoxBanWords.Items.Add(text);
                    }
                }
                text = string.Empty;
            }
            if (File.Exists(path + PathStartProgram))
            {
                using (StreamReader sr = new StreamReader(path + PathStartProgram, true))
                {
                    while ((text = sr.ReadLine()) != null)
                    {
                        listBox_StartProg.Items.Add(text);
                    }
                    text = string.Empty;
                }                
            }
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
