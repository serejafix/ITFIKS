using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WINFORM_CHESS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void CreateMap()
        {
            
            bool check = true;
           
            for (int i = 0; i < 8; i++)
            {             
                for (int j = 0; j < 8; j++)
                {
                    myElem elem = new myElem();

                    elem.Size = new Size(50, 50);

                    elem.Location = new Point(j * 50+50, i * 50+50);

                    if (check)
                    {
                        elem.setColor(Color.White);
                        check = !check;
                    }
                    else
                    { 
                        elem.setColor(Color.Black);
                        check = !check;
                    }

                    this.Controls.Add(elem);
                }
                check = !check;
            }    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMap();            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            char abc = 'A';
            char abca = '8';
            //char ontwothree = '1';
            for (int j = 0; j < 8; j++)
            {
                Graphics g = this.CreateGraphics();
                g.DrawString(abc++.ToString(), new Font("Arial", 20), Brushes.Black, new Point(j * 50+50,0));
            }

            for (int j = 0; j < 8; j++)
            {
                Graphics g = this.CreateGraphics();
                g.DrawString(abca--.ToString(), new Font("Arial", 20), Brushes.Black, new Point(0,j*50+50));

            }
        }
    }
}
