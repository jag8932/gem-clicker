using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using GemClicker.Models;
using GemClicker.Views;
using System.ComponentModel;

namespace GemClicker.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        public MainPageViewModel()
        {
            IncreaseGems = new Command(OnIncrease);
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
              Device.BeginInvokeOnMainThread(() =>
              {
                  NumOfCastles = Data.numDefenses;
                  Data.TotalGems += (Data.miningLevel * Data.miningEfficiency) * Data.autoLevel;
                  GemDisplay = Data.TotalGems;
                  Data.perSecond = (Data.miningEfficiency * Data.miningLevel) + (Data.miningLevel * Data.miningEfficiency * Data.autoLevel);
                  PerSecDisplay = Data.perSecond;

              });
                return true;
             });
            
        }

        private int gemDisplay;
        private int perSecDisplay;
        private int numOfCastles;
        private string attackDisplay;
        public ICommand IncreaseGems { get; }
        public int GemDisplay
        {
            get => gemDisplay;
            set
            {
                if (value == gemDisplay)
                    return;
                gemDisplay = value;
                OnPropertyChanged(nameof(GemDisplay));
            }
        }
        public int PerSecDisplay
        {
            get => perSecDisplay;
            set
            {
                if (value == perSecDisplay)
                    return;
                perSecDisplay = value;
                OnPropertyChanged(nameof(PerSecDisplay));
            }
        }

        public int NumOfCastles
        {
            get => numOfCastles;
            set
            {
                if (value == numOfCastles)
                    return;
                numOfCastles = value;
                OnPropertyChanged(nameof(NumOfCastles));
            }
        }

        public string AttackDisplay
        {
            get => attackDisplay;
            set
            {
                if (value == attackDisplay)
                    return;
                attackDisplay = value;
                OnPropertyChanged(nameof(AttackDisplay));
            }
        }

        public void OnIncrease()
        {
            
           
            int adder = Data.miningEfficiency * Data.miningLevel;
            Data.TotalGems += adder;
            if (Data.miningLevel > 1)
            {
                DragonAttack();
            }
            
            GemDisplay = Data.TotalGems;

        }


        // A dragon will try and steal player gems. The player must construct fortifications
        // to minimize the damage.
        public void DragonAttack()
        {
            Random rand = new Random();
            int chanceOfAttack = rand.Next(0, 100);
        
            if (chanceOfAttack < 1)
            {
                if (Data.TotalGems - Data.dragonDamage > 0)
                {
                    Data.TotalGems -= Data.dragonDamage;
                    AttackDisplay = $"Stealing {Data.dragonDamage} gems.";
                   
                } else
                {
                    Data.TotalGems = 0;
                }
            }
        }
    }
}
