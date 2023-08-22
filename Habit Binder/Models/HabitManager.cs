using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class HabitManager
    {
        private readonly List<Habit> _habits;
        public HabitManager()
        {
            _habits = new List<Habit>();
        }
        
        public List<Habit> GetAllHabits()
        {
            return _habits;
        }
        public void AddHabit(Habit habit)
        {
            _habits.Add(habit);
        }
    }
}
