using Habit_Binder_MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Habit_Binder.ViewModels
{
    public class HabitManagerViewModel
    {
        public ObservableCollection<TwoMinuteRule> TwoMinuteRules;

        public ICommand AddTwoMinuteRuleCommand;
        public HabitManagerViewModel() 
        {
            this.AddTwoMinuteRuleCommand = new RelayCommand(AddTwoMinuteRule);
            TwoMinuteRules = new ObservableCollection<TwoMinuteRule>();
        }

        void AddTwoMinuteRule()
        {
            TwoMinuteRules.Add(new TwoMinuteRule(DateOnly.FromDateTime(DateTime.Now), "Test", 2));
        }

    }
}
