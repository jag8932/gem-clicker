using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using GemClicker.ViewModels;
using GemClicker.Models;

namespace GemClicker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainPageViewModel();
            var image = new Image { Source = "Assets/dragon.png" };
        }
    }
}
