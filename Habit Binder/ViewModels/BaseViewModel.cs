using PropertyChanged;
using System.ComponentModel;

namespace Habit_Binder
{   
    [AddINotifyPropertyChangedInterface]
    internal class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}