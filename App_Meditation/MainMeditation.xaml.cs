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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace App_Meditation
{
    public partial class MainMeditation : Window
    {

        DispatcherTimer timerUtro = new DispatcherTimer();
        DispatcherTimer timerDay = new DispatcherTimer();
        DispatcherTimer timerNight = new DispatcherTimer();

        public MainMeditation()
        {
            InitializeComponent();
            Time.Text = "00:00";
            TimeDay.Text = "00:00";
            TimeNight.Text = "00:00";
            timerUtro.Tick += timer_Tick;
            timerUtro.Start();
            timerDay.Tick += timer_TickDay;
            timerDay.Start();
            timerNight.Tick += timer_TickNight;
            timerNight.Start();
        }

        private void timer_TickNight(object sender, EventArgs e)
        {
            if (mediaNight.Source != null)
            {
                if (mediaNight.NaturalDuration.HasTimeSpan)
                    TimeNight.Text = String.Format("{0} / {1}", mediaNight.Position.ToString(@"mm\:ss"), mediaNight.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                TimeNight.Text = "No file selected...";
        }

        private void timer_TickDay(object sender, EventArgs e)
        {
            if (mediaDay.Source != null)
            {
                if (mediaDay.NaturalDuration.HasTimeSpan)
                    TimeDay.Text = String.Format("{0} / {1}", mediaDay.Position.ToString(@"mm\:ss"), mediaDay.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                TimeDay.Text = "No file selected...";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (media.Source != null)
            {
                if (media.NaturalDuration.HasTimeSpan)
                    Time.Text = String.Format("{0} / {1}", media.Position.ToString(@"mm\:ss"), media.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
            }
            else
                Time.Text = "No file selected...";
        }

        private void Play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            mediaDay.Stop();
            mediaNight.Stop();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            media.Position = media.Position - TimeSpan.FromSeconds(10);
        }

        private void Forward_Click(object sender, RoutedEventArgs e)
        {
            media.Position = media.Position + TimeSpan.FromSeconds(10);
        }

        private void Pause_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            media.Stop();
        }

        private void PlayDay_Click(object sender, RoutedEventArgs e)
        {
            mediaDay.Play();
            media.Stop();
            mediaNight.Stop();
        }

        private void PauseDay_Click(object sender, RoutedEventArgs e)
        {
            mediaDay.Pause();
        }

        private void BackDay_Click(object sender, RoutedEventArgs e)
        {
            mediaDay.Position = mediaDay.Position - TimeSpan.FromSeconds(10);
        }

        private void ForwarDay_Click(object sender, RoutedEventArgs e)
        {
            mediaDay.Position = mediaDay.Position + TimeSpan.FromSeconds(10);
        }
        private void PauseDay_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mediaDay.Stop();
        }

        private void PauseNight_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            mediaNight.Stop();
        }

        private void PauseNight_Click(object sender, RoutedEventArgs e)
        {
            mediaNight.Pause();
        }

        private void PlayNight_Click(object sender, RoutedEventArgs e)
        {
            mediaNight.Play();
            media.Stop();
            mediaDay.Stop();
        }

        private void BackNight_Click(object sender, RoutedEventArgs e)
        {
            mediaNight.Position = mediaNight.Position - TimeSpan.FromSeconds(10);
        }

        private void ForwarNight_Click(object sender, RoutedEventArgs e)
        {
            mediaNight.Position = mediaNight.Position + TimeSpan.FromSeconds(10);
        }
    }

}
