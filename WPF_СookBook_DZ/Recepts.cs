using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace WPF_СookBook_DZ
{

    [Serializable]
    public class Recepts:INotifyPropertyChanged
    {
        private string _Name;
        private int _ServingsCount;
        private string _CookingTime;
        private string _PicturePath;
        private ObservableCollection<Ingredients> _LstIngr;

        public Ingredients ingredients;

        private ObservableCollection<string> _LstIngredientsSteps;


        public Recepts()
        {
            this.lstIngr = new ObservableCollection<Ingredients>();
            this.lstIngredientsSteps = new ObservableCollection<string>();
        }

        public string Name
        {
            get => _Name;
            set
            {
                SetChanged(ref _Name, value, nameof(Name));
            }
        }

        public string PicturePath
        {
            get => _PicturePath;
            set
            {
                SetChanged(ref _PicturePath, value, nameof(PicturePath));
            }
        }

        public ObservableCollection<Ingredients> lstIngr
        {
            get => this._LstIngr;
            set
            {
                this.SetChanged(ref this._LstIngr, value, nameof(this.lstIngr));
            }
        }

        public ObservableCollection<string> lstIngredientsSteps
        {
            get => this._LstIngredientsSteps;
            set
            {
                this.SetChanged(ref this._LstIngredientsSteps, value, nameof(this.lstIngredientsSteps));
            } 
        }
        public int ServingsCount
        {
            get => _ServingsCount;
            set
            {
                SetChanged(ref _ServingsCount, value, nameof(ServingsCount));
            }
        }
        public string CookingTime
        {
            get => _CookingTime;
            set
            {
                SetChanged(ref _CookingTime, value, nameof(CookingTime));
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
