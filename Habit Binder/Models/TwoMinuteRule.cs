using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class TwoMinuteRule
    {
        private DateOnly _date { get; }
        private string _ruleDescription { get; }
        private int _addedTimeInMinutes { get; }
        public TwoMinuteRule(DateOnly date, string ruleDescription, int addedTimeInMinutes)
        {
            _date = date;
            _ruleDescription = ruleDescription;
            _addedTimeInMinutes = addedTimeInMinutes;
        }
    }
}
