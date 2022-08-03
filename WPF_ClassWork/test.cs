using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_ClassWork
{
   public class Contact:INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string company;
        private string number;
        private string email;

        public string FirstName
        {
            get => firstName;
            set
            {
                SetChanged(ref firstName, value, nameof(FirstName));
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                SetChanged(ref lastName, value, nameof(LastName));
            }
        }
        public string Company
        {
            get => company;
            set
            {
                SetChanged(ref company, value, nameof(Company));
            }
        }
        public string Number
        {
            get => number;
            set
            {
                SetChanged(ref number, value, nameof(Number));
            }
        }
        public string Email
        {
            get => email;
            set
            {
                SetChanged(ref email, value, nameof(Email));
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
