using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAS_OIL
{
    public partial class Form1 : Form
    {
        //double hotDog;
        //double Gambureger;
        //double PatatoFree;
        //double CocaCola;

        double hotDogSum;
        double GamburgerSum;
        double PatatoFreeSum;
        double CocaColaSum;

        double allSum;

        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        //public List<double> cafePrice = new List<double>();
        public Form1()
        {          
            InitializeComponent();
            //cafePrice.Add(hotDog = 6.15);
            //cafePrice.Add(Gambureger = 5.40);
            //cafePrice.Add(PatatoFree = 7.20);
            //cafePrice.Add(CocaCola = 4.40);
            
            List<Oils> oils = new List<Oils>();

            oils.Add(new Oils() { price = 51.56, Name ="A-95 Премиум" });
            oils.Add(new Oils() { price = 50.77, Name ="A-95" });
            oils.Add(new Oils() { price = 51.50, Name ="A-92" });
            oils.Add(new Oils() { price = 42.50, Name ="ГАЗ" });
            OilBox.DataSource = oils;
            OilBox.DisplayMember = "Name";
            HotDogPrice.Text = Convert.ToString(6.17);
            GamburgerPrice.Text = Convert.ToString(6.15);
            PatatoFreePrice.Text = Convert.ToString(6);
            CocaColaPrice.Text = Convert.ToString(5);
            HotDogPrice.ReadOnly = true;
            GamburgerPrice.ReadOnly = true;
            PatatoFreePrice.ReadOnly = true;
            CocaColaPrice.ReadOnly = true;
            AmountHotDogs.ReadOnly = true;
            AmountGamburger.ReadOnly = true;
            AmountPatatoFree.ReadOnly = true;
            AmountCocaCola.ReadOnly = true;
        }
        private void anyButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        public double sum()
        {
            allSum = hotDogSum + PatatoFreeSum + GamburgerSum + CocaColaSum;
            return allSum;
        }

        private void OilBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Oils oils1 = OilBox.SelectedItem as Oils;
          
            OilPrice.Text= Convert.ToString(oils1.price);
        }

        private void amountLitr_CheckedChanged(object sender, EventArgs e)
        {
            // тут непонтяно работает amounCash.checked , не знаю что с ним
            if (amountLitr.Checked)
            {
                Sums.ReadOnly = true;
                Litrs.ReadOnly = false;
            }

            if (amountCash.Checked)
            {               
                Litrs.ReadOnly = true;
                Sums.ReadOnly = false;
            }
        }

        private void ChoiceLiter_Enter(object sender, EventArgs e)
        {

        }

        private void Litrs_TextChanged(object sender, EventArgs e)
        {
            Oils oils1 = OilBox.SelectedItem as Oils;
            if (!String.IsNullOrEmpty(Litrs.Text))
            {
                double a = (oils1.price) * Convert.ToDouble(Litrs.Text);
                OilFullPrice.Text = Convert.ToString(a);
            }
            else
            {
                OilFullPrice.Text = "";
            }   
        }


        private void HotDogPrice_TextChanged(object sender, EventArgs e)
        {
            //cafePrice.RemoveAt(0);
            //cafePrice.Insert(0, Convert.ToDouble(HotDogPrice.Text));
            ////cafePrice[0] = Convert.ToDouble(HotDogPrice.Text);
            //HotDogPrice.Text = cafePrice[0].ToString();
        }
        private void Sums_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Sums.Text))
            {
                double a = Convert.ToDouble(Sums.Text);
                OilFullPrice.Text = Convert.ToString(a);
            }
            else
            {
                OilFullPrice.Text = "";
            }
        }

        private void Sums_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void Litrs_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

       
        private void AmountHotDogs_TextChanged(object sender, EventArgs e)
        {         
            if (!String.IsNullOrEmpty(AmountHotDogs.Text))
            {
                hotDogSum = Convert.ToDouble(AmountHotDogs.Text) * Convert.ToDouble(HotDogPrice.Text);
          
                CafeFullPrice.Text = Convert.ToString(sum());              
            }
            else
            {
                CafeFullPrice.Text = Convert.ToString(sum() - hotDogSum);
            }
           
        }

        private void AmountGamburger_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AmountGamburger.Text))
            {
                GamburgerSum = Convert.ToDouble(AmountGamburger.Text) * Convert.ToDouble(GamburgerPrice.Text);
            
                CafeFullPrice.Text = Convert.ToString(sum());
            }
            else
            {
                CafeFullPrice.Text = Convert.ToString(sum() - GamburgerSum);
            }
            
        }
      
        private void AmountPatatoFree_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AmountPatatoFree.Text))
            {
                PatatoFreeSum = Convert.ToDouble(AmountPatatoFree.Text) * Convert.ToDouble(PatatoFreePrice.Text);              
                CafeFullPrice.Text = Convert.ToString(sum());
            }
            else
            {
                CafeFullPrice.Text = Convert.ToString(sum() - PatatoFreeSum);
            }
            
        }
        
        private void AmountCocaCola_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(AmountCocaCola.Text))
            {
                CocaColaSum = Convert.ToDouble(AmountCocaCola.Text) * Convert.ToDouble(CocaColaPrice.Text);                
                CafeFullPrice.Text = Convert.ToString(sum());
            }  
            else
            {
                CafeFullPrice.Text = Convert.ToString(sum() - CocaColaSum);
            }

        }
        private void checkBox1_HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1_HotDog.Checked) { AmountHotDogs.ReadOnly = false; }
            else { AmountHotDogs.ReadOnly = true; AmountHotDogs.Text = ""; CafeFullPrice.Text = Convert.ToString(sum() - hotDogSum); }
           
        }

        private void checkBox2_Gamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2_Gamburger.Checked) { AmountGamburger.ReadOnly = false; }
            else { AmountGamburger.ReadOnly = true; AmountGamburger.Text = ""; CafeFullPrice.Text = Convert.ToString(sum() - GamburgerSum); }
       
        }

        private void checkBox3_PatatoFree_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3_PatatoFree.Checked) { AmountPatatoFree.ReadOnly = false; }
            else { AmountPatatoFree.ReadOnly = true; AmountPatatoFree.Text = ""; CafeFullPrice.Text = Convert.ToString(sum() - PatatoFreeSum); }
          
        }

        private void checkBox4_CocaCola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4_CocaCola.Checked) { AmountCocaCola.ReadOnly = false; }
            else { AmountCocaCola.ReadOnly = true; AmountCocaCola.Text = ""; CafeFullPrice.Text = Convert.ToString(sum() - CocaColaSum);}

        }

        private void AmountHotDogs_KeyPress(object sender, KeyPressEventArgs e)
        {
            anyButton_KeyPress(sender, e);
        }

        private void AmountGamburger_KeyPress(object sender, KeyPressEventArgs e)
        {
            anyButton_KeyPress(sender, e);
        }

        private void AmountPatatoFree_KeyPress(object sender, KeyPressEventArgs e)
        {
            anyButton_KeyPress(sender,e);
        }

        private void AmountCocaCola_KeyPress(object sender, KeyPressEventArgs e)
        {
            anyButton_KeyPress(sender, e);
        }
        private static void TimerEventProcessor(Object myObject,EventArgs myEventArgs)
        {
            myTimer.Stop();
            if (MessageBox.Show("Очистить", "Стирка)",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myTimer.Enabled = false;
                Application.Restart();
            }
            else
            {
                myTimer.Start();
            }
        }
        double sums;
        double CloseDaySums;
        private void button1_allsum_Click(object sender, EventArgs e)
        {
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            sums = sum() + Convert.ToDouble(OilFullPrice.Text);
            label3_allsum.Text = Convert.ToString(sums);
            myTimer.Interval = 10000;
            myTimer.Start();
            CloseDaySums = CloseDaySums + sums;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string allDaySums;
            allDaySums = Convert.ToString(CloseDaySums);
            MessageBox.Show(allDaySums, "Конец дня", MessageBoxButtons.OK);

        }

        private void OilFullPrice_Click(object sender, EventArgs e)
        {

        }

        private void AdminONOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (AdminONOFF.Checked)
            {
                HotDogPrice.ReadOnly = false;
                GamburgerPrice.ReadOnly = false;
                PatatoFreePrice.ReadOnly = false;
                CocaColaPrice.ReadOnly = false;
            }
            else
            {
                HotDogPrice.ReadOnly = true;
                GamburgerPrice.ReadOnly = true;
                PatatoFreePrice.ReadOnly = true;
                CocaColaPrice.ReadOnly = true;
            }
        }
    }
}
