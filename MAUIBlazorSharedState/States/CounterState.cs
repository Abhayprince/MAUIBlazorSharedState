using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIBlazorSharedState.States
{
    public class CounterState : INotifyPropertyChanged
    {
        private int _counter;
        public int Counter
        {
            get => _counter;
            set
            {
                _counter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Counter)));
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
