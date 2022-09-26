using DZ_Api_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_Api1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_Tusk1_Click(object sender, EventArgs e)
        {
            ApiFunc.MessageBox(IntPtr.Zero, "Hello", "1", 0);
            ApiFunc.MessageBox(IntPtr.Zero, "I am ", "2", 0);
            ApiFunc.MessageBox(IntPtr.Zero, "Fiks Sergey", "3", 0);
        }
        
        private void btn_Tusk2_Click(object sender, EventArgs e)
        {
            string title = "Form1";
            IntPtr hwnd = ApiFunc.FindWindowByCaption(IntPtr.Zero, title);
            if ((hwnd == IntPtr.Zero) || (hwnd == null))
            {
                MessageBox.Show("Window not found");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Закрыть Окно?","Окно выбора", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ApiFunc.SendMessage(hwnd, ApiFunc.WM_CLOSE, IntPtr.Zero, "");
                }                
            }
        }

        private void btn_tusk22_Click(object sender, EventArgs e)
        {
           
            string title = "Form1";
            string newTitle = string.Empty;
            newTitle = txb_newTitle.Text;
            IntPtr hwnd = ApiFunc.FindWindowByCaption(IntPtr.Zero, title);
            if ((hwnd == IntPtr.Zero) || (hwnd == null))
            {
                MessageBox.Show("Window not found");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Сменить заголовок?", "Окно выбора", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (newTitle == string.Empty)
                    {
                        return;
                    }
                    ApiFunc.SendMessage(hwnd, ApiFunc.WM_SETTEXT, IntPtr.Zero, newTitle);
                }
            }
        }

        private void btn_Tusk3_Click(object sender, EventArgs e)
        {
            for (uint i = 100; i <= 200; i++)
            {
               ApiFunc.Beep(i, 20);
            }
            
        }

        private void btn_Tusk32_Click(object sender, EventArgs e)
        {         
            ApiFunc.beep(ApiFunc.beepType.Asterisk);
            Thread.Sleep(1000);
            ApiFunc.beep(ApiFunc.beepType.Exclamation);
            Thread.Sleep(1000);
            ApiFunc.beep(ApiFunc.beepType.OK);
            Thread.Sleep(1000);
            ApiFunc.beep(ApiFunc.beepType.Question);
            Thread.Sleep(1000);
            ApiFunc.beep(ApiFunc.beepType.SimpleBeep);
        }

        private void btn_Form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}
