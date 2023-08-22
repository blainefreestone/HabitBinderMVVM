using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class GoodHabit : Habit
    {
        private List<TwoMinuteRule> _twoMinuteRules = new List<TwoMinuteRule>();
        public GoodHabit(string name, Identity identity) : base(name, identity) { }
        public void AddTwoMinuteRule(TwoMinuteRule twoMinuteRule)
        {
            _twoMinuteRules.Add(twoMinuteRule);
        }
    }
}
