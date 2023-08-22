using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class BadHabit : Habit
    {
        public BadHabit(string name, Identity identity) : base(name, identity) { }
    }
}
