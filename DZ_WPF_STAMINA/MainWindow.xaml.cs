using System;
using System.Collections.Generic;
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

namespace DZ_WPF_STAMINA
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
        bool capslock = true;

        public void KeysToUP()
        {
            this.OemOpenBrackets.Content = "{";
            this.OemCloseBrackets.Content = "}";
            this.Oem5.Content = "|";
            this.Oem3.Content = "~";
            this.D1.Content = "!";
            this.D2.Content = "@";
            this.D3.Content = "#";
            this.D4.Content = "$";
            this.D5.Content = "%";
            this.D6.Content = "^";
            this.D7.Content = "&";
            this.D8.Content = "*";
            this.D9.Content = "(";
            this.D0.Content = ")";
            this.OemMinus.Content = "_";
            this.OemPlus.Content = "+";
            this.OemSemicolon.Content = ":";
            this.OemQuotes.Content = "\"";
            this.OemComma.Content = "<";
            this.OemPeriod.Content = ">";
            this.OemQuestion.Content = "?";
            this.Back.Content = "BACKSPACE";
        }
        public void SymbolToUp()
        {
            
        }
        public void SymbolToLower()
        {

        }
        public void KeytoLower()
        {
            this.Back.Content = "backspace";
            this.OemOpenBrackets.Content = "[";
            this.OemCloseBrackets.Content = "]";
            this.Oem5.Content = "/";
            this.Oem5.Content = "|";
            this.Oem3.Content = "`";
            this.D1.Content = "1";
            this.D2.Content = "2";
            this.D3.Content = "3";
            this.D4.Content = "4";
            this.D5.Content = "5";
            this.D6.Content = "6";
            this.D7.Content = "7";
            this.D8.Content = "8";
            this.D9.Content = "9";
            this.D0.Content = "0";
            this.OemMinus.Content = "-";
            this.OemPlus.Content = "=";
            this.OemQuotes.Content = "\'";
            this.OemComma.Content = ",";
            this.OemPeriod.Content = ".";
            this.OemQuestion.Content = "/";
            this.OemSemicolon.Content = ";";
        }
        
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
           
            foreach (var item in this.Buts.Children)
            {
                if (item is WrapPanel)
                {
                    foreach (var but in (item as WrapPanel).Children)
                    {
                        if (but is Button)
                        {
                            if (e.Key.ToString() == (but as Button).Name.ToString())
                            {
                                (but as Button).Opacity = 0.5;
                                TextBox.Focusable = true;
                                Keyboard.Focus(TextBox);
                            }
                            if (e.Key == Key.Capital)
                            {
                                var isNumLockToggled = Keyboard.IsKeyToggled(Key.Capital);

                                if (isNumLockToggled)
                                {
                                    (but as Button).Content = (but as Button).Content.ToString().ToUpper();
                                }
                                else
                                {
                                    (but as Button).Content = (but as Button).Content.ToString().ToLower();
                                }                                
                            }

                            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                            {
                                KeysToUP();
                                (but as Button).Content = (but as Button).Content.ToString().ToUpper();
                            }
                        }
                    }
                }
            }
           
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            
            foreach (var item in this.Buts.Children)
            {
                if (item is WrapPanel)
                {
                    foreach (var but in (item as WrapPanel).Children)
                    {
                        if (but is Button)
                        {
                            if (e.Key.ToString() == (but as Button).Name.ToString())
                            {
                                (but as Button).Opacity = 1;
                            }
 
                            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
                            {     
                                    KeytoLower();
                                    (but as Button).Content = (but as Button).Content.ToString().ToLower(); 
                            }
                        }
                    }
                }
            }
           
        }
    }
}
