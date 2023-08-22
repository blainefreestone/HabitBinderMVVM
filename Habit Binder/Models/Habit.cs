using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class Habit
    {
        public string Name { get; }
        public Identity Identity { get; }
        public List<string> MakeItObvious { get; }
        public List<string> MakeItAttractive { get; }
        public List<string> MakeItEasy { get; }
        public List<string> MakeItSatisfying { get; }
        public List<DateOnly> DatesCompleted { get; }
        public Habit(string name, Identity identity)
        {
            Name = name;
            Identity = identity;
            MakeItObvious = new List<string>();
            MakeItAttractive = new List<string>();
            MakeItEasy = new List<string>();
            MakeItSatisfying = new List<string>();
            DatesCompleted = new List<DateOnly>();
        }
        public void AddMakeitObvious(string planText)
        {
            MakeItObvious.Add(planText);
        }
        public void AddMakeitAttractive(string planText)
        {
            MakeItAttractive.Add(planText);
        }
        public void AddMakeitEasy(string planText)
        {
            MakeItEasy.Add(planText);
        }
        public void AddMakeitSatisfying(string planText)
        {
            MakeItSatisfying.Add(planText);
        }
    }
}