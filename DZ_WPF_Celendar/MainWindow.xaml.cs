using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace DZ_WPF_Celendar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }
    }
    public class DateTimeConvert : IMultiValueConverter
    {
        public static bool IsLeapYear(int year)
        {

            return (year % 4 == 0) && (year % 100 != 0 || year % 400 == 0);
            
        }

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
           
            string strValue = values[0].ToString() + "/" + values[1].ToString() + "/" + values[2].ToString();
            if ((values[1].ToString() == "04" || values[1].ToString() == "4") && values[0].ToString() == "31")
            {
                MessageBox.Show("Такой даты не существует");
            };
            
            DateTime resultDateTime;
            
            if (DateTime.TryParse(strValue, out resultDateTime))
            {
                if (DateTime.IsLeapYear(resultDateTime.Year) && values[0].ToString() == "29")
                {
                    MessageBox.Show("Високосный");      
                }
                else
                {
                    MessageBox.Show("Не високосный");
                }
                return resultDateTime;
            }
            return DependencyProperty.UnsetValue;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            string temp = value.ToString();
            string[] first = temp.Split(' ');
            string second = first[0];
            string[] splitdate = second.Split('.');
            return splitdate;
        }
    }
}
