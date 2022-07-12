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
using System.Windows.Threading;

namespace DZ_WPF_STAMINA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random;
        private DispatcherTimer timer = null;
        private int failCount = 0;
        private int timerCount = 0;
        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
            timer = new DispatcherTimer();

           timer.Tick += timer_Tick;

           timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
        }

       
        private string baseString =
            "QWERTYUIOPASDFGHJKLZXCVBNM~!@#$%^&*()_+{}|:\"<>?1234567890[],./\\`-=;'qwertyuiopasdfghjklzxcvbnm";
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
                                Keyboard.Focus(TextBoxInput);
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

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            start.IsEnabled = true;
            stop.IsEnabled = false;
            slider.IsEnabled = true;
            checkCase.IsEnabled = true;
            TextBox.Text = "";
            TextBoxInput.Text = "";
            failscount.Text = "";
            SpeedCount.Text = "";
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            stop.IsEnabled = true;
            slider.IsEnabled = false;
            @case.IsReadOnly = false;
            checkCase.IsEnabled = false;
            start.IsEnabled = false;
            TextBox.Text = "";
            TextBoxInput.Text = "";

            createString(Int32.Parse(DifficultyValue.Text), baseString, (bool)checkCase.IsChecked);

            TextBoxInput.IsReadOnly = false;
            failscount.Text = "0";
            timer.Start();
        }
        private void createString(int charNumber, string baseString, bool isCase)
        {
            string baseChars = "";

            int startIndex = (isCase) ? 0 : 47;

            // Выбрать заданное кол-во случайных символов из исходной строки, начиная с 0 индекса, если включен регистр символов,
            // и с 47 индекса, если регистр символов не включен.
            for (int i = 0; i < charNumber; i++)
            {
                baseChars += baseString[random.Next(startIndex, baseString.Length)];
            }

            // К выбранным символам добавить пробел. Добавляется здесь, а не в исходной строке, для более частого выбора
            // (т.к. находясь в исходной строке из 94 символов выпадает крайне редко).
            baseChars += " ";

            for (int i = 0; i < 70; i++)
            {
                this.TextBox.Text += baseChars[random.Next(0, baseChars.Length)];
            }
        }
        private void SliderChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int sliderValue = (int)slider.Value;
            DifficultyValue.Text = sliderValue.ToString();
        }
        void computeSpeed()
        {
            SpeedCount.Text = Math.Round((double)TextBoxInput.Text.Length / timerCount * 60).ToString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            timerCount++;
            computeSpeed();
        }
       
        private void TextBoxInput_TextChanged(object sender, TextChangedEventArgs e)
       {
          
            string check= TextBox.Text.Substring(0, TextBoxInput.Text.Length);

            // Проверить введенную строку на соответствие подстроке.
            if (TextBoxInput.Text.Equals(check))
            {
                computeSpeed();
                TextBoxInput.Foreground = new SolidColorBrush(Colors.Black);
            }
            else
            {
                failCount++;
                // При неравенстве строк цвет шрифта - красный.
                TextBoxInput.Foreground = new SolidColorBrush(Colors.SkyBlue);
                failscount.Text = failCount.ToString();
            }
            // При равенстве исходной и введенной строк завершить задание.
            if (TextBoxInput.Text.Length == TextBox.Text.Length)
            {
                timer.Stop();
                computeSpeed();
                TextBoxInput.IsReadOnly = true;
                MessageBox.Show($"Задание завершенно!\n Количество символов {this.TextBox.Text.Length}.\n Количество ошибок {this.failscount.Text}.\nДля завершения задания нажмите Stop.",
                                    "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }
    }
}
