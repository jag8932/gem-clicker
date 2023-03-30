using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace GemClicker.ViewModels
{
    public class ViewModelHelper : INotifyPropertyChanged
    {
        public ViewModelHelper()
        {
         //   public string TowersDisplay = $"{Towers}";
        }
        public event PropertyChangedEventHandler PropertyChanged;

        string towers = string.Empty;
        public string Towers
        {
            get => towers;
            set
            {
                if (towers == value)
                    return;

                towers = value;
                OnPropertyChanged(nameof(Towers));
            }
        }
        
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
