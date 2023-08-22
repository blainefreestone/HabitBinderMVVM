using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Habit_Binder_MVVM.Models
{
    public class Identity
    {
        private string _descriptor;
        private string _description;
        public Identity(string descriptor, string description)
        {
            _descriptor = descriptor;
            _description = description;
        }
    }
}
