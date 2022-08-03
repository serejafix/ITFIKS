using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace WPF_СookBook_DZ
{
   public class Ingredients : INotifyPropertyChanged
    {
        private string _Name;
        private string _Units;
        private int _Count;

        public string Name
        {
            get => _Name;
            set
            {
                SetChanged(ref _Name, value, nameof(Name));
            }
        }
        public string Units
        {
            get => _Units;
            set
            {
                SetChanged(ref _Units, value, nameof(Name));
            }
        }
        public int Count
        {
            get => _Count;
            set
            {
                SetChanged(ref _Count, value, nameof(Name));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void SetChanged<T>(ref T field, T value, string propertyName)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            }
        }
    }
}
