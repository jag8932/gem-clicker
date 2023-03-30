using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using GemClicker.ViewModels;
using GemClicker.Models;

namespace GemClicker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpgradePage : ContentPage
    {
        public UpgradePage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void MiningUpgrade_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 100 && Data.TotalGems - 100 > 0 && Data.miningLevel < 2)
            {
                Data.miningLevel = 2;
                Data.TotalGems -= 100;
                MiningUpgrade.BorderWidth = 2;
                MiningUpgrade.BorderColor = Color.Black;
            }
    }

        private void MiningUpgrade2_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 400 && Data.TotalGems - 400 > 0 && Data.miningLevel < 3)
            {
                Data.miningLevel = 3;
                Data.TotalGems -= 400;
                MiningUpgrade2.BorderWidth = 2;
                MiningUpgrade2.BorderColor = Color.Black;
            }
        }

        private void MiningUpgrade3_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 4000 && Data.TotalGems - 4000 > 0 && Data.miningLevel < 4)
            {
                Data.miningLevel = 4;
                Data.TotalGems -= 4000;
                MiningUpgrade3.BorderWidth = 2;
                MiningUpgrade3.BorderColor = Color.Black;
            }
        }

        private void BuyTower_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 500 && Data.numDefenses < 50)
            {
                Data.numDefenses++;
                Data.TotalGems -= 500;
                Data.dragonDamage = 100 - (Data.numDefenses * 2);
                TowerCount.Text = Data.numDefenses.ToString();
            }
        }

        private void AutomatedMiningButton_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 600 && Data.autoLevel < 2)
            {
                Data.autoLevel = 2;
                Data.TotalGems -= 600;
                AutomatedMiningButton.BorderWidth = 2;
                AutomatedMiningButton.BorderColor = Color.Black;
            }

        }

        private void AutomatedMiningButton2_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 1200 && Data.autoLevel < 3)
            {
                Data.autoLevel = 3;
                Data.TotalGems -= 1200;
                AutomatedMiningButton.BorderWidth = 2;
                AutomatedMiningButton.BorderColor = Color.Black;
                AutomatedMiningButton2.BorderWidth = 2;
                AutomatedMiningButton2.BorderColor = Color.Black;
            }

        }

        private void AutomatedMiningButton3_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 1800 && Data.autoLevel < 4)
            {
                Data.autoLevel = 4;
                Data.TotalGems -= 1800;
                AutomatedMiningButton.BorderWidth = 2;
                AutomatedMiningButton.BorderColor = Color.Black;
                AutomatedMiningButton2.BorderWidth = 2;
                AutomatedMiningButton2.BorderColor = Color.Black;
                AutomatedMiningButton3.BorderWidth = 2;
                AutomatedMiningButton3.BorderColor = Color.Black;
            }

        }

        private void Efficiency1_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 500 )
            {
                Data.TotalGems -= 500;
                Data.miningEfficiency = 2;
                Efficiency1.BorderWidth = 2;
                Efficiency1.BorderColor = Color.Black;
            }
        }

        private void Efficiency2_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 1000)
            {
                Data.TotalGems -= 1000;
                Data.miningEfficiency = 3;
                Efficiency1.BorderWidth = 2;
                Efficiency1.BorderColor = Color.Black;
                Efficiency2.BorderWidth = 2;
                Efficiency2.BorderColor = Color.Black;
            }
        }

        private void Efficiency3_Clicked(object sender, EventArgs e)
        {
            if (Data.TotalGems >= 1500)
            {
                Data.TotalGems -= 1500;
                Data.miningEfficiency = 4;
                Efficiency1.BorderWidth = 2;
                Efficiency1.BorderColor = Color.Black;
                Efficiency2.BorderWidth = 2;
                Efficiency2.BorderColor = Color.Black;
                Efficiency3.BorderWidth = 2;
                Efficiency3.BorderColor = Color.Black;
            }
        }
    }
}