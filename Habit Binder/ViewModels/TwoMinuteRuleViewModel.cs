using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder.ViewModels
{
    public class TwoMinuteRuleViewModel : BaseViewModel
    {
        #region Public Properties
        public DateOnly Date { get; set; } 
        public string RuleDescription { get; set; }
        public int AddedTimeInMinutes { get; set; }
        #endregion

        #region Constructor
        public TwoMinuteRuleViewModel(string ruleDescription, int addedTimeInMinutes) 
        {
            Date = DateOnly.FromDateTime(DateTime.Now);
            RuleDescription = ruleDescription;
            AddedTimeInMinutes = addedTimeInMinutes;
        }
        #endregion
    }
}
